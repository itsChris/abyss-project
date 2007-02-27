namespace Abyss_Client {
    partial class MainForm {
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
            this.activeDirectory_btn = new Abyss_Client.CompBase.BaseButton();
            this.oracle_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activeDirectory_btn
            // 
            this.activeDirectory_btn.BackColor = System.Drawing.Color.LightGray;
            this.activeDirectory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.activeDirectory_btn.Location = new System.Drawing.Point(70, 74);
            this.activeDirectory_btn.Name = "activeDirectory_btn";
            this.activeDirectory_btn.Size = new System.Drawing.Size(108, 23);
            this.activeDirectory_btn.TabIndex = 0;
            this.activeDirectory_btn.Text = "Active Directory ";
            this.activeDirectory_btn.UseVisualStyleBackColor = true;
            this.activeDirectory_btn.Click += new System.EventHandler(this.activeDirectory_btn_Click);
            // 
            // oracle_btn
            // 
            this.oracle_btn.Location = new System.Drawing.Point(70, 103);
            this.oracle_btn.Name = "oracle_btn";
            this.oracle_btn.Size = new System.Drawing.Size(108, 22);
            this.oracle_btn.TabIndex = 1;
            this.oracle_btn.Text = "Oracle";
            this.oracle_btn.UseVisualStyleBackColor = true;
            this.oracle_btn.Click += new System.EventHandler(this.oracle_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 214);
            this.Controls.Add(this.oracle_btn);
            this.Controls.Add(this.activeDirectory_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "MainForm";
            this.Text = "Abyss Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Abyss_Client.CompBase.BaseButton activeDirectory_btn;
        private System.Windows.Forms.Button oracle_btn;

    }
}