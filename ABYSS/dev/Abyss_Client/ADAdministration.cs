using System;
using System.Windows.Forms; 
using System.DirectoryServices;
using Business;

namespace Abyss_Client {
    public partial class ADAdministration : CompBase.BaseForm {
        #region Attributes
        private ADConnection ldap;
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
            Group,
            Unknown,
            Unavailable,
            Disable
        }
        #endregion

        #region Constructors
        public ADAdministration(ADConnection ldap) {
            InitializeComponent();
            this.ldap = ldap;
        }
        #endregion

        #region Component events
        private void quitToolStripMenuItem_Click(object sender, EventArgs e){
            this.Close();
        }

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
            catch (Exception ex) {
                // active directory exception ???
                //MessageBox.Show(ex.Message);
            }
            e.Node.Expand();
            treeView.EndUpdate();
        }
        
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
          
        private void ADManagement_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you want to quit ?", this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            }
        }

        private void user_tmi_Click(object sender, EventArgs e) {
            openForm(new ADUserUpdate());
        }
        #endregion

        #region Private Methods
        private void initView() {
            this.lvwColumnSorter = new ListViewColumnSorter();
            this.list_lst.ListViewItemSorter = lvwColumnSorter;
            DirectoryEntry entry = ldap.Entry;
            TreeNode root = new TreeNode((string)entry.Properties["distinguishedName"].Value, (int)AdImages.AdRoot, (int)AdImages.AdRoot);
            root.Tag = entry;
            this.tree_trv.Nodes.Clear();
            this.tree_trv.Nodes.Add(root);
        }
        #endregion
    }
}