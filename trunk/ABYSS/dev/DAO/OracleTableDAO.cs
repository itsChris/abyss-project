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
        public static void SaveTable(OracleTableData table, int numberRows) {
            string query = "CREATE TABLE " + table.TableName + " (";
            for (int i = 0; i < numberRows; i++) {
                if (i == 0) {
                    query += table.TableNameRows[i] + " " + table.TableTypeRows[i];
                }
                else {
                    query += ", " + table.TableNameRows[i] + " " + table.TableTypeRows[i];
                }
                if (table.TableNull[i].ToString() == "NOT NULL") {
                    query += "CONSTRAINT "+table.TableName[i]+"_nn NOT NULL";
                }                
            }
            query += "CONSTRAINT "+table.TablePK+"_pk PRIMARY KEY ("+table.TablePK+")";
            query += ")";

            ExecuteNonQuery(query);
        }

        public static void DeleteTable(OracleTableData table) {
            string query = "DROP TABLE " + table.TableOwner + "." + table.TableName + " CASCADE CONSTRAINTS";
        }

        public static void EditTableName(OracleTableData table, string newName) {
            string query = "ALTER TABLE " + table.TableName + " RENAME TO " + newName;
        }

        public static OracleDataReader GetTable() {
            string query = "SELECT TABLE_NAME FROM  DBA_TABLES ORDER BY TABLE_NAME";
            return ExecuteReader(query);
        }
        #endregion
    }
}
