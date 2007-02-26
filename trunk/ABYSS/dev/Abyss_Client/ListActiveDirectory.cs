using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;

namespace Abyss_Client
{
    public partial class ListActiveDirectory : CompBase.BaseForm
    {
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

        private DirectoryEntry root;

        public ListActiveDirectory(DirectoryEntry root) {
            InitializeComponent();
            this.root = root;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e){

            if (MessageBox.Show("Do you want quit Active Directory part ?", "ABYSS MANAGEMENT",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes) {
                this.Close();
            }
        }

        private void ListActiveDirectory_Load(object sender, EventArgs e) {
            TreeNode root = new TreeNode((string)this.root.Properties["distinguishedName"].Value, (int)AdImages.AdRoot, (int)AdImages.AdRoot);
            root.Tag = this.root;
            this.baseTreeViewListADObject.Nodes.Clear();
            this.baseTreeViewListADObject.Nodes.Add(root);
        }

    }
}