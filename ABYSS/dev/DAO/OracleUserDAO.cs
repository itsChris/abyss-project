using System;
using Persistence;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using System.Collections;

namespace DAO {
    public class OracleUserDAO : OracleDAO {
        #region Public Static Methods
        public static ArrayList GetDefaultTablespace() {
            string query = "select TABLESPACE_NAME FROM DBA_DATA_FILES order by TABLESPACE_NAME";
            OracleDataReader reader = ExecuteReader(query);
            ArrayList list = new ArrayList();
            if (reader != null) {
                while (reader.Read()) {
                    list.Add(reader.GetValue(0));
                }
                reader.Close();
                return list;
            }
            return null;
        }

        public static ArrayList GetTemporatyTablespace() {
            string query = "select TABLESPACE_NAME FROM DBA_TEMP_FILES order by TABLESPACE_NAME";
            OracleDataReader reader = ExecuteReader(query);
            ArrayList list = new ArrayList();
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
            string query = "SELECT DISTINCT PROFILE FROM DBA_PROFILES ORDER BY PROFILE";
            OracleDataReader reader = ExecuteReader(query);
            ArrayList list = new ArrayList();
            if (reader != null) {
                while (reader.Read()) {
                    list.Add(reader.GetValue(0));
                }
                reader.Close();
                return list;
            }
            return null;
        }

        public static ArrayList GetRoleList() {
            string query = "SELECT ROLE FROM DBA_ROLES ORDER BY ROLE";
            OracleDataReader reader = ExecuteReader(query);
            ArrayList list = new ArrayList();
            if (reader != null) {
                while (reader.Read()) {
                    list.Add(reader.GetValue(0));
                }
                reader.Close();
                return list;
            }
            return null;
        }

        public static OracleDataReader GetPrivilegesListFromUser(string userName) {
            string query = "SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + userName + "'";
            return ExecuteReader(query);
        }

        public static void SaveOracleUser(OracleUserData oracleUserData) {
            string query = "CREATE USER " + oracleUserData.UserLogin +
                  " IDENTIFIED EXTERNALLY" +
                  " DEFAULT TABLESPACE " + oracleUserData.DefaultTablespace +
                  " TEMPORARY TABLESPACE " + oracleUserData.TemporatyTablespace +
                  " PROFILE " + oracleUserData.Profile;
            if (oracleUserData.IsEnable) {
                query += " ACCOUNT UNLOCK";
            }
            else {
                query += " ACCOUNT LOCK";
            }
            ExecuteNonQuery(query);
            foreach (String role in oracleUserData.Roles) {
                query = "GRANT " + role + " TO " + oracleUserData.UserLogin;
                try {
                    ExecuteNonQuery(query);
                }
                catch (Exception) {
                }
            }
        }

        public static void EditOracleUser(OracleUserData oracleUserData) {
            string query = "ALTER USER " + oracleUserData.UserLogin +
                  " IDENTIFIED EXTERNALLY" +
                  " DEFAULT TABLESPACE " + oracleUserData.DefaultTablespace +
                  " TEMPORARY TABLESPACE " + oracleUserData.TemporatyTablespace +
                  " PROFILE " + oracleUserData.Profile;
            if (oracleUserData.IsEnable) {
                query += " ACCOUNT UNLOCK";
            }
            else {
                query += " ACCOUNT LOCK";
            }
            ExecuteNonQuery(query);
            foreach (String role in oracleUserData.LastRoleList) {
                query = "REVOKE " + role + " FROM " + oracleUserData.UserLogin;
                try {
                    ExecuteNonQuery(query);
                }
                catch (Exception) {
                }
            }
            foreach (String role in oracleUserData.Roles) {
                query = "GRANT " + role + " TO " + oracleUserData.UserLogin;
                try {
                    ExecuteNonQuery(query);
                }
                catch (Exception) {
                }
            }
        }

        public static ArrayList GetOracleUsers() {
            string query = "SELECT USERNAME " +
                "FROM DBA_USERS " +
                "ORDER BY USERNAME";
            ArrayList list = new ArrayList();
            OracleDataReader reader = ExecuteReader(query);
            if (reader != null) {
                while (reader.Read()) {
                    OracleUserData user = GetUserData(reader.GetValue(0).ToString());
                    list.Add(user);
                }
                reader.Close();
                return list;
            }
            return null;
        }

        public static OracleUserData GetUserData(string userName) {
            string query = "select USERNAME, " +
                   "USER_ID, " +
                   "DEFAULT_TABLESPACE, " +
                   "TEMPORARY_TABLESPACE ," +
                   "PASSWORD, " +
                   "ACCOUNT_STATUS, " +
                   "PROFILE, " +
                   "CREATED " +
            "from DBA_USERS " +
            "WHERE USERNAME = '" + userName + "'";
            OracleDataReader reader = ExecuteReader(query);
            if (reader != null) {
                OracleUserData oracleUserData = new OracleUserData();
                while (reader.Read()) {
                    oracleUserData.UserLogin = (string)reader.GetValue(0);
                    oracleUserData.CreatedDate = reader.GetValue(7).ToString();
                    oracleUserData.DefaultTablespace = (string)reader.GetValue(2);
                    oracleUserData.TemporatyTablespace = (string)reader.GetValue(3);
                    string account = reader.GetValue(5).ToString();
                    if(account.ToUpper().Contains("LOCKED")){
                        oracleUserData.IsEnable = false;
                    }
                    else{
                        oracleUserData.IsEnable = true;
                    }
                    oracleUserData.Profile = (string)reader.GetValue(6);
                }
                reader.Close();
                return oracleUserData;
            }
            return null;
        }

        

        

        public static void LockOracleUser(OracleUserData oracleUserData) {
            string query = "ALTER USER " + oracleUserData.UserLogin + " ACCOUNT LOCK";
            ExecuteNonQuery(query);
        }

        public static void UnlockOracleUser(OracleUserData oracleUserData) {
            string query = "ALTER USER " + oracleUserData.UserLogin + " ACCOUNT UNLOCK";
            ExecuteNonQuery(query);
        }

        

        public static void EditTablespaces(OracleUserData oracleUserData) {
            string query = "ALTER USER " + oracleUserData.UserLogin + " DEFAULT TABLESPACE " + oracleUserData.DefaultTablespace +
                " TEMPORARY TABLESPACE " + oracleUserData.TemporatyTablespace;
            ExecuteNonQuery(query);
        }

        public static void DeleteOracleUser(OracleUserData oracleUserData) {
            string query = "DROP USER " + oracleUserData.UserLogin + " CASCADE";
            ExecuteNonQuery(query);
        }

        

       

        

        
        #endregion
    }
}
