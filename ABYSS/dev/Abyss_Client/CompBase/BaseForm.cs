using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Abyss_Client.CompBase {
    public partial class BaseForm : Form {
        public BaseForm() {
            InitializeComponent();
        }

        public DialogResult openForm(BaseForm form){
            this.Hide();
            form.ShowDialog();
            this.Show();
            return form.DialogResult;
        }
    }
}
