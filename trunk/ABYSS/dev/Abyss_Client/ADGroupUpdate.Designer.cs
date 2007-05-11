namespace Abyss_Client {
    partial class ADGroupUpdate {
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
            this.type_gbx = new Abyss_Client.CompBase.BaseGroupBox();
            this.distribution_rdt = new Abyss_Client.CompBase.BaseRadioButton();
            this.security_rdt = new Abyss_Client.CompBase.BaseRadioButton();
            this.cope_gbx = new Abyss_Client.CompBase.BaseGroupBox();
            this.universal_rdt = new Abyss_Client.CompBase.BaseRadioButton();
            this.global_rdt = new Abyss_Client.CompBase.BaseRadioButton();
            this.domainLocal_rdt = new Abyss_Client.CompBase.BaseRadioButton();
            this.desc_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.desc_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.name_txt = new Abyss_Client.CompBase.BaseTextBox();
            this.name_lbl = new Abyss_Client.CompBase.BaseLabel();
            this.ok_btn = new Abyss_Client.CompBase.BaseButton();
            this.cancel_btn = new Abyss_Client.CompBase.BaseButton();
            this.memberof_btn = new Abyss_Client.CompBase.BaseButton();
            this.members_btn = new Abyss_Client.CompBase.BaseButton();
            this.info_gbx.SuspendLayout();
            this.type_gbx.SuspendLayout();
            this.cope_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // info_gbx
            // 
            this.info_gbx.BackColor = System.Drawing.Color.Transparent;
            this.info_gbx.Controls.Add(this.type_gbx);
            this.info_gbx.Controls.Add(this.cope_gbx);
            this.info_gbx.Controls.Add(this.desc_txt);
            this.info_gbx.Controls.Add(this.desc_lbl);
            this.info_gbx.Controls.Add(this.name_txt);
            this.info_gbx.Controls.Add(this.name_lbl);
            this.info_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.info_gbx.Location = new System.Drawing.Point(12, 12);
            this.info_gbx.Name = "info_gbx";
            this.info_gbx.Size = new System.Drawing.Size(420, 271);
            this.info_gbx.TabIndex = 0;
            this.info_gbx.TabStop = false;
            this.info_gbx.Text = "Group Information";
            // 
            // type_gbx
            // 
            this.type_gbx.BackColor = System.Drawing.Color.Transparent;
            this.type_gbx.Controls.Add(this.distribution_rdt);
            this.type_gbx.Controls.Add(this.security_rdt);
            this.type_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.type_gbx.Location = new System.Drawing.Point(224, 126);
            this.type_gbx.Name = "type_gbx";
            this.type_gbx.Size = new System.Drawing.Size(183, 132);
            this.type_gbx.TabIndex = 5;
            this.type_gbx.TabStop = false;
            this.type_gbx.Text = "Group Type";
            // 
            // distribution_rdt
            // 
            this.distribution_rdt.AutoSize = true;
            this.distribution_rdt.BackColor = System.Drawing.Color.Transparent;
            this.distribution_rdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.distribution_rdt.Location = new System.Drawing.Point(37, 63);
            this.distribution_rdt.Name = "distribution_rdt";
            this.distribution_rdt.Size = new System.Drawing.Size(89, 17);
            this.distribution_rdt.TabIndex = 4;
            this.distribution_rdt.Text = "Distribution";
            this.distribution_rdt.UseVisualStyleBackColor = false;
            this.distribution_rdt.CheckedChanged += new System.EventHandler(this.distribution_rtn_CheckedChanged);
            // 
            // security_rdt
            // 
            this.security_rdt.AutoSize = true;
            this.security_rdt.BackColor = System.Drawing.Color.Transparent;
            this.security_rdt.Checked = true;
            this.security_rdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.security_rdt.Location = new System.Drawing.Point(37, 30);
            this.security_rdt.Name = "security_rdt";
            this.security_rdt.Size = new System.Drawing.Size(71, 17);
            this.security_rdt.TabIndex = 3;
            this.security_rdt.TabStop = true;
            this.security_rdt.Text = "Security";
            this.security_rdt.UseVisualStyleBackColor = false;
            this.security_rdt.CheckedChanged += new System.EventHandler(this.security_rtn_CheckedChanged);
            // 
            // cope_gbx
            // 
            this.cope_gbx.BackColor = System.Drawing.Color.Transparent;
            this.cope_gbx.Controls.Add(this.universal_rdt);
            this.cope_gbx.Controls.Add(this.global_rdt);
            this.cope_gbx.Controls.Add(this.domainLocal_rdt);
            this.cope_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cope_gbx.Location = new System.Drawing.Point(21, 126);
            this.cope_gbx.Name = "cope_gbx";
            this.cope_gbx.Size = new System.Drawing.Size(197, 132);
            this.cope_gbx.TabIndex = 4;
            this.cope_gbx.TabStop = false;
            this.cope_gbx.Text = "Groupe Scope";
            // 
            // universal_rdt
            // 
            this.universal_rdt.AutoSize = true;
            this.universal_rdt.BackColor = System.Drawing.Color.LightGray;
            this.universal_rdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.universal_rdt.Location = new System.Drawing.Point(26, 96);
            this.universal_rdt.Name = "universal_rdt";
            this.universal_rdt.Size = new System.Drawing.Size(78, 17);
            this.universal_rdt.TabIndex = 2;
            this.universal_rdt.TabStop = true;
            this.universal_rdt.Text = "Universal";
            this.universal_rdt.UseVisualStyleBackColor = true;
            // 
            // global_rdt
            // 
            this.global_rdt.AutoSize = true;
            this.global_rdt.BackColor = System.Drawing.Color.LightGray;
            this.global_rdt.Checked = true;
            this.global_rdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.global_rdt.Location = new System.Drawing.Point(26, 63);
            this.global_rdt.Name = "global_rdt";
            this.global_rdt.Size = new System.Drawing.Size(61, 17);
            this.global_rdt.TabIndex = 1;
            this.global_rdt.TabStop = true;
            this.global_rdt.Text = "Global";
            this.global_rdt.UseVisualStyleBackColor = true;
            // 
            // domainLocal_rdt
            // 
            this.domainLocal_rdt.AutoSize = true;
            this.domainLocal_rdt.BackColor = System.Drawing.Color.LightGray;
            this.domainLocal_rdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.domainLocal_rdt.Location = new System.Drawing.Point(26, 30);
            this.domainLocal_rdt.Name = "domainLocal_rdt";
            this.domainLocal_rdt.Size = new System.Drawing.Size(102, 17);
            this.domainLocal_rdt.TabIndex = 0;
            this.domainLocal_rdt.TabStop = true;
            this.domainLocal_rdt.Text = "Domain Local";
            this.domainLocal_rdt.UseVisualStyleBackColor = true;
            // 
            // desc_txt
            // 
            this.desc_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.desc_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.desc_txt.Location = new System.Drawing.Point(124, 82);
            this.desc_txt.Mandatory = false;
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.Size = new System.Drawing.Size(239, 20);
            this.desc_txt.TabIndex = 3;
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.BackColor = System.Drawing.Color.LightGray;
            this.desc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.desc_lbl.Location = new System.Drawing.Point(18, 85);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(79, 13);
            this.desc_lbl.TabIndex = 2;
            this.desc_lbl.Text = "Description :";
            // 
            // name_txt
            // 
            this.name_txt.ErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.name_txt.Location = new System.Drawing.Point(124, 38);
            this.name_txt.Mandatory = true;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(167, 20);
            this.name_txt.TabIndex = 1;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.BackColor = System.Drawing.Color.LightGray;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.name_lbl.Location = new System.Drawing.Point(18, 41);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(85, 13);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Group Name :";
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.LightGray;
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ok_btn.Location = new System.Drawing.Point(300, 292);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = "Save";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.LightGray;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.Location = new System.Drawing.Point(214, 292);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // memberof_btn
            // 
            this.memberof_btn.BackColor = System.Drawing.Color.LightGray;
            this.memberof_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.memberof_btn.Location = new System.Drawing.Point(33, 292);
            this.memberof_btn.Name = "memberof_btn";
            this.memberof_btn.Size = new System.Drawing.Size(75, 23);
            this.memberof_btn.TabIndex = 4;
            this.memberof_btn.Text = "MemberOf";
            this.memberof_btn.UseVisualStyleBackColor = true;
            this.memberof_btn.Click += new System.EventHandler(this.memberof_btn_Click);
            // 
            // members_btn
            // 
            this.members_btn.BackColor = System.Drawing.Color.LightGray;
            this.members_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.members_btn.Location = new System.Drawing.Point(119, 292);
            this.members_btn.Name = "members_btn";
            this.members_btn.Size = new System.Drawing.Size(75, 23);
            this.members_btn.TabIndex = 3;
            this.members_btn.Text = "Members";
            this.members_btn.UseVisualStyleBackColor = true;
            this.members_btn.Click += new System.EventHandler(this.members_btn_Click);
            // 
            // ADGroupUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 327);
            this.Controls.Add(this.memberof_btn);
            this.Controls.Add(this.members_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.info_gbx);
            this.Name = "ADGroupUpdate";
            this.Text = "Active Directory Group";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADGroupUpdate_FormClosing);
            this.Load += new System.EventHandler(this.ADGroupUpdate_Load);
            this.info_gbx.ResumeLayout(false);
            this.info_gbx.PerformLayout();
            this.type_gbx.ResumeLayout(false);
            this.type_gbx.PerformLayout();
            this.cope_gbx.ResumeLayout(false);
            this.cope_gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Abyss_Client.CompBase.BaseGroupBox info_gbx;
        private Abyss_Client.CompBase.BaseLabel name_lbl;
        private Abyss_Client.CompBase.BaseTextBox name_txt;
        private Abyss_Client.CompBase.BaseTextBox desc_txt;
        private Abyss_Client.CompBase.BaseLabel desc_lbl;
        private Abyss_Client.CompBase.BaseGroupBox type_gbx;
        private Abyss_Client.CompBase.BaseGroupBox cope_gbx;
        private Abyss_Client.CompBase.BaseRadioButton universal_rdt;
        private Abyss_Client.CompBase.BaseRadioButton global_rdt;
        private Abyss_Client.CompBase.BaseRadioButton domainLocal_rdt;
        private Abyss_Client.CompBase.BaseRadioButton distribution_rdt;
        private Abyss_Client.CompBase.BaseRadioButton security_rdt;
        private Abyss_Client.CompBase.BaseButton ok_btn;
        private Abyss_Client.CompBase.BaseButton cancel_btn;
        private Abyss_Client.CompBase.BaseButton memberof_btn;
        private Abyss_Client.CompBase.BaseButton members_btn;
    }
}