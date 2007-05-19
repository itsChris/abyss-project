namespace Abyss_Client {
    partial class OracleTableAdd {
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
            this.tableName_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.tableName_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.rowsNumber_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.rowsNumber_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.tableRows_pnl = new System.Windows.Forms.Panel();
            this.primaryKey_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.null_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.type_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.rowsName_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.createTable_btn = new Abyss_Client.CompBase.BaseButton();
            this.rowsAdd_btn = new Abyss_Client.CompBase.BaseButton();
            this.delRows_btn = new Abyss_Client.CompBase.BaseButton();
            this.SuspendLayout();
            // 
            // tableName_lbl
            // 
            this.tableName_lbl.AutoSize = true;
            this.tableName_lbl.BackColor = System.Drawing.Color.LightGray;
            this.tableName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tableName_lbl.Location = new System.Drawing.Point(13, 13);
            this.tableName_lbl.Name = "tableName_lbl";
            this.tableName_lbl.Size = new System.Drawing.Size(83, 13);
            this.tableName_lbl.TabIndex = 0;
            this.tableName_lbl.Text = "Table Name :";
            // 
            // tableName_txt
            // 
            this.tableName_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableName_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tableName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tableName_txt.Location = new System.Drawing.Point(127, 10);
            this.tableName_txt.Mandatory = true;
            this.tableName_txt.Name = "tableName_txt";
            this.tableName_txt.Size = new System.Drawing.Size(180, 20);
            this.tableName_txt.TabIndex = 1;
            // 
            // rowsNumber_lbl
            // 
            this.rowsNumber_lbl.AutoSize = true;
            this.rowsNumber_lbl.BackColor = System.Drawing.Color.LightGray;
            this.rowsNumber_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rowsNumber_lbl.Location = new System.Drawing.Point(403, 13);
            this.rowsNumber_lbl.Name = "rowsNumber_lbl";
            this.rowsNumber_lbl.Size = new System.Drawing.Size(93, 13);
            this.rowsNumber_lbl.TabIndex = 2;
            this.rowsNumber_lbl.Text = "Rows Number :";
            // 
            // rowsNumber_txt
            // 
            this.rowsNumber_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.rowsNumber_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rowsNumber_txt.Location = new System.Drawing.Point(532, 10);
            this.rowsNumber_txt.Mandatory = true;
            this.rowsNumber_txt.Name = "rowsNumber_txt";
            this.rowsNumber_txt.Size = new System.Drawing.Size(43, 20);
            this.rowsNumber_txt.TabIndex = 3;
            this.rowsNumber_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rowsNumber_txt_KeyPress);
            // 
            // tableRows_pnl
            // 
            this.tableRows_pnl.AutoScroll = true;
            this.tableRows_pnl.BackColor = System.Drawing.Color.Transparent;
            this.tableRows_pnl.Location = new System.Drawing.Point(6, 76);
            this.tableRows_pnl.Name = "tableRows_pnl";
            this.tableRows_pnl.Size = new System.Drawing.Size(630, 337);
            this.tableRows_pnl.TabIndex = 4;
            this.tableRows_pnl.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tableRows_pnl_Scroll);
            // 
            // primaryKey_lbl
            // 
            this.primaryKey_lbl.AutoSize = true;
            this.primaryKey_lbl.BackColor = System.Drawing.Color.LightGray;
            this.primaryKey_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.primaryKey_lbl.Location = new System.Drawing.Point(564, 60);
            this.primaryKey_lbl.Name = "primaryKey_lbl";
            this.primaryKey_lbl.Size = new System.Drawing.Size(23, 13);
            this.primaryKey_lbl.TabIndex = 3;
            this.primaryKey_lbl.Text = "PK";
            // 
            // null_lbl
            // 
            this.null_lbl.AutoSize = true;
            this.null_lbl.BackColor = System.Drawing.Color.LightGray;
            this.null_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.null_lbl.Location = new System.Drawing.Point(451, 60);
            this.null_lbl.Name = "null_lbl";
            this.null_lbl.Size = new System.Drawing.Size(29, 13);
            this.null_lbl.TabIndex = 2;
            this.null_lbl.Text = "Null";
            // 
            // type_lbl
            // 
            this.type_lbl.AutoSize = true;
            this.type_lbl.BackColor = System.Drawing.Color.LightGray;
            this.type_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.type_lbl.Location = new System.Drawing.Point(272, 60);
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.Size = new System.Drawing.Size(35, 13);
            this.type_lbl.TabIndex = 1;
            this.type_lbl.Text = "Type";
            // 
            // rowsName_lbl
            // 
            this.rowsName_lbl.AutoSize = true;
            this.rowsName_lbl.BackColor = System.Drawing.Color.LightGray;
            this.rowsName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rowsName_lbl.Location = new System.Drawing.Point(79, 60);
            this.rowsName_lbl.Name = "rowsName_lbl";
            this.rowsName_lbl.Size = new System.Drawing.Size(39, 13);
            this.rowsName_lbl.TabIndex = 0;
            this.rowsName_lbl.Text = "Name";
            // 
            // createTable_btn
            // 
            this.createTable_btn.BackColor = System.Drawing.Color.LightGray;
            this.createTable_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.createTable_btn.Location = new System.Drawing.Point(281, 422);
            this.createTable_btn.Name = "createTable_btn";
            this.createTable_btn.Size = new System.Drawing.Size(126, 23);
            this.createTable_btn.TabIndex = 5;
            this.createTable_btn.Text = "Create table";
            this.createTable_btn.UseVisualStyleBackColor = true;
            this.createTable_btn.Click += new System.EventHandler(this.createTable_btn_Click);
            // 
            // rowsAdd_btn
            // 
            this.rowsAdd_btn.BackColor = System.Drawing.Color.LightGray;
            this.rowsAdd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rowsAdd_btn.Location = new System.Drawing.Point(160, 422);
            this.rowsAdd_btn.Name = "rowsAdd_btn";
            this.rowsAdd_btn.Size = new System.Drawing.Size(75, 23);
            this.rowsAdd_btn.TabIndex = 6;
            this.rowsAdd_btn.Text = "Add rows";
            this.rowsAdd_btn.UseVisualStyleBackColor = true;
            this.rowsAdd_btn.Click += new System.EventHandler(this.rowsAdd_btn_Click);
            // 
            // delRows_btn
            // 
            this.delRows_btn.BackColor = System.Drawing.Color.LightGray;
            this.delRows_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.delRows_btn.Location = new System.Drawing.Point(12, 422);
            this.delRows_btn.Name = "delRows_btn";
            this.delRows_btn.Size = new System.Drawing.Size(142, 23);
            this.delRows_btn.TabIndex = 7;
            this.delRows_btn.Text = "Delete selected rows";
            this.delRows_btn.UseVisualStyleBackColor = true;
            this.delRows_btn.Click += new System.EventHandler(this.delRows_btn_Click);
            // 
            // OracleTableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 456);
            this.Controls.Add(this.delRows_btn);
            this.Controls.Add(this.rowsAdd_btn);
            this.Controls.Add(this.primaryKey_lbl);
            this.Controls.Add(this.createTable_btn);
            this.Controls.Add(this.null_lbl);
            this.Controls.Add(this.tableRows_pnl);
            this.Controls.Add(this.type_lbl);
            this.Controls.Add(this.rowsNumber_txt);
            this.Controls.Add(this.rowsName_lbl);
            this.Controls.Add(this.rowsNumber_lbl);
            this.Controls.Add(this.tableName_txt);
            this.Controls.Add(this.tableName_lbl);
            this.Name = "OracleTableAdd";
            this.Text = "Oracle Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Abyss_Client.CompBase.BaseLabel tableName_lbl;
        private Abyss_Client.CompBase.BaseTextBox tableName_txt;
        private Abyss_Client.CompBase.BaseLabel rowsNumber_lbl;
        private Abyss_Client.CompBase.BaseTextBox rowsNumber_txt;
        private System.Windows.Forms.Panel tableRows_pnl;
        private Abyss_Client.CompBase.BaseButton createTable_btn;
        private Abyss_Client.CompBase.BaseLabel rowsName_lbl;
        private Abyss_Client.CompBase.BaseLabel type_lbl;
        private Abyss_Client.CompBase.BaseLabel null_lbl;
        private Abyss_Client.CompBase.BaseLabel primaryKey_lbl;
        private Abyss_Client.CompBase.BaseButton rowsAdd_btn;
        private Abyss_Client.CompBase.BaseButton delRows_btn;
    }
}