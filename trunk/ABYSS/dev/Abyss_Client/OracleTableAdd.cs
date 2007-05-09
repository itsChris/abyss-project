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
            int y = 10;
            
            tableRows_pnl.Controls.Clear();

            if (rowsNumber_txt.Text.Length > 0) {
                this.SuspendLayout();
                for (int i = 0; i < Convert.ToInt32(rowsNumber_txt.Text); i++) {
                    BaseTextBox txt = new BaseTextBox();
                    txt.Location = new Point(x, y);
                    txt.Size = new Size(150, 20);
                    txt.Name = "rowsName" + i + "_txt";
                    tableRows_pnl.Controls.Add(txt);

                    x = x + txt.Size.Width + 5;

                    BaseComboBox cbx = new BaseComboBox();
                    cbx.Location = new Point(x, y);
                    cbx.Size = new Size(150, 20);
                    cbx.Name = "rowsType" + i + "_cbx";
                    cbx.Items.Add("VARCHAR2");
                    cbx.Items.Add("DATE");
                    cbx.Items.Add("INTEGER");
                    cbx.Items.Add("FLOAT");
                    cbx.Sorted = true;
                    tableRows_pnl.Controls.Add(cbx);
                    cbx.SelectedIndex = 0;

                    x = x + cbx.Size.Width + 5;

                    BaseTextBox type = new BaseTextBox();
                    type.Location = new Point(x, y);
                    type.Size = new Size(50, 20);
                    type.Name = "rowsTypeNumber" + i + "_txt";
                    tableRows_pnl.Controls.Add(type);
                    type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rowsNumber_txt_KeyPress);

                    x = x + type.Size.Width + 5;

                    BaseComboBox rowNull = new BaseComboBox();
                    rowNull.DataSource = null;
                    rowNull.Location = new Point(x, y);
                    rowNull.Size = new Size(150, 20);
                    rowNull.Name = "rowsNull" + i + "_cbx";
                    rowNull.Items.Add("Null");
                    rowNull.Items.Add("Not Null");
                    rowNull.Sorted = true;
                    tableRows_pnl.Controls.Add(rowNull);
                    rowNull.SelectedIndex = 0;

                    x = x + rowNull.Size.Width + 15;

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
                    tableRows_pnl.Controls.Add(rbt);

                    x = 13;
                    y = y + txt.Size.Height + 5;
                }
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }

        private void rowsNumber_txt_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter && rowsNumber_txt.Text.Length > 0) {
                rowsNumber_txt_Leave(new object(), new EventArgs());
            }

            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete ||
                (Char.IsControl(e.KeyChar) && (e.KeyChar == (char)Keys.V || e.KeyChar == (char)Keys.A)))) {
                e.Handled = true;
            }
            
        }

        private void tableName_txt_KeyPress(object sender, KeyPressEventArgs e) {

        }

    }
}