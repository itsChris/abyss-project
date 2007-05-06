namespace Abyss_Client {
    partial class ADComputerUpdate {
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
            this.info_gbx = new Abyss_Client.CompBase.BaseGroupBox();
            this.trust_cbx = new Abyss_Client.CompBase.BaseCheckBox();
            this.role_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.server_cbx = new Abyss_Client.CompBase.BaseCheckBox();
            this.desc_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.desc_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.role_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.cpuName_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.cpuName_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.dns_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.dns_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.baseGroupBox1 = new Abyss_Client.CompBase.BaseGroupBox();
            this.pack_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.version_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.version_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.systemName_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.systemName_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.pack_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.MemberOf_btn = new Abyss_Client.CompBase.BaseButton();
            this.save_btn = new Abyss_Client.CompBase.BaseButton();
            this.cancel_btn = new Abyss_Client.CompBase.BaseButton();
            this.info_gbx.SuspendLayout();
            this.baseGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // info_gbx
            // 
            this.info_gbx.BackColor = System.Drawing.Color.Transparent;
            this.info_gbx.Controls.Add(this.trust_cbx);
            this.info_gbx.Controls.Add(this.role_txt);
            this.info_gbx.Controls.Add(this.server_cbx);
            this.info_gbx.Controls.Add(this.desc_txt);
            this.info_gbx.Controls.Add(this.desc_lbl);
            this.info_gbx.Controls.Add(this.role_lbl);
            this.info_gbx.Controls.Add(this.cpuName_txt);
            this.info_gbx.Controls.Add(this.cpuName_lbl);
            this.info_gbx.Controls.Add(this.dns_txt);
            this.info_gbx.Controls.Add(this.dns_lbl);
            this.info_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.info_gbx.Location = new System.Drawing.Point(12, 12);
            this.info_gbx.Name = "info_gbx";
            this.info_gbx.Size = new System.Drawing.Size(423, 247);
            this.info_gbx.TabIndex = 0;
            this.info_gbx.TabStop = false;
            this.info_gbx.Text = "General Information";
            // 
            // trust_cbx
            // 
            this.trust_cbx.AutoSize = true;
            this.trust_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trust_cbx.Location = new System.Drawing.Point(24, 224);
            this.trust_cbx.Name = "trust_cbx";
            this.trust_cbx.Size = new System.Drawing.Size(194, 17);
            this.trust_cbx.TabIndex = 9;
            this.trust_cbx.Text = "Trust computer for delegation";
            this.trust_cbx.UseVisualStyleBackColor = true;
            this.trust_cbx.Click += new System.EventHandler(this.trust_cbx_Click);
            // 
            // role_txt
            // 
            this.role_txt.Enabled = false;
            this.role_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.role_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.role_txt.Location = new System.Drawing.Point(132, 161);
            this.role_txt.Mandatory = false;
            this.role_txt.Name = "role_txt";
            this.role_txt.Size = new System.Drawing.Size(181, 20);
            this.role_txt.TabIndex = 7;
            // 
            // server_cbx
            // 
            this.server_cbx.AutoSize = true;
            this.server_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_cbx.Location = new System.Drawing.Point(24, 198);
            this.server_cbx.Name = "server_cbx";
            this.server_cbx.Size = new System.Drawing.Size(373, 17);
            this.server_cbx.TabIndex = 8;
            this.server_cbx.Text = "Assign this computer account as a backup domain controller.";
            this.server_cbx.UseVisualStyleBackColor = true;
            // 
            // desc_txt
            // 
            this.desc_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.desc_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.desc_txt.Location = new System.Drawing.Point(131, 90);
            this.desc_txt.Mandatory = false;
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.Size = new System.Drawing.Size(272, 20);
            this.desc_txt.TabIndex = 3;
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.BackColor = System.Drawing.Color.LightGray;
            this.desc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.desc_lbl.Location = new System.Drawing.Point(21, 93);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(79, 13);
            this.desc_lbl.TabIndex = 2;
            this.desc_lbl.Text = "Description :";
            // 
            // role_lbl
            // 
            this.role_lbl.AutoSize = true;
            this.role_lbl.BackColor = System.Drawing.Color.LightGray;
            this.role_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.role_lbl.Location = new System.Drawing.Point(22, 164);
            this.role_lbl.Name = "role_lbl";
            this.role_lbl.Size = new System.Drawing.Size(41, 13);
            this.role_lbl.TabIndex = 6;
            this.role_lbl.Text = "Role :";
            // 
            // cpuName_txt
            // 
            this.cpuName_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cpuName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cpuName_txt.Location = new System.Drawing.Point(132, 52);
            this.cpuName_txt.Mandatory = true;
            this.cpuName_txt.Name = "cpuName_txt";
            this.cpuName_txt.Size = new System.Drawing.Size(181, 20);
            this.cpuName_txt.TabIndex = 1;
            // 
            // cpuName_lbl
            // 
            this.cpuName_lbl.AutoSize = true;
            this.cpuName_lbl.BackColor = System.Drawing.Color.LightGray;
            this.cpuName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cpuName_lbl.Location = new System.Drawing.Point(22, 55);
            this.cpuName_lbl.Name = "cpuName_lbl";
            this.cpuName_lbl.Size = new System.Drawing.Size(104, 13);
            this.cpuName_lbl.TabIndex = 0;
            this.cpuName_lbl.Text = "Computer Name :";
            // 
            // dns_txt
            // 
            this.dns_txt.Enabled = false;
            this.dns_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dns_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.dns_txt.Location = new System.Drawing.Point(132, 126);
            this.dns_txt.Mandatory = false;
            this.dns_txt.Name = "dns_txt";
            this.dns_txt.Size = new System.Drawing.Size(181, 20);
            this.dns_txt.TabIndex = 5;
            // 
            // dns_lbl
            // 
            this.dns_lbl.AutoSize = true;
            this.dns_lbl.BackColor = System.Drawing.Color.LightGray;
            this.dns_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.dns_lbl.Location = new System.Drawing.Point(22, 129);
            this.dns_lbl.Name = "dns_lbl";
            this.dns_lbl.Size = new System.Drawing.Size(77, 13);
            this.dns_lbl.TabIndex = 4;
            this.dns_lbl.Text = "DNS Name :";
            // 
            // baseGroupBox1
            // 
            this.baseGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.baseGroupBox1.Controls.Add(this.pack_txt);
            this.baseGroupBox1.Controls.Add(this.version_txt);
            this.baseGroupBox1.Controls.Add(this.version_lbl);
            this.baseGroupBox1.Controls.Add(this.systemName_txt);
            this.baseGroupBox1.Controls.Add(this.systemName_lbl);
            this.baseGroupBox1.Controls.Add(this.pack_lbl);
            this.baseGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.baseGroupBox1.Location = new System.Drawing.Point(441, 12);
            this.baseGroupBox1.Name = "baseGroupBox1";
            this.baseGroupBox1.Size = new System.Drawing.Size(334, 247);
            this.baseGroupBox1.TabIndex = 1;
            this.baseGroupBox1.TabStop = false;
            this.baseGroupBox1.Text = "Operating System";
            // 
            // pack_txt
            // 
            this.pack_txt.Enabled = false;
            this.pack_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pack_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.pack_txt.Location = new System.Drawing.Point(131, 126);
            this.pack_txt.Mandatory = false;
            this.pack_txt.Name = "pack_txt";
            this.pack_txt.Size = new System.Drawing.Size(181, 20);
            this.pack_txt.TabIndex = 5;
            // 
            // version_txt
            // 
            this.version_txt.Enabled = false;
            this.version_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.version_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.version_txt.Location = new System.Drawing.Point(131, 90);
            this.version_txt.Mandatory = false;
            this.version_txt.Name = "version_txt";
            this.version_txt.Size = new System.Drawing.Size(181, 20);
            this.version_txt.TabIndex = 3;
            // 
            // version_lbl
            // 
            this.version_lbl.AutoSize = true;
            this.version_lbl.BackColor = System.Drawing.Color.LightGray;
            this.version_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.version_lbl.Location = new System.Drawing.Point(21, 93);
            this.version_lbl.Name = "version_lbl";
            this.version_lbl.Size = new System.Drawing.Size(57, 13);
            this.version_lbl.TabIndex = 2;
            this.version_lbl.Text = "Version :";
            // 
            // systemName_txt
            // 
            this.systemName_txt.Enabled = false;
            this.systemName_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.systemName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.systemName_txt.Location = new System.Drawing.Point(131, 52);
            this.systemName_txt.Mandatory = false;
            this.systemName_txt.Name = "systemName_txt";
            this.systemName_txt.Size = new System.Drawing.Size(181, 20);
            this.systemName_txt.TabIndex = 1;
            // 
            // systemName_lbl
            // 
            this.systemName_lbl.AutoSize = true;
            this.systemName_lbl.BackColor = System.Drawing.Color.LightGray;
            this.systemName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.systemName_lbl.Location = new System.Drawing.Point(22, 55);
            this.systemName_lbl.Name = "systemName_lbl";
            this.systemName_lbl.Size = new System.Drawing.Size(47, 13);
            this.systemName_lbl.TabIndex = 0;
            this.systemName_lbl.Text = "Name :";
            // 
            // pack_lbl
            // 
            this.pack_lbl.AutoSize = true;
            this.pack_lbl.BackColor = System.Drawing.Color.LightGray;
            this.pack_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.pack_lbl.Location = new System.Drawing.Point(22, 129);
            this.pack_lbl.Name = "pack_lbl";
            this.pack_lbl.Size = new System.Drawing.Size(91, 13);
            this.pack_lbl.TabIndex = 4;
            this.pack_lbl.Text = "Service Pack :";
            // 
            // MemberOf_btn
            // 
            this.MemberOf_btn.BackColor = System.Drawing.Color.LightGray;
            this.MemberOf_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.MemberOf_btn.Location = new System.Drawing.Point(155, 274);
            this.MemberOf_btn.Name = "MemberOf_btn";
            this.MemberOf_btn.Size = new System.Drawing.Size(75, 23);
            this.MemberOf_btn.TabIndex = 2;
            this.MemberOf_btn.Text = "MemberOf";
            this.MemberOf_btn.UseVisualStyleBackColor = true;
            this.MemberOf_btn.Click += new System.EventHandler(this.MemberOf_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.LightGray;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.save_btn.Location = new System.Drawing.Point(388, 274);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.LightGray;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.Location = new System.Drawing.Point(267, 274);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ADComputerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 304);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.MemberOf_btn);
            this.Controls.Add(this.baseGroupBox1);
            this.Controls.Add(this.info_gbx);
            this.Name = "ADComputerUpdate";
            this.Text = "Active Directory Computer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADComputerUpdate_FormClosing);
            this.Load += new System.EventHandler(this.ADComputerUpdate_Load);
            this.info_gbx.ResumeLayout(false);
            this.info_gbx.PerformLayout();
            this.baseGroupBox1.ResumeLayout(false);
            this.baseGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Abyss_Client.CompBase.BaseGroupBox info_gbx;
        private Abyss_Client.CompBase.BaseTextBox cpuName_txt;
        private Abyss_Client.CompBase.BaseLabel cpuName_lbl;
        private Abyss_Client.CompBase.BaseCheckBox server_cbx;
        private Abyss_Client.CompBase.BaseTextBox dns_txt;
        private Abyss_Client.CompBase.BaseLabel dns_lbl;
        private Abyss_Client.CompBase.BaseTextBox role_txt;
        private Abyss_Client.CompBase.BaseLabel role_lbl;
        private Abyss_Client.CompBase.BaseTextBox desc_txt;
        private Abyss_Client.CompBase.BaseLabel desc_lbl;
        private Abyss_Client.CompBase.BaseCheckBox trust_cbx;
        private Abyss_Client.CompBase.BaseGroupBox baseGroupBox1;
        private Abyss_Client.CompBase.BaseLabel version_lbl;
        private Abyss_Client.CompBase.BaseTextBox systemName_txt;
        private Abyss_Client.CompBase.BaseLabel systemName_lbl;
        private Abyss_Client.CompBase.BaseLabel pack_lbl;
        private Abyss_Client.CompBase.BaseTextBox pack_txt;
        private Abyss_Client.CompBase.BaseTextBox version_txt;
        private Abyss_Client.CompBase.BaseButton MemberOf_btn;
        private Abyss_Client.CompBase.BaseButton save_btn;
        private Abyss_Client.CompBase.BaseButton cancel_btn;
    }
}