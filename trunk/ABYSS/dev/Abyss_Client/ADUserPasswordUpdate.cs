using System;
using System.Windows.Forms;
using Business;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Abyss_Client {
    public partial class ADUserPasswordUpdate : CompBase.BaseForm {
        #region Attributes
        private ADUser user;
        #endregion

        #region Constructor
        public ADUserPasswordUpdate(ADUser user) {
            this.user = user;
            InitializeComponent();
        }
        #endregion

        #region Commponent Events
        private void ok_btn_Click(object sender, EventArgs e) {
            if (checkMandatoryFields()) {
                if (!checkPasswords()) {
                    MessageBox.Show("The passwords do not match", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    password_txt.Text = string.Empty;
                    confirmPassword_txt.Text = string.Empty;
                    return;
                }
                try {
                    Cursor.Current = Cursors.WaitCursor;
                    user.setUserPassword(password_txt.Text);
                    user.ChangePasswordNextLogon = changePassword_chk.Checked;
                    user.save();
                    Cursor.Current = Cursors.Default;
                    dialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (COMException comex) {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(comex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (TargetInvocationException tiex) {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(tiex.InnerException.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (UnauthorizedAccessException uaex) {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(uaex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void cancel_bn_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

        #region Private Methods
        private bool checkPasswords() {
            string password = password_txt.Text.Trim();
            string confirmPassword = confirmPassword_txt.Text.Trim();
            if (password.Equals(confirmPassword)) {
                return true;
            }
            return false;
        }
        #endregion
    }
}