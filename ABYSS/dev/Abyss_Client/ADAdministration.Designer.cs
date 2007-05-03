namespace Abyss_Client
{
    partial class ADAdministration
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADAdministration));
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tree_trv = new Abyss_Client.CompBase.BaseTreeView();
            this.treeView_ctm = new Abyss_Client.CompBase.BaseContextMenu();
            this.new_tmi = new System.Windows.Forms.ToolStripMenuItem();
            this.computer_tmi = new System.Windows.Forms.ToolStripMenuItem();
            this.group_tmi = new System.Windows.Forms.ToolStripMenuItem();
            this.user_tmi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imageList_adObjects = new System.Windows.Forms.ImageList(this.components);
            this.list_lst = new Abyss_Client.CompBase.BaseListView();
            this.name_clh = new System.Windows.Forms.ColumnHeader();
            this.type_cln = new System.Windows.Forms.ColumnHeader();
            this.desc_cln = new System.Windows.Forms.ColumnHeader();
            this.listView_ctm = new Abyss_Client.CompBase.BaseContextMenu();
            this.modify_tmi = new System.Windows.Forms.ToolStripMenuItem();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.disable_tmi = new System.Windows.Forms.ToolStripMenuItem();
            this.separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.enable_tmi = new System.Windows.Forms.ToolStripMenuItem();
            this.separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.delete_tmi = new System.Windows.Forms.ToolStripMenuItem();
            this.separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.changePwd_tmi = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_stp = new Abyss_Client.CompBase.BaseMenuStrip();
            this.filesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oracleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView_ctm.SuspendLayout();
            this.listView_ctm.SuspendLayout();
            this.menu_stp.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 24);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // tree_trv
            // 
            this.tree_trv.ContextMenuStrip = this.treeView_ctm;
            this.tree_trv.ImageIndex = 0;
            this.tree_trv.ImageList = this.imageList_adObjects;
            this.tree_trv.Location = new System.Drawing.Point(10, 27);
            this.tree_trv.Name = "tree_trv";
            this.tree_trv.SelectedImageIndex = 0;
            this.tree_trv.Size = new System.Drawing.Size(255, 527);
            this.tree_trv.TabIndex = 1;
            this.tree_trv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_trv_AfterSelect);
            // 
            // treeView_ctm
            // 
            this.treeView_ctm.BackColor = System.Drawing.Color.AliceBlue;
            this.treeView_ctm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_tmi,
            this.toolStripSeparator2});
            this.treeView_ctm.Name = "baseContextMenu1";
            this.treeView_ctm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.treeView_ctm.ShowImageMargin = false;
            this.treeView_ctm.Size = new System.Drawing.Size(128, 54);
            // 
            // new_tmi
            // 
            this.new_tmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computer_tmi,
            this.group_tmi,
            this.user_tmi});
            this.new_tmi.Name = "new_tmi";
            this.new_tmi.Size = new System.Drawing.Size(127, 22);
            this.new_tmi.Text = "New";
            // 
            // computer_tmi
            // 
            this.computer_tmi.Image = global::Abyss_Client.Properties.Resources.splash;
            this.computer_tmi.Name = "computer_tmi";
            this.computer_tmi.Size = new System.Drawing.Size(130, 22);
            this.computer_tmi.Text = "Computer";
            // 
            // group_tmi
            // 
            this.group_tmi.Image = global::Abyss_Client.Properties.Resources.splash;
            this.group_tmi.Name = "group_tmi";
            this.group_tmi.Size = new System.Drawing.Size(130, 22);
            this.group_tmi.Text = "Group";
            // 
            // user_tmi
            // 
            this.user_tmi.Image = global::Abyss_Client.Properties.Resources.splash;
            this.user_tmi.Name = "user_tmi";
            this.user_tmi.Size = new System.Drawing.Size(130, 22);
            this.user_tmi.Text = "User";
            this.user_tmi.Click += new System.EventHandler(this.user_tmi_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
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
            // list_lst
            // 
            this.list_lst.AllowColumnReorder = true;
            this.list_lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_clh,
            this.type_cln,
            this.desc_cln});
            this.list_lst.ContextMenuStrip = this.listView_ctm;
            this.list_lst.FullRowSelect = true;
            this.list_lst.LargeImageList = this.imageList_adObjects;
            this.list_lst.Location = new System.Drawing.Point(271, 27);
            this.list_lst.MultiSelect = false;
            this.list_lst.Name = "list_lst";
            this.list_lst.Size = new System.Drawing.Size(874, 526);
            this.list_lst.SmallImageList = this.imageList_adObjects;
            this.list_lst.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.list_lst.TabIndex = 2;
            this.list_lst.TabStop = false;
            this.list_lst.UseCompatibleStateImageBehavior = false;
            this.list_lst.View = System.Windows.Forms.View.Details;
            this.list_lst.DoubleClick += new System.EventHandler(this.list_lst_DoubleClick);
            this.list_lst.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.list_lst_ColumnClick);
            // 
            // name_clh
            // 
            this.name_clh.Text = "Name";
            this.name_clh.Width = 191;
            // 
            // type_cln
            // 
            this.type_cln.Text = "Type";
            this.type_cln.Width = 150;
            // 
            // desc_cln
            // 
            this.desc_cln.Text = "Description";
            this.desc_cln.Width = 517;
            // 
            // listView_ctm
            // 
            this.listView_ctm.BackColor = System.Drawing.Color.AliceBlue;
            this.listView_ctm.Font = new System.Drawing.Font("Lucida Grande", 8.25F);
            this.listView_ctm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modify_tmi,
            this.separator1,
            this.disable_tmi,
            this.separator2,
            this.enable_tmi,
            this.separator3,
            this.delete_tmi,
            this.separator4,
            this.changePwd_tmi});
            this.listView_ctm.Name = "baseContextMenu1";
            this.listView_ctm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.listView_ctm.ShowImageMargin = false;
            this.listView_ctm.Size = new System.Drawing.Size(147, 138);
            this.listView_ctm.Opening += new System.ComponentModel.CancelEventHandler(this.listView_ctm_Opening);
            // 
            // modify_tmi
            // 
            this.modify_tmi.Name = "modify_tmi";
            this.modify_tmi.Size = new System.Drawing.Size(146, 22);
            this.modify_tmi.Text = "Modify";
            this.modify_tmi.Click += new System.EventHandler(this.modify_tmi_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(143, 6);
            // 
            // disable_tmi
            // 
            this.disable_tmi.Name = "disable_tmi";
            this.disable_tmi.Size = new System.Drawing.Size(146, 22);
            this.disable_tmi.Text = "Disable account";
            this.disable_tmi.Click += new System.EventHandler(this.disable_tmi_Click);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(143, 6);
            // 
            // enable_tmi
            // 
            this.enable_tmi.Name = "enable_tmi";
            this.enable_tmi.Size = new System.Drawing.Size(146, 22);
            this.enable_tmi.Text = "Enable Account";
            this.enable_tmi.Click += new System.EventHandler(this.enable_tmi_Click);
            // 
            // separator3
            // 
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(143, 6);
            // 
            // delete_tmi
            // 
            this.delete_tmi.Name = "delete_tmi";
            this.delete_tmi.Size = new System.Drawing.Size(146, 22);
            this.delete_tmi.Text = "Delete Account";
            this.delete_tmi.Click += new System.EventHandler(this.delete_tmi_Click);
            // 
            // separator4
            // 
            this.separator4.Name = "separator4";
            this.separator4.Size = new System.Drawing.Size(143, 6);
            // 
            // changePwd_tmi
            // 
            this.changePwd_tmi.Name = "changePwd_tmi";
            this.changePwd_tmi.Size = new System.Drawing.Size(146, 22);
            this.changePwd_tmi.Text = "Change Password";
            this.changePwd_tmi.Click += new System.EventHandler(this.changePwd_tmi_Click);
            // 
            // menu_stp
            // 
            this.menu_stp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu_stp.Location = new System.Drawing.Point(0, 0);
            this.menu_stp.Name = "menu_stp";
            this.menu_stp.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu_stp.Size = new System.Drawing.Size(1157, 24);
            this.menu_stp.TabIndex = 0;
            this.menu_stp.Text = "menu_menu";
            // 
            // filesStripMenuItem
            // 
            this.filesStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.oracleToolStripMenuItem});
            this.filesStripMenuItem.Name = "filesStripMenuItem";
            this.filesStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.filesStripMenuItem.Text = "Files";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.exitToolStripMenuItem.Text = "Exit AD Administration";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.quitToolStripMenuItem.Text = "Quit the application";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // oracleToolStripMenuItem
            // 
            this.oracleToolStripMenuItem.Name = "oracleToolStripMenuItem";
            this.oracleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.oracleToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.oracleToolStripMenuItem.Text = "Oracle Administration";
            this.oracleToolStripMenuItem.Click += new System.EventHandler(this.oracleToolStripMenuItem_Click);
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
            // ADAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 566);
            this.Controls.Add(this.tree_trv);
            this.Controls.Add(this.list_lst);
            this.Controls.Add(this.menu_stp);
            this.MainMenuStrip = this.menu_stp;
            this.Name = "ADAdministration";
            this.Text = "Active Directory Administration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADManagement_FormClosing);
            this.Load += new System.EventHandler(this.ListActiveDirectory_Load);
            this.treeView_ctm.ResumeLayout(false);
            this.listView_ctm.ResumeLayout(false);
            this.menu_stp.ResumeLayout(false);
            this.menu_stp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private Abyss_Client.CompBase.BaseTreeView tree_trv;
        private Abyss_Client.CompBase.BaseListView list_lst;
        private Abyss_Client.CompBase.BaseMenuStrip menu_stp;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList_adObjects;
        private System.Windows.Forms.ColumnHeader name_clh;
        private System.Windows.Forms.ColumnHeader type_cln;
        private System.Windows.Forms.ColumnHeader desc_cln;
        private Abyss_Client.CompBase.BaseContextMenu treeView_ctm;
        private System.Windows.Forms.ToolStripMenuItem new_tmi;
        private System.Windows.Forms.ToolStripMenuItem computer_tmi;
        private System.Windows.Forms.ToolStripMenuItem group_tmi;
        private System.Windows.Forms.ToolStripMenuItem user_tmi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Abyss_Client.CompBase.BaseContextMenu listView_ctm;
        private System.Windows.Forms.ToolStripMenuItem modify_tmi;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripMenuItem disable_tmi;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripMenuItem enable_tmi;
        private System.Windows.Forms.ToolStripSeparator separator3;
        private System.Windows.Forms.ToolStripMenuItem delete_tmi;
        private System.Windows.Forms.ToolStripSeparator separator4;
        private System.Windows.Forms.ToolStripMenuItem changePwd_tmi;
        private System.Windows.Forms.ToolStripMenuItem filesStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oracleToolStripMenuItem;
    }
}