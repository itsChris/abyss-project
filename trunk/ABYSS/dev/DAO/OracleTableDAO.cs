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
            string query = "SELECT column_name, data_type, data_length, nullable FROM user_tab_columns WHERE table_name='" + tableName + "'";
            OracleDataReader reader = ExecuteReader(query);
            if (reader != null) {
                OracleTableData tableData = new OracleTableData();
                tableData.TableName = tableName;
                while (reader.Read()) {
                    tableData.TableNameRows.Add(reader.GetValue(0));
                    if (reader.GetValue(1).Equals("VARCHAR2")) {
                        tableData.TableTypeRows.Add(reader.GetValue(1) + "(" + reader.GetValue(2) + ")");
                    }
                    else {
                        tableData.TableTypeRows.Add(reader.GetValue(1));
                    }
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
            string query = "SELECT CONSTRAINT_NAME FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE='P' AND TABLE_NAME='" + tableName + "'";
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
                    query += " CONSTRAINT " + table.TableNameRows[i] + "_nn NOT NULL";
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

        public static void DeleteConstraint(OracleTableData table, int index) {
            try {
                string query = "ALTER TABLE " + table.TableName + " drop CONSTRAINT " + table.TableNameRows[index] + "_nn";
                ExecuteNonQuery(query);
            }
            catch (OracleException) {
            }
        }

        public static void UpdateTable(OracleTableData table) {
            if (table.TableEditRows.Count > 0) {
                EditTableRows(table);
            }
            if (table.TableNewRows.Count > 0) {
                AddTableRows(table);
            }
        }

        public static void EditTableName(OracleTableData table, string newName) {
            string query = "ALTER TABLE " + table.TableName + " RENAME TO " + newName;
            ExecuteNonQuery(query);
        }

        public static void AddTableRows(OracleTableData table) {
            int index = 0;
            string query = "ALTER TABLE " + table.TableName + " ADD (";

            for (int i = 0; i < table.TableNewRows.Count; i++) {
                index=Convert.ToInt32(table.TableNewRows[i].ToString());
                if (i == 0) {
                    query += table.TableNameRows[index] + " " + table.TableTypeRows[index];
                }
                else {
                    query += ", " + table.TableNameRows[index] + " " + table.TableTypeRows[index];
                }

                if(table.TableNull[index].ToString()=="NOT NULL"){
                    query += " CONSTRAINT " + table.TableNameRows[index] + "_nn NOT NULL";
                }
            }

            query += ")";

            ExecuteNonQuery(query);
        }

        public static void EditTableRows(OracleTableData table) {
            int index = 0;
            string query = "ALTER TABLE " + table.TableName + " MODIFY (";

            for (int i = 0; i < table.TableEditRows.Count; i++) {
                index = Convert.ToInt32(table.TableEditRows[i].ToString());
                if (i == 0) {
                    query += table.TableNameRows[index] + " " + table.TableTypeRows[index];
                }
                else {
                    query += ", " + table.TableNameRows[index] + " " + table.TableTypeRows[index];
                }

                OracleTableData tableData = GetTableDataStructure(table.TableName);

                if (table.TableNull[index] != tableData.TableNull[index]) {
                    if (table.TableNull[index].ToString() == "NOT NULL") {
                        query += " CONSTRAINT " + table.TableNameRows[index] + "_nn NOT NULL";
                    }
                    else {
                        DeleteConstraint(table, index);
                    }
                }
            }

            query += ")";

            ExecuteNonQuery(query);
        }
        #endregion
    }
}
