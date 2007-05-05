using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence {
    [Serializable()]public class OracleTableData {
        #region Attributs
        private String tableName;
        private String tableOwner;
        private Array tableNameRows;
        private Array tableTypeRows;
        #endregion

        #region Constructors
        public OracleTableData() {
        }
        #endregion

        #region Properties        
        public String TableName {
            get { return tableName; }
            set { tableName = value; }
        }

        public String TableOwner {
            get { return tableOwner; }
            set { tableOwner = value; }
        }

        public Array TableNameRows {
            get { return tableNameRows; }
            set { tableNameRows = value; }
        }
        
        public Array TableTypeRows {
            get { return tableTypeRows; }
            set { tableTypeRows = value; }
        }
	    #endregion
    }
}
