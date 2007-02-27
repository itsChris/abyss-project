using System;
using DAO;
using System.DirectoryServices;

namespace Business {
    public class LDAP {
        #region Attributes
        private static LDAP instance = null;
        private DirectoryEntry entry = null;
        #endregion

        #region Properties
        public DirectoryEntry Entry {
            get { return entry; }
        }
        #endregion

        #region Constructor
        private LDAP(string path, string username, string password) {
            entry = LdapDAO.getLdapConnection(path, username, password);
        }

        private LDAP(string username, string password) {
            entry = LdapDAO.getLdapConnection(username, password);
        }
        #endregion

        #region Static Methods
        public static LDAP getInstance(string path, string username, string password) {
            if (instance == null) {
                instance = new LDAP(path, username, password);
            }
            return instance;
        }
        
        public static LDAP getInstance(string username, string password) {
            if (instance == null) {
                instance = new LDAP(username, password);
            }
            return instance;
        }
        #endregion

        #region Public Methods
        public void setInitToFalse() {
            LdapDAO.setInitToFalse();
            instance = null;
            entry = null;
        }
        #endregion
    }
}
