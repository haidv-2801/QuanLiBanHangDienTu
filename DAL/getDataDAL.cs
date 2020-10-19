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

        public static DataSet SPBanChayNhat(string Manhanvien)
        {
            SqlCommand command = new SqlCommand("pro_getDataForQuestion6", mycon);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Manhanvien", Manhanvien);

            command.Connection = mycon;
            mycon.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(command);
            dap.Fill(ds);
            mycon.Close();
            return ds;
        }

        public static DataSet HoadonVaTongtien(string MaNCC)
        {
            SqlCommand command = new SqlCommand("pro_getDataForQuestion7", mycon);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@MaNCC", MaNCC);

            command.Connection = mycon;
            mycon.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(command);
            dap.Fill(ds);
            mycon.Close();
            return ds;
        }

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
