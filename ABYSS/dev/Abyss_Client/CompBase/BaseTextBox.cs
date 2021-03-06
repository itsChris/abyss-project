using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Abyss_Client.CompBase {
    public partial class BaseTextBox : TextBox {
        #region Attributes
        private Color errorBackColor = System.Drawing.Color.FromArgb(240, 180, 180);
        private Color saveBackColor;
        private bool mandatory = false;
        #endregion

        #region Constructors
        public BaseTextBox() {
            InitializeComponent();
            saveBackColor = BackColor;
        }
        #endregion

        #region Usercontrol properties
        [Category("Configuration"), Browsable(true), Description("The error back color")]
        public Color ErrorBackColor {
            get { return errorBackColor; }
            set { errorBackColor = value; }
        }
        [Category("Configuration"), Browsable(true), Description("Gets or Sets the textBox mandatory")]
        public bool Mandatory {
            get { return this.mandatory; }
            set { this.mandatory = value; }
        }
        #endregion

        #region Protected
        protected void BaseTextBox_Validating(object sender, CancelEventArgs e) {
            if (BackColor == errorBackColor && !string.IsNullOrEmpty(this.Text)) {
                BackColor = saveBackColor;
            }
            if (this.Text == string.Empty && this.mandatory) {
                BackColor = errorBackColor;
            }
        }

        protected void BaseTextBox_TextChanged(object sender, EventArgs e) {
            BaseTextBox_Validating(sender, new CancelEventArgs());
        }
        #endregion

        #region Public methods
        public void setErrorBackColor(bool dspError) {
            if (dspError) {
                BackColor = errorBackColor;
            }
            else {
                BackColor = saveBackColor;
            }
        }
        #endregion
    }
}


