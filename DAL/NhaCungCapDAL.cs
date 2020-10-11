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
    public class NhaCungCapDAL
    {
        static SqlConnection mycon = getConnectionSql.connectToSql();

        public static void insert(Obj_NhaCungCap obj_NhaCungCap)
        {
            SqlCommand cmd = new SqlCommand("pro_insertIntoNhaCC", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNCC", obj_NhaCungCap.MaNCC1);
            cmd.Parameters.AddWithValue("@TenNCC", obj_NhaCungCap.TenNCC1);
            cmd.Parameters.AddWithValue("@DiaChi", obj_NhaCungCap.DiaChi1);
            cmd.Parameters.AddWithValue("@DienThoai", obj_NhaCungCap.DienTHoai1);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void update(Obj_NhaCungCap obj_NhaCungCap)
        {
            SqlCommand cmd = new SqlCommand("proc_updateNCC", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNCC", obj_NhaCungCap.MaNCC1);
            cmd.Parameters.AddWithValue("@TenNCC", obj_NhaCungCap.TenNCC1);
            cmd.Parameters.AddWithValue("@Diachi", obj_NhaCungCap.DiaChi1);
            cmd.Parameters.AddWithValue("@Dienthoai", obj_NhaCungCap.DienTHoai1);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void delete(string id)
        {
            SqlCommand cmd = new SqlCommand("proc_deleteFromNhaCC", mycon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNCC", id);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }
    }
}
