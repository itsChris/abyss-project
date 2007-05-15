using Business;
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
        #region Attributes
        private OracleTable table;
        private bool update = false;
        private int lastY;
        private int lastI;
        #endregion

        #region Constructors
        public OracleTableAdd() {
            InitializeComponent();
            this.table = new OracleTable();
        }

        public OracleTableAdd(OracleTable table) {
            InitializeComponent();

            update = true;
            
            int x = 13;
            int y = 10;
            this.table = table;

            tableName_txt.Text = table.TableName;
            rowsNumber_txt.Text = table.TableNameRows.Count.ToString();

            this.SuspendLayout();
            for (int i = 0; i < table.TableNameRows.Count; i++) {
                BaseCheckBox chk = new BaseCheckBox();
                chk.Location = new Point(x, y);
                chk.Size = new Size(15, 14);
                chk.Name = "rowsSel" + i + "_chk";
                chk.Text = "";
                chk.Enabled = false;
                tableRows_pnl.Controls.Add(chk);

                x = x + chk.Size.Width + 5;

                BaseTextBox txt = new BaseTextBox();
                txt.Location = new Point(x, y);
                txt.Size = new Size(150, 20);
                txt.Name = "rowsName" + i + "_txt";
                txt.Text = table.TableNameRows[i].ToString();
                txt.Enabled = false;
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
                cbx.Enabled = false;
                tableRows_pnl.Controls.Add(cbx);
                if (table.TableTypeRows[i].ToString().Contains("(")) {
                    if (cbx.Items.Contains(table.TableTypeRows[i].ToString().Substring(0, table.TableTypeRows[i].ToString().IndexOf("(")))) {
                        cbx.SelectedItem = table.TableTypeRows[i].ToString().Substring(0, table.TableTypeRows[i].ToString().IndexOf("("));
                    }
                    else {
                        cbx.Items.Add(table.TableTypeRows[i].ToString().Substring(0, table.TableTypeRows[i].ToString().IndexOf("(")));
                        cbx.SelectedItem = table.TableTypeRows[i].ToString().Substring(0, table.TableTypeRows[i].ToString().IndexOf("("));
                    }
                }
                else {
                    if (cbx.Items.Contains(table.TableTypeRows[i].ToString())) {
                        cbx.SelectedItem = table.TableTypeRows[i].ToString();
                    }
                    else {
                        cbx.Items.Add(table.TableTypeRows[i].ToString());
                        cbx.SelectedItem = table.TableTypeRows[i].ToString();
                    }
                }

                x = x + cbx.Size.Width + 5;

                BaseTextBox type = new BaseTextBox();
                type.Location = new Point(x, y);
                type.Size = new Size(50, 20);
                type.Name = "rowsTypeNumber" + i + "_txt";
                if (table.TableTypeRows[i].ToString().Contains("(")) {
                    type.Text = table.TableTypeRows[i].ToString().Substring(table.TableTypeRows[i].ToString().IndexOf("(")).Replace("(", "").Replace(")", "");
                }
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
                rowNull.SelectedValue = table.TableNull[i].ToString();
                rowNull.Sorted = true;
                tableRows_pnl.Controls.Add(rowNull);
                rowNull.SelectedIndex = 0;

                x = x + rowNull.Size.Width + 15;

                BaseRadioButton rbt = new BaseRadioButton();
                rbt.Location = new Point(x, y);
                if (table.TablePK.Contains(table.TableNameRows[i].ToString())) {
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
                lastI = i;
            }
            this.ResumeLayout();
            this.PerformLayout();

            lastY = y;            

            createTable_btn.Text = "Update Table";
            rowsNumber_txt.Enabled = false;
        }
        #endregion

        private void generateRows() {

            int x = 13;
            int y = 10;

            tableRows_pnl.Controls.Clear();

            if (rowsNumber_txt.Text.Length > 0) {
                this.SuspendLayout();
                for (int i = 0; i < Convert.ToInt32(rowsNumber_txt.Text); i++) {
                    BaseCheckBox chk = new BaseCheckBox();
                    chk.Location = new Point(x, y);
                    chk.Size = new Size(15, 14);
                    chk.Name = "rowsSel" + i + "_chk";
                    chk.Text = "";
                    tableRows_pnl.Controls.Add(chk);

                    x = x + chk.Size.Width + 5;

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
                    lastI = i;
                }
                this.ResumeLayout();
                this.PerformLayout();

                lastY = y;
            }
        }

        private void rowsNumber_txt_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter && rowsNumber_txt.Text.Length > 0) {
                generateRows();                
            }

            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete ||
                (Char.IsControl(e.KeyChar) && (e.KeyChar == (char)Keys.V || e.KeyChar == (char)Keys.A)))) {
                e.Handled = true;
            }
            
        }

        private void tableName_txt_KeyPress(object sender, KeyPressEventArgs e) {

        }

        private void createTable_btn_Click(object sender, EventArgs e) {
            int i=-1;
            int rowsIndex = 0;


            if (update) {
                foreach (Control ctrl in tableRows_pnl.Controls) {
                    if (ctrl is BaseTextBox && ctrl.Name.Contains("rowsName")) {
                        BaseTextBox txtN = (BaseTextBox)ctrl;
                        rowsIndex=Convert.ToInt32(txtN.Name.Substring(txtN.Name.IndexOf("_") - 1, 1));

                        if (!(table.TableNameRows.Count > rowsIndex)) {
                            table.TableNameRows.Add(txtN.Text);
                            table.TableNewRows.Add(table.TableNameRows.IndexOf(txtN.Text));
                            i = Convert.ToInt32(txtN.Name.Substring(txtN.Name.IndexOf("_") - 1, 1));
                        }
                    }
                    if (ctrl is BaseComboBox && ctrl.Name.Contains("rowsType")) {
                        BaseComboBox cbxT = (BaseComboBox)ctrl;
                                                
                        if (ctrl.Name == "rowsType" + i + "_cbx") {
                            table.TableTypeRows.Add(cbxT.SelectedItem);
                        }
                    }
                    if (ctrl is BaseTextBox && ctrl.Name=="rowsTypeNumber"+i+"_txt") {
                        BaseTextBox txtT = (BaseTextBox)ctrl;

                        if (ctrl.Name == "rowsType" + i + "_cbx") {
                            if ((string)table.TableTypeRows[i] == "VARCHAR2") {
                                table.TableTypeRows[i] += "(" + txtT.Text + ")";
                            }                           
                        }                        
                    }
                    if (ctrl is BaseComboBox && ctrl.Name=="rowsNull"+i+"_cbx") {
                        BaseComboBox cbxN = (BaseComboBox)ctrl;

                        if (table.TableNull.Count > rowsIndex && table.TableTypeRows[rowsIndex] != cbxN.SelectedItem.ToString()) {
                            table.TableNull[rowsIndex] = cbxN.SelectedItem;
                            if (!table.TableEditRows.Contains(table.TableNameRows.LastIndexOf(cbxN.SelectedItem))) {
                                table.TableEditRows.Add(table.TableNameRows.LastIndexOf(cbxN.SelectedItem));
                            }
                        }

                        if (ctrl.Name == "rowsNull" + i + "_cbx") {
                            table.TableNull.Add(cbxN.SelectedText);                            
                        }
                    }
                    if (ctrl is BaseRadioButton && ctrl.Name.Contains("rowsPK")) {
                        BaseRadioButton rbt = (BaseRadioButton)ctrl;
                        if (rbt.Checked) {
                            table.TablePK = table.TableNameRows[rowsIndex].ToString();
                        }
                    }
                }
                table.update();
            }
            else {
                table.TableName = tableName_txt.Text;

                i = 0;

                foreach (Control ctrl in tableRows_pnl.Controls) {
                    if (ctrl is BaseTextBox && ctrl.Name.Contains("rowsName")) {
                        BaseTextBox txtN = (BaseTextBox)ctrl;
                        table.TableNameRows.Add(txtN.Text);
                    }
                    if (ctrl is BaseComboBox && ctrl.Name.Contains("rowsType")) {
                        BaseComboBox cbxT = (BaseComboBox)ctrl;
                        table.TableTypeRows.Add(cbxT.SelectedItem);
                    }
                    if (ctrl is BaseTextBox && ctrl.Name.Contains("rowsTypeNumber")) {
                        BaseTextBox txtT = (BaseTextBox)ctrl;
                        if ((string)table.TableTypeRows[i] == "VARCHAR2") {
                            table.TableTypeRows[i] += "(" + txtT.Text + ")";
                        }
                    }
                    if (ctrl is BaseComboBox && ctrl.Name.Contains("rowsNull")) {
                        BaseComboBox cbxN = (BaseComboBox)ctrl;
                        table.TableNull.Add(cbxN.SelectedText);
                    }
                    if (ctrl is BaseRadioButton && ctrl.Name.Contains("rowsPK")) {
                        BaseRadioButton rbt = (BaseRadioButton)ctrl;
                        if (rbt.Checked) {
                            table.TablePK = table.TableNameRows[i].ToString();
                        }
                        i++;
                    }
                }
                table.save(Convert.ToInt32(rowsNumber_txt.Text));
            }
            this.Close();            
        }

        private void rowsAdd_btn_Click(object sender, EventArgs e) {
            int x = 13;
            int y = lastY;
            int i = lastI + 1;

            this.SuspendLayout();
            BaseCheckBox chk = new BaseCheckBox();
            chk.Location = new Point(x, y);
            chk.Size = new Size(15, 14);
            chk.Name = "rowsSel" + i + "_chk";
            chk.Text = "";
            tableRows_pnl.Controls.Add(chk);

            x = x + chk.Size.Width + 5;

            BaseTextBox txt = new BaseTextBox();
            txt.Location = new Point(x, y);
            txt.Size = new Size(150, 20);
            txt.Name = "rowsName" + i + "_txt";
            tableRows_pnl.Controls.Add(txt);
            txt.Focus();

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

            y = y + txt.Size.Height + 5;

            rowsNumber_txt.Text = (i + 1).ToString();

            lastY = y;
            lastI = i;
            this.ResumeLayout();
            this.PerformLayout();
        }

        private void delRows_btn_Click(object sender, EventArgs e) {
            ArrayList listDel = new ArrayList();
            int i;

            this.SuspendLayout();
            foreach (Control ctrl in tableRows_pnl.Controls) {
                if (ctrl is BaseCheckBox && ctrl.Name.Contains("rowsSel")) {
                    BaseCheckBox chk = (BaseCheckBox)ctrl;

                    if (chk.Checked) {             
                                                
                        listDel.Add(chk.Name.Substring(chk.Name.IndexOf("_") - 1, 1));
                                              
                    }                    
                }
            }

            for (i = 0; i < listDel.Count; i++) {
                int index;

                Control ctrl = tableRows_pnl.Controls["rowsName" + listDel[i].ToString() + "_txt"];
                index = table.TableNameRows.LastIndexOf(ctrl.Text);                
                tableRows_pnl.Controls.Remove(ctrl);

                tableRows_pnl.Controls.RemoveByKey("rowsType" + listDel[i].ToString() + "_cbx");
                tableRows_pnl.Controls.RemoveByKey("rowsTypeNumber" + listDel[i].ToString() + "_txt");
                tableRows_pnl.Controls.RemoveByKey("rowsNull" + listDel[i].ToString() + "_cbx");
                tableRows_pnl.Controls.RemoveByKey("rowsPK" + listDel[i].ToString() + "_rbt");
                tableRows_pnl.Controls.RemoveByKey("rowsSel" + listDel[i].ToString() + "_chk");

                //if (index > 0) {
                //    table.TableNameRows.RemoveAt(index);
                //    table.TableTypeRows.RemoveAt(index);
                //    table.TableNull.RemoveAt(index);
                //}
            }

            i=0;
            foreach (Control ctrl in tableRows_pnl.Controls) {
                if (ctrl is BaseCheckBox && ctrl.Name.Contains("rowsSel")) {
                    BaseCheckBox chkS = (BaseCheckBox)ctrl;
                    chkS.Name = "rowsSel" + i + "_chk";
                }
                if (ctrl is BaseTextBox && ctrl.Name.Contains("rowsName")) {
                    BaseTextBox txtN = (BaseTextBox)ctrl;
                    txtN.Name = "rowsName" + i + "_txt";
                }
                if (ctrl is BaseComboBox && ctrl.Name.Contains("rowsType")) {
                    BaseComboBox cbxT = (BaseComboBox)ctrl;
                    cbxT.Name = "rowsType" + i + "_cbx";
                }
                if (ctrl is BaseTextBox && ctrl.Name.Contains("rowsTypeNumber")) {
                    BaseTextBox txtT = (BaseTextBox)ctrl;
                    txtT.Name = "rowsTypeNumber" + i + "_txt";
                }
                if (ctrl is BaseComboBox && ctrl.Name.Contains("rowsNull")) {
                    BaseComboBox cbxN = (BaseComboBox)ctrl;
                    cbxN.Name = "rowsNull" + i + "_cbx";
                }
                if (ctrl is BaseRadioButton && ctrl.Name.Contains("rowsPK")) {
                    BaseRadioButton rbt = (BaseRadioButton)ctrl;
                    rbt.Name = "rowsPK" + i + "_rbt";
                    i++;
                }                
            }
            this.ResumeLayout();
            this.PerformLayout();
            rowsNumber_txt.Text = tableRows_pnl.Controls.Count.ToString();
        }

        private void tableRows_pnl_Scroll(object sender, ScrollEventArgs e) {
            this.Refresh();
        }

    }
}