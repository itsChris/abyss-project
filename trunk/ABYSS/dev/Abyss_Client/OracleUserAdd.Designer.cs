namespace Abyss_Client {
    partial class OracleUserAdd {
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
            this.userInformation_gbx = new Abyss_Client.CompBase.BaseGroupBox();
            this.userLogin_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.accountLock_chk = new Abyss_Client.CompBase.BaseCheckBox();
            this.userLogin_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.tablespace_gbx = new Abyss_Client.CompBase.BaseGroupBox();
            this.temporaryTablespace_cbx = new Abyss_Client.CompBase.BaseComboBox();
            this.defaultTablespace_cbx = new Abyss_Client.CompBase.BaseComboBox();
            this.temporaryTablespace_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.defaultTablespace_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.accountInformation_gbx = new Abyss_Client.CompBase.BaseGroupBox();
            this.profile_cbx = new Abyss_Client.CompBase.BaseComboBox();
            this.profile_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.createUser_btn = new Abyss_Client.CompBase.BaseButton();
            this.userInformation_gbx.SuspendLayout();
            this.tablespace_gbx.SuspendLayout();
            this.accountInformation_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInformation_gbx
            // 
            this.userInformation_gbx.BackColor = System.Drawing.Color.Transparent;
            this.userInformation_gbx.Controls.Add(this.userLogin_txt);
            this.userInformation_gbx.Controls.Add(this.accountLock_chk);
            this.userInformation_gbx.Controls.Add(this.userLogin_lbl);
            this.userInformation_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.userInformation_gbx.Location = new System.Drawing.Point(13, 13);
            this.userInformation_gbx.Name = "userInformation_gbx";
            this.userInformation_gbx.Size = new System.Drawing.Size(341, 92);
            this.userInformation_gbx.TabIndex = 0;
            this.userInformation_gbx.TabStop = false;
            this.userInformation_gbx.Text = "User Information";
            // 
            // userLogin_txt
            // 
            this.userLogin_txt.BackColor = System.Drawing.Color.White;
            this.userLogin_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.userLogin_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.userLogin_txt.Location = new System.Drawing.Point(85, 29);
            this.userLogin_txt.Mandatory = false;
            this.userLogin_txt.Name = "userLogin_txt";
            this.userLogin_txt.Size = new System.Drawing.Size(141, 20);
            this.userLogin_txt.TabIndex = 4;
            // 
            // accountLock_chk
            // 
            this.accountLock_chk.AutoSize = true;
            this.accountLock_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLock_chk.Location = new System.Drawing.Point(85, 64);
            this.accountLock_chk.Name = "accountLock_chk";
            this.accountLock_chk.Size = new System.Drawing.Size(106, 17);
            this.accountLock_chk.TabIndex = 2;
            this.accountLock_chk.Text = "Lock Account";
            this.accountLock_chk.UseVisualStyleBackColor = true;
            // 
            // userLogin_lbl
            // 
            this.userLogin_lbl.AutoSize = true;
            this.userLogin_lbl.BackColor = System.Drawing.Color.LightGray;
            this.userLogin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.userLogin_lbl.Location = new System.Drawing.Point(33, 32);
            this.userLogin_lbl.Name = "userLogin_lbl";
            this.userLogin_lbl.Size = new System.Drawing.Size(46, 13);
            this.userLogin_lbl.TabIndex = 0;
            this.userLogin_lbl.Text = "Login :";
            // 
            // tablespace_gbx
            // 
            this.tablespace_gbx.BackColor = System.Drawing.Color.Transparent;
            this.tablespace_gbx.Controls.Add(this.temporaryTablespace_cbx);
            this.tablespace_gbx.Controls.Add(this.defaultTablespace_cbx);
            this.tablespace_gbx.Controls.Add(this.temporaryTablespace_lbl);
            this.tablespace_gbx.Controls.Add(this.defaultTablespace_lbl);
            this.tablespace_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablespace_gbx.Location = new System.Drawing.Point(376, 13);
            this.tablespace_gbx.Name = "tablespace_gbx";
            this.tablespace_gbx.Size = new System.Drawing.Size(342, 92);
            this.tablespace_gbx.TabIndex = 1;
            this.tablespace_gbx.TabStop = false;
            this.tablespace_gbx.Text = "Tablespace Information";
            // 
            // temporaryTablespace_cbx
            // 
            this.temporaryTablespace_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.temporaryTablespace_cbx.FormattingEnabled = true;
            this.temporaryTablespace_cbx.Location = new System.Drawing.Point(192, 60);
            this.temporaryTablespace_cbx.Name = "temporaryTablespace_cbx";
            this.temporaryTablespace_cbx.Size = new System.Drawing.Size(145, 21);
            this.temporaryTablespace_cbx.TabIndex = 5;
            // 
            // defaultTablespace_cbx
            // 
            this.defaultTablespace_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultTablespace_cbx.FormattingEnabled = true;
            this.defaultTablespace_cbx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.defaultTablespace_cbx.Location = new System.Drawing.Point(192, 27);
            this.defaultTablespace_cbx.Name = "defaultTablespace_cbx";
            this.defaultTablespace_cbx.Size = new System.Drawing.Size(145, 21);
            this.defaultTablespace_cbx.TabIndex = 4;
            this.defaultTablespace_cbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.defaultTablespace_cbx_KeyPress);
            // 
            // temporaryTablespace_lbl
            // 
            this.temporaryTablespace_lbl.AutoSize = true;
            this.temporaryTablespace_lbl.BackColor = System.Drawing.Color.LightGray;
            this.temporaryTablespace_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.temporaryTablespace_lbl.Location = new System.Drawing.Point(34, 63);
            this.temporaryTablespace_lbl.Name = "temporaryTablespace_lbl";
            this.temporaryTablespace_lbl.Size = new System.Drawing.Size(144, 13);
            this.temporaryTablespace_lbl.TabIndex = 2;
            this.temporaryTablespace_lbl.Text = "Temporary Tablespace :";
            // 
            // defaultTablespace_lbl
            // 
            this.defaultTablespace_lbl.AutoSize = true;
            this.defaultTablespace_lbl.BackColor = System.Drawing.Color.LightGray;
            this.defaultTablespace_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.defaultTablespace_lbl.Location = new System.Drawing.Point(34, 32);
            this.defaultTablespace_lbl.Name = "defaultTablespace_lbl";
            this.defaultTablespace_lbl.Size = new System.Drawing.Size(126, 13);
            this.defaultTablespace_lbl.TabIndex = 0;
            this.defaultTablespace_lbl.Text = "Default Tablespace :";
            // 
            // accountInformation_gbx
            // 
            this.accountInformation_gbx.BackColor = System.Drawing.Color.Transparent;
            this.accountInformation_gbx.Controls.Add(this.profile_cbx);
            this.accountInformation_gbx.Controls.Add(this.profile_lbl);
            this.accountInformation_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.accountInformation_gbx.Location = new System.Drawing.Point(13, 128);
            this.accountInformation_gbx.Name = "accountInformation_gbx";
            this.accountInformation_gbx.Size = new System.Drawing.Size(341, 105);
            this.accountInformation_gbx.TabIndex = 2;
            this.accountInformation_gbx.TabStop = false;
            this.accountInformation_gbx.Text = "Account Information :";
            // 
            // profile_cbx
            // 
            this.profile_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profile_cbx.FormattingEnabled = true;
            this.profile_cbx.Location = new System.Drawing.Point(114, 30);
            this.profile_cbx.Name = "profile_cbx";
            this.profile_cbx.Size = new System.Drawing.Size(166, 21);
            this.profile_cbx.TabIndex = 3;
            // 
            // profile_lbl
            // 
            this.profile_lbl.AutoSize = true;
            this.profile_lbl.BackColor = System.Drawing.Color.LightGray;
            this.profile_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.profile_lbl.Location = new System.Drawing.Point(33, 33);
            this.profile_lbl.Name = "profile_lbl";
            this.profile_lbl.Size = new System.Drawing.Size(51, 13);
            this.profile_lbl.TabIndex = 0;
            this.profile_lbl.Text = "Profile :";
            // 
            // createUser_btn
            // 
            this.createUser_btn.BackColor = System.Drawing.Color.LightGray;
            this.createUser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.createUser_btn.Location = new System.Drawing.Point(284, 340);
            this.createUser_btn.Name = "createUser_btn";
            this.createUser_btn.Size = new System.Drawing.Size(127, 23);
            this.createUser_btn.TabIndex = 3;
            this.createUser_btn.Text = "Save";
            this.createUser_btn.UseVisualStyleBackColor = true;
            this.createUser_btn.Click += new System.EventHandler(this.createUser_btn_Click);
            // 
            // OracleUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 439);
            this.Controls.Add(this.createUser_btn);
            this.Controls.Add(this.accountInformation_gbx);
            this.Controls.Add(this.tablespace_gbx);
            this.Controls.Add(this.userInformation_gbx);
            this.Name = "OracleUserAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oracle User";
            this.Load += new System.EventHandler(this.OracleUserAdd_Load);
            this.userInformation_gbx.ResumeLayout(false);
            this.userInformation_gbx.PerformLayout();
            this.tablespace_gbx.ResumeLayout(false);
            this.tablespace_gbx.PerformLayout();
            this.accountInformation_gbx.ResumeLayout(false);
            this.accountInformation_gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Abyss_Client.CompBase.BaseGroupBox userInformation_gbx;
        private Abyss_Client.CompBase.BaseLabel userLogin_lbl;
        private Abyss_Client.CompBase.BaseTextBox userLogin_txt;
        private Abyss_Client.CompBase.BaseGroupBox tablespace_gbx;
        private Abyss_Client.CompBase.BaseLabel defaultTablespace_lbl;
        private Abyss_Client.CompBase.BaseLabel temporaryTablespace_lbl;
        private Abyss_Client.CompBase.BaseGroupBox accountInformation_gbx;
        private Abyss_Client.CompBase.BaseLabel profile_lbl;
        private Abyss_Client.CompBase.BaseCheckBox accountLock_chk;
        private Abyss_Client.CompBase.BaseButton createUser_btn;
        private Abyss_Client.CompBase.BaseComboBox defaultTablespace_cbx;
        private Abyss_Client.CompBase.BaseComboBox temporaryTablespace_cbx;
        private Abyss_Client.CompBase.BaseComboBox profile_cbx;
    }
}