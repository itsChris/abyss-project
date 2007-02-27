using System;
using DAO;
using System.DirectoryServices;

namespace Business {
    public class LDAP {
        #region Static Methods
        public static DirectoryEntry Ldap(string path, string username, string password) {
            return LdapDAO.getLdapConnection(path, username, password);
        }

        public static DirectoryEntry Ldap(string username, string password) {
            return LdapDAO.getLdapConnection(username, password);
        }
        #endregion
    }
}
