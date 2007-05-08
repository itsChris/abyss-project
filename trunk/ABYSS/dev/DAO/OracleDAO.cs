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
                instance.Open();
            }
            return instance;
        }
        #endregion

        #region Protect Methods
        protected static void ExecuteNonQuery(string query) {
            OracleCommand cmd = getInstance().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        protected static OracleDataReader ExecuteReader(string query) {
            OracleCommand cmd = getInstance().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            OracleDataReader reader = cmd.ExecuteReader();
            cmd.Dispose();
            return reader;
        }
        #endregion
    }
}
