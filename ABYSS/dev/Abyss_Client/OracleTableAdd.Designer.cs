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
            this.tableName_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tableName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tableName_txt.Location = new System.Drawing.Point(127, 10);
            this.tableName_txt.Mandatory = false;
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
            this.rowsNumber_txt.Mandatory = false;
            this.rowsNumber_txt.Name = "rowsNumber_txt";
            this.rowsNumber_txt.Size = new System.Drawing.Size(43, 20);
            this.rowsNumber_txt.TabIndex = 3;
            this.rowsNumber_txt.TextChanged += new System.EventHandler(this.rowsNumber_txt_TextChanged);
            // 
            // OracleTableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 528);
            this.Controls.Add(this.rowsNumber_txt);
            this.Controls.Add(this.rowsNumber_lbl);
            this.Controls.Add(this.tableName_txt);
            this.Controls.Add(this.tableName_lbl);
            this.Name = "OracleTableAdd";
            this.Text = "OracleTableAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Abyss_Client.CompBase.BaseLabel tableName_lbl;
        private Abyss_Client.CompBase.BaseTextBox tableName_txt;
        private Abyss_Client.CompBase.BaseLabel rowsNumber_lbl;
        private Abyss_Client.CompBase.BaseTextBox rowsNumber_txt;
    }
}