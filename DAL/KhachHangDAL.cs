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
    public class KhachHangDAL
    {
        static SqlConnection mycon = getConnectionSql.connectToSql();

        public static void insert(Obj_KhachHang obj_KhachHang)
        {
            SqlCommand cmd = new SqlCommand("pro_insertIntoKhachhang", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Makhach", obj_KhachHang.Makhach1);
            cmd.Parameters.AddWithValue("@Tenkhach", obj_KhachHang.Tenkhach1);
            cmd.Parameters.AddWithValue("@DiaChi", obj_KhachHang.Diachi1);
            cmd.Parameters.AddWithValue("@DienThoai", obj_KhachHang.Dienthoai1);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void update(Obj_KhachHang obj_KhachHang)
        {
            SqlCommand cmd = new SqlCommand("proc_updateKhachhang", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Makhach", obj_KhachHang.Makhach1);
            cmd.Parameters.AddWithValue("@Tenkhach", obj_KhachHang.Tenkhach1);
            cmd.Parameters.AddWithValue("@Diachi", obj_KhachHang.Diachi1);
            cmd.Parameters.AddWithValue("@Dienthoai", obj_KhachHang.Dienthoai1);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void delete(string id)
        {
            SqlCommand cmd = new SqlCommand("proc_deleteFromKhachhang", mycon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Makhach", id);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }
    }
}
