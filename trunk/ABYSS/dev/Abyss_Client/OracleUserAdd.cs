using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Abyss_Client {
    public partial class OracleUserAdd : Abyss_Client.CompBase.BaseForm {
 
        public OracleUserAdd() {
            InitializeComponent();

            passwordExpire_chk.Checked = true;

        }

        private void createUser_btn_Click(object sender, EventArgs e) {
            
            
            
            OracleUser user = new OracleUser();

            user.Profile = profile_txt.Text;
            user.DefaultTablespace = defaultTablespace_txt.Text;
            user.TemporatyTablespace = temporaryTablespace_txt.Text;
            user.CreatedDate = DateTime.Now;

            if (accountLock_chk.Checked) {
                user.Account = false;
            }

            if (!passwordExpire_chk.Checked) {
                user.PasswordExpire = false;
            }

            if (externalUser_chk.Checked) {
                user.ExternalUser = true;
                user.UserLogin = "OPS$ABYSS\\" + userLogin_txt.Text;
            }
            else {
                user.ExternalUser = false;
                user.UserLogin = userLogin_txt.Text;
                user.UserPassword = userPassword_txt.Text;
            }

            //Save user in Oracle
            user.save();
        }

        private void externalUser_chk_Click(object sender, EventArgs e) {

            if (externalUser_chk.Checked) {
                userPassword_txt.Enabled = false;
            }
            else {
                userPassword_txt.Enabled = true;
            }

        }
    }
}