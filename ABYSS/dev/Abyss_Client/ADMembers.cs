using System;
using System.Windows.Forms;
using Business;
using Persistence;
using System.Collections;
using Utils;
using System.DirectoryServices;
using System.Runtime.InteropServices;

namespace Abyss_Client {
    public partial class ADMembers : CompBase.BaseForm {
        #region Attributes
        private ListViewColumnSorter lvwColumnSorter;
        private Object businessOject;
        private Hashtable ht = new Hashtable();
        private ArrayList list = new ArrayList();
        #endregion

        #region Properties
        public ArrayList List {
            get { return list; }
            set { list = value; }
        }
        #endregion

        #region Constructors
        public ADMembers(Object businessOject) {
            InitializeComponent();
            this.businessOject = businessOject;
            this.lvwColumnSorter = new ListViewColumnSorter();
            this.lastmembers_lst.ListViewItemSorter = lvwColumnSorter;
            this.newmembers_lst.ListViewItemSorter = lvwColumnSorter;
        }
        #endregion

        #region Enumeration
        private enum AdImages {
            AdRoot,
            Ou,
            Container,
            OpenContainer,
            Computer,
            User,
            Disable,
            Group,
            Unknown,
            DisableCompunter
        }
        #endregion

        #region Component Events
        private void ADMembers_Load(object sender, EventArgs e) {
            try {
                ArrayList list = new ArrayList();
                if (businessOject.GetType() == typeof(ADGroup)) {
                    ADGroup adGroup = (ADGroup)businessOject;
                    if (adGroup.Scope != ADGroupData.GroupeScope.Global) {
                        list = ADGroup.getGroupsList();
                        foreach (ADGroupData groupData in list) {
                            ADGroup group = new ADGroup(groupData);
                            if (adGroup.Scope != ADGroupData.GroupeScope.DomainLocal) {
                                if (group.Scope == ADGroupData.GroupeScope.Global || group.Scope == ADGroupData.GroupeScope.Global) {
                                    ListViewItem lvi = new ListViewItem(new string[] { group.Name, group.Description }, (int)AdImages.Group);
                                    lvi.Tag = group;
                                    lastmembers_lst.Items.Add(lvi);
                                }
                            }
                            else {
                                if (adGroup.Scope == ADGroupData.GroupeScope.DomainLocal && adGroup.SecurityGroupe) {
                                    if (group.Scope != ADGroupData.GroupeScope.DomainLocal ) {
                                        ListViewItem lvi = new ListViewItem(new string[] { group.Name, group.Description }, (int)AdImages.Group);
                                        lvi.Tag = group;
                                        lastmembers_lst.Items.Add(lvi);
                                    }
                                }
                                else if (adGroup.Scope == ADGroupData.GroupeScope.DomainLocal && !adGroup.SecurityGroupe){
                                    ListViewItem lvi = new ListViewItem(new string[] { group.Name, group.Description }, (int)AdImages.Group);
                                    lvi.Tag = group;
                                    lastmembers_lst.Items.Add(lvi);
                                }
                            }
                        }
                    }
                }

                list = ADUser.getUsersList();
                foreach (ADUserData userData in list) {
                    ADUser user = new ADUser(userData);
                    ListViewItem lvi = new ListViewItem(new string[] { user.UserName, user.Description }, user.IsAccountActive ? (int)AdImages.User : (int)AdImages.Disable);
                    lvi.Tag = user;
                    lastmembers_lst.Items.Add(lvi);
                }

                list = ADComputer.getComputersList();
                foreach (ADComputerData computerData in list) {
                    ADComputer computer = new ADComputer(computerData);
                    ListViewItem lvi = new ListViewItem(new string[] { computer.ComputerName, computer.Description }, computer.Enabled ? (int)AdImages.Computer : (int)AdImages.DisableCompunter);
                    lvi.Tag = computer;
                    lastmembers_lst.Items.Add(lvi);
                }

                if (businessOject.GetType() == typeof(ADGroup)) {
                    ADGroup adGroup = (ADGroup)businessOject;
                    foreach (String distinguishedNama in adGroup.Members) {
                        DirectoryEntry entry = Utility.getDirectoryObjectByDistinguishedName(distinguishedNama);
                        switch (entry.SchemaClassName) {
                            case "group":
                                ADGroup group = ADGroup.getGroupByName((string)entry.Properties["sAMAccountName"].Value);
                                if (group != null) {
                                    ht.Add(group.Name, group);
                                }
                                break;
                            case "computer":
                                ADComputer computer = ADComputer.getComputerByName((string)entry.Properties["sAMAccountName"].Value);
                                if (computer != null) {
                                    ht.Add(computer.ComputerName, computer);
                                }
                                break;
                            case "user":
                                ADUser user = ADUser.getUserByName((string)entry.Properties["sAMAccountName"].Value);
                                if (user != null) {
                                    ht.Add(user.UserName, user);
                                }
                                break;
                        }
                    }
                }
            }
            catch (COMException) {
            }
            updateView();
        }

