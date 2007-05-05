namespace Abyss_Client {
    partial class ADLogin {
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
            this.ldap_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.otherLdap_rbt = new Abyss_Client.CompBase.BaseRadioButton();
            this.defaultLdap_rbt = new Abyss_Client.CompBase.BaseRadioButton();
            this.connect_btn = new Abyss_Client.CompBase.BaseButton();
            this.user_gbx = new Abyss_Client.CompBase.BaseGroupBox();
            this.login_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.password_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.login_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.password_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.ldap_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.ldap_gbx = new Abyss_Client.CompBase.BaseGroupBox();
            this.reset_btn = new Abyss_Client.CompBase.BaseButton();
            this.quit_btn = new Abyss_Client.CompBase.BaseButton();
            this.user_gbx.SuspendLayout();
            this.ldap_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // ldap_lbl
            // 
            this.ldap_lbl.AutoSize = true;
            this.ldap_lbl.BackColor = System.Drawing.Color.LightGray;
            this.ldap_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ldap_lbl.Location = new System.Drawing.Point(23, 95);
            this.ldap_lbl.Name = "ldap_lbl";
            this.ldap_lbl.Size = new System.Drawing.Size(47, 13);
            this.ldap_lbl.TabIndex = 2;
            this.ldap_lbl.Text = "LDAP :";
            this.ldap_lbl.Visible = false;
            // 
            // otherLdap_rbt
            // 
            this.otherLdap_rbt.AutoSize = true;
            this.otherLdap_rbt.BackColor = System.Drawing.Color.LightGray;
            this.otherLdap_rbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.otherLdap_rbt.Location = new System.Drawing.Point(26, 57);
            this.otherLdap_rbt.Name = "otherLdap_rbt";
            this.otherLdap_rbt.Size = new System.Drawing.Size(182, 17);
            this.otherLdap_rbt.TabIndex = 1;
            this.otherLdap_rbt.Text = "Connect to an other domain";
            this.otherLdap_rbt.UseVisualStyleBackColor = true;
            this.otherLdap_rbt.Click += new System.EventHandler(this.otherLdap_rbt_Click);
            // 
            // defaultLdap_rbt
            // 
            this.defaultLdap_rbt.AutoSize = true;
            this.defaultLdap_rbt.BackColor = System.Drawing.Color.LightGray;
            this.defaultLdap_rbt.Checked = true;
            this.defaultLdap_rbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.defaultLdap_rbt.Location = new System.Drawing.Point(26, 33);
            this.defaultLdap_rbt.Name = "defaultLdap_rbt";
            this.defaultLdap_rbt.Size = new System.Drawing.Size(174, 17);
            this.defaultLdap_rbt.TabIndex = 0;
            this.defaultLdap_rbt.TabStop = true;
            this.defaultLdap_rbt.Text = "Connect to default domain";
            this.defaultLdap_rbt.UseVisualStyleBackColor = true;
            this.defaultLdap_rbt.Click += new System.EventHandler(this.defaultLdap_rbt_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.BackColor = System.Drawing.Color.Transparent;
            this.connect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.connect_btn.Location = new System.Drawing.Point(205, 328);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 2;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = false;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // user_gbx
            // 
            this.user_gbx.BackColor = System.Drawing.Color.Transparent;
            this.user_gbx.Controls.Add(this.login_lbl);
            this.user_gbx.Controls.Add(this.password_lbl);
            this.user_gbx.Controls.Add(this.login_txt);
            this.user_gbx.Controls.Add(this.password_txt);
            this.user_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.user_gbx.Location = new System.Drawing.Point(12, 170);
            this.user_gbx.Name = "user_gbx";
            this.user_gbx.Size = new System.Drawing.Size(356, 130);
            this.user_gbx.TabIndex = 1;
            this.user_gbx.TabStop = false;
            this.user_gbx.Text = "User Information";
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.BackColor = System.Drawing.Color.LightGray;
            this.login_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.Location = new System.Drawing.Point(28, 33);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(58, 17);
            this.login_lbl.TabIndex = 0;
            this.login_lbl.Text = "Login :";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.BackColor = System.Drawing.Color.LightGray;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(28, 79);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(87, 17);
            this.password_lbl.TabIndex = 2;
            this.password_lbl.Text = "Password :";
            // 
            // login_txt
            // 
            this.login_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.login_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.login_txt.Location = new System.Drawing.Point(170, 33);
            this.login_txt.Mandatory = true;
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(150, 20);
            this.login_txt.TabIndex = 1;
            // 
            // password_txt
            // 
            this.password_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.password_txt.Location = new System.Drawing.Point(170, 79);
            this.password_txt.Mandatory = true;
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(150, 20);
            this.password_txt.TabIndex = 3;
            // 
            // ldap_txt
            // 
            this.ldap_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ldap_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ldap_txt.Location = new System.Drawing.Point(76, 92);
            this.ldap_txt.Mandatory = true;
            this.ldap_txt.Name = "ldap_txt";
            this.ldap_txt.Size = new System.Drawing.Size(181, 20);
            this.ldap_txt.TabIndex = 3;
            this.ldap_txt.Visible = false;
            // 
            // ldap_gbx
            // 
            this.ldap_gbx.BackColor = System.Drawing.Color.LightGray;
            this.ldap_gbx.Controls.Add(this.ldap_txt);
            this.ldap_gbx.Controls.Add(this.ldap_lbl);
            this.ldap_gbx.Controls.Add(this.otherLdap_rbt);
            this.ldap_gbx.Controls.Add(this.defaultLdap_rbt);
            this.ldap_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ldap_gbx.Location = new System.Drawing.Point(12, 12);
            this.ldap_gbx.Name = "ldap_gbx";
            this.ldap_gbx.Size = new System.Drawing.Size(356, 130);
            this.ldap_gbx.TabIndex = 0;
            this.ldap_gbx.TabStop = false;
            this.ldap_gbx.Text = "LDAP Information";
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Transparent;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.reset_btn.Location = new System.Drawing.Point(106, 328);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 3;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.BackColor = System.Drawing.Color.Transparent;
            this.quit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.quit_btn.Location = new System.Drawing.Point(12, 328);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(75, 23);
            this.quit_btn.TabIndex = 4;
            this.quit_btn.Text = "Quit";
            this.quit_btn.UseVisualStyleBackColor = false;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // ADLogin
            // 
            this.AcceptButton = this.connect_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 379);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.user_gbx);
            this.Controls.Add(this.ldap_gbx);
            this.Name = "ADLogin";
            this.Text = "Abyss Management - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADLogin_FormClosing);
            this.user_gbx.ResumeLayout(false);
            this.user_gbx.PerformLayout();
            this.ldap_gbx.ResumeLayout(false);
            this.ldap_gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Abyss_Client.CompBase.BaseLabel ldap_lbl;
        private Abyss_Client.CompBase.BaseRadioButton otherLdap_rbt;
        private Abyss_Client.CompBase.BaseRadioButton defaultLdap_rbt;
        private Abyss_Client.CompBase.BaseButton connect_btn;
        private Abyss_Client.CompBase.BaseGroupBox user_gbx;
        private Abyss_Client.CompBase.BaseLabel login_lbl;
        private Abyss_Client.CompBase.BaseLabel password_lbl;
        private Abyss_Client.CompBase.BaseTextBox login_txt;
        private Abyss_Client.CompBase.BaseTextBox password_txt;
        private Abyss_Client.CompBase.BaseGroupBox ldap_gbx;
        private Abyss_Client.CompBase.BaseTextBox ldap_txt;
        private Abyss_Client.CompBase.BaseButton reset_btn;
        private Abyss_Client.CompBase.BaseButton quit_btn;

    }
}