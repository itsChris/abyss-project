using System;
using Business;
using System.Windows.Forms;

namespace Abyss_Client {
    public partial class OracleViewAdd : CompBase.BaseForm {
        #region Attributs
        private OracleView oracleView;
        private bool update = false;
        #endregion

        #region Constructors
        public OracleViewAdd() {
            InitializeComponent();
            this.oracleView = new OracleView();
        }

        public OracleViewAdd(OracleView oracleView) {
            InitializeComponent();
            this.oracleView = oracleView;

            viewName_txt.Text = oracleView.ViewName;
            viewName_txt.Enabled = false;
            viewQuery_txt.Text = oracleView.ViewQuery;
            update = true;
        }
        #endregion

        #region Events
        private void viewValidation_btn_Click(object sender, EventArgs e) {
            if (!checkMandatoryFields()) {
                return;
            }

            if (update) {
                if (oracleView.ViewQuery != viewQuery_txt.Text.Replace(";", "")) {
                    oracleView.ViewQuery = viewQuery_txt.Text.Replace(";", "");
                }
                else {
                    DialogResult result = MessageBox.Show("You don't have any modification.\n Would you have quit ?", "Any modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) {
                        return;
                    }
                }
            }
            else {
                oracleView.ViewName = viewName_txt.Text;
                oracleView.ViewQuery = viewQuery_txt.Text.Replace(";", "");

                oracleView.save();
            }
            this.Close();
        }
        #endregion
    }
}