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
        public string ViewQuery {
            get { return oracleViewData.ViewQuery; }
            set { oracleViewData.ViewQuery = value; }
        }
        #endregion

        #region Public Methods
        public void save() {
            OracleViewDAO.SaveView(this.oracleViewData);
        }

        public void delete() {
            OracleViewDAO.DeleteView(this.oracleViewData);
        }

        public void update() {
            OracleViewDAO.EditView(this.oracleViewData);
        }
        #endregion

        #region Static Methods
        public static ArrayList GetViews() {
            return OracleViewDAO.GetViews();
        }

        public static OracleView GetView(string viewName) {
            OracleViewData viewData = OracleViewDAO.GetView(viewName);
            if (viewData != null) {
                return new OracleView(viewData);
            }
            return null;
        }
        #endregion
    }
}
