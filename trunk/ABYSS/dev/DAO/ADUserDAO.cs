using System;
using System.Collections.Generic;
using System.Text;
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

        private static DirectoryEntry addUser(ADUserData adUserData) {
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
            return directoryEntry;
        }
        #endregion

        #region Static Methods
        public static ADUserData getUser(string userName) {
            return adUserDataMapping(Utility.getUser(userName));
        }

        public static ArrayList getUsersList(){
            return getUsersList(Utility.getUsers());
        }

        public static ADUserData createUser(ADUserData adUserData) {
            return adUserDataMapping(addUser(adUserData));
        }
        #endregion
    }
}
