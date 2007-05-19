using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abyss_Client {
    public partial class AboutForm : CompBase.BaseForm {
        #region Constructor
        public AboutForm() {
            InitializeComponent();
        }
        #endregion

        #region Conponent Events
        private void AboutForm_Load(object sender, EventArgs e) {
            baseLabel10.Text = Application.ProductName;
            baseLabel9.Text = Application.CompanyName;
            baseLabel8.Text = Application.ProductVersion;
            baseLabel7.Text = "Kevin Le Douget, Campos Pierre-Alexandre, Sascha PAOLO";
            baseLabel5.Text = "We wish, you enjoyed use this application. See you next time";
        }
        #endregion
    }
}