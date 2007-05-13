using System;
using Business;
using System.Windows.Forms;

namespace Abyss_Client {
    public partial class OracleViewAdd : CompBase.BaseForm {
        private OracleView oracleView;

        public OracleViewAdd() {
            InitializeComponent();
            this.oracleView = new OracleView();
        }

        public OracleViewAdd(OracleView oracleView) {
            InitializeComponent();
            this.oracleView = oracleView;
        }
    }
}