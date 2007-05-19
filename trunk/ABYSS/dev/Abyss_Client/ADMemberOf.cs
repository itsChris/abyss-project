using System;
using System.Windows.Forms;
using Business;
using Persistence;
using System.Collections;
using Utils;
using System.DirectoryServices;
using System.Runtime.InteropServices;

namespace Abyss_Client {
    public partial class ADMemberOf : CompBase.BaseForm {
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
        public ADMemberOf(Object businessOject) {
            InitializeComponent();
            this.businessOject = businessOject;
            this.lvwColumnSorter = new ListViewColumnSorter();
            this.lastmemberof_lst.ListViewItemSorter = lvwColumnSorter;
            this.newmemberof_lst.ListViewItemSorter = lvwColumnSorter;
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
        private void ADMemberOf_Load(object sender, EventArgs e) {
            try {
                ArrayList list = ADGroup.getGroupsList();
                foreach (ADGroupData groupData in list) {
                    ADGroup group = new ADGroup(groupData);
                    if (businessOject.GetType() == typeof(ADGroup)) {
                        ADGroup adGroup = (ADGroup)businessOject;
                        if (adGroup.Scope == ADGroupData.GroupeScope.Global) {
                            if (group.Scope != ADGroupData.GroupeScope.Global || !group.SecurityGroupe) {

                                ListViewItem lvi = new ListViewItem(new string[] { group.Name, group.Description }, (int)AdImages.Group);
                                lvi.Tag = group;
                                lastmemberof_lst.Items.Add(lvi);
                            }
                        }
                        else if (adGroup.Scope == ADGroupData.GroupeScope.DomainLocal) {
                            if (group.Scope == ADGroupData.GroupeScope.DomainLocal && !group.SecurityGroupe) {
                                ListViewItem lvi = new ListViewItem(new string[] { group.Name, group.Description }, (int)AdImages.Group);
                                lvi.Tag = group;
                                lastmemberof_lst.Items.Add(lvi);
                            }
                        }
                        else if (adGroup.Scope == ADGroupData.GroupeScope.Universel) {
                            if (!adGroup.SecurityGroupe && group.Scope != ADGroupData.GroupeScope.Global) {
                                ListViewItem lvi = new ListViewItem(new string[] { group.Name, group.Description }, (int)AdImages.Group);
                                lvi.Tag = group;
                                lastmemberof_lst.Items.Add(lvi);
                            }
                            else if (!adGroup.SecurityGroupe && group.Scope == ADGroupData.GroupeScope.Global) {
                                ListViewItem lvi = new ListViewItem(new string[] { group.Name, group.Description }, (int)AdImages.Group);
                                lvi.Tag = group;
                                lastmemberof_lst.Items.Add(lvi);
                            }
                        }
                    }
                    else {
                        ListViewItem lvi = new ListViewItem(new string[] { group.Name, group.Description }, (int)AdImages.Group);
                        lvi.Tag = group;
                        lastmemberof_lst.Items.Add(lvi);
                    }
                }

                if (businessOject.GetType() == typeof(ADUser)) {
                    ADUser adUser = (ADUser)businessOject;
                    foreach (String distinguishedNama in adUser.MemberOf) {
                        DirectoryEntry entry = Utility.getDirectoryObjectByDistinguishedName(distinguishedNama);
                        ADGroup group = ADGroup.getGroupByName((string)entry.Properties["sAMAccountName"].Value);
                        if (group != null) {
                            ht.Add(group.Name, group);
                        }
                    }
                }
                else if (businessOject.GetType() == typeof(ADGroup)) {
                    ADGroup adGroup = (ADGroup)businessOject;
                    foreach (String distinguishedNama in adGroup.Memberof) {
                        DirectoryEntry entry = Utility.getDirectoryObjectByDistinguishedName(distinguishedNama);
                        ADGroup group = ADGroup.getGroupByName((string)entry.Properties["sAMAccountName"].Value);
                        if (group != null) {
                            ht.Add(group.Name, group);
                        }
                    }
                }
                else {
                    ADComputer adComputer = (ADComputer)businessOject;
                    foreach (String distinguishedNama in adComputer.Memberof) {
                        DirectoryEntry entry = Utility.getDirectoryObjectByDistinguishedName(distinguishedNama);
                        ADGroup group = ADGroup.getGroupByName((string)entry.Properties["sAMAccountName"].Value);
                        if (group != null) {
                            ht.Add(group.Name, group);
                        }
                    }
                }
            }
            catch (COMException) {
            }
            updateView();
        }

        private void lastmemberof_lst_DoubleClick(object sender, EventArgs e) {
            if (lastmemberof_lst.SelectedItems.Count != 0) {
                ADGroup group = (ADGroup)lastmemberof_lst.SelectedItems[0].Tag;
                if (!ht.ContainsKey(group.Name)) {
                    ht.Add(group.Name, group);
                    updateView();
                }
            }
        }

        private void newmemberof_lst_DoubleClick(object sender, EventArgs e) {
            if (newmemberof_lst.SelectedItems.Count != 0) {
                ADGroup group = (ADGroup)newmemberof_lst.SelectedItems[0].Tag;
                if (ht.ContainsKey(group.Name)) {
                    ht.Remove(group.Name);
                    updateView();
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
                ADGroup group = (ADGroup)ht[name];
                list.Add(group.DistinguishedName);
            }
            dialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #region Private Methods
        private void updateView() {
            newmemberof_lst.Items.Clear();
            foreach (String name in ht.Keys) {
                ADGroup group = (ADGroup)ht[name];
                ListViewItem lvi = new ListViewItem(new string[] { group.Name, group.Description }, (int)AdImages.Group);
                lvi.Tag = group;
                newmemberof_lst.Items.Add(lvi);
            }
        }
        #endregion
    }
}