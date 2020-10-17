using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object;
using System.Data.SqlClient;
using System.Data;
using Handling;


namespace DAL
{
    public class getDataDAL
    {
        static SqlConnection mycon = getConnectionSql.connectToSql();
        public static DataTable getTable(string procName)
        {
            DataTable tb = new DataTable();

            SqlCommand cmd = new SqlCommand(procName, mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            mycon.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(tb);

            mycon.Close();

            return tb;
        }

        public static DataTable getTableById(string procName, string id)
        {
            DataTable tb = new DataTable();

            SqlCommand cmd = new SqlCommand(procName, mycon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            mycon.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(tb);

            mycon.Close();

            return tb;
        }

      
    }
}
