using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace Abyss_Client.CompBase {
    public partial class BaseForm : Form {
        #region Attributes
        protected internal DialogResult dialogResult = DialogResult.Cancel;
        protected internal ResourceManager myManager;
        #endregion

        #region Constructors
        public BaseForm() {
            InitializeComponent();
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Override the ShowDialog method in order to return a
        /// dialog result on our forms
        /// </summary>
        public new DialogResult ShowDialog() {
            base.ShowDialog();
            return dialogResult;
        }
        #endregion

        #region Protected
        /// <summary>
        /// Check all mandatory fields
        /// </summary>
        /// <returns>true if all mandatory fields are set
        /// false elsewhere</returns>
        protected bool checkMandatoryFields() {
            return recurControlsCheck(this);
        }

        /// <summary>
        /// Open a form - this is a generic method used to open each form of the application
        /// the same way
        /// </summary>
        protected DialogResult openForm(BaseForm form) {
            DialogResult dres = DialogResult.Cancel;
            this.Hide();
#if !DEBUG
            try {
#endif
            dres = form.ShowDialog();
#if !DEBUG
            }
            catch {}
#endif
            this.Show();

            return dres;
        }

        /// <summary>
        /// Check all mandatory fields
        /// </summary>
        /// <returns>true if all mandatory fields are set
        /// false elsewhere</returns>
        /// <summary>
        /// Recursive function that checks each mandatory field
        /// </summary>
        /// <returns>true if all mandatory fields are set
        /// false elsewhere</returns>
        private bool recurControlsCheck(Control parent) {
            bool result = true;
            foreach (Control group in parent.Controls) {
                if (group.Visible) {
                    if (group is BaseGroupBox) {
                        foreach (Control control in group.Controls) {
                            if (control is BaseTextBox) {
                                BaseTextBox tb = (BaseTextBox)control;
                                if (tb.Mandatory && string.IsNullOrEmpty(tb.Text.Trim())) {
                                    tb.setErrorBackColor(true);
                                    result = false;
                                }
                                else {
                                    tb.setErrorBackColor(false);
                                }
                            }
                        }
                   
                    }
                }
            }

            return result;
        }
        #endregion
    }
}
