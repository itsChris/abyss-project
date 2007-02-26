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
            this.SuspendLayout();
            // 
            // activeDirectory_btn
            // 
            this.activeDirectory_btn.BackColor = System.Drawing.Color.LightGray;
            this.activeDirectory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.activeDirectory_btn.Location = new System.Drawing.Point(231, 135);
            this.activeDirectory_btn.Name = "activeDirectory_btn";
            this.activeDirectory_btn.Size = new System.Drawing.Size(108, 23);
            this.activeDirectory_btn.TabIndex = 0;
            this.activeDirectory_btn.Text = "Active Directory ";
            this.activeDirectory_btn.UseVisualStyleBackColor = true;
            this.activeDirectory_btn.Click += new System.EventHandler(this.activeDirectory_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 299);
            this.Controls.Add(this.activeDirectory_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Abyss Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Abyss_Client.CompBase.BaseButton activeDirectory_btn;

    }
}