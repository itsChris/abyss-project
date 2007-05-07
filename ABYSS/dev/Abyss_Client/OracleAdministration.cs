using Business;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Abyss_Client {
    public partial class OracleAdministration : Abyss_Client.CompBase.BaseForm {
        #region Constructors
        public OracleAdministration() {
            InitializeComponent();
                        
        }
        #endregion

        #region Component events
        private void create_btn_Click(object sender, EventArgs e) {
            try {
                OracleCommand cmd = OracleDAO.getInstance();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql_txt.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

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

        private void load_btn_Click(object sender, EventArgs e) {
            if (load_ofd.ShowDialog()==DialogResult.OK){
                string sqlFile=load_ofd.FileName;
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

        private void listOracleItem_trv_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeView tree = (TreeView)sender;           
            TreeNode node = tree.SelectedNode;

            //Get user list
            if (node.Name == "Noeud3") {
                OracleUser user = new OracleUser();
                OracleDataReader reader = user.GetUser();

                while (reader.Read()) {
                    node.Nodes.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
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

