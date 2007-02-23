using System;
using System.Collections.Generic;
using System.Text;
using Persistence;
using Utils;

namespace DAO {
    public class DAO {
        #region Attributes
        private static DAO instance;
        #endregion

        #region Constructors
        protected DAO() {
        }
        #endregion

        #region Properties
        public static DAO Instance {
            get {
                if (instance == null) {
                    instance = new DAO();
                }
                return instance;
            }
        }
        #endregion
    }
}
