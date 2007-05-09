using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Abyss_Client.CompBase;
using System.Collections;

namespace Abyss_Client {
    public partial class OracleTableAdd : CompBase.BaseForm {
        public OracleTableAdd() {
            InitializeComponent();            
        }

        private void rowsNumber_txt_Leave(object sender, EventArgs e) {
            int x = 13;
            int y = 86;
            
            ArrayList rowsType = new ArrayList();
            rowsType.Add("VARCHAR2");
            rowsType.Add("DATE");
            rowsType.Add("INTEGER");
            rowsType.Add("FLOAT");

            if (rowsNumber_txt.Text.Length > 0) {
                for (int i = 0; i < Convert.ToInt32(rowsNumber_txt.Text); i++) {
                    BaseTextBox txt = new BaseTextBox();
                    txt.Location = new Point(x, y);
                    txt.Size = new Size(150, 20);
                    txt.Name = "rowsName" + i + "_txt";
                    this.Controls.Add(txt);

                    x = x + txt.Size.Width + 5;

                    BaseComboBox cbx = new BaseComboBox();
                    cbx.Location = new Point(x, y);
                    cbx.Size = new Size(150, 20);
                    cbx.Name = "rowsType" + i + "_cbx";
                    cbx.DataSource = rowsType;
                    cbx.Sorted = true;
                    cbx.SelectedIndex = 0;
                    this.Controls.Add(cbx);

                    x = x + cbx.Size.Width + 5;

                    txt.Dispose();
                    txt.Location = new Point(x, y);
                    txt.Size = new Size(150, 20);
                    txt.Name = "rowsTypeNumber" + i + "_txt";
                    this.Controls.Add(txt);

                    x = x + txt.Size.Width + 5;

                    cbx.Dispose();
                    cbx.Location = new Point(x, y);
                    cbx.Size = new Size(150, 20);
                    cbx.Name = "rowsNull" + i + "_cbx";
                    cbx.Items.Add("Null");
                    cbx.Items.Add("Not Null");
                    cbx.Sorted = true;
                    cbx.SelectedIndex = 0;
                    this.Controls.Add(cbx);

                    x = x + cbx.Size.Width + 5;

                    BaseRadioButton rbt = new BaseRadioButton();
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
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }

        private void rowsNumber_txt_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Keys.Enter && rowsNumber_txt.Text.Length > 0) {
                rowsNumber_txt.Leave();
            }
            
            if(!(Char.IsDigit(e.KeyChar) || e.KeyChar==Keys.Back || e.KeyChar==Keys.Delete || 
                (Char.IsControl(e.KeyChar) && e.KeyChar==Keys.V))){
                e.Handled = true;
            }
            
        }
    }
}