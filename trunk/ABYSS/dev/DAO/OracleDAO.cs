using System;
using Oracle.DataAccess.Client;
using System.Configuration;
using System.Data;

namespace DAO {
    public class OracleDAO {
        #region Attributes
        private static OracleConnection instance = null;
        #endregion

        #region Constructors
        /// <summary>
        /// Protected Singleton
        /// </summary>
        protected OracleDAO() { }
        #endregion

        #region Static Methods
        public static OracleConnection getInstance() {
            if (instance == null) {
                instance = new OracleConnection(ConfigurationManager.ConnectionStrings["OraConnect"].ConnectionString);
            }
            return instance;
        }
        #endregion
    }
}
