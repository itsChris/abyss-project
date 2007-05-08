using Business;
using DAO;
using System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.IO;
using System.Collections;
using System.Data;

namespace Abyss_Client {
    public partial class OracleAdministration : Abyss_Client.CompBase.BaseForm {
        #region Constructors
        public OracleAdministration() {
            InitializeComponent();           
        }
        #endregion

        #region Component events
        private void load_btn_Click(object sender, EventArgs e) {
            if (load_ofd.ShowDialog() == DialogResult.OK) {
                sql_txt.Text = String.Empty;
                string sqlFile = load_ofd.FileName;
                StreamReader sr = null;
                string line;
                sr = new StreamReader(sqlFile);
                line = sr.ReadLine();
                while (line != null) {
                    sql_txt.Text += line;
                    line = sr.ReadLine();
                }
            }
        }

        private void create_btn_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(sql_txt.Text)) {
                return;
            }
            try {
                OracleCommand cmd = OracleDAO.getInstance().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql_txt.Text;
                if (sql_txt.Text.ToUpper().Contains("SELECT")) {
                    OracleDataReader reader = cmd.ExecuteReader();
                    cmd.Dispose();
                    sql_txt.Text = string.Empty;
                    while (reader.Read()) {
                        sql_txt.Text = sql_txt.Text + reader.GetValue(0).ToString()+ "\r\n\r\n";
                    }
                }
                else {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                MessageBox.Show("Your query has been succesfully execute", "Succesfull", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (OracleException oex) {
                MessageBox.Show("Error in query execution : " + oex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e) {
            openForm(new OracleUserAdd());
        }

        #endregion

        

        private void listOracleItem_trv_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeView tree = (TreeView)sender;           
            TreeNode node = tree.SelectedNode;

            //Get user list
            if (node.Name == "Noeud3") {
                ArrayList list = OracleUser.GetUsers();
                foreach (String var in list) {
                    node.Nodes.Add(var);
                }
            }

            //Get Table list
            if (node.Name == "Noeud1") {
                OracleTable table = new OracleTable();
                OracleDataReader reader = table.GetTable();

                while (reader.Read()) {
                    node.Nodes.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }

            //Get View list
            if (node.Name == "Noeud2") {
                /*
                OracleDataReader reader = table.GetTable();

                while (reader.Read()) {
                    node.Nodes.Add(reader.GetValue(0).ToString());
                }
                reader.Close();*/
            }
        }
              
    }
}

