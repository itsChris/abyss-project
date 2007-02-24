using System;
using System.Collections.Generic;
using System.Text;
using Persistence;
using Utils;
using System.Collections;
using System.DirectoryServices;

namespace DAO {
    public class ADUserDAO{
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

        #region Private Methods
        private static ArrayList getUsersList(SearchResultCollection searchResultCollection) {
            ArrayList list = new ArrayList();
            foreach (SearchResult searchResult in searchResultCollection) {
                ADUserData adUserData = adUserDataMapping(new DirectoryEntry(searchResult.Path, Utility.CrtUserName, Utility.CrtPassword, AuthenticationTypes.Secure));
                list.Add(adUserData);
            }
            return list;
        }

        private void Add(ADUserData adUserData) {
            string path;
            DirectorySearcher directorySearcher = new DirectorySearcher();
            try {
                path = directorySearcher.SearchRoot.Path;
                //path = path.Insert(7, Utility.ADUsersPath);
                //System.DirectoryServices.DirectoryEntry myDE = new DirectoryEntry(path);
                //DirectoryEntries myEntries = myDE.Children;
                //System.DirectoryServices.DirectoryEntry myDirectoryEntry = myEntries.Add("CN=" + UserName, "user");
                //Utility.SetProperty(myDirectoryEntry, "givenName", FirstName);
                //Utility.SetProperty(myDirectoryEntry, "initials", MiddleInitial);
                //Utility.SetProperty(myDirectoryEntry, "sn", LastName);
                //if (UserPrincipalName != null) {
                //    Utility.SetProperty(myDirectoryEntry, "UserPrincipalName", UserPrincipalName);
                //}
                //else {
                //    Utility.SetProperty(myDirectoryEntry, "UserPrincipalName", UserName);
                //}
                //Utility.SetProperty(myDirectoryEntry, "PostalAddress", PostalAddress);
                //Utility.SetProperty(myDirectoryEntry, "StreetAddress", MailingAddress);
                //Utility.SetProperty(myDirectoryEntry, "HomePostalAddress", ResidentialAddress);
                //Utility.SetProperty(myDirectoryEntry, "Title", Title);
                //Utility.SetProperty(myDirectoryEntry, "HomePhone", HomePhone);
                //Utility.SetProperty(myDirectoryEntry, "TelephoneNumber", OfficePhone);
                //Utility.SetProperty(myDirectoryEntry, "Mobile", Mobile);
                //Utility.SetProperty(myDirectoryEntry, "FacsimileTelephoneNumber", Fax);
                //Utility.SetProperty(myDirectoryEntry, "mail", Email);
                //Utility.SetProperty(myDirectoryEntry, "Url", Url);
                //Utility.SetProperty(myDirectoryEntry, "sAMAccountName", UserName);
                //Utility.SetProperty(myDirectoryEntry, "UserPassword", Password);
                //myDirectoryEntry.Properties["userAccountControl"].Value = Utility.UserStatus.Enable;
                //myDirectoryEntry.CommitChanges();
                //myDirectoryEntry = GetUser(UserName);
                //Utility.SetUserPassword(myDirectoryEntry, Password);
                //return myDirectoryEntry;
            }
            catch (Exception ex) {
                throw (ex);
            }
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
            return null;
        }
        #endregion
    }
}
