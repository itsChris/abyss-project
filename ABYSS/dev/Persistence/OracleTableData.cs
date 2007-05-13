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
        private String tablePK;
        #endregion

        #region Constructors
        public OracleTableData() {
            this.TableNameRows = new ArrayList();
            this.TableNull = new ArrayList();
            this.TableTypeRows = new ArrayList();
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

        public String TablePK {
            get { return tablePK; }
            set { tablePK = value; }
        }
	    #endregion
    }
}
