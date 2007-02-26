using System;
using Persistence;
using Utils;
using System.Collections;
using System.DirectoryServices;

namespace DAO {
    public class ADUserDAO {
        #region Private Methods
        #region Mapping
        private static ADUserData adUserDataMapping(DirectoryEntry directoryEntry) {
            ADUserData adUserData = new ADUserData();
            adUserData.FirstName = Utility.getProperty(directoryEntry, "givenName");
            adUserData.MiddleInitial = Utility.getProperty(directoryEntry, "initials");
            adUserData.LastName = Utility.getProperty(directoryEntry, "sn");
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
        #endregion

        private static ArrayList getUsersList(SearchResultCollection searchResultCollection) {
            ArrayList list = new ArrayList();
            foreach (SearchResult searchResult in searchResultCollection) {
                ADUserData adUserData = adUserDataMapping(new DirectoryEntry(searchResult.Path, Utility.CrtUserName, Utility.CrtPassword, AuthenticationTypes.Secure));
                list.Add(adUserData);
            }
            return list;
        }

        private static void addUser(ADUserData adUserData) {
            DirectoryEntry directoryEntry = Utility.getDirectoryObject();
            DirectoryEntries directoryEntries = directoryEntry.Children;
            directoryEntry = directoryEntries.Add("cn=" + adUserData.UserName+",cn=users", "user");
            Utility.setProperty(directoryEntry, "givenName", adUserData.FirstName);
            Utility.setProperty(directoryEntry, "initials", adUserData.MiddleInitial);
            Utility.setProperty(directoryEntry, "sn", adUserData.LastName);
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
            directoryEntry.Properties["userAccountControl"].Value = Utility.userStatus.Enable;
            directoryEntry.CommitChanges();
            directoryEntry = Utility.getUser(adUserData.UserName);
            Utility.setUserPassword(directoryEntry, adUserData.Password);
        }

        private static void modifyUser(ADUserData adUserData) {
            DirectoryEntry directoryEntry = Utility.getDirectoryObject(adUserData.UserName, adUserData.Password);
            Utility.setProperty(directoryEntry, "givenName", adUserData.FirstName);
            Utility.setProperty(directoryEntry, "initials", adUserData.MiddleInitial);
            Utility.setProperty(directoryEntry, "sn", adUserData.LastName);
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
            directoryEntry.Properties["userAccountControl"].Value = Utility.userStatus.Enable;
            directoryEntry.CommitChanges();
            directoryEntry = Utility.getUser(adUserData.UserName);
            Utility.setUserPassword(directoryEntry, adUserData.Password);
        }

        private static bool IsUserValid(string userName, string password) {
            DirectoryEntry DirectoryEntry = Utility.getUser(userName, password);
            DirectoryEntry.Close();
            return true;
        }
        #endregion

        #region Static Methods
        public static ADUserData getUser(string userName) {
            return adUserDataMapping(Utility.getUser(userName));
        }

        public static ArrayList getUsersList(){
            return getUsersList(Utility.getUsers());
        }

        public static void createUser(ADUserData adUserData) {
            addUser(adUserData);
        }

        public static void addUserToGroup(string userDistinguishedName, string groupDistinguishedName) {
            DirectoryEntry directoryEntry = Utility.getDirectoryObjectByDistinguishedName(groupDistinguishedName);
            directoryEntry.Invoke("Add", new object[] { userDistinguishedName });
            directoryEntry.Close();
        }

        public static void saveModification(ADUserData adUserData){
            modifyUser(adUserData);
        }

        public static void removeUserFromGroup(string userDistinguishedName, string groupDistinguishedName) {
            DirectoryEntry directoryEntry = Utility.getDirectoryObjectByDistinguishedName(groupDistinguishedName);
            directoryEntry.Invoke("Remove", new object[] { userDistinguishedName });
            directoryEntry.Close();
        }

        public static void disableUserAccount(string userName) {
           Utility.disableUserAccount(Utility.getUser(userName));
        }


        public static void enableUserAccount(string userName) {
            Utility.enableUserAccount(Utility.getUser(userName));
        }

        public static void deleteUserAccount(string userName) {
            DirectoryEntry directoryEntry = Utility.getUser(userName);
            directoryEntry.DeleteTree();
            directoryEntry.CommitChanges();
        }

        //public static Utility.loginResult login(string UserName, string Password) {
        //    if (IsUserValid(UserName, Password)) {
        //        DirectoryEntry de = Utility.getUser(UserName);
        //        if (!(de == null)) {
        //            if (Utility.userStatus.Enable == (Utility.userStatus)(de.Properties["userAccountControl"][0])) {
        //                de.Close();
        //                return Utility.loginResult.LOGIN_OK;
        //            }
        //            else {
        //                de.Close();
        //                return Utility.loginResult.LOGIN_USER_ACCOUNT_INACTIVE;
        //            }

        //        }
        //        else {
        //            return Utility.loginResult.LOGIN_USER_DOESNT_EXIST;
        //        }
        //    }
        //    else {
        //        return Utility.loginResult.LOGIN_USER_DOESNT_EXIST;
        //    }
        //}
        #endregion
    }
}
