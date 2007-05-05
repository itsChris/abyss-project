using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using Persistence;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Business {
    public class OracleTable {

        #region Attributes
        private OracleTableData oracleTableData;
        #endregion

        #region Constructors
        public OracleTable() {
            this.oracleTableData = new OracleTableData();
        }

        public OracleTable(OracleTableData oracleTableData) {
            this.oracleTableData = oracleTableData;
        }
        #endregion

        #region Public Methods
        public void save(){
            OracleTableDAO.SaveTable(this.oracleTableData);
        }

        public OracleDataReader GetTable() {
            return OracleTableDAO.GetTable();
        }

        public void delete() {
            OracleTableDAO.DeleteTable(this.oracleTableData);
        }
        #endregion

        #region Properties
        public String TableName {
            get { return oracleTableData.TableName; }
            set { oracleTableData.TableName = value; }
        }

        public String TableOwner {
            get { return oracleTableData.TableOwner; }
            set { oracleTableData.TableOwner = value; }
        }

        public Array TableNameRows {
            get { return oracleTableData.TableNameRows; }
            set { oracleTableData.TableNameRows = value; }
        }

        public Array TableTypeRows {
            get { return oracleTableData.TableTypeRows; }
            set { oracleTableData.TableTypeRows = value; }
        }
        #endregion
    }
}
