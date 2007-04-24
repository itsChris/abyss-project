using System;
using System.Windows.Forms; 
using System.DirectoryServices;
using Business;
using System.Runtime.InteropServices;

namespace Abyss_Client {
    public partial class ADAdministration : CompBase.BaseForm {
        #region Attributes
        private DirectoryEntry ldap;
        private ListViewColumnSorter lvwColumnSorter;
        #endregion

        #region Enum
        private enum AdImages {
            AdRoot,
            Ou,
            Container,
            OpenContainer,
            Computer,
            User,
            Disable,
            Group,
            Unknown
        }
        #endregion

        #region Constructors
        public ADAdministration(DirectoryEntry ldap) {
            InitializeComponent();
            this.ldap = ldap;
        }
        #endregion

        #region Component events
        /// <summary>
        /// Load 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListActiveDirectory_Load(object sender, EventArgs e) {
            initView();
        }

        /// <summary>
        /// Built dynamically the tree view for each node of Active Directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_trv_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeView treeView = (TreeView)sender;
            DirectoryEntry selectedEntry = (DirectoryEntry)e.Node.Tag;
            // cleanup the current node and list view.
            this.list_lst.Items.Clear();
            e.Node.Nodes.Clear();
            treeView.BeginUpdate();
            try {
                foreach (DirectoryEntry child in selectedEntry.Children) {
                    TreeNode tmpNode = null;
                    ListViewItem tmpItem = null;
                    switch (child.SchemaClassName) {
                        case "orclContext":
                            tmpNode = new TreeNode((string)child.Properties["name"].Value, (int)AdImages.Container, (int)AdImages.OpenContainer);
                            tmpItem = new ListViewItem(new string[] {
																		(string)child.Properties["name"].Value,
																		child.SchemaClassName,
																		(string)child.Properties["description"].Value
																	}, (int)AdImages.Container);
                            break;
                        case "builtinDomain":
                            tmpNode = new TreeNode((string)child.Properties["name"].Value, (int)AdImages.Container, (int)AdImages.OpenContainer);
                            tmpItem = new ListViewItem(new string[] {
																		(string)child.Properties["name"].Value,
																		child.SchemaClassName,
																		(string)child.Properties["description"].Value
																	}, (int)AdImages.Container);
                            break;
                        case "container":
                            tmpNode = new TreeNode((string)child.Properties["name"].Value, (int)AdImages.Container, (int)AdImages.OpenContainer);
                            tmpItem = new ListViewItem(new string[] {
																		(string)child.Properties["name"].Value,
																		child.SchemaClassName,
																		(string)child.Properties["description"].Value
																	}, (int)AdImages.Container);
                            break;
                        case "organizationalUnit":
                            tmpNode = new TreeNode((string)child.Properties["name"].Value, (int)AdImages.Ou, (int)AdImages.OpenContainer);
                            tmpItem = new ListViewItem(new string[] {
																		(string)child.Properties["name"].Value,
																		child.SchemaClassName,
																		(string)child.Properties["description"].Value
																	}, (int)AdImages.Ou);
                            break;
                        case "computer":
                            tmpItem = new ListViewItem(new string[] {
																		(string)child.Properties["name"].Value,
																		child.SchemaClassName,
																		(string)child.Properties["description"].Value
																	}, (int)AdImages.Computer);
                            break;
                        case "user":
                            ADUser user = ADUser.getUserByName((string)child.Properties["name"].Value);
                            tmpItem = new ListViewItem(new string[] {
																		user.UserName,
																		child.SchemaClassName,
																		user.Description
																	}, user.IsAccountActive?(int)AdImages.User:(int)AdImages.Disable);
                            tmpItem.Tag = user;
                            break;
                        case "group":
                            tmpItem = new ListViewItem(new string[] {
																		(string)child.Properties["name"].Value,
																		child.SchemaClassName,
																		(string)child.Properties["description"].Value
																	}, (int)AdImages.Group);
                            break;
                        default:
                            tmpItem = new ListViewItem(new string[] {
																		(string)child.Properties["name"].Value,
																		child.SchemaClassName,
																		(string)child.Properties["description"].Value
																	}, (int)AdImages.Unknown);
                            break;
                    }
                    // save the directory entry reference in the tag.
                    if (tmpNode != null) {
                        tmpNode.Tag = child;
                        e.Node.Nodes.Add(tmpNode);
                    }
                    // save the list view item.
                    if (tmpItem != null) {
                        this.list_lst.Items.Add(tmpItem);
                    }
                }
            }
            catch (COMException ) {
            }
            e.Node.Expand();
            treeView.EndUpdate();
        }

        /// <summary>
        /// When double click on a container, expand it and show what it contains in the listview
        /// When double click, if its a user, a group or a compunter, open it and show informations about it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void list_lst_DoubleClick(object sender, EventArgs e) {
            ListView myListView = (ListView)sender;
            if (myListView.SelectedItems.Count == 1) {
                ListViewItem myListViewItem = myListView.SelectedItems[0];
                switch (myListViewItem.ImageIndex) {
                    case (int)AdImages.Ou:
                    case (int)AdImages.Container:
                        foreach (TreeNode tNode in this.tree_trv.SelectedNode.Nodes) {
                            if (tNode.Text.Equals(myListViewItem.Text)) {
                                this.tree_trv.SelectedNode = tNode;
                                if (myListView.Items.Count > 0) {
                                    myListView.Focus();
                                    myListView.Items[0].Selected = true;
                                }
                                break;
                            }
                        }
                        break;
                    case (int)AdImages.Group:
                    case (int)AdImages.Computer:
                    case (int)AdImages.User:
                        if (this.list_lst.SelectedItems[0].Tag != null) {
                            if (this.list_lst.SelectedItems[0].Tag.GetType() == typeof(ADUser)) {
                                ADUser user = (ADUser)this.list_lst.SelectedItems[0].Tag;
                                if (DialogResult.OK == openForm(new ADUserUpdate(user))) {
                                    refreshCurrentNode();
                                }
                            }
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Sort the column when click on it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// When the context menu opening, showing choise depend off the business object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_ctm_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            if (this.list_lst.SelectedItems.Count == 1) {
                if (this.list_lst.SelectedItems[0].Tag != null) {
                    this.listView_ctm.Items.Clear();
                    if (this.list_lst.SelectedItems[0].Tag.GetType() == typeof(ADUser)) {
                        ADUser user = (ADUser)this.list_lst.SelectedItems[0].Tag;
                        this.listView_ctm.Items.AddRange(new ToolStripItem[] { this.modify_tmi, this.separator1,
                        user.IsAccountActive?this.disable_tmi:this.enable_tmi, this.separator2,
                        this.delete_tmi, this.separator3, this.changePwd_tmi});
                    }
                    else {
                        e.Cancel = true;
                    }
                }
                else {
                    e.Cancel = true;
                }
            }
        }
          
        /// <summary>
        /// Open the form for the creation off a new user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void user_tmi_Click(object sender, EventArgs e) {
            if (DialogResult.OK == openForm(new ADUserUpdate())) {
                refreshCurrentNode();
            }
        }

        /// <summary>
        /// Open the form for the modification of an business object that you choose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modify_tmi_Click(object sender, EventArgs e) {
            if (this.list_lst.SelectedItems[0].Tag.GetType() == typeof(ADUser)) {
                ADUser user = (ADUser)this.list_lst.SelectedItems[0].Tag;
                if (DialogResult.OK == openForm(new ADUserUpdate(user))) {
                    refreshCurrentNode();
                }
            }
        }

        /// <summary>
        /// Disable an business object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void disable_tmi_Click(object sender, EventArgs e) {
            if (this.list_lst.SelectedItems[0].Tag.GetType() == typeof(ADUser)) {
                ADUser user = (ADUser)this.list_lst.SelectedItems[0].Tag;
                user.disableUserAccount();
                refreshCurrentNode();
            }
        }

        /// <summary>
        /// Enable an business object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enable_tmi_Click(object sender, EventArgs e) {
            if (this.list_lst.SelectedItems[0].Tag.GetType() == typeof(ADUser)) {
                ADUser user = (ADUser)this.list_lst.SelectedItems[0].Tag;
                user.enableUserAccount();
                refreshCurrentNode();
            }
        }

        /// <summary>
        /// Delete an business object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_tmi_Click(object sender, EventArgs e) {
            if (this.list_lst.SelectedItems[0].Tag.GetType() == typeof(ADUser)) {
                ADUser user = (ADUser)this.list_lst.SelectedItems[0].Tag;
                user.deleteUserAccount();
                refreshCurrentNode();
            }
        }

        private void changePwd_tmi_Click(object sender, EventArgs e) {

        }

        

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ADManagement_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you want to quit ?", this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Quit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

        #region Private Methods
        private void initView() {
            this.lvwColumnSorter = new ListViewColumnSorter();
            this.list_lst.ListViewItemSorter = lvwColumnSorter;
            TreeNode root = new TreeNode((string)ldap.Properties["distinguishedName"].Value, (int)AdImages.AdRoot, (int)AdImages.AdRoot);
            root.Tag = ldap;
            this.tree_trv.Nodes.Clear();
            this.tree_trv.Nodes.Add(root);
        }

        private void refreshCurrentNode() {
            TreeNode node = this.tree_trv.SelectedNode;
            TreeViewEventArgs tvea = new TreeViewEventArgs(node);
            this.tree_trv_AfterSelect(this.tree_trv, tvea);
        }
        #endregion 

        

        

        

        
    }
}