using System;
using Business;
using Persistence;
using System.Windows.Forms;

namespace Abyss_Client {
    public partial class ADGroupUpdate : CompBase.BaseForm {
        #region Attributes
        private ADGroup adGroup;
        private bool update = false;
        #endregion

        #region Constructors
        public ADGroupUpdate() {
            InitializeComponent();
            this.adGroup = new ADGroup();
        }

        public ADGroupUpdate(ADGroup adGroup) {
            InitializeComponent();
            this.adGroup = adGroup;
            update = true;
        }
        #endregion

        #region Component Events 
        private void ADGroupUpdate_Load(object sender, EventArgs e) {
            initFormData();
        }

        private void security_rtn_CheckedChanged(object sender, EventArgs e) {
            universal_rdt.Enabled = false;
            if (universal_rdt.Checked) {
                global_rdt.Checked = true;
            }
        }

        private void distribution_rtn_CheckedChanged(object sender, EventArgs e) {
            universal_rdt.Enabled = true;
        }

        private void ok_btn_Click(object sender, EventArgs e) {
            if (checkMandatoryFields()) {
                ADGroup group = ADGroup.getGroupByName(name_txt.Text);
                if (group != null && update!= true) {
                    MessageBox.Show("This group already exist", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                adGroup.Name = name_txt.Text;
                adGroup.Description = desc_txt.Text;
                if (global_rdt.Checked) {
                    adGroup.Scope = ADGroupData.GroupeScope.Global;
                }
                else if (domainLocal_rdt.Checked) {
                    adGroup.Scope = ADGroupData.GroupeScope.DomainLocal;
                }
                else {
                    adGroup.Scope = ADGroupData.GroupeScope.Universel;
                }
                if (security_rdt.Checked) {
                    adGroup.SecurityGroupe = true;
                }
                else {
                    adGroup.SecurityGroupe = false;
                }
                adGroup.save();
                dialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void members_btn_Click(object sender, EventArgs e) {
            ADMembers members = new ADMembers(adGroup);
            if (openForm(members) == DialogResult.OK) {
                adGroup.Members = members.List;
            }
        }

        private void memberof_btn_Click(object sender, EventArgs e) {
            ADMemberOf memberof = new ADMemberOf(adGroup);
            if (openForm(memberof) == DialogResult.OK) {
                adGroup.Memberof = memberof.List;
            }
        }

        private void ADGroupUpdate_FormClosing(object sender, FormClosingEventArgs e) {
            if (dialogResult != DialogResult.OK) {
                if (MessageBox.Show("Do you want to quit ?",
                this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Private Methods
        private void initFormData() {
            name_txt.Text = adGroup.Name;
            desc_txt.Text = adGroup.Description;
            if (adGroup.Scope == ADGroupData.GroupeScope.DomainLocal) {
                domainLocal_rdt.Checked = true;
            }
            else if (adGroup.Scope == ADGroupData.GroupeScope.Global) {
                global_rdt.Checked = true;
            }
            else {
                universal_rdt.Checked = true;
            }
            if (adGroup.SecurityGroupe) {
                security_rdt.Checked = true;
            }
            else {
                distribution_rdt.Checked = true;
            }
            members_btn.Enabled = false;
            memberof_btn.Enabled = false;
            if (update) {
                name_txt.Enabled = false;
                domainLocal_rdt.Enabled = false;
                global_rdt.Enabled = false;
                universal_rdt.Enabled = false;
                security_rdt.Enabled = false;
                distribution_rdt.Enabled = false;
                memberof_btn.Enabled = true;
                members_btn.Enabled = true;
            }
            if (adGroup.Scope == ADGroupData.GroupeScope.DomainLocal) {
                memberof_btn.Enabled = false;
            }
        }
        #endregion
    }
}