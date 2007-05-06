namespace Abyss_Client {
    partial class ADMemberOf {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMemberOf));
            this.lastmemberof_lst = new Abyss_Client.CompBase.BaseListView();
            this.name_cln = new System.Windows.Forms.ColumnHeader();
            this.desc_cln = new System.Windows.Forms.ColumnHeader();
            this.imageList_adObjects = new System.Windows.Forms.ImageList(this.components);
            this.cancel_btn = new Abyss_Client.CompBase.BaseButton();
            this.ok_btn = new Abyss_Client.CompBase.BaseButton();
            this.newmemberof_lst = new Abyss_Client.CompBase.BaseListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lastmemberof_lst
            // 
            this.lastmemberof_lst.AllowColumnReorder = true;
            this.lastmemberof_lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_cln,
            this.desc_cln});
            this.lastmemberof_lst.FullRowSelect = true;
            this.lastmemberof_lst.LargeImageList = this.imageList_adObjects;
            this.lastmemberof_lst.Location = new System.Drawing.Point(12, 12);
            this.lastmemberof_lst.MultiSelect = false;
            this.lastmemberof_lst.Name = "lastmemberof_lst";
            this.lastmemberof_lst.Size = new System.Drawing.Size(880, 269);
            this.lastmemberof_lst.SmallImageList = this.imageList_adObjects;
            this.lastmemberof_lst.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lastmemberof_lst.StateImageList = this.imageList_adObjects;
            this.lastmemberof_lst.TabIndex = 0;
            this.lastmemberof_lst.TabStop = false;
            this.lastmemberof_lst.UseCompatibleStateImageBehavior = false;
            this.lastmemberof_lst.View = System.Windows.Forms.View.Details;
            this.lastmemberof_lst.DoubleClick += new System.EventHandler(this.lastmemberof_lst_DoubleClick);
            this.lastmemberof_lst.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.list_lst_ColumnClick);
            // 
            // name_cln
            // 
            this.name_cln.Text = "Name (RDN)";
            this.name_cln.Width = 297;
            // 
            // desc_cln
            // 
            this.desc_cln.Text = "Description";
            this.desc_cln.Width = 565;
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
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.LightGray;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.Location = new System.Drawing.Point(284, 562);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(88, 23);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.Transparent;
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ok_btn.Location = new System.Drawing.Point(420, 562);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(88, 23);
            this.ok_btn.TabIndex = 3;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // newmemberof_lst
            // 
            this.newmemberof_lst.AllowColumnReorder = true;
            this.newmemberof_lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.newmemberof_lst.FullRowSelect = true;
            this.newmemberof_lst.LargeImageList = this.imageList_adObjects;
            this.newmemberof_lst.Location = new System.Drawing.Point(12, 287);
            this.newmemberof_lst.MultiSelect = false;
            this.newmemberof_lst.Name = "newmemberof_lst";
            this.newmemberof_lst.Size = new System.Drawing.Size(880, 269);
            this.newmemberof_lst.SmallImageList = this.imageList_adObjects;
            this.newmemberof_lst.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.newmemberof_lst.StateImageList = this.imageList_adObjects;
            this.newmemberof_lst.TabIndex = 4;
            this.newmemberof_lst.TabStop = false;
            this.newmemberof_lst.UseCompatibleStateImageBehavior = false;
            this.newmemberof_lst.View = System.Windows.Forms.View.Details;
            this.newmemberof_lst.DoubleClick += new System.EventHandler(this.newmemberof_lst_DoubleClick);
            this.newmemberof_lst.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.list_lst_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name (RDN)";
            this.columnHeader1.Width = 297;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 565;
            // 
            // ADMemberOf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 596);
            this.Controls.Add(this.newmemberof_lst);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.lastmemberof_lst);
            this.Name = "ADMemberOf";
            this.Text = "Member Of Information";
            this.Load += new System.EventHandler(this.ADMemberOf_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Abyss_Client.CompBase.BaseListView lastmemberof_lst;
        private System.Windows.Forms.ColumnHeader name_cln;
        private Abyss_Client.CompBase.BaseButton cancel_btn;
        private Abyss_Client.CompBase.BaseButton ok_btn;
        private System.Windows.Forms.ImageList imageList_adObjects;
        private System.Windows.Forms.ColumnHeader desc_cln;
        private Abyss_Client.CompBase.BaseListView newmemberof_lst;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;

    }
}