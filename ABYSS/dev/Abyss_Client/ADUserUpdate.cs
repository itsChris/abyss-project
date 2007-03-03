using System;
using Business;
using System.Windows.Forms;

namespace Abyss_Client {
    public partial class ADUserUpdate : Abyss_Client.CompBase.BaseForm {
        #region Attributes
        private ADUser user;
        #endregion Attributes

        #region Constructors
        public ADUserUpdate() {
            InitializeComponent();
            this.user = new ADUser();
        }

        public ADUserUpdate(ADUser user) {
            InitializeComponent();
            this.user = user;
        }
        #endregion

        #region Component events
        private void ADUserUpdate_Load(object sender, EventArgs e) {

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
        #endregion  
    }
}

