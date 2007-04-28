using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abyss_Client {
    public partial class OracleUserAdd : Abyss_Client.CompBase.BaseForm {
 
        public OracleUserAdd() {
            InitializeComponent();

            passwordExpire_chk.Checked = true;
        }

        private void createUser_btn_Click(object sender, EventArgs e) {
            OracleUser user = new OracleUser();

            user.UserLogin = userLogin_txt.Text;
            user.UserPassword = userPassword_txt.Text;
            user.Profile = profile_txt.Text;
            user.DefaultTablespace = defaultTablespace_txt.Text;
            user.TemporatyTablespace = temporaryTablespace_txt.Text;

            if (accountLock_chk.Checked) {
                user.Account = false;
            }

            if (!passwordExpire_chk.Checked) {
                user.PasswordExpire = false;
            }

            if (globalUser_chk.Checked) {
                user.GlobalUser = true;
            }
            else {
                user.GlobalUser = false;
            }

            if (externalUser_chk.Checked) {
                user.ExternalUser = true;
            }
            else {
                user.ExternalUser = false;
            }

            //Save user in Oracle
            user.save();
        }
    }
}