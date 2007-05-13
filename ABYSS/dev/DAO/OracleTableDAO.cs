using System;
using System.Collections.Generic;
using System.Text;
using Persistence;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using System.Collections;

namespace DAO {
    public class OracleTableDAO : OracleDAO {
        #region Public Static Methods
        public static ArrayList GetTables() {
            string query = "SELECT TABLE_NAME FROM USER_TABLES ORDER BY TABLE_NAME";
            OracleDataReader reader = ExecuteReader(query);
            ArrayList list = new ArrayList();
            if (reader != null) {
                while (reader.Read()) {
                    OracleTableData oracleTableData = GetTableDataStructure(reader.GetValue(0).ToString());
                    list.Add(oracleTableData);
                }
                reader.Close();
                return list;
            }
            return null;
        }

        public static OracleTableData GetTableDataStructure(string tableName) {
            string query = "SELECT column_name, data_type, data_length, null FROM all_tab_columns WHERE table_name='" + tableName + "'";
            OracleDataReader reader = ExecuteReader(query);
            if (reader != null) {
                OracleTableData tableData = new OracleTableData();
                tableData.TableName = tableName;
                while (reader.Read()) {
                    tableData.TableNameRows.Add(reader.GetValue(0));
                    tableData.TableTypeRows.Add(reader.GetValue(1) + "(" + reader.GetValue(2) + ")");
                    if (reader.GetValue(3).ToString() == "Y") {
                        tableData.TableNull.Add("NULL");
                    }
                    else {
                        tableData.TableNull.Add("NOT NULL");
                    }
                }
                reader.Close();
                reader = OracleTableDAO.GetPK(tableName);
                if (reader != null) {
                    while (reader.Read()) {
                        tableData.TablePK = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                    return tableData;
                }
            }
            return null;  
        }

        public static OracleDataReader GetPK(string tableName) {
            string query = "SELECT CONSTRAINT_NAME FROM ALL_CONSTRAINTS WHERE CONSTRAINT_TYPE='P' AND TABLE_NAME='" + tableName + "'";
            return ExecuteReader(query);
        }

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
                    query += " CONSTRAINT "+table.TableName[i]+"_nn NOT NULL";
                }                
            }
            query += ", CONSTRAINT " + table.TableName + "_" + table.TablePK + "_pk PRIMARY KEY (" + table.TablePK + ")";
            query += ")";

            ExecuteNonQuery(query);
        }

        public static void DeleteTable(OracleTableData table) {
            string query = "DROP TABLE " + table.TableName + " CASCADE CONSTRAINTS";
            ExecuteNonQuery(query);
        }

        public static void EditTableName(OracleTableData table, string newName) {
            string query = "ALTER TABLE " + table.TableName + " RENAME TO " + newName;
            ExecuteNonQuery(query);
        }  
        #endregion
    }
}
