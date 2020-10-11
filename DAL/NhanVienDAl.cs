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
    public class NhanVienDAL
    {
        static SqlConnection mycon = getConnectionSql.connectToSql();

        public static void insert(Obj_NhanVien obj_NhanVien)
        {
            SqlCommand cmd = new SqlCommand("pro_insertIntoNhanvien", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNV", obj_NhanVien.MaNV1);
            cmd.Parameters.AddWithValue("@TenNV", obj_NhanVien.TenNV1);
            cmd.Parameters.AddWithValue("@Gioitinh", obj_NhanVien.GioiTinh1);
            cmd.Parameters.AddWithValue("@Ngaysinh", obj_NhanVien.NgaySinh1);
            cmd.Parameters.AddWithValue("@Dienthoai", obj_NhanVien.DienThoai1);
            cmd.Parameters.AddWithValue("@Diachi", obj_NhanVien.DiaChi1);
            cmd.Parameters.AddWithValue("@Maca", obj_NhanVien.MaCa1);
            cmd.Parameters.AddWithValue("@MaCV", obj_NhanVien.MaCV1);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void delete(string id)
        {
            SqlCommand cmd = new SqlCommand("proc_deleteFromNhanvien", mycon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", id);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void update(Obj_NhanVien obj_NhanVien)
        {
            SqlCommand cmd = new SqlCommand("pro_updateIntoNhanvien", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNV", obj_NhanVien.MaNV1);
            cmd.Parameters.AddWithValue("@Tennhanvien", obj_NhanVien.TenNV1);
            cmd.Parameters.AddWithValue("@Gioitinh", obj_NhanVien.GioiTinh1);
            cmd.Parameters.AddWithValue("@Ngaysinh", obj_NhanVien.NgaySinh1);
            cmd.Parameters.AddWithValue("@Dienthoai", obj_NhanVien.DienThoai1);
            cmd.Parameters.AddWithValue("@Diachi", obj_NhanVien.DiaChi1);
            cmd.Parameters.AddWithValue("@Maca", obj_NhanVien.MaCa1);
            cmd.Parameters.AddWithValue("@MaCV", obj_NhanVien.MaCV1);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

    }
}
