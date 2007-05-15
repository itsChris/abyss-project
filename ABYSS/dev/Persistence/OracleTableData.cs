using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Persistence {
    [Serializable()]public class OracleTableData {
        #region Attributs
        private String tableName;
        private ArrayList tableNameRows;
        private ArrayList tableTypeRows;
        private ArrayList tableNull;
        private ArrayList tableNewRows;
        private ArrayList tableEditRows;
        private String tablePK;
        #endregion

        #region Constructors
        public OracleTableData() {
            this.TableNameRows = new ArrayList();
            this.TableNull = new ArrayList();
            this.TableTypeRows = new ArrayList();
            this.TableNewRows = new ArrayList();
            this.TableEditRows = new ArrayList();
            this.TablePK = String.Empty;
        }
        #endregion

        #region Properties
        public String TableName {
            get { return tableName; }
            set { tableName = value; }
        }

        public ArrayList TableNameRows {
            get { return tableNameRows; }
            set { tableNameRows = value; }
        }

        public ArrayList TableTypeRows {
            get { return tableTypeRows; }
            set { tableTypeRows = value; }
        }

        public ArrayList TableNull {
            get { return tableNull; }
            set { tableNull = value; }
        }

        public ArrayList TableNewRows {
            get { return tableNewRows; }
            set { tableNewRows = value; }
        }

        public ArrayList TableEditRows {
            get { return tableEditRows; }
            set { tableEditRows = value; }
        }

        public String TablePK {
            get { return tablePK; }
            set { tablePK = value; }
        }
	    #endregion
    }
}
