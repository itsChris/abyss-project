using System;
using Persistence;
using Utils;
using System.Collections;
using System.DirectoryServices;
using System.Reflection;

namespace DAO {
    public class ADUserDAO : LdapDAO{
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
            adUserData.DistinguishedName = "LDAP://" + Utility.CrtDomain + "/" + Utility.getProperty(directoryEntry, "distinguishedName");
            adUserData.MemberOf = getMemberOfList(adUserData.DistinguishedName);
            long fileTime = longFromLargeInteger(directoryEntry.Properties["pwdLastSet"].Value);
            DateTime pwdSet = DateTime.FromFileTime(fileTime);
            if (pwdSet.ToString() == "01/01/1601 01:00:00") {
                adUserData.ChangePasswordNextLogon = true;
            }
            else {
                adUserData.ChangePasswordNextLogon = false;
            }
            adUserData.IsAccountActive = Utility.isAccountActive(Convert.ToInt32(Utility.getProperty(directoryEntry, "userAccountControl")));
            adUserData.PasswordNeverExpired = Utility.isDontExpiredPassword(Convert.ToInt32(Utility.getProperty(directoryEntry, "userAccountControl")));
            return adUserData;
        }

        private static ArrayList getMemberOfList(string DistinguishedName) {
            int index;
            DirectoryEntry de = Utility.getDirectoryObjectByDistinguishedName(DistinguishedName);
            ArrayList list = new ArrayList();
            for (index = 0; index <= de.Properties["memberOf"].Count - 1; index++) {
                DirectoryEntry temp = Utility.getDirectoryObjectByDistinguishedName(getInstance().Path + "/" + de.Properties["memberOf"][index].ToString());
                list.Add(Utility.getProperty(temp, "distinguishedName"));
            }
            de.Close();
            return list;
        }

        private static long longFromLargeInteger(object largeInteger) {
            System.Type type = largeInteger.GetType();
            int highPart = (int)type.InvokeMember("HighPart", BindingFlags.GetProperty, null, largeInteger, null);
            int lowPart = (int)type.InvokeMember("LowPart", BindingFlags.GetProperty, null, largeInteger, null);
            return (long)highPart << 32 | (uint)lowPart;
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

        private static void updateMemberOfList(ADUserData adUserData, DirectoryEntry directoryEntry) {
            ArrayList list = getMemberOfList(adUserData.DistinguishedName);
            foreach (String distinguishedName in list) {
                DirectoryEntry memberOf = Utility.getDirectoryObjectByDistinguishedName(distinguishedName);
                try {
                    Utility.removeProperty(memberOf, "Member", adUserData.DistinguishedName);
                    memberOf.CommitChanges();
                    memberOf.Close();
                }
                catch (Exception) {
                }
            }
            foreach (String distinguishedName in adUserData.MemberOf) {
                DirectoryEntry memberOf = Utility.getDirectoryObjectByDistinguishedName(distinguishedName);
                try {
                    Utility.setProperty(memberOf, "Member", adUserData.DistinguishedName);
                    memberOf.CommitChanges();
                    memberOf.Close();
                }
                catch (Exception) {
                }
            }
        }

        /// <summary>
        /// Save a adUserData.
        /// </summary>
        /// <param name="adUserData"></param>
        private static void save(ADUserData adUserData) {
            bool update = true;
            DirectoryEntry entry = getInstance();
            DirectoryEntry directoryEntry = Utility.getUser(adUserData.UserName);
            if (directoryEntry == null) {
                DirectoryEntries directoryEntries = entry.Children;
                directoryEntry = directoryEntries.Add("cn=" + adUserData.UserName + ",cn=users", "user");
                update = false;
            }
            adUserData.DistinguishedName = Utility.getProperty(directoryEntry, "distinguisedName");
            Utility.setProperty(directoryEntry, "givenName", adUserData.FirstName);
            Utility.setProperty(directoryEntry, "initials", adUserData.MiddleInitial);
            Utility.setProperty(directoryEntry, "sn", adUserData.LastName);
            Utility.setProperty(directoryEntry, "displayName", adUserData.DisplayName);
            Utility.setProperty(directoryEntry, "description", adUserData.Description);
            if (adUserData.UserPrincipalName != null) {
                Utility.setProperty(directoryEntry, "UserPrincipalName", adUserData.UserPrincipalName);
            }
            else {
                Utility.setProperty(directoryEntry, "UserPrincipalName", adUserData.UserName + "@" + Utility.PurgeDC(Utility.getProperty(entry, "distinguishedName")));
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
            if (update) {
                adUserData.DistinguishedName = Utility.getProperty(directoryEntry, "distinguishedName");
                updateMemberOfList(adUserData, directoryEntry);
            }
            int userAccountControl;
            if (adUserData.IsAccountActive) {
                userAccountControl = Convert.ToInt32(Utility.UserStatus.Enable);
            }
            else {
                userAccountControl = Convert.ToInt32(Utility.UserStatus.Disable);
            }
            if (adUserData.PasswordNeverExpired) {
                userAccountControl += Convert.ToInt32(Utility.ADS_USER_FLAG_ENUM.ADS_UF_DONT_EXPIRE_PASSWD);
            }
            directoryEntry.Properties["userAccountControl"].Value = userAccountControl;
            directoryEntry.CommitChanges();
            if (update == false) {
                setUserPassword(adUserData.Password, adUserData.UserName);
            }
            Utility.setProperty(directoryEntry, "pwdLastSet", adUserData.ChangePasswordNextLogon ? "0" : "-1");
            directoryEntry.CommitChanges();
            directoryEntry.Close();
        }
        #endregion

        #region Public
        /// <summary>
        /// Returns an adUserData.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static ADUserData getUser(string userName) {
            DirectoryEntry directoryEntry = Utility.getUser(userName);
            if (directoryEntry != null) {
                return adUserDataMapping(directoryEntry);
            }
            return null;
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
        /// Change user password
        /// </summary>
        /// <param name="password"></param>
        /// <param name="userName"></param>
        public static void setUserPassword(string password, string userName){
            Utility.setUserPassword(Utility.getUser(userName), password);
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
            directoryEntry.Close();
        }
        #endregion
        #endregion
    }
}
