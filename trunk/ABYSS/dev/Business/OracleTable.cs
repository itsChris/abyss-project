using System;
using DAO;
using Persistence;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Collections;

namespace Business {
    public class OracleTable {
        #region Attributes
        private OracleTableData oracleTableData;
        #endregion

        #region Constructors
        public OracleTable() {
            this.oracleTableData = new OracleTableData();
            this.oracleTableData.TableNameRows = new ArrayList();
            this.oracleTableData.TableNull = new ArrayList();
            this.oracleTableData.TableTypeRows = new ArrayList();
        }

        public OracleTable(OracleTableData oracleTableData) {
            this.oracleTableData = oracleTableData;
        }
        #endregion

        #region Public Methods
        public void save(int numberRows){
            OracleTableDAO.SaveTable(this.oracleTableData, numberRows);
        }

        public OracleDataReader GetTable() {
            return OracleTableDAO.GetTable();
        }

        public void delete() {
            OracleTableDAO.DeleteTable(this.oracleTableData);
        }

        public void EditName(string newName) {
            OracleTableDAO.EditTableName(this.oracleTableData, newName);
        }

        public OracleTable GetTableData(string tableName) {
            OracleDataReader reader = OracleTableDAO.GetTable(tableName);

            OracleTable table = new OracleTable();

            table.TableName = tableName;
                        
            while (reader.Read()) {
                table.TableNameRows.Add(reader.GetValue(0));

                table.TableTypeRows.Add(reader.GetValue(1) + "(" + reader.GetValue(2) + ")");
                if (reader.GetValue(3).ToString() == "Y") {
                    table.TableNull.Add("NULL");
                }
                else {
                    table.TableNull.Add("NOT NULL");
                }
            }
            reader.Dispose();

            reader = OracleTableDAO.GetPK(tableName);
            reader.Read();
            table.TablePK = reader.GetValue(0).ToString();
            reader.Dispose();

            return table;
        }
        #endregion

        #region Properties
        public String TableName {
            get { return oracleTableData.TableName; }
            set { oracleTableData.TableName = value; }
        }

        public ArrayList TableNameRows {
            get { return oracleTableData.TableNameRows; }
            set { oracleTableData.TableNameRows = value; }
        }

        public ArrayList TableTypeRows {
            get { return oracleTableData.TableTypeRows; }
            set { oracleTableData.TableTypeRows = value; }
        }

        public ArrayList TableNull {
            get { return oracleTableData.TableNull; }
            set { oracleTableData.TableNull = value; }
        }

        public String TablePK {
            get { return oracleTableData.TablePK; }
            set { oracleTableData.TablePK = value; }
        }
        #endregion
    }
}