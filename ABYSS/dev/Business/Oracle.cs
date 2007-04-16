using System;
using System.Data;

namespace Business {
    public class Oracle {
       

        


   

      

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
