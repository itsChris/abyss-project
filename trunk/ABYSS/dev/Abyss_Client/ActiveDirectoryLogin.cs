using System;
using System.Windows.Forms;
using Utils;
using System.DirectoryServices;
using Business;

namespace Abyss_Client {
    public partial class ActiveDirectoryLogin : CompBase.BaseForm {
        #region Constructors
        public ActiveDirectoryLogin() {
            InitializeComponent();
        }
        #endregion

        #region Component events
        private void connect_btn_Click(object sender, EventArgs e) {
            try {
                if (setError()) {
                    return;
                }
                Utility.CrtUserName = login_txt.Text;
                Utility.CrtPassword = password_txt.Text;

                DirectoryEntry directoryEntry;
                if (defaultLdap_rbt.Checked) {
                    directoryEntry = Utility.getDirectoryObject(login_txt.Text, password_txt.Text);
                    //Utility.CrtDomain = "rootDSE";
                }
                else {
                    directoryEntry = Utility.getDirectoryObject(ldap_txt.Text, login_txt.Text, password_txt.Text);
                    Utility.CrtDomain = ldap_txt.Text;    
                }
                ADUser user = ADUser.getUserByName(login_txt.Text);
                if (user != null) {
                    this.Hide();
                    new ListActiveDirectory(directoryEntry).ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"ABYSS MANAGEMENT",
                MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void defaultLdap_rbt_Click(object sender, EventArgs e) {
            otherLdap_rbt.Checked = false;
            ldap_lbl.Visible = false;
            ldap_txt.Visible = false;
        }

        private void otherLdap_rbt_Click(object sender, EventArgs e) {
            defaultLdap_rbt.Checked = false;
            ldap_lbl.Visible = true;
            ldap_txt.Visible = true;
        }
        #endregion

        #region Private Methods
        private bool isValide(Control control) {
            if (control.GetType() == typeof(CompBase.BaseTextBox)) {
                if (string.IsNullOrEmpty(control.Text)) {
                    return false;
                }
            }
            return true;
        }

        private bool setError() {
            bool error = false;
            if (!defaultLdap_rbt.Checked) {
                if (!isValide(ldap_txt)) {
                    errorProvider.SetError(ldap_txt, "A domain controlor must be specified");
                    error = true;
                }
                else {
                    errorProvider.SetError(ldap_txt, "");
                }
            }
            if (!isValide(login_txt)) {
                errorProvider.SetError(login_txt, "A login must be specified");
                error = true;
            }
            else {
                errorProvider.SetError(login_txt, "");
            }
            if (!isValide(password_txt)) {
                errorProvider.SetError(password_txt, "A password must be specified");
                error = true;
            }
            else {
                errorProvider.SetError(password_txt, "");
            }
            return error;
        }
        #endregion
    }
}