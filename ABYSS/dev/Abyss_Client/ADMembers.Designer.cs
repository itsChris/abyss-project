namespace Abyss_Client {
    partial class ADMembers {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMembers));
            this.ok_btn = new Abyss_Client.CompBase.BaseButton();
            this.cancel_btn = new Abyss_Client.CompBase.BaseButton();
            this.newmembers_lst = new Abyss_Client.CompBase.BaseListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.imageList_adObjects = new System.Windows.Forms.ImageList(this.components);
            this.name_cln = new System.Windows.Forms.ColumnHeader();
            this.lastmembers_lst = new Abyss_Client.CompBase.BaseListView();
            this.desc_cln = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.Transparent;
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ok_btn.Location = new System.Drawing.Point(420, 562);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(88, 23);
            this.ok_btn.TabIndex = 6;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.LightGray;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.Location = new System.Drawing.Point(284, 562);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(88, 23);
            this.cancel_btn.TabIndex = 8;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // newmembers_lst
            // 
            this.newmembers_lst.AllowColumnReorder = true;
            this.newmembers_lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.newmembers_lst.FullRowSelect = true;
            this.newmembers_lst.LargeImageList = this.imageList_adObjects;
            this.newmembers_lst.Location = new System.Drawing.Point(12, 287);
            this.newmembers_lst.MultiSelect = false;
            this.newmembers_lst.Name = "newmembers_lst";
            this.newmembers_lst.Size = new System.Drawing.Size(880, 269);
            this.newmembers_lst.SmallImageList = this.imageList_adObjects;
            this.newmembers_lst.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.newmembers_lst.StateImageList = this.imageList_adObjects;
            this.newmembers_lst.TabIndex = 7;
            this.newmembers_lst.TabStop = false;
            this.newmembers_lst.UseCompatibleStateImageBehavior = false;
            this.newmembers_lst.View = System.Windows.Forms.View.Details;
            this.newmembers_lst.DoubleClick += new System.EventHandler(this.newmembers_lst_DoubleClick);
            this.newmembers_lst.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.list_lst_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name (RDN)";
            this.columnHeader1.Width = 249;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 565;
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
            // name_cln
            // 
            this.name_cln.Text = "Name (RDN)";
            this.name_cln.Width = 253;
            // 
            // lastmembers_lst
            // 
            this.lastmembers_lst.AllowColumnReorder = true;
            this.lastmembers_lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_cln,
            this.desc_cln});
            this.lastmembers_lst.FullRowSelect = true;
            this.lastmembers_lst.LargeImageList = this.imageList_adObjects;
            this.lastmembers_lst.Location = new System.Drawing.Point(12, 12);
            this.lastmembers_lst.MultiSelect = false;
            this.lastmembers_lst.Name = "lastmembers_lst";
            this.lastmembers_lst.Size = new System.Drawing.Size(880, 269);
            this.lastmembers_lst.SmallImageList = this.imageList_adObjects;
            this.lastmembers_lst.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lastmembers_lst.StateImageList = this.imageList_adObjects;
            this.lastmembers_lst.TabIndex = 5;
            this.lastmembers_lst.TabStop = false;
            this.lastmembers_lst.UseCompatibleStateImageBehavior = false;
            this.lastmembers_lst.View = System.Windows.Forms.View.Details;
            this.lastmembers_lst.DoubleClick += new System.EventHandler(this.lastmembers_lst_DoubleClick);
            this.lastmembers_lst.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.list_lst_ColumnClick);
            // 
            // desc_cln
            // 
            this.desc_cln.Text = "Description";
            this.desc_cln.Width = 565;
            // 
            // ADMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 596);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.newmembers_lst);
            this.Controls.Add(this.lastmembers_lst);
            this.Name = "ADMembers";
            this.Text = "Members Information";
            this.Load += new System.EventHandler(this.ADMembers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Abyss_Client.CompBase.BaseButton ok_btn;
        private Abyss_Client.CompBase.BaseButton cancel_btn;
        private Abyss_Client.CompBase.BaseListView newmembers_lst;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList_adObjects;
        private System.Windows.Forms.ColumnHeader name_cln;
        private Abyss_Client.CompBase.BaseListView lastmembers_lst;
        private System.Windows.Forms.ColumnHeader desc_cln;
    }
}