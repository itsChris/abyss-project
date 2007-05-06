namespace Abyss_Client {
    partial class OracleEditUserPassword {
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
            this.password_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.confirmPassword_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.password_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.confirmPassword_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.valid_btn = new Abyss_Client.CompBase.BaseButton();
            this.SuspendLayout();
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.BackColor = System.Drawing.Color.LightGray;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.password_lbl.Location = new System.Drawing.Point(13, 49);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(69, 13);
            this.password_lbl.TabIndex = 0;
            this.password_lbl.Text = "Password :";
            // 
            // confirmPassword_lbl
            // 
            this.confirmPassword_lbl.AutoSize = true;
            this.confirmPassword_lbl.BackColor = System.Drawing.Color.LightGray;
            this.confirmPassword_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.confirmPassword_lbl.Location = new System.Drawing.Point(13, 87);
            this.confirmPassword_lbl.Name = "confirmPassword_lbl";
            this.confirmPassword_lbl.Size = new System.Drawing.Size(115, 13);
            this.confirmPassword_lbl.TabIndex = 1;
            this.confirmPassword_lbl.Text = "Confirm Password :";
            // 
            // password_txt
            // 
            this.password_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.password_txt.Location = new System.Drawing.Point(162, 46);
            this.password_txt.Mandatory = false;
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(197, 20);
            this.password_txt.TabIndex = 2;
            // 
            // confirmPassword_txt
            // 
            this.confirmPassword_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.confirmPassword_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.confirmPassword_txt.Location = new System.Drawing.Point(162, 84);
            this.confirmPassword_txt.Mandatory = false;
            this.confirmPassword_txt.Name = "confirmPassword_txt";
            this.confirmPassword_txt.PasswordChar = '*';
            this.confirmPassword_txt.Size = new System.Drawing.Size(197, 20);
            this.confirmPassword_txt.TabIndex = 3;
            // 
            // valid_btn
            // 
            this.valid_btn.BackColor = System.Drawing.Color.LightGray;
            this.valid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.valid_btn.Location = new System.Drawing.Point(128, 155);
            this.valid_btn.Name = "valid_btn";
            this.valid_btn.Size = new System.Drawing.Size(131, 23);
            this.valid_btn.TabIndex = 4;
            this.valid_btn.Text = "Change Password";
            this.valid_btn.UseVisualStyleBackColor = true;
            this.valid_btn.Click += new System.EventHandler(this.valid_btn_Click);
            // 
            // OracleEditUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 190);
            this.Controls.Add(this.valid_btn);
            this.Controls.Add(this.confirmPassword_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.confirmPassword_lbl);
            this.Controls.Add(this.password_lbl);
            this.Name = "OracleEditUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Password of an Orcale User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Abyss_Client.CompBase.BaseLabel password_lbl;
        private Abyss_Client.CompBase.BaseLabel confirmPassword_lbl;
        private Abyss_Client.CompBase.BaseTextBox password_txt;
        private Abyss_Client.CompBase.BaseTextBox confirmPassword_txt;
        private Abyss_Client.CompBase.BaseButton valid_btn;
    }
}