using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Handling;
using Object;

namespace DAL
{
    public class HoaDonBanDAL
    {

        static SqlConnection mycon = getConnectionSql.connectToSql();
        public static void insert(Obj_HoaDonBan obj_HoaDonBan)
        {
            SqlCommand cmd = new SqlCommand("proc_insertIntoHoadonban", mycon);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@SoHDB", obj_HoaDonBan.SoHDB1);
            cmd.Parameters.AddWithValue("@MaNV", obj_HoaDonBan.MaNV1);
            cmd.Parameters.AddWithValue("@Ngayban", obj_HoaDonBan.NgayBan1);
            cmd.Parameters.AddWithValue("@Makhach", obj_HoaDonBan.MaKhach1);
            cmd.Parameters.AddWithValue("@Tongtien", obj_HoaDonBan.TongTien1);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();

        }

        /*public static void delete(string id)
        {
            SqlCommand cmd = new SqlCommand("proc_deleteFromHoadonnhap", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("", id);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }*/
    }
}
