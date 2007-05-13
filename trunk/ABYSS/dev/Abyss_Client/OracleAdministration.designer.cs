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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tables");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Views");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Users");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Oracle", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OracleAdministration));
            this.menu_menu = new Abyss_Client.CompBase.BaseMenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addViewToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_pnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.back_btn = new Abyss_Client.CompBase.BaseButton();
            this.baseLabel1 = new Abyss_Client.CompBase.BaseLabel();
            this.load_btn = new Abyss_Client.CompBase.BaseButton();
            this.create_btn = new Abyss_Client.CompBase.BaseButton();
            this.sql_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.gridView_gdw = new System.Windows.Forms.DataGridView();
            this.load_ofd = new System.Windows.Forms.OpenFileDialog();
            this.listOracleItem_trv = new Abyss_Client.CompBase.BaseTreeView();
            this.menu_stp = new Abyss_Client.CompBase.BaseContextMenu();
            this.imageList_adObjects = new System.Windows.Forms.ImageList(this.components);
            this.menu_menu.SuspendLayout();
            this.panel_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_gdw)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_menu
            // 
            this.menu_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu_menu.Location = new System.Drawing.Point(0, 0);
            this.menu_menu.Name = "menu_menu";
            this.menu_menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu_menu.Size = new System.Drawing.Size(1029, 24);
            this.menu_menu.TabIndex = 0;
            this.menu_menu.Text = "baseMenuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTableToolStripMenuItem,
            this.addUserToolStripMenu,
            this.addViewToDatabaseToolStripMenuItem,
            this.exitToolStripMenu});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addTableToolStripMenuItem
            // 
            this.addTableToolStripMenuItem.Name = "addTableToolStripMenuItem";
            this.addTableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.addTableToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.addTableToolStripMenuItem.Text = "Add Table to database ";
            this.addTableToolStripMenuItem.Click += new System.EventHandler(this.addTableToolStripMenuItem_Click);
            // 
            // addUserToolStripMenu
            // 
            this.addUserToolStripMenu.Name = "addUserToolStripMenu";
            this.addUserToolStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.addUserToolStripMenu.Size = new System.Drawing.Size(228, 22);
            this.addUserToolStripMenu.Text = "Add User to database";
            this.addUserToolStripMenu.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // addViewToDatabaseToolStripMenuItem
            // 
            this.addViewToDatabaseToolStripMenuItem.Name = "addViewToDatabaseToolStripMenuItem";
            this.addViewToDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.addViewToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.addViewToDatabaseToolStripMenuItem.Text = "Add View to database";
            this.addViewToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.addViewToDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenu.Size = new System.Drawing.Size(228, 22);
            this.exitToolStripMenu.Text = "Exit Oracle Administration";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel_pnl
            // 
            this.panel_pnl.BackColor = System.Drawing.Color.Transparent;
            this.panel_pnl.Controls.Add(this.button1);
            this.panel_pnl.Controls.Add(this.back_btn);
            this.panel_pnl.Controls.Add(this.baseLabel1);
            this.panel_pnl.Controls.Add(this.load_btn);
            this.panel_pnl.Controls.Add(this.create_btn);
            this.panel_pnl.Controls.Add(this.sql_txt);
            this.panel_pnl.Controls.Add(this.gridView_gdw);
            this.panel_pnl.Location = new System.Drawing.Point(328, 28);
            this.panel_pnl.Name = "panel_pnl";
            this.panel_pnl.Size = new System.Drawing.Size(698, 462);
            this.panel_pnl.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightGray;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.back_btn.Location = new System.Drawing.Point(16, 424);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(133, 23);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "Back to text mode";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // baseLabel1
            // 
            this.baseLabel1.AutoSize = true;
            this.baseLabel1.BackColor = System.Drawing.Color.LightGray;
            this.baseLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.baseLabel1.Location = new System.Drawing.Point(37, 21);
            this.baseLabel1.Name = "baseLabel1";
            this.baseLabel1.Size = new System.Drawing.Size(479, 13);
            this.baseLabel1.TabIndex = 1;
            this.baseLabel1.Text = "You can tape your SQL statements or load an external sql files and then execute i" +
                "t.";
            this.baseLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.Color.LightGray;
            this.load_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.load_btn.Location = new System.Drawing.Point(562, 16);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(94, 23);
            this.load_btn.TabIndex = 0;
            this.load_btn.Text = "Load SQL file";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.LightGray;
            this.create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.create_btn.Location = new System.Drawing.Point(190, 424);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(90, 23);
            this.create_btn.TabIndex = 3;
            this.create_btn.Text = "Execute";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // sql_txt
            // 
            this.sql_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sql_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.sql_txt.Location = new System.Drawing.Point(3, 50);
            this.sql_txt.Mandatory = false;
            this.sql_txt.Multiline = true;
            this.sql_txt.Name = "sql_txt";
            this.sql_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sql_txt.Size = new System.Drawing.Size(692, 359);
            this.sql_txt.TabIndex = 2;
            // 
            // gridView_gdw
            // 
            this.gridView_gdw.AllowUserToAddRows = false;
            this.gridView_gdw.AllowUserToDeleteRows = false;
            this.gridView_gdw.AllowUserToOrderColumns = true;
            this.gridView_gdw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_gdw.Location = new System.Drawing.Point(3, 50);
            this.gridView_gdw.Name = "gridView_gdw";
            this.gridView_gdw.ReadOnly = true;
            this.gridView_gdw.Size = new System.Drawing.Size(674, 359);
            this.gridView_gdw.TabIndex = 8;
            this.gridView_gdw.Visible = false;
            // 
            // load_ofd
            // 
            this.load_ofd.FileName = "load_ofd";
            this.load_ofd.Filter = "Fichiers SQL|*.sql|Fichiers Text|*.txt";
            // 
            // listOracleItem_trv
            // 
            this.listOracleItem_trv.ContextMenuStrip = this.menu_stp;
            this.listOracleItem_trv.ImageIndex = 2;
            this.listOracleItem_trv.ImageList = this.imageList_adObjects;
            this.listOracleItem_trv.Location = new System.Drawing.Point(12, 28);
            this.listOracleItem_trv.Name = "listOracleItem_trv";
            treeNode1.Name = "Tables";
            treeNode1.Text = "Tables";
            treeNode2.Name = "Views";
            treeNode2.Text = "Views";
            treeNode3.Name = "Users";
            treeNode3.Text = "Users";
            treeNode4.Name = "Noeud0";
            treeNode4.Text = "Oracle";
            this.listOracleItem_trv.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.listOracleItem_trv.SelectedImageIndex = 3;
            this.listOracleItem_trv.Size = new System.Drawing.Size(309, 462);
            this.listOracleItem_trv.StateImageList = this.imageList_adObjects;
            this.listOracleItem_trv.TabIndex = 1;
            this.listOracleItem_trv.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.listOracleItem_trv_NodeMouseDoubleClick);
            this.listOracleItem_trv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.listOracleItem_trv_AfterSelect);
            // 
            // menu_stp
            // 
            this.menu_stp.Name = "baseContextMenu1";
            this.menu_stp.ShowImageMargin = false;
            this.menu_stp.Size = new System.Drawing.Size(36, 4);
            // 
            // imageList_adObjects
            // 
            this.imageList_adObjects.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_adObjects.ImageStream")));
            this.imageList_adObjects.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_adObjects.Images.SetKeyName(0, "");
            this.imageList_adObjects.Images.SetKeyName(1, "ou.png");
            this.imageList_adObjects.Images.SetKeyName(2, "5485-cameleonhelp-Dossiervistaferme.png");
            this.imageList_adObjects.Images.SetKeyName(3, "5493-cameleonhelp-dossiervistaouvert.png");
            this.imageList_adObjects.Images.SetKeyName(4, "");
            this.imageList_adObjects.Images.SetKeyName(5, "");
            this.imageList_adObjects.Images.SetKeyName(6, "");
            this.imageList_adObjects.Images.SetKeyName(7, "");
            this.imageList_adObjects.Images.SetKeyName(8, "");
            this.imageList_adObjects.Images.SetKeyName(9, "computerblocked.png");
            // 
            // OracleAdministration
            // 
            this.ClientSize = new System.Drawing.Size(1029, 504);
            this.Controls.Add(this.listOracleItem_trv);
            this.Controls.Add(this.panel_pnl);
            this.Controls.Add(this.menu_menu);
            this.MainMenuStrip = this.menu_menu;
            this.Name = "OracleAdministration";
            this.Text = "Oracle Administration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Oracle_FormClosing);
            this.menu_menu.ResumeLayout(false);
            this.menu_menu.PerformLayout();
            this.panel_pnl.ResumeLayout(false);
            this.panel_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_gdw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private CompBase.BaseMenuStrip menu_menu;
        private System.Windows.Forms.Panel panel_pnl;
        private CompBase.BaseTextBox sql_txt;
        private System.Windows.Forms.OpenFileDialog load_ofd;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private CompBase.BaseButton create_btn;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenu;
        private Abyss_Client.CompBase.BaseTreeView listOracleItem_trv;
        private Abyss_Client.CompBase.BaseContextMenu menu_stp;
        private Abyss_Client.CompBase.BaseLabel baseLabel1;
        private Abyss_Client.CompBase.BaseButton load_btn;
        private System.Windows.Forms.DataGridView gridView_gdw;
        private Abyss_Client.CompBase.BaseButton back_btn;
        private System.Windows.Forms.ToolStripMenuItem addTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addViewToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList_adObjects;

    }
}