        private void lastmembers_lst_DoubleClick(object sender, EventArgs e) {
            if (lastmembers_lst.SelectedItems.Count != 0) {
                if (lastmembers_lst.SelectedItems[0].Tag.GetType() == typeof(ADGroup)) {
                    ADGroup group = (ADGroup)lastmembers_lst.SelectedItems[0].Tag;
                    if (!ht.ContainsKey(group.Name)) {
                        ht.Add(group.Name, group);
                        updateView();
                    }
                }
                else if (lastmembers_lst.SelectedItems[0].Tag.GetType() == typeof(ADUser)) {
                    ADUser user = (ADUser)lastmembers_lst.SelectedItems[0].Tag;
                    if (!ht.ContainsKey(user.UserName)) {
                        ht.Add(user.UserName, user);
                        updateView();
                    }
                }
                else {
                    ADComputer computer = (ADComputer)lastmembers_lst.SelectedItems[0].Tag;
                    if (!ht.ContainsKey(computer.ComputerName)) {
                        ht.Add(computer.ComputerName, computer);
                        updateView();
                    }
                }
            }
        }

        private void newmembers_lst_DoubleClick(object sender, EventArgs e) {
            if (newmembers_lst.SelectedItems.Count != 0) {
                if (newmembers_lst.SelectedItems[0].Tag.GetType() == typeof(ADGroup)) {
                    ADGroup group = (ADGroup)newmembers_lst.SelectedItems[0].Tag;
                    if (ht.ContainsKey(group.Name)) {
                        ht.Remove(group.Name);
                        updateView();
                    }
                }
                else if (newmembers_lst.SelectedItems[0].Tag.GetType() == typeof(ADUser)) {
                    ADUser user = (ADUser)newmembers_lst.SelectedItems[0].Tag;
                    if (ht.ContainsKey(user.UserName)) {
                        ht.Remove(user.UserName);
                        updateView();
                    }
                }
                else {
                    ADComputer computer = (ADComputer)newmembers_lst.SelectedItems[0].Tag;
                    if (ht.ContainsKey(computer.ComputerName)) {
                        ht.Remove(computer.ComputerName);
                        updateView();
                    }
                }
            }
        }

        private void list_lst_ColumnClick(object sender, ColumnClickEventArgs e) {
            ListView myListView = (ListView)sender;
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn) {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending) {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            // Perform the sort with these new sort options.
            myListView.Sort();
        }

        private void cancel_btn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ok_btn_Click(object sender, EventArgs e) {
            list.Clear();
            foreach (String name in ht.Keys) {
                if (ht[name].GetType() == typeof(ADGroup)){
                    ADGroup group = (ADGroup)ht[name];
                    list.Add(group.DistinguishedName);
                }
                else if (ht[name].GetType() == typeof(ADUser)) {
                    ADUser user = (ADUser)ht[name];
                    list.Add(user.DistinguishedName);
                }
                else {
                    ADComputer computer = (ADComputer)ht[name];
                    list.Add(computer.DistinguishedName);
                }   
            }
            dialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #region Private Methods
        private void updateView() {
            newmembers_lst.Items.Clear();
            foreach (String name in ht.Keys) {
                if (ht[name].GetType() == typeof(ADGroup)) {
                    ADGroup group = (ADGroup)ht[name];
                    ListViewItem lvi = new ListViewItem(new string[] { group.Name, group.Description }, (int)AdImages.Group);
                    lvi.Tag = group;
                    newmembers_lst.Items.Add(lvi);
                }
                else if (ht[name].GetType() == typeof(ADUser)) {
                    ADUser user = (ADUser)ht[name];
                    ListViewItem lvi = new ListViewItem(new string[] { user.UserName, user.Description }, user.IsAccountActive ? (int)AdImages.User : (int)AdImages.Disable);
                    lvi.Tag = user;
                    newmembers_lst.Items.Add(lvi);
                }
                else {
                    ADComputer computer = (ADComputer)ht[name];
                    ListViewItem lvi = new ListViewItem(new string[] { computer.ComputerName, computer.Description },computer.Enabled?(int)AdImages.Computer : (int)AdImages.DisableCompunter);
                    lvi.Tag = computer;
                    newmembers_lst.Items.Add(lvi);
                }   
            }
        }
        #endregion
    }
}