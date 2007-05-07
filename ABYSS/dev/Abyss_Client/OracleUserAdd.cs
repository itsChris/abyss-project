using Business;
using System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Abyss_Client {
    public partial class OracleUserAdd : Abyss_Client.CompBase.BaseForm {
        #region Attributes
        private OracleUser user;
        private bool update = false;
        #endregion

        #region Constructors
        public OracleUserAdd() {
            InitializeComponent();
            this.user = new OracleUser();
        }

        public OracleUserAdd(OracleUser user) {
            InitializeComponent();
            this.user = user;
            this.update = true;
        }
        #endregion

        private void OracleUserAdd_Load(object sender, EventArgs e) {
            initFormData();
        }

        private void createUser_btn_Click(object sender, EventArgs e) {
            
            
            
            OracleUser user = new OracleUser();

            user.Profile = profile_cbx.SelectedItem.ToString();
            user.DefaultTablespace = defaultTablespace_cbx.SelectedItem.ToString();
            user.TemporatyTablespace = temporaryTablespace_cbx.SelectedItem.ToString();
            user.CreatedDate = DateTime.Now.ToString();

            if (accountLock_chk.Checked) {
                user.Account = false;
            }

            //if (!passwordExpire_chk.Checked) {
            //    user.PasswordExpire = false;
            //}

            //if (externalUser_chk.Checked) {
            //    user.ExternalUser = true;
            //    user.UserLogin = userLogin_txt.Text;
            //}
            //else {
            //    user.ExternalUser = false;
            //    user.UserLogin = userLogin_txt.Text;
            //    //user.UserPassword = userPassword_txt.Text;
            //}

            //Save user in Oracle
            user.save();
            dialogResult = DialogResult.OK;
            this.Close();
        }

        private void externalUser_chk_Click(object sender, EventArgs e) {

            //if (externalUser_chk.Checked) {
            //    //userPassword_txt.Enabled = false;
            //    passwordExpire_chk.Enabled = false;
            //    passwordExpire_chk.Checked = false;
            //}
            //else {
            //    //userPassword_txt.Enabled = true;
            //}

        }

        private void initFormData() {
            if (!update) {
                OracleDataReader reader = user.GetDefaultTablespace();
                while (reader.Read()) {
                    defaultTablespace_cbx.Items.Add(reader.GetValue(0));
                }
                defaultTablespace_cbx.SelectedIndex = 0;
                reader.Close();
                reader = user.GetTemporaryTablespace();
                while (reader.Read()) {
                    temporaryTablespace_cbx.Items.Add(reader.GetValue(0));
                }
                temporaryTablespace_cbx.SelectedIndex = 0;
                reader.Close();
                reader = user.GetProfile();
                while (reader.Read()) {
                    profile_cbx.Items.Add(reader.GetValue(0));
                }
                reader.Close();
                profile_cbx.SelectedIndex = 0;
            }
            userLogin_txt.Text = user.UserLogin;




            
        }

        private void defaultTablespace_cbx_KeyPress(object sender, KeyPressEventArgs e) {
            return;
        }

        

    }
}