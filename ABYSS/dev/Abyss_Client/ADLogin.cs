using System;
using System.Windows.Forms;
using Business;

namespace Abyss_Client {
    public partial class ADLogin : CompBase.BaseForm {
        #region Constructors
        public ADLogin() {
            InitializeComponent();
        }
        #endregion

        #region Component events
        private void connect_btn_Click(object sender, EventArgs e) {
            LDAP ldap=null;
            Cursor.Current = Cursors.WaitCursor;
            try {
                if (setError()) {
                    return;
                }
                if (defaultLdap_rbt.Checked) {
                    ldap = LDAP.getInstance(login_txt.Text, password_txt.Text);
                }
                else {
                    ldap = LDAP.getInstance(ldap_txt.Text, login_txt.Text, password_txt.Text);
                }
                ADUser user = ADUser.getUserByName(login_txt.Text);
                if (user != null) {
                    MessageBox.Show("Login success. Welcome " + user.DisplayName,
                    this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    openForm(new ListActiveDirectory(ldap));
                    ldap.setInitToFalse();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ldap != null) {
                    ldap.setInitToFalse();
                }
                return;
            }
            Cursor.Current = Cursors.Default;
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

        private void reset_btn_Click(object sender, EventArgs e) {
            foreach (Control box in this.Controls) {
                if (box.GetType() == typeof(CompBase.BaseGroupBox)) {
                    foreach (Control control in box.Controls) {
                        if (control.GetType() == typeof(CompBase.BaseTextBox)) {
                            control.Text = string.Empty;
                        }
                    }
                }      
            }
            login_txt.Select();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Returns the status of the control
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private bool isValide(Control control) {
            if (control.GetType() == typeof(CompBase.BaseTextBox)) {
                if (string.IsNullOrEmpty(control.Text)) {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Check if all fields have been writed.
        /// </summary>
        /// <returns></returns>
        private bool setError() {
            bool error = false;
            if (!defaultLdap_rbt.Checked) {
                if (!isValide(ldap_txt)) {
                    error_prv.SetError(ldap_txt, "A domain controlor must be specified");
                    error = true;
                }
                else {
                    error_prv.SetError(ldap_txt, "");
                }
            }
            if (!isValide(login_txt)) {
                error_prv.SetError(login_txt, "A login must be specified");
                error = true;
            }
            else {
                error_prv.SetError(login_txt, "");
            }
            if (!isValide(password_txt)) {
                error_prv.SetError(password_txt, "A password must be specified");
                error = true;
            }
            else {
                error_prv.SetError(password_txt, "");
            }
            return error;
        }
        #endregion
    }
}