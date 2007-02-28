using System;
using System.Windows.Forms; 
using System.DirectoryServices;
using Business;

namespace Abyss_Client {
    public partial class ADAdministration : CompBase.BaseForm {
        #region Attributes
        private LDAP ldap;
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
            Unavailable
        }
        #endregion

        #region Constructors
        public ADAdministration(LDAP ldap) {
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
        /// Built dynamicly the tree view for eachn node of Active Directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_trv_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeView treeView = (TreeView)sender;
            DirectoryEntry selectedEntry = (DirectoryEntry)e.Node.Tag;
            // cleanup the current node and list view.
            this.list_lst.Items.Clear();
            e.Node.Nodes.Clear();
            // Begin tree view creation.
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
                            tmpNode = new TreeNode((string)child.Properties["name"].Value, (int)AdImages.Container , (int)AdImages.OpenContainer);
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
                        case "container":
                            tmpNode = new TreeNode((string)child.Properties["name"].Value, (int)AdImages.Container, (int)AdImages.OpenContainer);
                            tmpItem = new ListViewItem(new string[] {
																		(string)child.Properties["name"].Value,
																		child.SchemaClassName,
																		(string)child.Properties["description"].Value

																	}, (int)AdImages.Container);
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

																	}, (int)AdImages.User);
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
                    // save the directory entry reference in the tag
                    if (tmpNode != null) {
                        tmpNode.Tag = child;
                        e.Node.Nodes.Add(tmpNode);
                    }
                    if (tmpItem != null) {
                        //tmpItem.Tag = child;
                        this.list_lst.Items.Add(tmpItem);
                    }
                }
            }
            catch (Exception) {
                //e.Node.ImageIndex = (int)AdImages.Unavailable;
                //e.Node.SelectedImageIndex = (int)AdImages.Unavailable;
                //return;
            }
            
            e.Node.Expand();
            treeView.EndUpdate();
        }

        private void ADManagement_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you want to quit ?", this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            }
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