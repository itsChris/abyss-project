using System;
using DAO;
using Persistence;
using System.Collections;

namespace Business {
    public class OracleView {
        #region Attributes
        private OracleViewData oracleViewData;
        #endregion

        #region Constructors
        public OracleView() {
            this.oracleViewData = new OracleViewData();
            this.oracleViewData.ViewSchema = String.Empty;
            this.oracleViewData.ViewName = String.Empty;
            this.oracleViewData.ViewQuery = String.Empty;
        }

        public OracleView(OracleViewData oracleViewData) {
            this.oracleViewData = oracleViewData;
        }
        #endregion

        #region Properties
        public string ViewName {
            get { return oracleViewData.ViewName; }
            set { oracleViewData.ViewName = value; }
        }
        public string ViewSchema {
            get { return oracleViewData.ViewSchema; }
            set { oracleViewData.ViewSchema = value; }
        }
        public string ViewQuery {
            get { return oracleViewData.ViewQuery; }
            set { oracleViewData.ViewQuery = value; }
        }
        #endregion

        #region Public Methods
        public void save() {
            OracleViewDAO.SaveView(this.oracleViewData);
        }
        #endregion
    }
}
