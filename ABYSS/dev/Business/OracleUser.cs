using System;
using DAO;
using Persistence;
using System.Collections;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Business {
    public class OracleUser {
        #region Attributes
        private OracleUserData oracleUserData;
        #endregion

        #region Constructors
        public OracleUser() {
            this.oracleUserData = new OracleUserData();
            this.oracleUserData.Account = true;
        }

        public OracleUser(OracleUserData oracleUserData) {
            this.oracleUserData = oracleUserData;
        }
        #endregion

        #region Public Methods
        public void save() {
            OracleUserDAO.SaveOracleUser(this.oracleUserData);
        }

        public void delete() {
            OracleUserDAO.DeleteOracleUser(this.oracleUserData);
        }

        public void edit(){
            OracleUserDAO.EditOracleUser(this.oracleUserData);
        }

        public void LockUser() {
            OracleUserDAO.LockOracleUser(this.oracleUserData);
        }

        public void UnlockUser() {
            OracleUserDAO.UnlockOracleUser(this.oracleUserData);
        }

        public OracleDataReader GetDefaultTablespace() {
            return OracleUserDAO.GetDefaultTablespace();
        }

        public OracleDataReader GetTemporaryTablespace() {
            return OracleUserDAO.GetTemporatyTablespace();
        }

        public OracleDataReader GetUser() {
            return OracleUserDAO.GetOracleUser();
        }

        public OracleDataReader GetUserData(string userName) {
            return OracleUserDAO.GetUserData(userName);
        }

        public OracleDataReader GetProfile() {
            return OracleUserDAO.GetUserProfile();
        }
        #endregion

        #region Properties
        public string UserLogin {
            get { return oracleUserData.UserLogin; }
            set { oracleUserData.UserLogin = value; }
        }
        public string UserPassword {
            get { return oracleUserData.UserPassword; }
            set { oracleUserData.UserPassword = value; }
        }
        public bool ExternalUser {
            get { return oracleUserData.ExternalUser; }
            set { oracleUserData.ExternalUser = value; }
        }
        public string DefaultTablespace {
            get { return oracleUserData.DefaultTablespace; }
            set { oracleUserData.DefaultTablespace = value; }
        }
        public string TemporatyTablespace {
            get { return oracleUserData.TemporatyTablespace; }
            set { oracleUserData.TemporatyTablespace = value; }
        }
        public string Profile {
            get { return oracleUserData.Profile; }
            set { oracleUserData.Profile = value; }
        }
        public bool PasswordExpire {
            get { return oracleUserData.PasswordExpire; }
            set { oracleUserData.PasswordExpire = value; }
        }
        public bool Account {
            get { return oracleUserData.Account; }
            set { oracleUserData.Account = value; }
        }
        public string CreatedDate {
            get { return oracleUserData.CreatedDate; }
            set { oracleUserData.CreatedDate = value; }
        }
        #endregion

    }
}
