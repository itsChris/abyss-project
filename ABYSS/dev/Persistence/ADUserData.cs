using System;

namespace Persistence {
    [Serializable()]public class ADUserData {
        #region Private Properties
        private string firstName;
        private string middleInitial;
        private string lastName;
        private string displayName;
        private string userPrincipalName; //userPrincipalName (e.g. user@domain.local)
        private string postalAddress;
        private string MailingAddress; //StreetAddress
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
        private string istinguishedName;
        private bool IsAccountActive; //userAccountControl
        //private ArrayList _Groups;

        #endregion

    }
}
