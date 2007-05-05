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
            this.sql_rbt = new Abyss_Client.CompBase.BaseRadioButton();
            this.interface_rbl = new Abyss_Client.CompBase.BaseRadioButton();
            this.menu_menu = new Abyss_Client.CompBase.BaseMenuStrip();
            this.switcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableList_lst = new Abyss_Client.CompBase.BaseListView();
            this.panel_pnl = new System.Windows.Forms.Panel();
            this.load_btn = new Abyss_Client.CompBase.BaseButton();
            this.create_btn = new Abyss_Client.CompBase.BaseButton();
            this.interface_gbx = new Abyss_Client.CompBase.BaseGroupBox();
            this.number_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.number_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.name_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.name_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.view_rbt = new Abyss_Client.CompBase.BaseRadioButton();
            this.table_rbt = new Abyss_Client.CompBase.BaseRadioButton();
            this.sql_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.load_ofd = new System.Windows.Forms.OpenFileDialog();
            this.menu_menu.SuspendLayout();
            this.panel_pnl.SuspendLayout();
            this.interface_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // sql_rbt
            // 
            this.sql_rbt.AutoSize = true;
            this.sql_rbt.BackColor = System.Drawing.Color.LightGray;
            this.sql_rbt.Checked = true;
            this.sql_rbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.sql_rbt.Location = new System.Drawing.Point(17, 13);
            this.sql_rbt.Name = "sql_rbt";
            this.sql_rbt.Size = new System.Drawing.Size(77, 17);
            this.sql_rbt.TabIndex = 0;
            this.sql_rbt.TabStop = true;
            this.sql_rbt.Text = "Sql mode";
            this.sql_rbt.UseVisualStyleBackColor = true;
            this.sql_rbt.Click += new System.EventHandler(this.sql_rbt_Click);
            // 
            // interface_rbl
            // 
            this.interface_rbl.AutoSize = true;
            this.interface_rbl.BackColor = System.Drawing.Color.LightGray;
            this.interface_rbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.interface_rbl.Location = new System.Drawing.Point(17, 305);
            this.interface_rbl.Name = "interface_rbl";
            this.interface_rbl.Size = new System.Drawing.Size(110, 17);
            this.interface_rbl.TabIndex = 3;
            this.interface_rbl.TabStop = true;
            this.interface_rbl.Text = "Interface mode";
            this.interface_rbl.UseVisualStyleBackColor = true;
            this.interface_rbl.Click += new System.EventHandler(this.interface_rbl_Click);
            // 
            // menu_menu
            // 
            this.menu_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switcToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menu_menu.Location = new System.Drawing.Point(0, 0);
            this.menu_menu.Name = "menu_menu";
            this.menu_menu.Size = new System.Drawing.Size(979, 24);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // tableList_lst
            // 
            this.tableList_lst.AllowColumnReorder = true;
            this.tableList_lst.FullRowSelect = true;
            this.tableList_lst.Location = new System.Drawing.Point(13, 28);
            this.tableList_lst.MultiSelect = false;
            this.tableList_lst.Name = "tableList_lst";
            this.tableList_lst.Size = new System.Drawing.Size(308, 513);
            this.tableList_lst.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.tableList_lst.TabIndex = 1;
            this.tableList_lst.TabStop = false;
            this.tableList_lst.UseCompatibleStateImageBehavior = false;
            this.tableList_lst.View = System.Windows.Forms.View.List;
            // 
            // panel_pnl
            // 
            this.panel_pnl.BackColor = System.Drawing.Color.Transparent;
            this.panel_pnl.Controls.Add(this.load_btn);
            this.panel_pnl.Controls.Add(this.create_btn);
            this.panel_pnl.Controls.Add(this.interface_gbx);
            this.panel_pnl.Controls.Add(this.sql_txt);
            this.panel_pnl.Controls.Add(this.sql_rbt);
            this.panel_pnl.Controls.Add(this.interface_rbl);
            this.panel_pnl.Location = new System.Drawing.Point(328, 28);
            this.panel_pnl.Name = "panel_pnl";
            this.panel_pnl.Size = new System.Drawing.Size(648, 513);
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
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.LightGray;
            this.create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.create_btn.Location = new System.Drawing.Point(284, 481);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(90, 23);
            this.create_btn.TabIndex = 5;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // interface_gbx
            // 
            this.interface_gbx.BackColor = System.Drawing.Color.Transparent;
            this.interface_gbx.Controls.Add(this.number_txt);
            this.interface_gbx.Controls.Add(this.number_lbl);
            this.interface_gbx.Controls.Add(this.name_txt);
            this.interface_gbx.Controls.Add(this.name_lbl);
            this.interface_gbx.Controls.Add(this.view_rbt);
            this.interface_gbx.Controls.Add(this.table_rbt);
            this.interface_gbx.Enabled = false;
            this.interface_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.interface_gbx.Location = new System.Drawing.Point(50, 328);
            this.interface_gbx.Name = "interface_gbx";
            this.interface_gbx.Size = new System.Drawing.Size(324, 147);
            this.interface_gbx.TabIndex = 4;
            this.interface_gbx.TabStop = false;
            // 
            // number_txt
            // 
            this.number_txt.Enabled = false;
            this.number_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.number_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.number_txt.Location = new System.Drawing.Point(127, 96);
            this.number_txt.Mandatory = false;
            this.number_txt.Name = "number_txt";
            this.number_txt.Size = new System.Drawing.Size(38, 20);
            this.number_txt.TabIndex = 5;
            // 
            // number_lbl
            // 
            this.number_lbl.AutoSize = true;
            this.number_lbl.BackColor = System.Drawing.Color.LightGray;
            this.number_lbl.Enabled = false;
            this.number_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.number_lbl.Location = new System.Drawing.Point(18, 101);
            this.number_lbl.Name = "number_lbl";
            this.number_lbl.Size = new System.Drawing.Size(103, 13);
            this.number_lbl.TabIndex = 4;
            this.number_lbl.Text = "Number of rows :";
            // 
            // name_txt
            // 
            this.name_txt.Enabled = false;
            this.name_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.name_txt.Location = new System.Drawing.Point(71, 70);
            this.name_txt.Mandatory = false;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(150, 20);
            this.name_txt.TabIndex = 3;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.BackColor = System.Drawing.Color.LightGray;
            this.name_lbl.Enabled = false;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.name_lbl.Location = new System.Drawing.Point(18, 73);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(47, 13);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "Name :";
            // 
            // view_rbt
            // 
            this.view_rbt.AutoSize = true;
            this.view_rbt.BackColor = System.Drawing.Color.LightGray;
            this.view_rbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.view_rbt.Location = new System.Drawing.Point(21, 42);
            this.view_rbt.Name = "view_rbt";
            this.view_rbt.Size = new System.Drawing.Size(92, 17);
            this.view_rbt.TabIndex = 1;
            this.view_rbt.TabStop = true;
            this.view_rbt.Text = "Create view";
            this.view_rbt.UseVisualStyleBackColor = true;
            this.view_rbt.Click += new System.EventHandler(this.view_rbt_Click);
            // 
            // table_rbt
            // 
            this.table_rbt.AutoSize = true;
            this.table_rbt.BackColor = System.Drawing.Color.LightGray;
            this.table_rbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.table_rbt.Location = new System.Drawing.Point(20, 19);
            this.table_rbt.Name = "table_rbt";
            this.table_rbt.Size = new System.Drawing.Size(94, 17);
            this.table_rbt.TabIndex = 0;
            this.table_rbt.TabStop = true;
            this.table_rbt.Text = "Create table";
            this.table_rbt.UseVisualStyleBackColor = true;
            this.table_rbt.Click += new System.EventHandler(this.table_rbt_Click);
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
            this.sql_txt.Size = new System.Drawing.Size(595, 210);
            this.sql_txt.TabIndex = 2;
            // 
            // load_ofd
            // 
            this.load_ofd.FileName = "load_ofd";
            // 
            // OracleAdministration
            // 
            this.ClientSize = new System.Drawing.Size(979, 541);
            this.Controls.Add(this.panel_pnl);
            this.Controls.Add(this.tableList_lst);
            this.Controls.Add(this.menu_menu);
            this.MainMenuStrip = this.menu_menu;
            this.Name = "OracleAdministration";
            this.Text = "Oracle Administration view";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Oracle_FormClosing);
            this.Load += new System.EventHandler(this.OracleAdministration_Load);
            this.menu_menu.ResumeLayout(false);
            this.menu_menu.PerformLayout();
            this.panel_pnl.ResumeLayout(false);
            this.panel_pnl.PerformLayout();
            this.interface_gbx.ResumeLayout(false);
            this.interface_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private CompBase.BaseRadioButton sql_rbt;
        private CompBase.BaseRadioButton interface_rbl;
        private CompBase.BaseMenuStrip menu_menu;
        private CompBase.BaseListView tableList_lst;
        private System.Windows.Forms.Panel panel_pnl;
        private CompBase.BaseTextBox sql_txt;
        private CompBase.BaseGroupBox interface_gbx;
        private CompBase.BaseRadioButton table_rbt;
        private CompBase.BaseRadioButton view_rbt;
        private CompBase.BaseTextBox name_txt;
        private CompBase.BaseLabel name_lbl;
        private CompBase.BaseLabel number_lbl;
        private CompBase.BaseTextBox number_txt;
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

    }
}
