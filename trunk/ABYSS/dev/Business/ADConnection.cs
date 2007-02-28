using System;
using DAO;
using System.DirectoryServices;

namespace Business {
    public class ADConnection {
        #region Attributes
        private static ADConnection instance = null;
        private DirectoryEntry entry = null;
        #endregion

        #region Properties
        public DirectoryEntry Entry {
            get { return entry; }
        }
        #endregion

        #region Constructor
        private ADConnection(string path, string username, string password) {
            entry = LdapDAO.getLdapConnection(path, username, password);
        }

        private ADConnection(string username, string password) {
            entry = LdapDAO.getLdapConnection(username, password);
        }
        #endregion

        #region Static Methods
        public static ADConnection getInstance(string path, string username, string password) {
            if (instance == null) {
                instance = new ADConnection(path, username, password);
            }
            return instance;
        }
        
        public static ADConnection getInstance(string username, string password) {
            if (instance == null) {
                instance = new ADConnection(username, password);
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
