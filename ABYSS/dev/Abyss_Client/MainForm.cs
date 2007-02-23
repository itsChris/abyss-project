using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;

namespace Abyss_Client {
    public partial class MainForm : CompBase.BaseForm {
        #region Attributes
        private bool startOk = true;
        #endregion

        #region Constructors
        public MainForm() {
            InitializeComponent();
            this.Hide();
            new SplashScreen().ShowDialog();
        }
        #endregion

        [STAThread]
        static void Main() {
            using (SingleInstanceApp app = new SingleInstanceApp("{567825376 - DGZJ - PODS - 2875 - ABYSS}")) {
                if (!app.IsRunning()) {
                    MainForm mainForm = new MainForm();
                    if (mainForm.startOk == true) {
                        Application.Run(mainForm);
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            DirectoryEntry test = Utils.Utility.getDirectoryObject("supinfo-project","Administrator", "password");
            MessageBox.Show((string)test.Properties["distinguishedName"].Value);
            MessageBox.Show(Utils.Utility.getUser(test,"Administrator", "password").Name);
        }

       

        private void connect_btn_Click(object sender, EventArgs e)
        {
            //LDAP Connexion
        }

        private void defaultLdap_rbt_Click(object sender, EventArgs e)
        {
            otherLdap_rbt.Checked = false;
            ldap_lbl.Visible = false;
            ldap_txt.Visible = false;
        }

        private void otherLdap_rbt_Click(object sender, EventArgs e)
        {
            defaultLdap_rbt.Checked = false;
            ldap_lbl.Visible = true;
            ldap_txt.Visible = true;
        }

    }
}