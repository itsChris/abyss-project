using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Configuration;

namespace Abyss_Client {
    public partial class Oracle : Abyss_Client.CompBase.BaseForm {
        #region Constructors
        public Oracle() {
            InitializeComponent();
        }
        #endregion

        #region Component events
        private void sql_rbt_Click(object sender, EventArgs e) {
            interface_rbl.Checked = false;
            sql_txt.Enabled = true;
            interface_gbx.Enabled = false;
        }

        private void interface_rbl_Click(object sender, EventArgs e) {
            sql_rbt.Checked = false;
            sql_txt.Enabled = false;
            interface_gbx.Enabled = true;
            name_txt.Enabled = false;
            name_lbl.Enabled = false;
            number_txt.Enabled = false;
            number_lbl.Enabled = false;
            view_rbt.Checked = false;
            table_rbt.Checked = false;
        }

        private void table_rbt_Click(object sender, EventArgs e) {
            view_rbt.Checked = false;
            name_txt.Enabled = true;
            name_lbl.Enabled = true;
            number_txt.Enabled = true;
            number_lbl.Enabled = true;
        }

        private void view_rbt_Click(object sender, EventArgs e) {
            table_rbt.Checked = false;
            name_txt.Enabled = true;
            name_lbl.Enabled = true;
            number_txt.Enabled = false;
            number_lbl.Enabled = false;
        }

        private void create_btn_Click(object sender, EventArgs e) {
            if (interface_rbl.Enabled && table_rbt.Enabled) {        
            }

            if (interface_rbl.Enabled && view_rbt.Enabled) {
            }
            if (sql_rbt.Enabled) {

            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Oracle_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you want to quit ?", this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            }
        }
        #endregion

        private void Oracle_Load(object sender, EventArgs e) {
            
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["OraConnect"].ConnectionString);
            
            /*con.ConnectionString = ConfigurationManager.ConnectionStrings["OraConnect"].ConnectionString;

            try {
                con.Open();

            }
            catch (OracleException ex) {
                Console.WriteLine("Error : " + ex.Message);
            }*/

            MessageBox.Show(con.ConnectionString);
            

        }
    }
}

