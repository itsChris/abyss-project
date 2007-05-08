using System;
using Persistence;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace DAO {
    public class OracleUserDAO : OracleDAO {
        #region Public Static Methods
        public static OracleDataReader GetDefaultTablespace() {
            string query = "select TABLESPACE_NAME FROM DBA_DATA_FILES order by TABLESPACE_NAME";
            return ExecuteReader(query);
        }

        public static OracleDataReader GetTemporatyTablespace() {
            string query = "select TABLESPACE_NAME FROM DBA_TEMP_FILES order by TABLESPACE_NAME";
            return ExecuteReader(query);
        }

        public static OracleDataReader GetUsersProfile() {
            string query = "SELECT DISTINCT PROFILE FROM DBA_PROFILES ORDER BY PROFILE";
            return ExecuteReader(query);
        }

        public static OracleDataReader GetRoleList() {
            string query = "SELECT ROLE FROM DBA_ROLES ORDER BY ROLE";
            return ExecuteReader(query);
        }

        public static OracleDataReader GetPrivilegesListFromUser(string userName) {
            string query = "SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE ="+userName;
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
                ExecuteNonQuery(query);
            }
        }







        public static OracleDataReader GetOracleUsers() {
            string query = "SELECT USERNAME " +
                "FROM DBA_USERS " +
                "ORDER BY USERNAME";
            return ExecuteReader(query);
        }

        public static OracleDataReader GetUserData(string userName) {
            string query = "select USERNAME," +
                   "USER_ID," +
                   "DEFAULT_TABLESPACE," +
                   "TEMPORARY_TABLESPACE," +
                   "PASSWORD," +
                   "ACCOUNT_STATUS," +
                   "PROFILE," +
                   "CREATED " +
            "from DBA_USERS " +
            "WHERE USERNAME=" + userName;
            return ExecuteReader(query);
        }

        

        public static void EditOracleUser(OracleUserData oracleUserData) {
            string query = "ALTER USER " + oracleUserData.UserLogin +
                  " IDENTIFIED EXTERNALLY " +
                  " DEFAULT TABLESPACE " + oracleUserData.DefaultTablespace +
                  " TEMPORARY TABLESPACE " + oracleUserData.TemporatyTablespace +
                  " PROFILE " + oracleUserData.Profile;

            ExecuteNonQuery(query);

            foreach (String role in oracleUserData.Roles) {
                query = "GRANT " + role + "to" + oracleUserData.UserLogin;
                ExecuteNonQuery(query);
            }
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
