using System;
using System.Collections;

namespace Persistence {
    [Serializable()]public class OracleUserData {
        #region Attribut
        private string userLogin;
        private string defaultTablespace;
        private string temporatyTablespace;
        private string profile;
        private ArrayList roles;
        private bool isEnable; //Lock (true) or Unlock(false)
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

        public bool IsEnable {
            get { return isEnable; }
            set { isEnable = value; }
        }

        public ArrayList Roles {
            get { return roles; }
            set { roles = value; }
        }

        public string CreatedDate {
            get { return createdDate; }
            set { createdDate = value; }
        }
        #endregion
    }
}
