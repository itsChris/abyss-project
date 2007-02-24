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
        #endregion

        #region Static Methods
        public static ADUser getUserByName(string username) {
            return new ADUser((ADUserData)ADUserDAO.getUser(username));

        }
      


        #endregion
    }
}
