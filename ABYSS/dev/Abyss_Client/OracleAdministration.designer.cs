namespace Abyss_Client {
    partial class OracleAdministration {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tables");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Views");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Users");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Oracle", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.menu_menu = new Abyss_Client.CompBase.BaseMenuStrip();
            this.switcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_pnl = new System.Windows.Forms.Panel();
            this.load_btn = new Abyss_Client.CompBase.BaseButton();
            this.create_btn = new Abyss_Client.CompBase.BaseButton();
            this.sql_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.load_ofd = new System.Windows.Forms.OpenFileDialog();
            this.listOracleItem_trv = new Abyss_Client.CompBase.BaseTreeView();
            this.baseContextMenu1 = new Abyss_Client.CompBase.BaseContextMenu();
            this.menu_menu.SuspendLayout();
            this.panel_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_menu
            // 
            this.menu_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switcToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menu_menu.Location = new System.Drawing.Point(0, 0);
            this.menu_menu.Name = "menu_menu";
            this.menu_menu.Size = new System.Drawing.Size(976, 24);
            this.menu_menu.TabIndex = 0;
            this.menu_menu.Text = "baseMenuStrip1";
            // 
            // switcToolStripMenuItem
            // 
            this.switcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.switcToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.switcToolStripMenuItem.Name = "switcToolStripMenuItem";
            this.switcToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.switcToolStripMenuItem.Text = "File";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // panel_pnl
            // 
            this.panel_pnl.BackColor = System.Drawing.Color.Transparent;
            this.panel_pnl.Controls.Add(this.load_btn);
            this.panel_pnl.Controls.Add(this.create_btn);
            this.panel_pnl.Controls.Add(this.sql_txt);
            this.panel_pnl.Location = new System.Drawing.Point(328, 28);
            this.panel_pnl.Name = "panel_pnl";
            this.panel_pnl.Size = new System.Drawing.Size(648, 456);
            this.panel_pnl.TabIndex = 2;
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.Color.LightGray;
            this.load_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.load_btn.Location = new System.Drawing.Point(524, 39);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(121, 23);
            this.load_btn.TabIndex = 1;
            this.load_btn.Text = "Load SQL file";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.LightGray;
            this.create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.create_btn.Location = new System.Drawing.Point(50, 318);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(90, 23);
            this.create_btn.TabIndex = 5;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // sql_txt
            // 
            this.sql_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sql_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.sql_txt.Location = new System.Drawing.Point(50, 68);
            this.sql_txt.Mandatory = false;
            this.sql_txt.Multiline = true;
            this.sql_txt.Name = "sql_txt";
            this.sql_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sql_txt.Size = new System.Drawing.Size(595, 244);
            this.sql_txt.TabIndex = 2;
            // 
            // load_ofd
            // 
            this.load_ofd.FileName = "load_ofd";
            this.load_ofd.Filter = "Fichiers SQL|*.sql|Fichiers Text|*.txt";
            // 
            // listOracleItem_trv
            // 
            this.listOracleItem_trv.Location = new System.Drawing.Point(12, 28);
            this.listOracleItem_trv.Name = "listOracleItem_trv";
            treeNode1.Name = "Noeud1";
            treeNode1.Text = "Tables";
            treeNode2.Name = "Noeud2";
            treeNode2.Text = "Views";
            treeNode3.Name = "Noeud3";
            treeNode3.Text = "Users";
            treeNode4.Name = "Noeud0";
            treeNode4.Text = "Oracle";
            this.listOracleItem_trv.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.listOracleItem_trv.Size = new System.Drawing.Size(309, 456);
            this.listOracleItem_trv.TabIndex = 3;
            this.listOracleItem_trv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.listOracleItem_trv_AfterSelect);
            // 
            // baseContextMenu1
            // 
            this.baseContextMenu1.Name = "baseContextMenu1";
            this.baseContextMenu1.ShowImageMargin = false;
            this.baseContextMenu1.Size = new System.Drawing.Size(36, 4);
            // 
            // OracleAdministration
            // 
            this.ClientSize = new System.Drawing.Size(976, 496);
            this.Controls.Add(this.listOracleItem_trv);
            this.Controls.Add(this.panel_pnl);
            this.Controls.Add(this.menu_menu);
            this.MainMenuStrip = this.menu_menu;
            this.Name = "OracleAdministration";
            this.Text = "Oracle Administration view";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Oracle_FormClosing);
            this.menu_menu.ResumeLayout(false);
            this.menu_menu.PerformLayout();
            this.panel_pnl.ResumeLayout(false);
            this.panel_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private CompBase.BaseMenuStrip menu_menu;
        private System.Windows.Forms.Panel panel_pnl;
        private CompBase.BaseTextBox sql_txt;
        private System.Windows.Forms.OpenFileDialog load_ofd;
        private System.Windows.Forms.ToolStripMenuItem switcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private CompBase.BaseButton create_btn;
        private Abyss_Client.CompBase.BaseButton load_btn;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private Abyss_Client.CompBase.BaseTreeView listOracleItem_trv;
        private Abyss_Client.CompBase.BaseContextMenu baseContextMenu1;

    }
}
