using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abyss_Client {
    public partial class OracleTableAdd : CompBase.BaseForm {
        private int x;
        private int y;
        public OracleTableAdd() {
            InitializeComponent();

            x = 13;
            y = 86;
        }

        private void rowsNumber_txt_TextChanged(object sender, EventArgs e) {
            
        }
    }
}