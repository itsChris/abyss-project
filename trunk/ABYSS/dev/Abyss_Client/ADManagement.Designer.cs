﻿namespace Abyss_Client
{
    partial class ADManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADManagement));
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tree_trv = new Abyss_Client.CompBase.BaseTreeView();
            this.imageList_adObjects = new System.Windows.Forms.ImageList(this.components);
            this.list_lst = new Abyss_Client.CompBase.BaseListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.menu_menu = new Abyss_Client.CompBase.BaseMenuStrip();
            this.filesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_menu.SuspendLayout();
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
            this.tree_trv.ImageIndex = 0;
            this.tree_trv.ImageList = this.imageList_adObjects;
            this.tree_trv.Location = new System.Drawing.Point(10, 27);
            this.tree_trv.Name = "tree_trv";
            this.tree_trv.SelectedImageIndex = 0;
            this.tree_trv.Size = new System.Drawing.Size(269, 526);
            this.tree_trv.TabIndex = 1;
            this.tree_trv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_trv_AfterSelect);
            // 
            // imageList_adObjects
            // 
            this.imageList_adObjects.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_adObjects.ImageStream")));
            this.imageList_adObjects.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_adObjects.Images.SetKeyName(0, "");
            this.imageList_adObjects.Images.SetKeyName(1, "");
            this.imageList_adObjects.Images.SetKeyName(2, "");
            this.imageList_adObjects.Images.SetKeyName(3, "");
            this.imageList_adObjects.Images.SetKeyName(4, "");
            this.imageList_adObjects.Images.SetKeyName(5, "");
            this.imageList_adObjects.Images.SetKeyName(6, "");
            this.imageList_adObjects.Images.SetKeyName(7, "");
            this.imageList_adObjects.Images.SetKeyName(8, "");
            // 
            // list_lst
            // 
            this.list_lst.AllowColumnReorder = true;
            this.list_lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.list_lst.FullRowSelect = true;
            this.list_lst.LargeImageList = this.imageList_adObjects;
            this.list_lst.Location = new System.Drawing.Point(285, 27);
            this.list_lst.MultiSelect = false;
            this.list_lst.Name = "list_lst";
            this.list_lst.Size = new System.Drawing.Size(692, 526);
            this.list_lst.SmallImageList = this.imageList_adObjects;
            this.list_lst.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.list_lst.TabIndex = 2;
            this.list_lst.TabStop = false;
            this.list_lst.UseCompatibleStateImageBehavior = false;
            this.list_lst.View = System.Windows.Forms.View.Details;
            // 
            // menu_menu
            // 
            this.menu_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu_menu.Location = new System.Drawing.Point(0, 0);
            this.menu_menu.Name = "menu_menu";
            this.menu_menu.Size = new System.Drawing.Size(992, 24);
            this.menu_menu.TabIndex = 0;
            this.menu_menu.Text = "baseMenuStrip1";
            // 
            // filesStripMenuItem
            // 
            this.filesStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.filesStripMenuItem.Name = "filesStripMenuItem";
            this.filesStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.filesStripMenuItem.Text = "Files";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
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
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ADManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 566);
            this.Controls.Add(this.list_lst);
            this.Controls.Add(this.tree_trv);
            this.Controls.Add(this.menu_menu);
            this.Name = "ADManagement";
            this.Text = "Active Directory Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADManagement_FormClosing);
            this.Load += new System.EventHandler(this.ListActiveDirectory_Load);
            this.menu_menu.ResumeLayout(false);
            this.menu_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private Abyss_Client.CompBase.BaseTreeView tree_trv;
        private Abyss_Client.CompBase.BaseListView list_lst;
        private Abyss_Client.CompBase.BaseMenuStrip menu_menu;
        private System.Windows.Forms.ToolStripMenuItem filesStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList_adObjects;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}