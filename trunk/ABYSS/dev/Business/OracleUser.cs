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
            this.oracleUserData.Account = false;
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

        public bool Account {
            get { return oracleUserData.Account; }
            set { oracleUserData.Account = value; }
        }

        public string CreatedDate {
            get { return oracleUserData.CreatedDate; }
            set { oracleUserData.CreatedDate = value; }
        }

        public ArrayList Roles {
            get { return oracleUserData.Roles; }
            set { oracleUserData.Roles = value; }
        }
        #endregion

        #region Static Methods
        public static ArrayList GetDefaultTablespace() {
            ArrayList list = new ArrayList();
            OracleDataReader reader = OracleUserDAO.GetDefaultTablespace();
            if (reader != null) {
                while (reader.Read()) {
                    list.Add(reader.GetValue(0));
                }
                reader.Close();
                return list;
            }
            return null;
        }

        public static ArrayList GetTemporaryTablespace() {
            ArrayList list = new ArrayList();
            OracleDataReader reader = OracleUserDAO.GetTemporatyTablespace();
            if (reader != null) {
                while (reader.Read()) {
                    list.Add(reader.GetValue(0));
                }
                reader.Close();
                return list;
            }
            return null;
        }

        public static ArrayList GetUsersProfile() {
            ArrayList list = new ArrayList();
            OracleDataReader reader = OracleUserDAO.GetUsersProfile();
            if (reader != null) {
                while (reader.Read()) {
                    list.Add(reader.GetValue(0));
                }
                reader.Close();
                return list;
            }
            return null;
        }

        public static ArrayList GetRoles() {
            ArrayList list = new ArrayList();
            OracleDataReader reader = OracleUserDAO.GetRoleList();
            if (reader != null) {
                while (reader.Read()) {
                    list.Add(reader.GetValue(0));
                }
                reader.Close();
                return list;
            }
            return null;
        }

        public static ArrayList GetPrivilegesListFromUser(String userName) {
            ArrayList list = new ArrayList();
            OracleDataReader reader = OracleUserDAO.GetPrivilegesListFromUser(userName);
            if (reader != null) {
                while (reader.Read()) {
                    list.Add(reader.GetValue(0));
                }
                reader.Close();
                return list;
            }
            return null;
        }




        public static ArrayList GetUsers() {
            ArrayList list = new ArrayList();
            OracleDataReader reader = OracleUserDAO.GetOracleUsers();
            if(reader != null){
                while (reader.Read()) {
                list.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
                return list;
            }
            return null;
        }

        public static OracleDataReader GetUserData(string userName) {
            return OracleUserDAO.GetUserData(userName);
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
        #endregion      
    }
}
