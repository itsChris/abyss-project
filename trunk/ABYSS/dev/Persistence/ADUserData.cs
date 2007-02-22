using System;
using System.Collections;

namespace Persistence {
    [Serializable()]public class ADUserData {
        #region Private Properties
        private string firstName; //givenName
        private string middleInitial; //initials


        private string lastName; //sn


        private string displayName; //Name


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
        private ArrayList groups;
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
            get { return displayName; }
            set { displayName = value; }
        }

        public string UserPrincipalName {
            get { return userPrincipalName; }
            set { userPrincipalName = value; }
        }

        public string PostalAddress {
            get { return postalAddress; }
            set { postalAddress = value; }
        }




        #endregion

    }
}
