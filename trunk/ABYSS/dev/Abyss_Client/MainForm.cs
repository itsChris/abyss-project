using System;
using System.Windows.Forms;
using Utils;

namespace Abyss_Client {
    public partial class MainForm : CompBase.BaseForm {
        #region Constructors
        public MainForm() {
            InitializeComponent();
        }
        #endregion

        #region Main [STAThread]
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.DoEvents();
            using (SingleInstanceApp app = new SingleInstanceApp("{567825376 - DGZJ - PODS - 2875 - ABYSS}")) {
                if (!app.IsRunning()) {
                    ADLogin adLogin = new ADLogin();
                    Application.Run(adLogin);
                }
            }
        }
        #endregion
    }
}