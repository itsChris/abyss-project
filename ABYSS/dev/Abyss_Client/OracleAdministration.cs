using Business;
using DAO;
using System;
using Persistence;
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
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e) {
            openForm(new OracleUserAdd());
        }

        private void addTableToolStripMenuItem_Click(object sender, EventArgs e) {
            openForm(new OracleTableAdd());
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
            dialogResult = DialogResult.OK;
            this.Close();
        }

        private void load_btn_Click(object sender, EventArgs e) {
            sql_txt.Visible = true;
            create_btn.Visible = true;
            gridView_gdw.Visible = false;
            back_btn.Visible = false;
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

            //char[] separator = { ';' };
            

            try {
                OracleCommand cmd = OracleDAO.getInstance().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql_txt.Text.Replace(";","");
                if (sql_txt.Text.ToUpper().Contains("SELECT")) {
                    OracleDataReader reader = cmd.ExecuteReader();
                    cmd.Dispose();
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("TABLE");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);
                    gridView_gdw.DataSource = ds.Tables[0];
                    gridView_gdw.Visible = true;
                    sql_txt.Visible = false;
                    create_btn.Visible = false;
                    back_btn.Visible = true;
                }
                else {
                    //for (int i = 0; i < sql_txt.Text.Split(separator).Length; i++) {
                    //    cmd.CommandText = sql_txt.Text.Split(separator).GetValue(i);
                    //    cmd.ExecuteNonQuery();
                    //    cmd.Dispose();
                    //}
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                MessageBox.Show("Your query has been succesfully execute", "Succesfull", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (OracleException oex) {
                MessageBox.Show("Error in query execution : " + oex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }            
        }

        private void back_btn_Click(object sender, EventArgs e) {
            gridView_gdw.Visible = false;
            sql_txt.Visible = true;
            back_btn.Visible = false;
            create_btn.Visible = true;
        }

        private void Oracle_FormClosing(object sender, FormClosingEventArgs e) {
            if (dialogResult != DialogResult.OK) {
                if (MessageBox.Show("Do you want to quit ?", this.Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No) {
                    e.Cancel = true;
                }
            }
            
        }

        private void listOracleItem_trv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node.Tag != null) {
                if (e.Node.Tag.GetType() == typeof(OracleUser)) {
                    OracleUser user = (OracleUser)e.Node.Tag;
                    openForm(new OracleUserAdd(user));
                }
            }
        }
        #endregion

        

        private void listOracleItem_trv_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeView treeView = (TreeView)sender;
            TreeNode treeNode = treeView.SelectedNode;
            treeView.BeginUpdate();

            if (treeNode.Name == "Noeud3") {
                treeNode.Nodes.Clear();
                ArrayList list = OracleUser.GetUsers();
                foreach (OracleUserData userData in list) {
                    OracleUser user = new OracleUser(userData);
                    TreeNode tmpNode = new TreeNode(user.UserLogin);
                    tmpNode.Tag = user;
                    treeNode.Nodes.Add(tmpNode);
                    

                    
                }
            }

            //Get Table list
            if (treeNode.Name == "Noeud1") {
                treeNode.Nodes.Clear();
                OracleTable table = new OracleTable();
                OracleDataReader reader = table.GetTable();

                while (reader.Read()) {
                    treeNode.Nodes.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }

            //Get View list
            if (treeNode.Name == "Noeud2") {
                treeNode.Nodes.Clear();
                /*
                OracleDataReader reader = table.GetTable();

                while (reader.Read()) {
                    node.Nodes.Add(reader.GetValue(0).ToString());
                }
                reader.Close();*/
            }
            treeNode.Expand();
            treeView.EndUpdate();
        }

        private void refreshCurrentNode() {
            TreeNode node = this.listOracleItem_trv.SelectedNode;
            TreeViewEventArgs tvea = new TreeViewEventArgs(node);
            this.listOracleItem_trv_AfterSelect(this.listOracleItem_trv, tvea);
        }

        private void button1_Click(object sender, EventArgs e) {
            OracleTable table = new OracleTable();
            
            OracleTableAdd f = new OracleTableAdd(table.GetTableData(listOracleItem_trv.SelectedNode.Text));
            f.Show();
        }

                
    }
}

