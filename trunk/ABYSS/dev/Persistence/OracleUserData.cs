using System;

namespace Persistence {
    [Serializable()]public class OracleUserData {

        #region Attribut
        private string userLogin;
        private string userPassword;
        private bool externalUser;
        private string defaultTablespace;
        private string temporatyTablespace;
        private string profile;
        private bool passwordExpire;
        private bool account; //Lock (true) or Unlock(false)
        private string createdDate; //Creation date of an Oracle user
        #endregion

        #region Constructors
        public OracleUserData() {
        }
        #endregion

        #region Properties
        public string UserLogin {
            get { return userLogin; }
            set { userLogin=value; }
        }
        public string UserPassword {
            get { return userPassword; }
            set { userPassword = value; }
        }
        public bool ExternalUser {
            get { return externalUser; }
            set { externalUser = value; }
        }
        public string DefaultTablespace {
            get { return defaultTablespace; }
            set { defaultTablespace = value; }
        }
        public string TemporatyTablespace {
            get { return temporatyTablespace; }
            set { temporatyTablespace = value; }
        }
        public string Profile {
            get { return profile; }
            set { profile = value; }
        }
        public bool PasswordExpire {
            get { return passwordExpire; }
            set { passwordExpire = value; }
        }
        public bool Account {
            get { return account; }
            set { account = value; }
        }

        public string CreatedDate {
            get { return createdDate; }
            set { createdDate = value; }
        }
        #endregion
    }
}
