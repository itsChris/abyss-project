using System;
using System.Collections.Generic;
using System.Text;
using Persistence;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace DAO {
    public class OracleTableDAO : OracleDAO {
        #region Public Static Methods
        public static void SaveTable(OracleTableData table) {
            string query = "CREATE TABLE " + table.TableName + " (";
            for (int i = 0; i < table.TableNameRows.Length; i++) {
                if (i == 0) {
                    query += table.TableNameRows.GetValue(i) + " " + table.TableTypeRows.GetValue(i);
                }
                else {
                    query += ", " + table.TableNameRows.GetValue(i) + " " + table.TableTypeRows.GetValue(i);
                }
            }
            query += ")";

            ExecuteNonQuery(query);
        }

        public static void DeleteTable(OracleTableData table) {
            string query = "DROP TABLE " + table.TableOwner + "." + table.TableName + " CASCADE CONSTRAINTS";
        }

        public static OracleDataReader GetTable() {
            string query = "SELECT TABLE_NAME FROM  DBA_TABLES ORDER BY TABLE_NAME";
            return ExecuteReader(query);
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
