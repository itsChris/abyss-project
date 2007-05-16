using System;
using Business;
using Persistence;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Abyss_Client {
    public partial class ADComputerUpdate : CompBase.BaseForm {
        #region Attributes
        private ADComputer adComputer;
        private bool update = false;
        #endregion

        #region Constructor
        public ADComputerUpdate() {
            InitializeComponent();
            this.adComputer = new ADComputer();
        }

        public ADComputerUpdate(ADComputer adComputer) {
            InitializeComponent();
            this.adComputer = adComputer;
            update = true;
        }
        #endregion

        #region Component Events
        private void trust_cbx_Click(object sender, EventArgs e) {
            MessageBox.Show("This option allow the computer for delegation. Trusting for delegation is a security-sensitive operation. It should not be done indiscriminaely",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void MemberOf_btn_Click(object sender, EventArgs e) {
            ADMemberOf memberOf = new ADMemberOf(adComputer);
            if (openForm(memberOf) == DialogResult.OK) {
                adComputer.Memberof = memberOf.List;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e) {
            if (checkMandatoryFields()) {
                try {
                    ADComputer computer = ADComputer.getComputerByName(cpuName_txt.Text.ToUpper());
                    if (computer != null && update == false) {
                        MessageBox.Show("This computer already exist", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    adComputer.ComputerName = cpuName_txt.Text.ToUpper();
                    adComputer.Description = desc_txt.Text;
                    adComputer.DnsName = dns_txt.Text;
                    adComputer.Role = ADComputerData.Computer.WORKSTATION_TRUST_ACCOUNT;
                    if (server_cbx.Checked) {
                        adComputer.Role = ADComputerData.Computer.SERVER_TRUST_ACCOUNT;
                    }
                    adComputer.TrustForDelegation = trust_cbx.Checked;
                    adComputer.OperatingSystem = systemName_txt.Text;
                    adComputer.OperatingSystemVersion = version_txt.Text;
                    adComputer.OperatingSystemServicePack = pack_txt.Text;
                    if (!update) {
                        adComputer.Enabled = true;
                    }
                    adComputer.save();
                    dialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (COMException comex) {
                    MessageBox.Show(comex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void ADComputerUpdate_Load(object sender, EventArgs e) {
            initFormData();
        }

        private void ADComputerUpdate_FormClosing(object sender, FormClosingEventArgs e) {
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
            cpuName_txt.Text = adComputer.ComputerName;
            desc_txt.Text = adComputer.Description;
            dns_txt.Text = adComputer.DnsName;
            systemName_txt.Text = adComputer.OperatingSystem;
            version_txt.Text = adComputer.OperatingSystemVersion;
            pack_txt.Text = adComputer.OperatingSystemServicePack;
            MemberOf_btn.Enabled = false;
            if (update) {
                server_cbx.Enabled = false;
                MemberOf_btn.Enabled = true;
                cpuName_txt.Enabled = false;
                if (adComputer.Role == ADComputerData.Computer.WORKSTATION_TRUST_ACCOUNT) {
                    role_txt.Text = "Workstation or server";
                }
                else {
                    role_txt.Text = "Domain controller";
                    server_cbx.Checked = true;
                }
            }
            if (adComputer.TrustForDelegation) {
                trust_cbx.Checked = true;
            }
        }
        #endregion
    }
}