using System;
using Utils;
using System.DirectoryServices;

namespace DAO {
    public class LdapDAO {
        #region Attributes
        private static DirectoryEntry root = null; // the current connection
        #endregion

        #region Properties
        public static DirectoryEntry Root{
            get { return root; }
            set { root = value; }
        }
        #endregion

        #region Static Methods
        public static DirectoryEntry getLdapConnection(string path, string username, string password) {
            root = Utility.connection(path, username, password);
            return root;
        }

        public static DirectoryEntry getLdapConnection(string username, string password){
            root = Utility.connection(username,password);
            return root;
        }
        #endregion
    }
}
