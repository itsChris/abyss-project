using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abyss_Client {
    public partial class OracleEditUserPassword : CompBase.BaseForm {
        public OracleEditUserPassword() {
            InitializeComponent();
        }

        private void valid_btn_Click(object sender, EventArgs e) {
            if (password_txt.Text == confirmPassword_txt.Text) {
                OracleUser user = new OracleUser();

                try {
                    user.editPassword(password_txt.Text);
                }
                catch (Exception ex) {
                    Console.WriteLine("Error in Password modification : " + ex.Message);
                }
                finally {
                    this.Close();
                }
            }
        }
    }
}