using System;
using DAO;
using Persistence;
using System.Collections;

namespace Business {
    public class ADUser {
        #region Attributes
        private ADUserData adUserData;
        #endregion

        #region Constructors
        public ADUser() {
            this.adUserData = new ADUserData();
            this.adUserData.IsAccountActive = true;
            this.adUserData.ChangePasswordNextLogon = true;
        }

        public ADUser(ADUserData adUserData) {
            this.adUserData = adUserData;
        }
        #endregion

        #region Properties
        public string FirstName {
            get { return adUserData.FirstName; }
            set { adUserData.FirstName = value; }
        }

        public string MiddleInitial {
            get { return adUserData.MiddleInitial; }
            set { adUserData.MailingAddress = value; }
        }

        public string LastName {
            get { return adUserData.LastName; }
            set { adUserData.LastName = value; }
        }

        public string DisplayName {
            get { return adUserData.DisplayName; }
            set { adUserData.DisplayName = value; }
        }

        public string Description {
            get { return adUserData.Description; }
            set { adUserData.Description = value; }
        }

        public string UserPrincipalName {
            get { return adUserData.UserPrincipalName; }
            set { adUserData.UserPrincipalName = value; }
        }

        public string PostalAddress {
            get { return adUserData.PostalAddress; }
            set { adUserData.PostalAddress = value; }
        }

        public string MailingAddress {
            get { return adUserData.MailingAddress; }
            set { adUserData.MailingAddress = value; }
        }

        public string ResidentialAddress {
            get { return adUserData.ResidentialAddress; }
            set { adUserData.ResidentialAddress = value; }
        }

        public string Title {
            get { return adUserData.Title; }
            set { adUserData.Title = value; }
        }

        public string HomePhone {
            get { return adUserData.HomePhone; }
            set { adUserData.HomePhone = value; }
        }

        public string OfficePhone {
            get { return adUserData.OfficePhone; }
            set { adUserData.OfficePhone = value; }
        }

        public string Mobile {
            get { return adUserData.Mobile; }
            set { adUserData.Mobile = value; }
        }

        public string Fax {
            get { return adUserData.Fax; }
            set { adUserData.Fax = value; }
        }

        public string Email {
            get { return adUserData.Email; }
            set { adUserData.Email = value; }
        }

        public string Url {
            get { return adUserData.Url; }
            set { adUserData.Url = value; }
        }

        public string UserName {
            get { return adUserData.UserName; }
            set { adUserData.UserName = value; }
        }

        public string Password {
            get { return adUserData.Password; }
            set { adUserData.Password = value; }
        }

        public string DistinguishedName {
            get { return adUserData.DistinguishedName; }
            set { adUserData.DistinguishedName = value; }
        }

        public bool IsAccountActive {
            get { return adUserData.IsAccountActive; }
            set { adUserData.IsAccountActive = value; }
        }

        public bool ChangePasswordNextLogon {
            get { return adUserData.ChangePasswordNextLogon; }
            set { adUserData.ChangePasswordNextLogon = value; }
        }

        public bool PasswordNeverExpired {
            get { return adUserData.PasswordNeverExpired; }
            set { adUserData.PasswordNeverExpired = value; }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Returns a adUser
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static ADUser getUserByName(string username) {
            ADUserData userData = ADUserDAO.getUser(username);
            if (userData != null) {
                return new ADUser((ADUserData)userData);
            }
            return null;
        }

        /// <summary>
        /// Returns a list composed of adUser
        /// </summary>
        /// <returns></returns>
        public static ArrayList getUsersList() {
            return ADUserDAO.getUsersList();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Save a user
        /// </summary>
        public void save() {
            ADUserDAO.saveUser(this.adUserData);
        }

        /// <summary>
        /// Add a user to a group
        /// </summary>
        /// <param name="groupDistinguishedName"></param>
        public void addUserToGroup(string groupDistinguishedName) {
            ADUserDAO.addUserToGroup(DistinguishedName, groupDistinguishedName);
        }

        /// <summary>
        /// Remove a user from a group
        /// </summary>
        /// <param name="groupDistinguishedName"></param>
        public void RemoveUserFromGroup(string groupDistinguishedName) {
            ADUserDAO.removeUserFromGroup(DistinguishedName, groupDistinguishedName);
        }

        /// <summary>
        /// Set a new password
        /// </summary>
        /// <param name="newPassword"></param>
        public void setUserPassword(string newPassword) {
            ADUserDAO.setUserPassword(newPassword, adUserData.UserName);
        }

        /// <summary>
        /// Disable user account
        /// </summary>
        public void disableUserAccount() {
            ADUserDAO.disableUserAccount(UserName);
        }

        /// <summary>
        /// Enable user account
        /// </summary>
        public void enableUserAccount() {
            ADUserDAO.enableUserAccount(UserName);
        }

        /// <summary>
        /// Delete user
        /// </summary>
        public void deleteUserAccount() {
            ADUserDAO.deleteUserAccount(UserName);
        }
        #endregion
    }
}
