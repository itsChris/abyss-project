using System;
using Business;
using System.Windows.Forms;

namespace Abyss_Client {
    public partial class ADUserUpdate : Abyss_Client.CompBase.BaseForm {
        #region Attributes
        private ADUser user;
        private bool update = false;
        #endregion Attributes

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

        private void firstName_txt_TextChanged(object sender, EventArgs e) {
            string display;
            if (!string.IsNullOrEmpty(lastName_txt.Text)) {
                display = firstName_txt.Text + " ";
            }
            else {
                display = firstName_txt.Text;
            }
            if(!string.IsNullOrEmpty(initial_txt.Text)){
                display+=initial_txt.Text+ ". ";
            }
            display+= lastName_txt.Text;
            displayName_txt.Text = display;
        }

        private void addUser_btn_Click(object sender, EventArgs e) {
            // Si il s'agit d'un ajout, vérif si le username existe déja
            // si oui on sort, sinon on ajoute


            user.FirstName = this.firstName_txt.Text;
            user.MiddleInitial = this.firstName_txt.Text;
            user.LastName = this.lastName_txt.Text;
            user.DisplayName = this.displayName_txt.Text;
            //user.Description = 
            user.UserPrincipalName = this.username_txt.Text + "@abyss.lan";
            user.UserName = this.username_txt.Text;
            user.Password = this.password_txt.Text;
            user.IsAccountActive = this.isAccountActive_chk.Checked;
            user.save();
        }

        private void ADUserUpdate_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you want to quit ?",
            this.Text,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            }
        }
        #endregion 
  
        #region Private Methods
        private void initFormData() {
            firstName_txt.Text = user.FirstName;
            lastName_txt.Text = user.LastName;
            initial_txt.Text = user.MiddleInitial;
            displayName_txt.Text = user.DisplayName;
            desc_txt.Text = user.Description;
            officePhone_txt.Text = user.OfficePhone;
            fax_txt.Text = user.Fax;
            url_txt.Text = user.Url;
            residentialAddress_txt.Text = user.ResidentialAddress;
            title_txt.Text = user.Title;
            homePhone_txt.Text = user.HomePhone;
            mobile_txt.Text = user.Mobile;
            email_lbl.Text = user.Email;
            postalAddress_txt.Text = user.PostalAddress;
            maillingAddress_txt.Text = user.MailingAddress;
            if (update == true) {
                username_txt.Enabled = false;
            }
            username_txt.Text = user.UserName;
            isAccountActive_chk.Enabled = user.IsAccountActive;          
        }
        #endregion

        
    }
}

