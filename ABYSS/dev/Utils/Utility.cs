using System;
using System.Collections.Generic;
using System.Text;
using System.DirectoryServices;

namespace Utils {
    public class Utility {
        #region Constants
        private const string protocolName = "LDAP://";
        private const string defaultDomainPath = "rootDSE";
        #endregion

        #region Enumerations
        internal enum loginResult {
            LOGIN_OK = 0,
            LOGIN_USER_DOESNT_EXIST,
            LOGIN_USER_ACCOUNT_INACTIVE
        }

        internal enum userStatus {
            Enable = 544,
            Disable = 546
        }

        internal enum groupScope {
            ADS_GROUP_TYPE_DOMAIN_LOCAL_GROUP = -2147483644,
            ADS_GROUP_TYPE_GLOBAL_GROUP = -2147483646,
            ADS_GROUP_TYPE_UNIVERSAL_GROUP = -2147483640
        }

        internal enum aDAccountOptions {
            UF_TEMP_DUPLICATE_ACCOUNT = 256,
            UF_NORMAL_ACCOUNT = 512,
            UF_INTERDOMAIN_TRUST_ACCOUNT = 2048,
            UF_WORKSTATION_TRUST_ACCOUNT = 4096,
            UF_SERVER_TRUST_ACCOUNT = 8192,
            UF_DONT_EXPIRE_PASSWD = 65536,
            UF_SCRIPT = 1,
            UF_ACCOUNTDISABLE = 2,
            UF_HOMEDIR_REQUIRED = 8,
            UF_LOCKOUT = 16,
            UF_PASSWD_NOTREQD = 32,
            UF_PASSWD_CANT_CHANGE = 64,
            UF_ACCOUNT_LOCKOUT = 16,
            UF_ENCRYPTED_TEXT_PASSWORD_ALLOWED = 128
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Return the root node
        /// </summary>
        /// <param name="path"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>DirectoryEntry</returns>
        public static DirectoryEntry getDirectoryObject(string path, string userName, string password) {
            DirectoryEntry directoryEntry = new DirectoryEntry(protocolName + path, userName, password, AuthenticationTypes.Secure);
            return directoryEntry;
        }

        /// <summary>
        /// Return the root node
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>DirectoryEntry</returns>
        public static DirectoryEntry getDirectoryObject(string userName, string password) {
            DirectoryEntry directoryEntryDSE = new DirectoryEntry(protocolName + defaultDomainPath);
            DirectoryEntry directoryEntry = new DirectoryEntry(protocolName + (string)directoryEntryDSE.Properties["defaultNamingContext"].Value, userName, password, AuthenticationTypes.Secure);
            return directoryEntry;
        }

