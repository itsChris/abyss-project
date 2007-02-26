namespace Abyss_Client {
    partial class Oracle {
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
            this.sql_rbt = new System.Windows.Forms.RadioButton();
            this.interface_rbl = new System.Windows.Forms.RadioButton();
            this.baseMenuStrip1 = new Abyss_Client.CompBase.BaseMenuStrip();
            this.switcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableList_lst = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.load_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.interface_gbx = new System.Windows.Forms.GroupBox();
            this.number_txt = new System.Windows.Forms.TextBox();
            this.number_lbl = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.view_rbt = new System.Windows.Forms.RadioButton();
            this.table_rbt = new System.Windows.Forms.RadioButton();
            this.sql_txt = new System.Windows.Forms.TextBox();
            this.load_ofd = new System.Windows.Forms.OpenFileDialog();
            this.baseMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.interface_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // sql_rbt
            // 
            this.sql_rbt.AutoSize = true;
            this.sql_rbt.Checked = true;
            this.sql_rbt.Location = new System.Drawing.Point(17, 13);
            this.sql_rbt.Name = "sql_rbt";
            this.sql_rbt.Size = new System.Drawing.Size(69, 17);
            this.sql_rbt.TabIndex = 0;
            this.sql_rbt.TabStop = true;
            this.sql_rbt.Text = "Sql mode";
            this.sql_rbt.UseVisualStyleBackColor = true;
            this.sql_rbt.Click += new System.EventHandler(this.sql_rbt_Click);
            // 
            // interface_rbl
            // 
            this.interface_rbl.AutoSize = true;
            this.interface_rbl.Location = new System.Drawing.Point(17, 293);
            this.interface_rbl.Name = "interface_rbl";
            this.interface_rbl.Size = new System.Drawing.Size(96, 17);
            this.interface_rbl.TabIndex = 1;
            this.interface_rbl.TabStop = true;
            this.interface_rbl.Text = "Interface mode";
            this.interface_rbl.UseVisualStyleBackColor = true;
            this.interface_rbl.Click += new System.EventHandler(this.interface_rbl_Click);
            // 
            // baseMenuStrip1
            // 
            this.baseMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switcToolStripMenuItem,
            this.editToolStripMenuItem});
            this.baseMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.baseMenuStrip1.Name = "baseMenuStrip1";
            this.baseMenuStrip1.Size = new System.Drawing.Size(986, 24);
            this.baseMenuStrip1.TabIndex = 2;
            this.baseMenuStrip1.Text = "baseMenuStrip1";
            // 
            // switcToolStripMenuItem
            // 
            this.switcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.switcToolStripMenuItem.Name = "switcToolStripMenuItem";
            this.switcToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.switcToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
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
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // tableList_lst
            // 
            this.tableList_lst.Location = new System.Drawing.Point(13, 28);
            this.tableList_lst.Name = "tableList_lst";
            this.tableList_lst.Size = new System.Drawing.Size(308, 526);
            this.tableList_lst.TabIndex = 3;
            this.tableList_lst.UseCompatibleStateImageBehavior = false;
            this.tableList_lst.View = System.Windows.Forms.View.List;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.load_btn);
            this.panel1.Controls.Add(this.create_btn);
            this.panel1.Controls.Add(this.interface_gbx);
            this.panel1.Controls.Add(this.sql_txt);
            this.panel1.Controls.Add(this.sql_rbt);
            this.panel1.Controls.Add(this.interface_rbl);
            this.panel1.Location = new System.Drawing.Point(328, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 526);
            this.panel1.TabIndex = 4;
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.Color.LightGray;
            this.load_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.load_btn.Location = new System.Drawing.Point(524, 29);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(121, 23);
            this.load_btn.TabIndex = 10;
            this.load_btn.Text = "Load SQL file";
            this.load_btn.UseVisualStyleBackColor = false;
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.LightGray;
            this.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.create_btn.Location = new System.Drawing.Point(299, 469);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(75, 23);
            this.create_btn.TabIndex = 9;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // interface_gbx
            // 
            this.interface_gbx.Controls.Add(this.number_txt);
            this.interface_gbx.Controls.Add(this.number_lbl);
            this.interface_gbx.Controls.Add(this.name_txt);
            this.interface_gbx.Controls.Add(this.name_lbl);
            this.interface_gbx.Controls.Add(this.view_rbt);
            this.interface_gbx.Controls.Add(this.table_rbt);
            this.interface_gbx.Enabled = false;
            this.interface_gbx.Location = new System.Drawing.Point(50, 316);
            this.interface_gbx.Name = "interface_gbx";
            this.interface_gbx.Size = new System.Drawing.Size(324, 147);
            this.interface_gbx.TabIndex = 4;
            this.interface_gbx.TabStop = false;
            // 
            // number_txt
            // 
            this.number_txt.Enabled = false;
            this.number_txt.Location = new System.Drawing.Point(143, 98);
            this.number_txt.Name = "number_txt";
            this.number_txt.Size = new System.Drawing.Size(38, 20);
            this.number_txt.TabIndex = 10;
            // 
            // number_lbl
            // 
            this.number_lbl.AutoSize = true;
            this.number_lbl.Enabled = false;
            this.number_lbl.Location = new System.Drawing.Point(49, 98);
            this.number_lbl.Name = "number_lbl";
            this.number_lbl.Size = new System.Drawing.Size(87, 13);
            this.number_lbl.TabIndex = 9;
            this.number_lbl.Text = "Number of rows :";
            // 
            // name_txt
            // 
            this.name_txt.Enabled = false;
            this.name_txt.Location = new System.Drawing.Point(143, 66);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(150, 20);
            this.name_txt.TabIndex = 8;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Enabled = false;
            this.name_lbl.Location = new System.Drawing.Point(49, 73);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(41, 13);
            this.name_lbl.TabIndex = 7;
            this.name_lbl.Text = "Name :";
            // 
            // view_rbt
            // 
            this.view_rbt.AutoSize = true;
            this.view_rbt.Location = new System.Drawing.Point(21, 42);
            this.view_rbt.Name = "view_rbt";
            this.view_rbt.Size = new System.Drawing.Size(81, 17);
            this.view_rbt.TabIndex = 6;
            this.view_rbt.TabStop = true;
            this.view_rbt.Text = "Create view";
            this.view_rbt.UseVisualStyleBackColor = true;
            this.view_rbt.Click += new System.EventHandler(this.view_rbt_Click);
            // 
            // table_rbt
            // 
            this.table_rbt.AutoSize = true;
            this.table_rbt.Location = new System.Drawing.Point(20, 19);
            this.table_rbt.Name = "table_rbt";
            this.table_rbt.Size = new System.Drawing.Size(82, 17);
            this.table_rbt.TabIndex = 4;
            this.table_rbt.TabStop = true;
            this.table_rbt.Text = "Create table";
            this.table_rbt.UseVisualStyleBackColor = true;
            this.table_rbt.Click += new System.EventHandler(this.table_rbt_Click);
            // 
            // sql_txt
            // 
            this.sql_txt.Location = new System.Drawing.Point(51, 58);
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
            // Oracle
            // 
            this.ClientSize = new System.Drawing.Size(986, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableList_lst);
            this.Controls.Add(this.baseMenuStrip1);
            this.MainMenuStrip = this.baseMenuStrip1;
            this.Name = "Oracle";
            this.Text = "Oracle Administrator view";
            this.baseMenuStrip1.ResumeLayout(false);
            this.baseMenuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.interface_gbx.ResumeLayout(false);
            this.interface_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton sql_rbt;
        private System.Windows.Forms.RadioButton interface_rbl;
        private Abyss_Client.CompBase.BaseMenuStrip baseMenuStrip1;
        private System.Windows.Forms.ListView tableList_lst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sql_txt;
        private System.Windows.Forms.GroupBox interface_gbx;
        private System.Windows.Forms.RadioButton table_rbt;
        private System.Windows.Forms.RadioButton view_rbt;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label number_lbl;
        private System.Windows.Forms.TextBox number_txt;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.OpenFileDialog load_ofd;
        private System.Windows.Forms.ToolStripMenuItem switcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;

    }
}
