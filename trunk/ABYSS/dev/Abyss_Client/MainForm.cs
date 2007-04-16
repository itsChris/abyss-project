using System;
using System.Windows.Forms;
using Business;

namespace Abyss_Client {
    public partial class MainForm : CompBase.BaseForm {
        #region Constructors
        public MainForm() {
            InitializeComponent();
            new SplashScreen().ShowDialog();
        }
        #endregion

        #region Main [STAThread]
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.DoEvents(); 
            using (SingleInstanceApp app = new SingleInstanceApp("{567825376 - DGZJ - PODS - 2875 - ABYSS}")) {
                if (!app.IsRunning()) {
                    MainForm mainForm = new MainForm();
                    Application.Run(mainForm);
                }
            }
        }
        #endregion

        #region Component events
        private void activeDirectory_btn_Click(object sender, EventArgs e) {
            openForm(new ADLogin());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you want to quit the application", this.Text, 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            }
        }

        private void oracle_btn_Click(object sender, EventArgs e) {
            openForm(new OracleAdministration());
        }
        #endregion
    }
}