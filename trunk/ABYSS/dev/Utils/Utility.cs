using System;
using System.DirectoryServices;

namespace Utils {
    public class Utility {
        #region Constants
        private const string protocolName = "LDAP://";
        private const string defaultDomainPath = "rootDSE";
        #endregion

        #region Attributes
        private static string crtDomain = null;
        private static string crtUserName = null;
        private static string crtPassword = null;
        private static bool initFinish = false;
        #endregion

        #region Properties
        public static string CrtDomain {
            get { return Utility.crtDomain; }
        }
        
        public static string CrtUserName {
            get { return Utility.crtUserName; }
        }
        
        public static string CrtPassword {
            get { return Utility.crtPassword; }
        }

        public static bool InitFinish {
            set { initFinish = value; }
        }
        #endregion

        #region Enumerations
        public enum UserStatus : long{
			Enable = 0x220,
			Disable = 0x222
		}

        public enum ADS_USER_FLAG_ENUM : long {
            ADS_UF_SCRIPT = 0x1, //The logon script is executed.
            ADS_UF_ACCOUNTDISABLE = 0x2, //The user account is disabled.
            ADS_UF_HOMEDIR_REQUIRED = 0x8, //The home directory is required.
            ADS_UF_LOCKOUT = 0x10, //The account is currently locked out.
            ADS_UF_PASSWD_NOTREQD = 0x20, //No password is required.
            ADS_UF_PASSWD_CANT_CHANGE = 0x40, //The user cannot change the password.    
            ADS_UF_ENCRYPTED_TEXT_PASSWORD_ALLOWED = 0x80, //The user can send an encrypted password.
            ADS_UF_TEMP_DUPLICATE_ACCOUNT = 0x100, //This is an account for users whose primary account is in another domain. 
            ADS_UF_NORMAL_ACCOUNT = 0x0200, //This is a default account type that represents a typical user. 
            ADS_UF_INTERDOMAIN_TRUST_ACCOUNT = 0x800, //This is a permit to trust account for a system domain that trusts other domains.
            ADS_UF_WORKSTATION_TRUST_ACCOUNT = 0x1000, //This is a computer account for a Microsoft Windows NT Workstation/Windows 2000 Professional.
            ADS_UF_SERVER_TRUST_ACCOUNT = 0x2000, //This is a computer account for a system backup domain controller that is a member of this domain.
            ADS_UF_DONT_EXPIRE_PASSWD = 0x10000, //When set, the password will not expire on this account.
            ADS_UF_MNS_LOGON_ACCOUNT = 0x20000, //This is an Majority Node Set (MNS) logon account.
            ADS_UF_SMARTCARD_REQUIRED = 0x40000, //When set, this flag will force the user to log on using a smart card.
            ADS_UF_TRUSTED_FOR_DELEGATION = 0x80000, //When set, the service account (user or computer account), under which a service runs, is trusted for Kerberos delegation. 
            ADS_UF_NOT_DELEGATED = 0x100000,  //When set, the security context of the user will not be delegated to a service
            ADS_UF_USE_DES_KEY_ONLY = 0x200000, //Restrict this principal to use only Data Encryption Standard (DES) encryption types for keys.
            ADS_UF_DONT_REQUIRE_PREAUTH = 0x400000, //This account does not require Kerberos preauthentication for logon.
            ADS_UF_PASSWORD_EXPIRED = 0x800000, //The user password has expired. 
            ADS_UF_TRUSTED_TO_AUTHENTICATE_FOR_DELEGATION = 0x1000000 //The account is enabled for delegation. 
        }

        public enum ADS_GROUP_TYPE_ENUM : long{
            ADS_GROUP_TYPE_GLOBAL_GROUP = 0x00000002, //Specifies a group that can contain accounts from the same domain and other global groups from the same domain.
            ADS_GROUP_TYPE_DOMAIN_LOCAL_GROUP = 0x00000004, //Specifies a group that can contain accounts from any domain in the forest, other domain local groups from the same domain, global groups from any domain in the forest, and universal groups.
            ADS_GROUP_TYPE_UNIVERSAL_GROUP = 0x00000008, //Specifies a group that can contain accounts from any domain, global groups from any domain, and other universal groups. This type of group cannot contain domain local groups.
            ADS_GROUP_TYPE_SECURITY_ENABLED = 0x80000000 //Specifies a group that is security enabled.    
        }
        #endregion

