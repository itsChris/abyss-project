using System;
using System.Collections.Generic;
using System.Text;
using Persistence;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace DAO {
    class OracleUserDAO:OracleDAO {

        #region Public Static Methods
        public static void SaveOracleUser(OracleUserData oracleUserData) {
            string query = "CREATE USER " + oracleUserData.UserLogin +
                    "IDENTIFIED BY " + oracleUserData.UserPassword +
                    "DEFAULT TABLESPACE " + oracleUserData.DefaultTablespace +
                    "TEMPORARY TABLESPACE " + oracleUserData.TemporatyTablespace +
                    "PROFILE " + oracleUserData.Profile;

            if (oracleUserData.PasswordExpire) {
                query += "PASSWORD EXPIRE";
            }

            if (oracleUserData.Account) {
                query += "ACCOUNT UNLOCK";
            }
            else {
                query += "ACCOUNT LOCK";
            }

            OracleCommand cmd = getInstance().CreateCommand();            
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }
        #endregion
    }
}
