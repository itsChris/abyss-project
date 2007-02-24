using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using Utils;

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
        //    //string RootDSE;
        //    //System.DirectoryServices.DirectorySearcher DSESearcher = new System.DirectoryServices.DirectorySearcher(Utils.Utility.getDirectoryObject("Supinfo-project","Administrator","password"));
        //    //RootDSE = DSESearcher.SearchRoot.Path;
        //    //RootDSE = RootDSE.Insert(7, "OU=MyDomain,");
        //    //MessageBox.Show(RootDSE);
        //    System.DirectoryServices.DirectoryEntry myDE = Utils.Utility.getDirectoryObject("Supinfo-Project","Administrator","password");
        //    Utility.CrtDomain = "Supinfo-project";
        //    Utility.CrtUserName = "Administrator";
        //    Utility.CrtPassword = "password";
        //    DirectoryEntry myDirectoryEntry = Utils.Utility.getUser("Administrator");
        //    foreach (String test in myDirectoryEntry.Properties.PropertyNames) {
        //        MessageBox.Show(test);

        //    }
            
        //    //DirectoryEntries myEntries = myDE.Children; 
        //    //System.DirectoryServices.DirectoryEntry myDirectoryEntry = myEntries.Add("CN=test,cn=users", "user");
        //    //Utility.setProperty(myDirectoryEntry, "givenName", "PAOLO");
        //    //Utility.setProperty(myDirectoryEntry, "initials", "PS");
        //    //Utility.setProperty(myDirectoryEntry, "sn", "Sascha");
        //    //if (UserPrincipalName != null) {
        //    //    Utility.SetProperty(myDirectoryEntry, "UserPrincipalName", UserPrincipalName);
        //    //}
        //    //else {
        //        //Utility.setProperty(myDirectoryEntry, "UserPrincipalName", "test");
        //    //}
        //    //Utility.setProperty(myDirectoryEntry, "PostalAddress", PostalAddress);
        //    //Utility.setProperty(myDirectoryEntry, "StreetAddress", MailingAddress);
        //    //Utility.setProperty(myDirectoryEntry, "HomePostalAddress", ResidentialAddress);
        //    //Utility.setProperty(myDirectoryEntry, "Title", Title);
        //    //Utility.setProperty(myDirectoryEntry, "HomePhone", HomePhone);
        //    //Utility.setProperty(myDirectoryEntry, "TelephoneNumber", OfficePhone);
        //    //Utility.setProperty(myDirectoryEntry, "Mobile", Mobile);
        //    //Utility.setProperty(myDirectoryEntry, "FacsimileTelephoneNumber", Fax);
        //    //Utility.setProperty(myDirectoryEntry, "mail", Email);
        //    //Utility.setProperty(myDirectoryEntry, "Url", Url);
        //    //Utility.setProperty(myDirectoryEntry, "sAMAccountName", "test");
        //    //Utility.setProperty(myDirectoryEntry, "UserPassword", "password");
        //    //myDirectoryEntry.Properties["userAccountControl"].Value = Utility.userStatus.Enable;
        //    //myDirectoryEntry.CommitChanges();
        //    //myDirectoryEntry = Utils.Utility.getUser("test");
        //    //Utility.setUserPassword(myDirectoryEntry, "password");
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