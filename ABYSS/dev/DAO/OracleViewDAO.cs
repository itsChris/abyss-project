using System;
using System.Collections.Generic;
using System.Text;
using Persistence;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using System.Collections;

namespace DAO {
    public class OracleViewDAO : OracleDAO {
        #region public static methods
        public static void SaveView(OracleViewData view) {
            string query = "CREATE VIEW " + view.ViewName + " AS " + view.ViewQuery;

            ExecuteNonQuery(query);
        }

        public static void EditView(OracleViewData view) {
            string query = "CREATE OR REPLACE VIEW " + view.ViewName + " AS " + view.ViewQuery;

            ExecuteNonQuery(query);
        }

        public static void DeleteView(OracleViewData view) {
            string query = "DROP VIEW " + view.ViewName + " CASCADE";
            ExecuteNonQuery(query);
        }

        public static OracleViewData GetView(string viewName) {
            string query = "SELECT VIEW_NAME, TEXT FROM USER_VIEWS WHERE VIEW_NAME='" + viewName + "'";

            OracleDataReader reader = ExecuteReader(query);
            if (reader != null) {
                OracleViewData oracleViewData = new OracleViewData();
                while (reader.Read()) {
                    oracleViewData.ViewName = (string)reader.GetValue(0);
                    oracleViewData.ViewQuery = (string)reader.GetValue(1);                    
                }
                reader.Close();
                return oracleViewData;
            }
            return null;
        }

        public static ArrayList GetViews() {
            string query = "SELECT VIEW_NAME FROM USER_VIEWS ORDER BY VIEW_NAME";
            OracleDataReader reader = ExecuteReader(query);
            ArrayList list = new ArrayList();
            if (reader != null) {
                while (reader.Read()) {
                    OracleViewData viewData = GetView(reader.GetValue(0).ToString());
                    list.Add(viewData);
                }
                reader.Close();
                return list;
            }
            return null;
        }
        #endregion
    }
}
