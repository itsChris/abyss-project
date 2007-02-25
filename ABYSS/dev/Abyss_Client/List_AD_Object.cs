using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abyss_Client
{
    public partial class List_AD_Object : CompBase.BaseForm
    {
        public List_AD_Object()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure to Quit this programs ?", "Exit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (response == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}