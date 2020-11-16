using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object;
using System.Data.SqlClient;

using Handling;
using System.Data;

namespace DAL
{
    public class TaiKhoanDAL
    {
        static SqlConnection mycon = getConnectionSql.connectToSql();

        public static void insert(TaiKhoan taiKhoan)
        {
            SqlCommand cmd = new SqlCommand("pro_insertIntoTaiKhoan", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenTaiKhoan", taiKhoan.TenTaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
            cmd.Parameters.AddWithValue("@Trangthai", taiKhoan.TrangThai);
            cmd.Parameters.AddWithValue("@Quyen", taiKhoan.PhanQuyen);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void delete(string id)
        {
            SqlCommand cmd = new SqlCommand("proc_deleteFromTaikhoan", mycon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenTaiKhoan", id);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void update(TaiKhoan taiKhoan)
        {
            SqlCommand cmd = new SqlCommand("pro_updateIntoTaikhoan", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenTaiKhoan", taiKhoan.TenTaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
            cmd.Parameters.AddWithValue("@Trangthai", taiKhoan.TrangThai);
            cmd.Parameters.AddWithValue("@Quyen", taiKhoan.PhanQuyen);


            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

    }
}
