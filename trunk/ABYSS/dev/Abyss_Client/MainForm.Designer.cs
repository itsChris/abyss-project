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
            this.login_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.login_txt = new System.Windows.Forms.TextBox();
            this.ldap_gbx = new System.Windows.Forms.GroupBox();
            this.ldap_txt = new System.Windows.Forms.TextBox();
            this.ldap_lbl = new System.Windows.Forms.Label();
            this.otherLdap_rbt = new System.Windows.Forms.RadioButton();
            this.defaultLdap_rbt = new System.Windows.Forms.RadioButton();
            this.user_gbx = new System.Windows.Forms.GroupBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.ldap_gbx.SuspendLayout();
            this.user_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
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
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(28, 79);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(87, 17);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Password :";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(170, 79);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(150, 20);
            this.password_txt.TabIndex = 2;
            // 
            // login_txt
            // 
            this.login_txt.Location = new System.Drawing.Point(170, 33);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(150, 20);
            this.login_txt.TabIndex = 1;
            // 
            // ldap_gbx
            // 
            this.ldap_gbx.Controls.Add(this.ldap_txt);
            this.ldap_gbx.Controls.Add(this.ldap_lbl);
            this.ldap_gbx.Controls.Add(this.otherLdap_rbt);
            this.ldap_gbx.Controls.Add(this.defaultLdap_rbt);
            this.ldap_gbx.Location = new System.Drawing.Point(245, 74);
            this.ldap_gbx.Name = "ldap_gbx";
            this.ldap_gbx.Size = new System.Drawing.Size(330, 130);
            this.ldap_gbx.TabIndex = 4;
            this.ldap_gbx.TabStop = false;
            this.ldap_gbx.Text = "LDAP Information";
            // 
            // ldap_txt
            // 
            this.ldap_txt.Location = new System.Drawing.Point(108, 91);
            this.ldap_txt.Name = "ldap_txt";
            this.ldap_txt.Size = new System.Drawing.Size(181, 20);
            this.ldap_txt.TabIndex = 3;
            this.ldap_txt.Visible = false;
            // 
            // ldap_lbl
            // 
            this.ldap_lbl.AutoSize = true;
            this.ldap_lbl.Location = new System.Drawing.Point(54, 91);
            this.ldap_lbl.Name = "ldap_lbl";
            this.ldap_lbl.Size = new System.Drawing.Size(47, 13);
            this.ldap_lbl.TabIndex = 2;
            this.ldap_lbl.Text = "LDAP :";
            this.ldap_lbl.Visible = false;
            // 
            // otherLdap_rbt
            // 
            this.otherLdap_rbt.AutoSize = true;
            this.otherLdap_rbt.Location = new System.Drawing.Point(26, 57);
            this.otherLdap_rbt.Name = "otherLdap_rbt";
            this.otherLdap_rbt.Size = new System.Drawing.Size(182, 17);
            this.otherLdap_rbt.TabIndex = 1;
            this.otherLdap_rbt.TabStop = true;
            this.otherLdap_rbt.Text = "Connect to an other domain";
            this.otherLdap_rbt.UseVisualStyleBackColor = true;
            this.otherLdap_rbt.Click += new System.EventHandler(this.otherLdap_rbt_Click);
            // 
            // defaultLdap_rbt
            // 
            this.defaultLdap_rbt.AutoSize = true;
            this.defaultLdap_rbt.Checked = true;
            this.defaultLdap_rbt.Location = new System.Drawing.Point(26, 33);
            this.defaultLdap_rbt.Name = "defaultLdap_rbt";
            this.defaultLdap_rbt.Size = new System.Drawing.Size(174, 17);
            this.defaultLdap_rbt.TabIndex = 0;
            this.defaultLdap_rbt.TabStop = true;
            this.defaultLdap_rbt.Text = "Connect to default domain";
            this.defaultLdap_rbt.UseVisualStyleBackColor = true;
            this.defaultLdap_rbt.Click += new System.EventHandler(this.defaultLdap_rbt_Click);
            // 
            // user_gbx
            // 
            this.user_gbx.Controls.Add(this.login_lbl);
            this.user_gbx.Controls.Add(this.password_lbl);
            this.user_gbx.Controls.Add(this.login_txt);
            this.user_gbx.Controls.Add(this.password_txt);
            this.user_gbx.Location = new System.Drawing.Point(245, 232);
            this.user_gbx.Name = "user_gbx";
            this.user_gbx.Size = new System.Drawing.Size(330, 130);
            this.user_gbx.TabIndex = 5;
            this.user_gbx.TabStop = false;
            this.user_gbx.Text = "User Information";
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(499, 383);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 6;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 518);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.ldap_gbx);
            this.Controls.Add(this.user_gbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ldap_gbx.ResumeLayout(false);
            this.ldap_gbx.PerformLayout();
            this.user_gbx.ResumeLayout(false);
            this.user_gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.GroupBox ldap_gbx;
        private System.Windows.Forms.RadioButton defaultLdap_rbt;
        private System.Windows.Forms.RadioButton otherLdap_rbt;
        private System.Windows.Forms.TextBox ldap_txt;
        private System.Windows.Forms.Label ldap_lbl;
        private System.Windows.Forms.GroupBox user_gbx;
        private System.Windows.Forms.Button connect_btn;
    }
}