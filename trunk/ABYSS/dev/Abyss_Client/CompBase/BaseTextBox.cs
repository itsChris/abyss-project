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

