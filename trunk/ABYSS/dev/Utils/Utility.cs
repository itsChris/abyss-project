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

        #region Attributes
        private static string crtDomain;
        private static string crtUserName;
        private static string crtPassword;
        #endregion

        #region Properties
        public static string CrtDomain {
            get { return Utility.crtDomain; }
            set { Utility.crtDomain = value; }
        }
        
        public static string CrtUserName {
            get { return Utility.crtUserName; }
            set { Utility.crtUserName = value; }
        }
        
        public static string CrtPassword {
            get { return Utility.crtPassword; }
            set { Utility.crtPassword = value; }
        }
        #endregion

        #region Enumerations
        public enum loginResult {
            LOGIN_OK = 0,
            LOGIN_USER_DOESNT_EXIST,
            LOGIN_USER_ACCOUNT_INACTIVE
        }

        public enum userStatus {
            Enable = 544,
            Disable = 546
        }

        public enum groupScope {
            ADS_GROUP_TYPE_DOMAIN_LOCAL_GROUP = -2147483644,
            ADS_GROUP_TYPE_GLOBAL_GROUP = -2147483646,
            ADS_GROUP_TYPE_UNIVERSAL_GROUP = -2147483640
        }

        public enum aDAccountOptions {
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
        /// Returns the root node
        /// </summary>
        /// <param name="path"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static DirectoryEntry getDirectoryObject(string path, string userName, string password) {
            DirectoryEntry directoryEntry = new DirectoryEntry(protocolName + path, userName, password, AuthenticationTypes.Secure);
            return directoryEntry;
        }

        /// <summary>
        /// Returns the root node
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static DirectoryEntry getDirectoryObject(string userName, string password) {
            DirectoryEntry directoryEntryDSE = new DirectoryEntry(protocolName + defaultDomainPath);
            DirectoryEntry directoryEntry = new DirectoryEntry(protocolName + (string)directoryEntryDSE.Properties["defaultNamingContext"].Value, userName, password, AuthenticationTypes.Secure);
            return directoryEntry;
        }

        /// <summary>
        /// Returns the current root node
        /// </summary>
        /// <returns></returns>
        internal static DirectoryEntry getDirectoryObject() {
            DirectoryEntry directoryEntry;
            directoryEntry = new DirectoryEntry(crtDomain, crtUserName, crtPassword, AuthenticationTypes.Secure);
            return directoryEntry;
        }

        /// <summary>
        /// Returns the node where the user has been found
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static DirectoryEntry getUser(string userName, string password) {
            DirectoryEntry directoryEntry = getDirectoryObject(crtDomain, userName, password);
            DirectorySearcher directorySearcher = new DirectorySearcher();
            directorySearcher.SearchRoot = directoryEntry;
            directorySearcher.Filter = "(&(objectClass=user)(sAMAccountName=" + userName + "))";
            directorySearcher.SearchScope = SearchScope.Subtree;
            SearchResult results = directorySearcher.FindOne();
            if (!(results == null)) {
                directoryEntry = new DirectoryEntry(results.Path, crtUserName, crtPassword, AuthenticationTypes.Secure);
                return directoryEntry;
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Returns the node where the user has been found
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static DirectoryEntry getUser(string userName) {
            DirectoryEntry directoryEntry = getDirectoryObject();
            DirectorySearcher directorySearcher = new DirectorySearcher();
            directorySearcher.SearchRoot = directoryEntry;
            directorySearcher.Filter = "(&(objectClass=user)(sAMAccountName=" + userName + "))";
            directorySearcher.SearchScope = SearchScope.Subtree;
            SearchResult results = directorySearcher.FindOne();
            if (!(results == null)) {
                directoryEntry = new DirectoryEntry(results.Path, crtUserName, crtPassword, AuthenticationTypes.Secure);
                return directoryEntry;
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Returns the results of the research of all users 
        /// </summary>
        /// <returns></returns>
        public static SearchResultCollection getUsers() {
            DirectoryEntry directoryEntry = Utility.getDirectoryObject();
            DirectorySearcher directorySearcher = new DirectorySearcher();
            directorySearcher.SearchRoot = directoryEntry;
            directorySearcher.Filter = "(&(objectClass=user)(objectCategory=person))";
            directorySearcher.SearchScope = SearchScope.Subtree;
            return directorySearcher.FindAll();
        }

        /// <summary>
        /// Returns the node where the group has been found
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public static DirectoryEntry getGroup(string groupName) {
            DirectoryEntry directoryEntry = getDirectoryObject();
            DirectorySearcher directorySearcher = new DirectorySearcher();
            directorySearcher.SearchRoot = directoryEntry;
            directorySearcher.Filter = "(&(objectClass=group)(cn=" + groupName + "))";
            directorySearcher.SearchScope = SearchScope.Subtree;
            SearchResult results = directorySearcher.FindOne();
            if (!(results == null)) {
                directoryEntry = new DirectoryEntry(results.Path, crtUserName, crtPassword, AuthenticationTypes.Secure);
                return directoryEntry;
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Returns the node where the compunter has been found
        /// </summary>
        /// <param name="computerName"></param>
        /// <returns></returns>
        public static DirectoryEntry getComputer(string computerName) {
            DirectoryEntry directoryEntry = getDirectoryObject();
            DirectorySearcher directorySearcher = new DirectorySearcher();
            directorySearcher.SearchRoot = directoryEntry;
            directorySearcher.Filter = "(&(objectClass=computer)(cn=" + computerName + "))";
            directorySearcher.SearchScope = SearchScope.Subtree;
            SearchResult results = directorySearcher.FindOne();
            if (!(results == null)) {
                directoryEntry = new DirectoryEntry(results.Path, crtUserName, crtPassword, AuthenticationTypes.Secure);
                return directoryEntry;
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Returns the node where the object has been found
        /// </summary>
        /// <param name="objectPath"></param>
        /// <returns></returns>
        public static DirectoryEntry getDirectoryObjectByDistinguishedName(string objectPath) {
            DirectoryEntry directoryEntry = new DirectoryEntry(objectPath, crtUserName, crtPassword, AuthenticationTypes.Secure);
            return directoryEntry;
        }

        /// <summary>
        /// Enable the user account where the user is
        /// </summary>
        /// <param name="directoryEntry"></param>
        public static void enableUserAccount(DirectoryEntry directoryEntry) {
            directoryEntry.Properties["userAccountControl"].Value = userStatus.Enable;
            directoryEntry.CommitChanges();
            directoryEntry.Close();
        }

        /// <summary>
        /// Disable the user account where the user is
        /// </summary>
        /// <param name="directoryEntry"></param>
        public static void disableUserAccount(DirectoryEntry directoryEntry) {
            directoryEntry.Properties["userAccountControl"].Value = userStatus.Disable;
            directoryEntry.CommitChanges();
            directoryEntry.Close();
        }

        /// <summary>
        /// Modify the user password where the user is
        /// </summary>
        /// <param name="directoryEntry"></param>
        /// <param name="password"></param>
        public static void setUserPassword(DirectoryEntry directoryEntry, string password) {
            directoryEntry.Invoke("SetPassword", new object[] { password });
        }

        /// <summary>
        /// Verify the user account status
        /// </summary>
        /// <param name="userAccountControl"></param>
        /// <returns></returns>
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
        /// Set the property for the object in the node
        /// </summary>
        /// <param name="directoryEntry"></param>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        public static void setProperty(DirectoryEntry directoryEntry, string propertyName, string propertyValue) {
            if (!string.IsNullOrEmpty(propertyValue)) {
                if (directoryEntry.Properties.Contains(propertyName)) {
                    directoryEntry.Properties[propertyName][0] = propertyValue;
                }
                else {
                    directoryEntry.Properties[propertyName].Add(propertyValue);
                }
            }
        }
        
        /// <summary>
        /// Get the property of the object in the node
        /// </summary>
        /// <param name="directoryEntrey"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static string getProperty(DirectoryEntry directoryEntrey, string propertyName) {
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
