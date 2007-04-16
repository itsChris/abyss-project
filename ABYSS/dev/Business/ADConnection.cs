using System;
using DAO;
using System.DirectoryServices;

namespace Business {
    public class ADConnection {
        #region Attributes
        private static DirectoryEntry instance = null;
        #endregion

        #region Constructor
        private ADConnection(string path, string username, string password) {
            LdapDAO.setLdapConnection(path, username, password);
        }

        private ADConnection(string username, string password) {
            LdapDAO.setLdapConnection(username, password);
        }
        #endregion

        #region Static Methods
        public static DirectoryEntry getInstance(string path, string username, string password) {
            if (instance == null) {
                new ADConnection(path, username, password);
                instance = LdapDAO.getInstance();
            }
            return instance;
        }

        public static DirectoryEntry getInstance(string username, string password) {
            if (instance == null) {
                new ADConnection(username, password);
                instance = LdapDAO.getInstance();
            }
            return instance;
        }

        public static void setInitToFalse() {
            LdapDAO.setInitToFalse();
            instance = null;
        }
        #endregion
    }
}
