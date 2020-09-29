using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Handling;

namespace DAL
{
    public class NhaCungCapDAL
    {
        static SqlConnection mycon = getConnectionSql.connectToSql();

        public static DataTable getTable()
        {
            DataTable tb = new DataTable();

            SqlCommand cmd = new SqlCommand("pro_getAllHangHoa", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            mycon.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(tb);

            mycon.Close();

            return tb;
        }
    }
}
