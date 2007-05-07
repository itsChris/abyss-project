using System;
using System.Collections.Generic;
using System.Text;
using Persistence;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace DAO {
    public class OracleUserDAO : OracleDAO {

        #region Public Static Methods
        public static void SaveOracleUser(OracleUserData oracleUserData) {
            string query = "CREATE USER " + oracleUserData.UserLogin;

            if (oracleUserData.ExternalUser) {
                query += " IDENTIFIED EXTERNALLY ";
            }
            else
            {
                query += " IDENTIFIED BY " + oracleUserData.UserPassword;
            }

            query += " DEFAULT TABLESPACE " + oracleUserData.DefaultTablespace +
              " TEMPORARY TABLESPACE " + oracleUserData.TemporatyTablespace +
              " PROFILE " + oracleUserData.Profile;

            if (oracleUserData.PasswordExpire) {
                query += " PASSWORD EXPIRE";
            }

            if (oracleUserData.Account) {
                query += " ACCOUNT UNLOCK";
            }
            else {
                query += " ACCOUNT LOCK";
            }

            ExecuteNonQuery(query);

        }

        public static void EditPasswordOracleUser(OracleUserData oracleUserData, string newPassword) {
            string query = "ALTER USER " + oracleUserData.UserLogin + " IDENTIFIED BY " + newPassword + " REPLACE " + oracleUserData.UserPassword;
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

        public static OracleDataReader GetOracleUser() {
            string query = "select USERNAME," +
                   "USER_ID," +
                   "DEFAULT_TABLESPACE," +
                   "TEMPORARY_TABLESPACE," +
                   "PASSWORD," +
                   "ACCOUNT_STATUS," +
                   "PROFILE," +
                   "CREATED " +
            "from DBA_USERS " +
            "order by USERNAME";

            return ExecuteReader(query);
        }

        public static OracleDataReader GetDefaultTablespace() {
            string query = "select TABLESPACE_NAME from DBA_DATA_FILES order by TABLESPACE_NAME";
            return ExecuteReader(query);
        }

        public static OracleDataReader GetTemporatyTablespace() {
            string query = "select TABLESPACE_NAME from DBA_TEMP_FILES order by TABLESPACE_NAME";
            return ExecuteReader(query);
        }

        public static OracleDataReader GetUserProfile() {
            string query = "SELECT DISTINCT PROFILE FROM DBA_PROFILES ORDER BY PROFILE";

            return ExecuteReader(query);
        }

        public static void ExecuteNonQuery(string query) {
            OracleCommand cmd = getInstance().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static OracleDataReader ExecuteReader(string query) {
            OracleCommand cmd = getInstance().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            OracleDataReader reader = cmd.ExecuteReader();
            cmd.Dispose();

            return reader;
        }
        #endregion
    }
}
