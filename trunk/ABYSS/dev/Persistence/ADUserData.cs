using System;

namespace Persistence {
    [Serializable()]public class ADUserData {
        #region Attributes
        private string firstName; //givenName
        private string middleInitial; //initials
        private string lastName; //sn
        private string displayName; //Name
        private string description; //Description
        private string userPrincipalName; //userPrincipalName (e.g. user@domain.local)
        private string postalAddress; 
        private string mailingAddress; //StreetAddress
        private string residentialAddress; //HomePostalAddress
        private string title;
        private string homePhone;
        private string officePhone; //TelephoneNumber
        private string mobile;
        private string fax; //FacsimileTelephoneNumber
        private string email; //mail
        private string url;
        private string userName; //sAMAccountName
        private string password;
        private string distinguishedName;
        private bool isAccountActive; //userAccountControl
        #endregion

        #region Constructors
        public ADUserData() {
        }
        #endregion

        #region Properties
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleInitial {
            get { return middleInitial; }
            set { middleInitial = value; }
        }

        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }

        public string DisplayName {
            get {return displayName;}
            set { displayName = value; }
        }

        public string Description {
            get { return description; }
            set { description = value; }
        }

        public string UserPrincipalName {
            get { return userPrincipalName; }
            set { userPrincipalName = value; }
        }

        public string PostalAddress {
            get { return postalAddress; }
            set { postalAddress = value; }
        }

        public string MailingAddress {
            get { return mailingAddress; }
            set { mailingAddress = value; }
        }

        public string ResidentialAddress {
            get { return residentialAddress; }
            set { residentialAddress = value; }
        }

        public string Title {
            get { return title; }
            set { title = value; }
        }

        public string HomePhone {
            get { return homePhone; }
            set { homePhone = value; }
        }

        public string OfficePhone {
            get { return officePhone; }
            set { officePhone = value; }
        }

        public string Mobile {
            get { return mobile; }
            set { mobile = value; }
        }

        public string Fax {
            get { return fax; }
            set { fax = value; }
        }

        public string Email {
            get { return email; }
            set { email = value; }
        }

        public string Url {
            get { return url; }
            set { url = value; }
        }

        public string UserName {
            get { return userName; }
            set { userName = value; }
        }

        public string Password {
            get { return password; }
            set { password = value; }
        }

        public string DistinguishedName {
            get { return distinguishedName; }
            set { distinguishedName = value; }
        }

        public bool IsAccountActive {
            get { return isAccountActive; }
            set { isAccountActive = value; }
        }
        #endregion
    }
}