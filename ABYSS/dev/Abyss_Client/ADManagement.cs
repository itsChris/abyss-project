using System;
using System.Windows.Forms;
using Business;

namespace Abyss_Client {
    public partial class ADManagement : CompBase.BaseForm {
        #region Constructors
        public ADManagement(LDAP ldap) {
            InitializeComponent();
        }
        #endregion

        #region Component events
        private void quitToolStripMenuItem_Click(object sender, EventArgs e){
            this.Close();
        }

        private void ListActiveDirectory_Load(object sender, EventArgs e) {
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