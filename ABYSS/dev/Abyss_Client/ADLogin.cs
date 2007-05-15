using System;
using System.Windows.Forms;
using Business;
using DAO;
using System.DirectoryServices;
using System.Runtime.InteropServices;
using System.Collections;
using Oracle.DataAccess.Client;

namespace Abyss_Client {
    public partial class ADLogin : CompBase.BaseForm {
        #region Attributes
        DirectoryEntry connexion = null;
        ADUser user = null;
        #endregion

        #region Constructors
        public ADLogin() {
            InitializeComponent();
            new SplashScreen().ShowDialog();
        }
        #endregion

        #region Component events
        private void connect_btn_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                if (!checkMandatoryFields()) {
                    return;
                }
                if (defaultLdap_rbt.Checked) {
                    connexion = ADConnection.getInstance(login_txt.Text, password_txt.Text);
                }
                else {
                    connexion = ADConnection.getInstance(ldap_txt.Text, login_txt.Text, password_txt.Text);
                }   
                user = ADUser.getUserByName(login_txt.Text);
            }
            catch (COMException ComEx) {
                MessageBox.Show(ComEx.Message, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connexion != null) {
                    ADConnection.setInitToFalse();
                }
                return;
            }
            if (user != null) {
                try {
                    OracleDAO.getInstance();
                }
                catch (OracleException oex) {
                    MessageBox.Show(oex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OracleDAO.close();
                    return;
                }
                MessageBox.Show("Login success. Welcome " + user.DisplayName,
                this.Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                if (openForm(new ADAdministration(connexion)) == DialogResult.OK) {
                    Application.ExitThread();
                }
                ADConnection.setInitToFalse();
                reset_btn_Click(new object(), new EventArgs());
            }
            else {
                MessageBox.Show("Login failed", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ADConnection.setInitToFalse();
            }
            Cursor.Current = Cursors.Default;
        }

        private void defaultLdap_rbt_Click(object sender, EventArgs e) {
            otherLdap_rbt.Checked = false;
            ldap_lbl.Visible = false;
            ldap_txt.Visible = false;
        }

        private void otherLdap_rbt_Click(object sender, EventArgs e) {
            defaultLdap_rbt.Checked = false;
            ldap_lbl.Visible = true;
            ldap_txt.Visible = true;
        }

        private void reset_btn_Click(object sender, EventArgs e) {
            foreach (Control box in this.Controls) {
                if (box.GetType() == typeof(CompBase.BaseGroupBox)) {
                    foreach (Control control in box.Controls) {
                        if (control.GetType() == typeof(CompBase.BaseTextBox)) {
                            control.Text = string.Empty;
                        }
                    }
                }      
            }
            login_txt.Select();
        }

        private void ADLogin_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you want to quit the application?", this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            }
        }

        private void quit_btn_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion    
    }
}