using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Handling;
using Object;

namespace DAL
{
    public class ChatLieuDAL
    {
        static SqlConnection mycon = getConnectionSql.connectToSql();

        public static void insert(Obj_ChatLieu obj_ChatLieu)
        {
            SqlCommand cmd = new SqlCommand("pro_insertIntoChatlieu", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Machatlieu", obj_ChatLieu.MaCL1);
            cmd.Parameters.AddWithValue("@Tenchatlieu", obj_ChatLieu.TenCL1);
           
            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void delete(string id)
        {
            SqlCommand cmd = new SqlCommand("proc_deleteFromChatlieu", mycon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Macl", id);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void update(Obj_ChatLieu obj_ChatLieu)
        {
            SqlCommand cmd = new SqlCommand("pro_updateIntoChatlieu", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Machatlieu", obj_ChatLieu.MaCL1);
            cmd.Parameters.AddWithValue("@Tenchatlieu", obj_ChatLieu.TenCL1);
            

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

    }
}
