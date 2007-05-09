using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abyss_Client {
    public partial class OracleTableAdd : CompBase.BaseForm {
        public OracleTableAdd() {
            InitializeComponent();            
        }

        private void rowsNumber_txt_Leave(object sender, EventArgs e) {
            int x = 13;
            int y = 86;

            if (rowsNumber_txt.Text.Length > 0) {
                for (int i = 0; i < Convert.ToInt32(rowsNumber_txt.Text); i++) {
                    TextBox txt = new TextBox();
                    txt.Location = new Point(x, y);
                    txt.Size = new Size(150, 20);
                    txt.Name = "rowsName" + i + "_txt";
                    this.Controls.Add(txt);

                    x = x + txt.Size.Width + 5;

                    ComboBox cbx = new ComboBox();
                    cbx.Location = new Point(x, y);
                    cbx.Size = new Size(150, 20);
                    cbx.Name = "rowsType" + i + "_cbx";
                    this.Controls.Add(cbx);

                    x = x + cbx.Size.Width + 5;

                    cbx.Dispose();
                    cbx.Location = new Point(x, y);
                    cbx.Size = new Size(150, 20);
                    cbx.Name = "rowsNull" + i + "_cbx";
                    cbx.Items.Add("");
                    cbx.Items.Add("Null");
                    cbx.Items.Add("Not Null");
                    this.Controls.Add(cbx);

                    x = x + cbx.Size.Width + 5;

                    RadioButton rbt = new RadioButton();
                    rbt.Location = new Point(x, y);
                    if (i == 0) {
                        rbt.Checked = true;
                    }
                    else {
                        rbt.Checked = false;
                    }
                    rbt.Name = "rowsPK" + i + "_rbt";
                    rbt.Text = "";
                    this.Controls.Add(rbt);

                    x = 13;
                    y = y + txt.Size.Height + 5;
                }
            }
        }

        private void rowsNumber_txt_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar < 0 && e.KeyChar > 9) {
                e.Handled = false;
            }
        }
    }
}