        #region Static Methods
        #region Public
        /// <summary>
        /// Create a connection and returns the node.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static DirectoryEntry connection(string path, string userName, string password) {
            if (!initFinish) {
                crtDomain = path;
                crtUserName = userName;
                crtPassword = password;
                initFinish = true;
            }
            return getDirectoryObject();
        }

        /// <summary>
        /// Create a connection and returns the node
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static DirectoryEntry connection(string userName, string password) {
            if (!initFinish) {
                DirectoryEntry directoryEntryDSE = new DirectoryEntry(protocolName + defaultDomainPath);
                crtDomain = (string)directoryEntryDSE.Properties["defaultNamingContext"].Value;
                crtUserName = userName;
                crtPassword = password;
                initFinish = true;
            }
            return getDirectoryObject();
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
                directoryEntry = new DirectoryEntry(results.Path, crtUserName, crtPassword);
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
            DirectoryEntry directoryEntry = getDirectoryObject();
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
            directorySearcher.Filter = "(&(objectClass=group)(sAMAccountName=" + groupName + "))";
            directorySearcher.SearchScope = SearchScope.Subtree;
            SearchResult results = directorySearcher.FindOne();
            if (!(results == null)) {
                directoryEntry = new DirectoryEntry(results.Path, crtUserName, crtPassword);
                return directoryEntry;
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Returns the results of the research of all groups 
        /// </summary>
        /// <returns></returns>
        public static SearchResultCollection getGroups() {
            DirectoryEntry directoryEntry = getDirectoryObject();
            DirectorySearcher directorySearcher = new DirectorySearcher();
            directorySearcher.SearchRoot = directoryEntry;
            directorySearcher.Filter = "(&(objectClass=group)(objectCategory=group)(description=*))";
            directorySearcher.SearchScope = SearchScope.Subtree;
            return directorySearcher.FindAll();
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
                directoryEntry = new DirectoryEntry(results.Path, crtUserName, crtPassword);
                return directoryEntry;
            }
            else {
                return null;
            }
        }

        /// <summary>
        /// Returns the node for the object path
        /// </summary>
        /// <param name="objectPath"></param>
        /// <returns></returns>
        public static DirectoryEntry getDirectoryObjectByDistinguishedName(string objectPath) {
            String path = objectPath;
            if (!objectPath.StartsWith("LDAP://")) {
                path = protocolName + crtDomain + "/" + objectPath;
            }
            DirectoryEntry directoryEntry = new DirectoryEntry(path, crtUserName, crtPassword);
            return directoryEntry;
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
        /// Enable the user account where the user is
        /// </summary>
        /// <param name="directoryEntry"></param>
        public static void enableUserAccount(DirectoryEntry directoryEntry) {
            directoryEntry.Properties["userAccountControl"].Value = Convert.ToInt32(UserStatus.Enable);
            directoryEntry.CommitChanges();
            directoryEntry.Close();
        }

        /// <summary>
        /// Disable the user account where the user is
        /// </summary>
        /// <param name="directoryEntry"></param>
        public static void disableUserAccount(DirectoryEntry directoryEntry) {
            directoryEntry.Properties["userAccountControl"].Value = Convert.ToInt32(UserStatus.Disable); ;
            directoryEntry.CommitChanges();
            directoryEntry.Close();
        }

        /// <summary>
        /// Verify the user account status
        /// </summary>
        /// <param name="userAccountControl"></param>
        /// <returns></returns>
        public static bool isAccountActive(int userAccountControl) {
            int userAccountControl_Disabled = Convert.ToInt32(ADS_USER_FLAG_ENUM.ADS_UF_ACCOUNTDISABLE);
            int flagExists = userAccountControl & userAccountControl_Disabled;
            if (flagExists > 0) {
                return false;
            }
            else {
                return true;
            }
        }

        /// <summary>
        /// Verify if the user account password can expired
        /// </summary>
        /// <param name="userAccountControl"></param>
        /// <returns></returns>
        public static bool isDontExpiredPassword(int userAccountControl) {
            int userPasswordNeverExpired = Convert.ToInt32(ADS_USER_FLAG_ENUM.ADS_UF_DONT_EXPIRE_PASSWD);
            int flagExists = userAccountControl & userPasswordNeverExpired;
            if (flagExists > 0) {
                return true;
            }
            else {
                return false;
            }
        }

        public static bool isGlobalScope(int groupScope) {
            int globalScope = Convert.ToInt32(ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_GLOBAL_GROUP);
            int flagExists = groupScope & globalScope;
            if (flagExists > 0) {
                return true;
            }
            else {
                return false;
            }
        }

        public static bool isDomainLocalScope(int groupScope) {
            int doamainLocalScopeScope = Convert.ToInt32(ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_DOMAIN_LOCAL_GROUP);
            int flagExists = groupScope & doamainLocalScopeScope;
            if (flagExists > 0) {
                return true;
            }
            else {
                return false;
            }
        }

        public static bool isUniversalScope(int groupScope) {
            int universalScope = Convert.ToInt32(ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_UNIVERSAL_GROUP);
            int flagExists = groupScope & universalScope;
            if (flagExists > 0) {
                return true;
            }
            else {
                return false;
            }
        }

        public static bool isSecurityEnable(long groupType) {
            long securityType = Convert.ToInt64(ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_SECURITY_ENABLED);
            long flagExists = groupType & securityType;
            if (flagExists > 0) {
                return true;
            }
            else {
                return false;
            }
        }

        /// <summary>
        /// Set the property for the object in the node
        /// </summary>
        /// <param name="directoryEntry"></param>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>propertyName
        public static void setProperty(DirectoryEntry directoryEntry, string propertyName, string propertyValue) {
            if (!string.IsNullOrEmpty(propertyValue)) {
                if (directoryEntry.Properties[propertyName].Count != 0 && propertyName != "Member" & propertyName != "MemberOf") {
                    directoryEntry.Properties[propertyName][0] = propertyValue;
                }
                else {
                    directoryEntry.Properties[propertyName].Add(propertyValue);
                }
            }
        }

        /// <summary>
        /// Remove the property for the object in the node
        /// </summary>
        /// <param name="directoryEntry"></param>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>propertyName
        public static void removeProperty(DirectoryEntry directoryEntry, string propertyName, string propertyValue) {
            if (!string.IsNullOrEmpty(propertyValue)) {
                if (directoryEntry.Properties[propertyName].Count != 0) {
                    directoryEntry.Properties[propertyName].Remove(propertyValue);
                }
            }
        }
        
        /// <summary>
        /// Get the property of the object in the node
        /// </summary>
        /// <param name="directoryEntrey"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static string getProperty(DirectoryEntry directoryEntry, string propertyName) {
            if (directoryEntry.Properties.Contains(propertyName)) {
                return directoryEntry.Properties[propertyName][0].ToString();
            }
            else {
                return string.Empty;
            }
        }

        /// <summary>
        /// Return the domain string for UPN
        /// </summary>
        /// <param name="dc"></param>
        /// <returns></returns>
        public static String PurgeDC(String dc) {

            String DCpropre = dc.Replace("DC=", "");
            DCpropre = DCpropre.Replace(",", ".");

            return DCpropre;
        }
        #endregion

        #region Private
        /// <summary>
        /// Returns the current node.
        /// </summary>
        /// <returns></returns>
        private static DirectoryEntry getDirectoryObject() {
            DirectoryEntry directoryEntry = new DirectoryEntry(protocolName + crtDomain, crtUserName, crtPassword);
            return directoryEntry;
        }

        /// <summary>
        /// Returns a node.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private static DirectoryEntry getDirectoryObject(string path, string userName, string password) {
            DirectoryEntry directoryEntry = new DirectoryEntry(protocolName + path, userName, password);
            return directoryEntry;
        }
        #endregion
        #endregion
    }
}
