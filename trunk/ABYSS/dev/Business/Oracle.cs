using System;
using System.Collections.Generic;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Configuration;

namespace Business {
    class Oracle {

        #region Constructors

        public Oracle() {
        }

        #endregion

        #region public function

        public OracleConnection connectDataBase() {

            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["OraConnect"].ConnectionString);

            try {
                con.Open();
                return con;
            }
            catch (OracleException oex) {
                Console.WriteLine("Oracle DataBase Connection Error : " + oex.Message);
                return null;
            }   

        }

        public OracleDataReader executeQuery(string query, OracleConnection con) {

            try {
                OracleCommand cmd = new OracleCommand(query);
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                cmd.Dispose();
                return reader;
            }
            catch (OracleException oex) {
                Console.WriteLine("Oracle Query Execution Error : " + oex.Message);
                return null;
            }

        }

        public void executeNonQuery(string query, OracleConnection con) {

            try {
                OracleCommand cmd = new OracleCommand(query);
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (OracleException oex) {
                Console.WriteLine("Oracle NonQuery Execution Error : " + oex.Message);
            }
        }

        public void disconnectDataBase(OracleConnection con) {

            con.Dispose();

        }

        #endregion
    }
}
