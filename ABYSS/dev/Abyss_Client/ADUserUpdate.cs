using System;
using Business;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Abyss_Client {
    public partial class ADUserUpdate : Abyss_Client.CompBase.BaseForm {
        #region Attributes
        private ADUser user;
        private bool update = false;
        #endregion Attributes

        #region enum
        private enum StrongPassword {
            Weak,
            Ok,
            Good,
            Perfect
        }
        #endregion

        #region Constructors
        public ADUserUpdate() {
            InitializeComponent();
            this.user = new ADUser();
        }

        public ADUserUpdate(ADUser user) {
            InitializeComponent();
            this.user = user;
            this.update = true;
        }
        #endregion

        #region Component events
        private void ADUserUpdate_Load(object sender, EventArgs e) {
            initFormData();
        }

        private void displayName_txt_TextChanged(object sender, EventArgs e) {
            string displayName;
            if (!string.IsNullOrEmpty(firstName_txt.Text)) {
                displayName = firstName_txt.Text + " ";
            }
            else {
                displayName = firstName_txt.Text;
            }
            if (!string.IsNullOrEmpty(initial_txt.Text)) {
                displayName += initial_txt.Text + ". ";
            }
            displayName += lastName_txt.Text;
            displayName_txt.Text = displayName;
            displayName_txt.Text = displayName;
        }

        private void addUser_btn_Click(object sender, EventArgs e) {
            // Check all mandatory fields
            if (checkMandatoryFields()) {
                // Check if the passwords are correct
                if (!checkPasswords()) {
                    MessageBox.Show("The passwords do not match", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    password_txt.Text = string.Empty;
                    confirmPassword_txt.Text = string.Empty;
                    return;
                }
                try {
                    // Check if the use already exist
                    if (!update && checkUser(username_txt.Text)) {
                        MessageBox.Show("The logon name you have chosen is already in use in this domain",
                            this.Text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return;
                    }
                    // Takes the parameters
                    ADUser user = new ADUser();
                    user.FirstName = firstName_txt.Text;
                    user.LastName = lastName_txt.Text;
                    user.MiddleInitial = initial_txt.Text;
                    user.DisplayName = displayName_txt.Text;
                    user.Description = desc_txt.Text;
                    user.OfficePhone = officePhone_txt.Text;
                    user.Fax = fax_txt.Text;
                    user.Url = url_txt.Text;
                    user.ResidentialAddress = residentialAddress_txt.Text;
                    user.Title = title_txt.Text;
                    user.HomePhone = homePhone_txt.Text;
                    user.Mobile = mobile_txt.Text;
                    user.Email = mail_txt.Text;
                    user.PostalAddress = postalAddress_txt.Text;
                    user.MailingAddress = maillingAddress_txt.Text;
                    user.UserName = username_txt.Text;
                    user.Password = password_txt.Text;
                    user.IsAccountActive = !isAccountActive_chk.Checked;
                    user.ChangePasswordNextLogon = changePassword_chk.Checked;
                    user.PasswordNeverExpired = neverExpires_chk.Checked;
                    // Save the user
                    user.save();
                    dialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (UnauthorizedAccessException uaex) {
                    MessageBox.Show(uaex.Message);
                    return;
                }
                catch (COMException comex) {
                    MessageBox.Show(comex.Message);
                    return;
                }
            }
        }

        private void neverExpires_chk_Click(object sender, EventArgs e) {
            if (neverExpires_chk.Checked && changePassword_chk.Checked) {
                MessageBox.Show("You specified that the password should never expire. The user will not be required to change the password at next logon",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                changePassword_chk.Checked = false;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ADUserUpdate_FormClosing(object sender, FormClosingEventArgs e) {
            if (dialogResult != DialogResult.OK) {
                if (MessageBox.Show("Do you want to quit ?",
                this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) {
                    e.Cancel = true;
                }
            }
        }

        private void password_txt_TextChanged(object sender, EventArgs e) {
            strong_lbl.Text = StrongPasswordChecker.CheckEffectiveBitSize(password_txt.Text).ToString();
        }
        #endregion 
  
        #region Private Methods
        private void initFormData() {
            firstName_txt.Text = user.FirstName;
            lastName_txt.Text = user.LastName;
            initial_txt.Text = user.MiddleInitial;
            displayName_txt.Text = user.DisplayName;

            title_txt.Text = user.Title;
            desc_txt.Text = user.Description;

            homePhone_txt.Text = user.HomePhone;
            officePhone_txt.Text = user.OfficePhone;
            fax_txt.Text = user.Fax;
            mobile_txt.Text = user.Mobile;
            mail_txt.Text = user.Email;
            url_txt.Text = user.Url;

            residentialAddress_txt.Text = user.ResidentialAddress;
            postalAddress_txt.Text = user.PostalAddress;
            maillingAddress_txt.Text = user.MailingAddress;
            if (update) {
                username_txt.Enabled = false;
                password_txt.Enabled = false;
                confirmPassword_txt.Enabled = false;
            }
            username_txt.Text = user.UserName;
            password_txt.Text = user.Password;
            confirmPassword_txt.Text = user.Password;

            isAccountActive_chk.Checked = !user.IsAccountActive;
            changePassword_chk.Checked = user.ChangePasswordNextLogon;
            neverExpires_chk.Checked = user.PasswordNeverExpired;
        }

        private bool checkPasswords(){
            string password = password_txt.Text.Trim();
            string confirmPassword = confirmPassword_txt.Text.Trim();
            if (password.Equals(confirmPassword)) {
                return true;
            }
            return false;  
        }

        private bool checkUser(string name) {
            ADUser anUser = ADUser.getUserByName(name);
            if (anUser != null) {
                return true;
            }
            return false;
        }
         #endregion    
    }
}

