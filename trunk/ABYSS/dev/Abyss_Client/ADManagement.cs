using System;
using System.Windows.Forms;
using Business;
using System.DirectoryServices;

namespace Abyss_Client {
    public partial class ADManagement : CompBase.BaseForm {
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
        public ADManagement(LDAP ldap) {
            InitializeComponent();
            this.ldap = ldap;
        }
        #endregion

        #region Component events
        private void quitToolStripMenuItem_Click(object sender, EventArgs e){
            this.Close();
        }

        private void ListActiveDirectory_Load(object sender, EventArgs e) {
            lvwColumnSorter = new ListViewColumnSorter();
            this.list_lst.ListViewItemSorter = lvwColumnSorter;
            
            DirectoryEntry entry = ldap.Entry;
            TreeNode root = new TreeNode((string)entry.Properties["distinguishedName"].Value, (int)AdImages.AdRoot, (int)AdImages.AdRoot);
            root.Tag = entry;
            this.tree_trv.Nodes.Clear();
            this.tree_trv.Nodes.Add(root);
        }

        private void tree_trv_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeView myTreeView = (TreeView)sender;
            DirectoryEntry selectedEntry = (DirectoryEntry)e.Node.Tag;
            //if (!DirectoryEntry.Exists(selectedEntry.Path)) {
            //    e.Node.ImageIndex = (int)AdImages.Unavailable;
            //    e.Node.SelectedImageIndex = (int)AdImages.Unavailable;
            //    return;
            //}
            // cleanup the current node 
            this.list_lst.Items.Clear();
            e.Node.Nodes.Clear();
            myTreeView.BeginUpdate();
            foreach (DirectoryEntry child in selectedEntry.Children) {
                TreeNode tmpNode = null;
                ListViewItem tmpItem = null;
                switch (child.SchemaClassName) {
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
                        tmpNode = new TreeNode((string)child.Properties["name"].Value,(int)AdImages.Computer,(int)AdImages.Computer);
                        tmpItem = new ListViewItem(new string[] {
																		(string)child.Properties["name"].Value,
																		child.SchemaClassName,
																		(string)child.Properties["description"].Value

																	}, (int)AdImages.Computer);
                        break;
                    case "user":
                        tmpNode = new TreeNode((string)child.Properties["name"].Value,(int)AdImages.User,(int)AdImages.User);
                        tmpItem = new ListViewItem(new string[] {
																		(string)child.Properties["name"].Value,
																		child.SchemaClassName,
																		(string)child.Properties["description"].Value

																	}, (int)AdImages.User);
                        break;
                    case "group":
                        tmpNode = new TreeNode((string)child.Properties["name"].Value,(int)AdImages.Group,(int)AdImages.Group);
                        tmpItem = new ListViewItem(new string[] {
																		(string)child.Properties["name"].Value,
																		child.SchemaClassName,
																		(string)child.Properties["description"].Value

																	}, (int)AdImages.Group);
                        break;
                    default:
                        tmpNode = new TreeNode((string)child.Properties["name"].Value,(int)AdImages.Unknown,(int)AdImages.Unknown);
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
                    tmpItem.Tag = child;
                    this.list_lst.Items.Add(tmpItem);
                }	
            }
            e.Node.Expand();
            myTreeView.EndUpdate();
        }

        private void ADManagement_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you want to quit ?", this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            }
        }
        #endregion
    }
}