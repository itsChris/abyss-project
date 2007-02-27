using System;
using Persistence;
using Utils;
using System.Collections;
using System.DirectoryServices;

namespace DAO {
    public class ADUserDAO {
        #region Static Methods
        #region Private
        /// <summary>
        /// Returns the adUserData from the directoryEntry node.
        /// </summary>
        /// <param name="directoryEntry"></param>
        /// <returns></returns>
        private static ADUserData adUserDataMapping(DirectoryEntry directoryEntry) {
            ADUserData adUserData = new ADUserData();
            adUserData.FirstName = Utility.getProperty(directoryEntry, "givenName");
            adUserData.MiddleInitial = Utility.getProperty(directoryEntry, "initials");
            adUserData.LastName = Utility.getProperty(directoryEntry, "sn");
            adUserData.DisplayName = Utility.getProperty(directoryEntry, "displayName");
            adUserData.Description = Utility.getProperty(directoryEntry, "description");
            adUserData.UserPrincipalName = Utility.getProperty(directoryEntry, "UserPrincipalName");
            adUserData.PostalAddress = Utility.getProperty(directoryEntry, "PostalAddress");
            adUserData.MailingAddress = Utility.getProperty(directoryEntry, "StreetAddress");
            adUserData.ResidentialAddress = Utility.getProperty(directoryEntry, "HomePostalAddress");
            adUserData.Title = Utility.getProperty(directoryEntry, "Title");
            adUserData.HomePhone = Utility.getProperty(directoryEntry, "HomePhone");
            adUserData.OfficePhone = Utility.getProperty(directoryEntry, "TelephoneNumber");
            adUserData.Mobile = Utility.getProperty(directoryEntry, "Mobile");
            adUserData.Fax = Utility.getProperty(directoryEntry, "FacsimileTelephoneNumber");
            adUserData.Email = Utility.getProperty(directoryEntry, "mail");
            adUserData.Url = Utility.getProperty(directoryEntry, "Url");
            adUserData.UserName = Utility.getProperty(directoryEntry, "sAMAccountName");
            adUserData.DistinguishedName = "LDAP://" + Utility.CrtDomain + "/" + Utility.getProperty(directoryEntry, "DistinguishedName");
            adUserData.IsAccountActive = Utility.isAccountActive(Convert.ToInt32(Utility.getProperty(directoryEntry, "userAccountControl")));
            return adUserData;
        }
      
        /// <summary>
        /// Returns an list composed of adUserData.
        /// </summary>
        /// <param name="searchResultCollection"></param>
        /// <returns></returns>
        private static ArrayList getUsersList(SearchResultCollection searchResultCollection) {
            ArrayList list = new ArrayList();
            foreach (SearchResult searchResult in searchResultCollection) {
                ADUserData adUserData = adUserDataMapping(new DirectoryEntry(searchResult.Path, Utility.CrtUserName, Utility.CrtPassword));
                list.Add(adUserData);
            }
            return list;
        }

