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
            string query = "CREATE OR REPLACE VIEW " + view.ViewSchema + "." + view.ViewName + " AS " + view.ViewQuery;

            ExecuteNonQuery(query);
        }

        public static void DeleteView(OracleViewData view) {

        }

        public static OracleDataReader GetView() {
            return null;
        }     
        #endregion
    }
}
