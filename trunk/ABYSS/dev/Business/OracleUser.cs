using System;
using DAO;
using Persistence;
using System.Collections;

namespace Business {
    public class OracleUser {

        #region Attributes
        private OracleUserData oracleUserData;
        #endregion

        #region Constructors
        public OracleUser() {
            this.oracleUserData = new OracleUserData();
            this.oracleUserData.Account = true;
            this.oracleUserData.PasswordExpire = true;
        }

        public OracleUser(OracleUserData oracleUserData) {
            this.oracleUserData = oracleUserData;
        }
        #endregion

        #region Public Methods

        #endregion






        //    public OracleDataReader executeQuery(string query, OracleConnection con) {

        //        try {
        //            OracleCommand cmd = new OracleCommand(query);
        //            cmd.Connection = con;
        //            cmd.CommandType = CommandType.Text;
        //            OracleDataReader reader = cmd.ExecuteReader();
        //            cmd.Dispose();
        //            return reader;
        //        }
        //        catch (OracleException oex) {
        //            Console.WriteLine("Oracle Query Execution Error : " + oex.Message);
        //            return null;
        //        }

        //    }

        //    public void executeNonQuery(string query, OracleConnection con) {

        //        try {
        //            OracleCommand cmd = new OracleCommand(query);
        //            cmd.Connection = con;
        //            cmd.CommandType = CommandType.Text;
        //            cmd.ExecuteNonQuery();
        //            cmd.Dispose();
        //        }
        //        catch (OracleException oex) {
        //            Console.WriteLine("Oracle NonQuery Execution Error : " + oex.Message);
        //        }
        //    }

        //    public void disconnectDataBase(OracleConnection con) {

        //        con.Dispose();

        //    }

        //    #endregion
        //}
    }
}
