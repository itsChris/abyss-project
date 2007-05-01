namespace Abyss_Client {
    partial class ADUserPasswordUpdate {
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
            this.password_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.confirmPassword_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.changePassword_chk = new Abyss_Client.CompBase.BaseCheckBox();
            this.newpwd_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.confpwd_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.info_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.ok_btn = new Abyss_Client.CompBase.BaseButton();
            this.cancel_bn = new Abyss_Client.CompBase.BaseButton();
            this.SuspendLayout();
            // 
            // password_txt
            // 
            this.password_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.password_txt.Location = new System.Drawing.Point(125, 25);
            this.password_txt.Mandatory = true;
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(168, 20);
            this.password_txt.TabIndex = 0;
            // 
            // confirmPassword_txt
            // 
            this.confirmPassword_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.confirmPassword_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.confirmPassword_txt.Location = new System.Drawing.Point(125, 63);
            this.confirmPassword_txt.Mandatory = true;
            this.confirmPassword_txt.Name = "confirmPassword_txt";
            this.confirmPassword_txt.PasswordChar = '*';
            this.confirmPassword_txt.Size = new System.Drawing.Size(168, 20);
            this.confirmPassword_txt.TabIndex = 1;
            // 
            // changePassword_chk
            // 
            this.changePassword_chk.BackColor = System.Drawing.Color.Transparent;
            this.changePassword_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassword_chk.Location = new System.Drawing.Point(12, 101);
            this.changePassword_chk.Name = "changePassword_chk";
            this.changePassword_chk.Size = new System.Drawing.Size(318, 24);
            this.changePassword_chk.TabIndex = 2;
            this.changePassword_chk.Text = "The user must change password at the next logon";
            this.changePassword_chk.UseVisualStyleBackColor = false;
            // 
            // newpwd_lbl
            // 
            this.newpwd_lbl.AutoSize = true;
            this.newpwd_lbl.BackColor = System.Drawing.Color.LightGray;
            this.newpwd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.newpwd_lbl.Location = new System.Drawing.Point(25, 28);
            this.newpwd_lbl.Name = "newpwd_lbl";
            this.newpwd_lbl.Size = new System.Drawing.Size(90, 13);
            this.newpwd_lbl.TabIndex = 3;
            this.newpwd_lbl.Text = "New Password";
            this.newpwd_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confpwd_lbl
            // 
            this.confpwd_lbl.AutoSize = true;
            this.confpwd_lbl.BackColor = System.Drawing.Color.LightGray;
            this.confpwd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.confpwd_lbl.Location = new System.Drawing.Point(9, 63);
            this.confpwd_lbl.Name = "confpwd_lbl";
            this.confpwd_lbl.Size = new System.Drawing.Size(106, 13);
            this.confpwd_lbl.TabIndex = 4;
            this.confpwd_lbl.Text = "Confirm password";
            this.confpwd_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.BackColor = System.Drawing.Color.Transparent;
            this.info_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.info_lbl.Location = new System.Drawing.Point(9, 139);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(388, 13);
            this.info_lbl.TabIndex = 5;
            this.info_lbl.Text = "The user must logoff and then logon for the change to take effect. ";
            this.info_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.Transparent;
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ok_btn.Location = new System.Drawing.Point(35, 178);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 6;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_bn
            // 
            this.cancel_bn.BackColor = System.Drawing.Color.Transparent;
            this.cancel_bn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cancel_bn.Location = new System.Drawing.Point(150, 178);
            this.cancel_bn.Name = "cancel_bn";
            this.cancel_bn.Size = new System.Drawing.Size(75, 23);
            this.cancel_bn.TabIndex = 7;
            this.cancel_bn.Text = "Cancel";
            this.cancel_bn.UseVisualStyleBackColor = false;
            this.cancel_bn.Click += new System.EventHandler(this.cancel_bn_Click);
            // 
            // ADUserPasswordUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 223);
            this.Controls.Add(this.cancel_bn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.confpwd_lbl);
            this.Controls.Add(this.newpwd_lbl);
            this.Controls.Add(this.changePassword_chk);
            this.Controls.Add(this.confirmPassword_txt);
            this.Controls.Add(this.password_txt);
            this.Name = "ADUserPasswordUpdate";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Abyss_Client.CompBase.BaseTextBox password_txt;
        private Abyss_Client.CompBase.BaseTextBox confirmPassword_txt;
        private Abyss_Client.CompBase.BaseCheckBox changePassword_chk;
        private Abyss_Client.CompBase.BaseLabel newpwd_lbl;
        private Abyss_Client.CompBase.BaseLabel confpwd_lbl;
        private Abyss_Client.CompBase.BaseLabel info_lbl;
        private Abyss_Client.CompBase.BaseButton ok_btn;
        private Abyss_Client.CompBase.BaseButton cancel_bn;
    }
}