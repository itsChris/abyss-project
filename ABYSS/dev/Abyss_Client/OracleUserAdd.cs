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
        private Hashtable ht = new Hashtable();
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
            try {
                initFormData();
            }
            catch (OracleException oex) {
                MessageBox.Show(oex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void roleList_lbx_DoubleClick(object sender, EventArgs e) {
            if (roleList_lbx.SelectedItems.Count == 1) {
                String role = (string)roleList_lbx.SelectedItems[0];
                if (!ht.ContainsKey(role)) {
                    ht.Add(role, role);
                    updateView();
                }
            }
        }

        private void userRoleList_lbx_DoubleClick(object sender, EventArgs e) {
            if (userRoleList_lbx.SelectedItems.Count == 1) {
                String role = (string)userRoleList_lbx.SelectedItems[0];
                if (ht.ContainsKey(role)) {
                    ht.Remove(role);
                    updateView();
                }
            }
        }

        private void createUser_btn_Click(object sender, EventArgs e) {
            user.Profile = profile_cbx.SelectedItem.ToString();
            user.DefaultTablespace = defaultTablespace_cbx.SelectedItem.ToString();
            user.TemporatyTablespace = temporaryTablespace_cbx.SelectedItem.ToString();
            user.CreatedDate = DateTime.Now.ToString();
            if (accountLock_chk.Checked) {
                user.Account = true;
            }
            user.UserLogin = userLogin_txt.Text;
            ArrayList privileges = new ArrayList();
            foreach (String var in ht.Keys) {
                string privilege = (string)ht[var];
                privileges.Add(privilege);
            }
            user.Roles = privileges;
            if (!update) {
                user.save();
            }
            else {
                user.edit();
            }
            dialogResult = DialogResult.OK;
            this.Close();
        }

        private void quit_btn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void OracleUserAdd_FormClosing(object sender, FormClosingEventArgs e) {
            if (dialogResult != DialogResult.OK) {
                if (MessageBox.Show("Do you want to quit ?",
                this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) {
                    e.Cancel = true;
                }
            }
        }
        #endregion

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

                userRoleList_lbx.Items.Add("CONNECT");
                ht.Add("CONNECT", "CONNECT");
            }
            else {
                defaultTablespace_cbx.SelectedItem = user.DefaultTablespace;
                temporaryTablespace_cbx.SelectedItem = user.TemporatyTablespace;
                profile_cbx.SelectedItem = user.Profile;
                userLogin_txt.Enabled = false;

                userRoleList_lbx.DataSource = user.Roles;
                foreach (String privilege in user.Roles) {
                    ht.Add(privilege, privilege);
                }
            }
            userLogin_txt.Text = user.UserLogin;
            accountLock_chk.Checked = user.Account;

            roleList_lbx.DataSource = OracleUser.GetRoles();
        }

        private void updateView() {
            userRoleList_lbx.Items.Clear();
            foreach (String var in ht.Keys) {
                String privilege = (string)ht[var];
                userRoleList_lbx.Items.Add(privilege);
            }
        } 
        #endregion
    }
}