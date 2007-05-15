namespace Abyss_Client {
    partial class OracleViewAdd {
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
            this.viewName_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.viewName_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.viewQuery_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.viewQuery_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.viewValidation_btn = new Abyss_Client.CompBase.BaseButton();
            this.SuspendLayout();
            // 
            // viewName_lbl
            // 
            this.viewName_lbl.AutoSize = true;
            this.viewName_lbl.BackColor = System.Drawing.Color.LightGray;
            this.viewName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.viewName_lbl.Location = new System.Drawing.Point(13, 25);
            this.viewName_lbl.Name = "viewName_lbl";
            this.viewName_lbl.Size = new System.Drawing.Size(78, 13);
            this.viewName_lbl.TabIndex = 0;
            this.viewName_lbl.Text = "View Name :";
            // 
            // viewName_txt
            // 
            this.viewName_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.viewName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.viewName_txt.Location = new System.Drawing.Point(98, 22);
            this.viewName_txt.Mandatory = false;
            this.viewName_txt.Name = "viewName_txt";
            this.viewName_txt.Size = new System.Drawing.Size(189, 20);
            this.viewName_txt.TabIndex = 1;
            // 
            // viewQuery_lbl
            // 
            this.viewQuery_lbl.AutoSize = true;
            this.viewQuery_lbl.BackColor = System.Drawing.Color.LightGray;
            this.viewQuery_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.viewQuery_lbl.Location = new System.Drawing.Point(13, 66);
            this.viewQuery_lbl.Name = "viewQuery_lbl";
            this.viewQuery_lbl.Size = new System.Drawing.Size(79, 13);
            this.viewQuery_lbl.TabIndex = 2;
            this.viewQuery_lbl.Text = "View Query :";
            // 
            // viewQuery_txt
            // 
            this.viewQuery_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.viewQuery_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.viewQuery_txt.Location = new System.Drawing.Point(98, 66);
            this.viewQuery_txt.Mandatory = false;
            this.viewQuery_txt.Multiline = true;
            this.viewQuery_txt.Name = "viewQuery_txt";
            this.viewQuery_txt.Size = new System.Drawing.Size(388, 248);
            this.viewQuery_txt.TabIndex = 3;
            // 
            // viewValidation_btn
            // 
            this.viewValidation_btn.BackColor = System.Drawing.Color.LightGray;
            this.viewValidation_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.viewValidation_btn.Location = new System.Drawing.Point(204, 346);
            this.viewValidation_btn.Name = "viewValidation_btn";
            this.viewValidation_btn.Size = new System.Drawing.Size(111, 23);
            this.viewValidation_btn.TabIndex = 4;
            this.viewValidation_btn.Text = "Create View";
            this.viewValidation_btn.UseVisualStyleBackColor = true;
            // 
            // OracleViewAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 395);
            this.Controls.Add(this.viewValidation_btn);
            this.Controls.Add(this.viewQuery_txt);
            this.Controls.Add(this.viewQuery_lbl);
            this.Controls.Add(this.viewName_txt);
            this.Controls.Add(this.viewName_lbl);
            this.Name = "OracleViewAdd";
            this.Text = "OracleViewAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Abyss_Client.CompBase.BaseLabel viewName_lbl;
        private Abyss_Client.CompBase.BaseTextBox viewName_txt;
        private Abyss_Client.CompBase.BaseLabel viewQuery_lbl;
        private Abyss_Client.CompBase.BaseTextBox viewQuery_txt;
        private Abyss_Client.CompBase.BaseButton viewValidation_btn;
    }
}