        /// <summary>
        /// Return the node where the user has been found
        /// </summary>
        /// <param name="directoryEntry"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>DirectoryEntry</returns>
        public static DirectoryEntry getUser(DirectoryEntry directoryEntry, string userName, string password) {
            DirectorySearcher directorySearcher = new DirectorySearcher();
            directorySearcher.SearchRoot = directoryEntry;
            directorySearcher.Filter = "(&(objectClass=user)(sAMAccountName=" + userName + "))";
            directorySearcher.SearchScope = SearchScope.Subtree;
            SearchResult results = directorySearcher.FindOne();
            if (!(results == null)) {
                directoryEntry = new DirectoryEntry(results.Path, userName, password, AuthenticationTypes.Secure);
                return directoryEntry;
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Return the node where the group has been found
        /// </summary>
        /// <param name="directoryEntry"></param>
        /// <param name="groupName"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns>DirectoryEntry</returns>
        public static DirectoryEntry getGroup(DirectoryEntry directoryEntry, string groupName, string userName, string password) {
            DirectorySearcher directorySearcher = new DirectorySearcher();
            directorySearcher.SearchRoot = directoryEntry;
            directorySearcher.Filter = "(&(objectClass=group)(cn=" + groupName + "))";
            directorySearcher.SearchScope = SearchScope.Subtree;
            SearchResult results = directorySearcher.FindOne();
            if (!(results == null)) {
                directoryEntry = new DirectoryEntry(results.Path, userName, password, AuthenticationTypes.Secure);
                return directoryEntry;
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Return the node where the computer has been found
        /// </summary>
        /// <param name="directoryEntry"></param>
        /// <param name="computer"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static DirectoryEntry getComputer(DirectoryEntry directoryEntry, string computer, string userName, string password) {
            DirectorySearcher directorySearcher = new DirectorySearcher();
            directorySearcher.SearchRoot = directoryEntry;
            directorySearcher.Filter = "(&(objectClass=computer)(cn=" + computer + "))";
            directorySearcher.SearchScope = SearchScope.Subtree;
            SearchResult results = directorySearcher.FindOne();
            if (!(results == null)) {
                directoryEntry = new DirectoryEntry(results.Path, userName, password, AuthenticationTypes.Secure);
                return directoryEntry;
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Enable a user account
        /// </summary>
        /// <param name="directoryEntry"></param>
        public static void enableUserAccount(DirectoryEntry directoryEntry) {
            directoryEntry.Properties["userAccountControl"].Value = userStatus.Enable;
            directoryEntry.CommitChanges();
            directoryEntry.Close();
        }

        /// <summary>
        /// Disable a user account
        /// </summary>
        /// <param name="directoryEntry"></param>
        public static void disableUserAccount(DirectoryEntry directoryEntry) {
            directoryEntry.Properties["userAccountControl"].Value = userStatus.Disable;
            directoryEntry.CommitChanges();
            directoryEntry.Close();
        }

        /// <summary>
        /// Change a user password
        /// </summary>
        /// <param name="directoryEntry"></param>
        /// <param name="password"></param>
        public static void setUserPassword(DirectoryEntry directoryEntry, string password) {
            directoryEntry.Invoke("SetPassword", new object[] { password });
        }

        /// <summary>
        /// Check the account status
        /// </summary>
        /// <param name="userAccountControl"></param>
        /// <returns>bool</returns>
        public static bool isAccountActive(int userAccountControl) {
            int userAccountControl_Disabled = Convert.ToInt32(aDAccountOptions.UF_ACCOUNTDISABLE);
            int flagExists = userAccountControl & userAccountControl_Disabled;
            if (flagExists > 0) {
                return false;
            }
            else {
                return true;
            }
        }

        /// <summary>
        /// Return the object from the node By Distinguished Name
        /// </summary>
        /// <param name="ObjectPath"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>directoryEntry</returns>
        public static DirectoryEntry getDirectoryObjectByDistinguishedName(string objectPath, String userName, String password) {
            DirectoryEntry directoryEntry = new DirectoryEntry(objectPath, userName, password, AuthenticationTypes.Secure);
            return directoryEntry;
        }

        /// <summary>
        /// Set a propertie in an object
        /// </summary>
        /// <param name="directoryEntry"></param>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        public static void SetProperty(DirectoryEntry directoryEntry, string propertyName, string propertyValue) {
            if ((propertyValue != string.Empty) && (propertyValue != null)) {
                if (directoryEntry.Properties.Contains(propertyName)) {
                    directoryEntry.Properties[propertyName][0] = propertyValue;
                }
                else {
                    directoryEntry.Properties[propertyName].Add(propertyValue);
                }
            }
        }
       
        /// <summary>
        /// Get a propertie from an object
        /// </summary>
        /// <param name="directoryEntrey"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static string GetProperty(DirectoryEntry directoryEntrey, string propertyName) {
            if (directoryEntrey.Properties.Contains(propertyName)) {
                return directoryEntrey.Properties[propertyName][0].ToString();
            }
            else {
                return string.Empty;
            }
        }
        #endregion
    }
}
