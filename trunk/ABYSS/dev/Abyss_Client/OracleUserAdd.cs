using Business;
using System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Collections;

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

        #region Component Events
        private void OracleUserAdd_Load(object sender, EventArgs e) {
            initFormData();
        }
        #endregion

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

        #region private Methods
        private void initFormData() {
            if (!update) {
                ArrayList list = OracleUser.GetDefaultTablespace();
                foreach (String var in list) {
                    defaultTablespace_cbx.Items.Add(var);
                }
                defaultTablespace_cbx.SelectedIndex = 0;
                list = OracleUser.GetTemporaryTablespace();
                foreach (String var in list) {
                    temporaryTablespace_cbx.Items.Add(var);
                }
                temporaryTablespace_cbx.SelectedIndex = 0;
                list = OracleUser.GetUsersProfile();
                foreach (String var in list) {
                    profile_cbx.Items.Add(var);
                }
                profile_cbx.SelectedIndex = 0;
            }
            else {
                defaultTablespace_cbx.SelectedItem = user.DefaultTablespace;
                temporaryTablespace_cbx.SelectedItem = user.TemporatyTablespace;
                profile_cbx.SelectedItem = user.Profile;
            }
            userLogin_txt.Text = user.UserLogin;
            accountLock_chk.Checked = user.Account;
            ArrayList rolesList = OracleUser.GetRoles();
            roleList_lbx.DataSource = rolesList;
        }
        #endregion
    }
}