        /// <summary>
        /// Save a adUserData.
        /// </summary>
        /// <param name="adUserData"></param>
        private static void save(ADUserData adUserData) {
            DirectoryEntry root = LdapDAO.Root;
            DirectoryEntry directoryEntry = Utility.getUser(adUserData.UserName);
            if (directoryEntry == null) {
                DirectoryEntries directoryEntries = root.Children;
                directoryEntry = directoryEntries.Add("cn=" + adUserData.UserName + ",cn=users", "user");
            }
            Utility.setProperty(directoryEntry, "givenName", adUserData.FirstName);
            Utility.setProperty(directoryEntry, "initials", adUserData.MiddleInitial);
            Utility.setProperty(directoryEntry, "sn", adUserData.LastName);
            Utility.setProperty(directoryEntry, "displayName", adUserData.DisplayName);
            Utility.setProperty(directoryEntry, "description", adUserData.Description);
            if (adUserData.UserPrincipalName != null) {
                Utility.setProperty(directoryEntry, "UserPrincipalName", adUserData.UserPrincipalName);
            }
            else {
                Utility.setProperty(directoryEntry, "UserPrincipalName", adUserData.UserName);
            }
            Utility.setProperty(directoryEntry, "PostalAddress", adUserData.PostalAddress);
            Utility.setProperty(directoryEntry, "StreetAddress", adUserData.MailingAddress);
            Utility.setProperty(directoryEntry, "HomePostalAddress", adUserData.ResidentialAddress);
            Utility.setProperty(directoryEntry, "Title", adUserData.Title);
            Utility.setProperty(directoryEntry, "HomePhone", adUserData.HomePhone);
            Utility.setProperty(directoryEntry, "TelephoneNumber", adUserData.OfficePhone);
            Utility.setProperty(directoryEntry, "Mobile", adUserData.Mobile);
            Utility.setProperty(directoryEntry, "FacsimileTelephoneNumber", adUserData.Fax);
            Utility.setProperty(directoryEntry, "mail", adUserData.Email);
            Utility.setProperty(directoryEntry, "Url", adUserData.Url);
            Utility.setProperty(directoryEntry, "sAMAccountName", adUserData.UserName);
            Utility.setProperty(directoryEntry, "UserPassword", adUserData.Password);
            if (adUserData.IsAccountActive) {
                directoryEntry.Properties["userAccountControl"].Value = Utility.ADS_USER_FLAG_ENUM.ADS_UF_NORMAL_ACCOUNT;
            }
            else {
                directoryEntry.Properties["userAccountControl"].Value = Utility.ADS_USER_FLAG_ENUM.ADS_UF_ACCOUNTDISABLE;
            }
            directoryEntry.CommitChanges();
        }
        #endregion

        #region Public
        /// <summary>
        /// Returns an adUserData.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static ADUserData getUser(string userName) {
            return adUserDataMapping(Utility.getUser(userName));
        }

        /// <summary>
        /// Returns an arraylist composed bys adUserData.
        /// </summary>
        /// <returns></returns>
        public static ArrayList getUsersList() {
            return getUsersList(Utility.getUsers());
        }

        /// <summary>
        /// Save an adUserData.
        /// </summary>
        /// <param name="adUserData"></param>
        public static void saveUser(ADUserData adUserData) {
            save(adUserData);
        }

        /// <summary>
        /// Add a user to a group
        /// </summary>
        /// <param name="userDistinguishedName"></param>
        /// <param name="groupDistinguishedName"></param>
        public static void addUserToGroup(string userDistinguishedName, string groupDistinguishedName) {
            DirectoryEntry directoryEntry = Utility.getDirectoryObjectByDistinguishedName(groupDistinguishedName);
            directoryEntry.Invoke("Add", new object[] { userDistinguishedName });
            directoryEntry.Close();
        }

        /// <summary>
        /// Remove a user to a group
        /// </summary>
        /// <param name="userDistinguishedName"></param>
        /// <param name="groupDistinguishedName"></param>
        public static void removeUserFromGroup(string userDistinguishedName, string groupDistinguishedName) {
            DirectoryEntry directoryEntry = Utility.getDirectoryObjectByDistinguishedName(groupDistinguishedName);
            directoryEntry.Invoke("Remove", new object[] { userDistinguishedName });
            directoryEntry.Close();
        }

        /// <summary>
        /// Disable a user account
        /// </summary>
        /// <param name="userName"></param>
        public static void disableUserAccount(string userName) {
            Utility.disableUserAccount(Utility.getUser(userName));
        }

        /// <summary>
        /// Enable a user account
        /// </summary>
        /// <param name="userName"></param>
        public static void enableUserAccount(string userName) {
            Utility.enableUserAccount(Utility.getUser(userName));
        }

        /// <summary>
        /// Remove a user
        /// </summary>
        /// <param name="userName"></param>
        public static void deleteUserAccount(string userName) {
            DirectoryEntry directoryEntry = Utility.getUser(userName);
            directoryEntry.DeleteTree();
            directoryEntry.CommitChanges();
        }
        #endregion
        #endregion
    }
}
