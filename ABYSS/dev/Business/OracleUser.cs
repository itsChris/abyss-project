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
            this.oracleUserData.IsEnable = true;
        }

        public OracleUser(OracleUserData oracleUserData) {
            this.oracleUserData = oracleUserData;
        }
        #endregion

        #region Properties
        public string UserLogin {
            get { return oracleUserData.UserLogin; }
            set { oracleUserData.UserLogin = value; }
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

        public bool IsEnable {
            get { return oracleUserData.IsEnable; }
            set { oracleUserData.IsEnable = value; }
        }

        public string CreatedDate {
            get { return oracleUserData.CreatedDate; }
            set { oracleUserData.CreatedDate = value; }
        }

        public ArrayList Roles {
            get { return oracleUserData.Roles; }
            set { oracleUserData.Roles = value; }
        }

        public ArrayList LastRoleList {
            get {return oracleUserData.LastRoleList;}
            set { oracleUserData.LastRoleList = value; }
        }
        #endregion

        #region Static Methods
        public static ArrayList GetDefaultTablespace() {
            return OracleUserDAO.GetDefaultTablespace();
        }

        public static ArrayList GetTemporaryTablespace() {
            return OracleUserDAO.GetTemporatyTablespace();
        }

        public static ArrayList GetUsersProfile() {
            return OracleUserDAO.GetUsersProfile();
        }

        public static ArrayList GetRoles() {
            return OracleUserDAO.GetRoleList();
        }

        public static ArrayList GetPrivilegesListFromUser(String userName) {
            return OracleUserDAO.GetPrivilegesListFromUser(userName);
        }

        public static ArrayList GetUsers() {
           return  OracleUserDAO.GetOracleUsers();
        }

        public static OracleUser GetUserData(string userName) {
            OracleUserData userData = OracleUserDAO.GetUserData(userName);
            if(userData != null){
                return new OracleUser((OracleUserData)userData);
            }
            return null;
        }
        #endregion

        #region Public Methods
        public void save() {
            OracleUserDAO.SaveOracleUser(this.oracleUserData);
        }

        public void edit() {
            OracleUserDAO.EditOracleUser(this.oracleUserData);
        }
        
        public void delete() {
            OracleUserDAO.DeleteOracleUser(this.oracleUserData);
        }

        public void LockUser() {
            OracleUserDAO.LockOracleUser(this.oracleUserData);
        }

        public void UnlockUser() {
            OracleUserDAO.UnlockOracleUser(this.oracleUserData);
        }
        #endregion      
    }
}
