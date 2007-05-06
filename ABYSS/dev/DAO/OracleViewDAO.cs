using System;
using System.Collections.Generic;
using System.Text;
using Persistence;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace DAO {
    public class OracleViewDAO : OracleDAO {
        #region public static methods
        public static void SaveView(OracleViewData view) {
        
        }

        public static void DeleteView(OracleViewData view) {

        }

        public static OracleDataReader GetView() {

        }

        public static void ExecuteNonQuery(string query) {
            OracleCommand cmd = getInstance().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static OracleDataReader ExecuteReader(string query) {
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
