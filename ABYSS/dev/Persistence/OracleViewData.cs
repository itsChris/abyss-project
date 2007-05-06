using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence {
    [Serializable()]public class OracleViewData {
        #region Attribut
        private string viewName;
        private string viewSchema;
        private string viewQuery;
        #endregion

        #region Constructors
        public OracleViewData() {
        }
        #endregion

        #region Properties
        public string ViewName {
            get { return viewName; }
            set { viewName = value; }
        }

        public string ViewSchema {
            get { return viewSchema; }
            set { viewSchema = value; }
        }

        public string ViewQuery {
            get { return viewQuery; }
            set { viewQuery = value; }
        }
        #endregion

    }
}
