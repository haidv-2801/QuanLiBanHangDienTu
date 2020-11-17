using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object;
using System.Data.SqlClient;
using System.Data;
using Handling;
using System.Drawing;

namespace DAL
{
    public class HangHoaDAL
    {
        static SqlConnection mycon = getConnectionSql.connectToSql();

        public static void insert(Obj_HangHoa hangHoaObj)
        {
            SqlCommand cmd = new SqlCommand("proc_insertIntoHangHoa", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Mahang", hangHoaObj.MaHang1);
            cmd.Parameters.AddWithValue("@Tenhang", hangHoaObj.TenHang1);
            cmd.Parameters.AddWithValue("@Soluong", hangHoaObj.SoLuong1);
            cmd.Parameters.AddWithValue("@Dongianhap", hangHoaObj.DonGiaNhap1);
           // cmd.Parameters.AddWithValue("@Dongiaban", hangHoaObj.DonGiaBan1);


            cmd.Parameters.AddWithValue("@Manhom", hangHoaObj.MaNhom1);
            cmd.Parameters.AddWithValue("@Maloai", hangHoaObj.MaLoai1);
            cmd.Parameters.AddWithValue("@Madonvi", hangHoaObj.MaDonVi1);
            cmd.Parameters.AddWithValue("@Machatlieu", hangHoaObj.MaChatLieu1);
            cmd.Parameters.AddWithValue("@ManuocSx", hangHoaObj.MaNuocSX1);

            cmd.Parameters.AddWithValue("@Thoigianbaohanh", hangHoaObj.ThoiGianBH1);
            cmd.Parameters.AddWithValue("@Ghichu", hangHoaObj.GhiChu1);
            cmd.Parameters.AddWithValue("@Anh", hangHoaObj.Anh1);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();

        }

        public static void delete(string id)
        {
            SqlCommand cmd = new SqlCommand("proc_deleteFromHanghoa", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Mahang", id);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void update(Obj_HangHoa hangHoaObj)
        {
            SqlCommand cmd = new SqlCommand("proc_updateHangHoa", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Mahang", hangHoaObj.MaHang1);
            cmd.Parameters.AddWithValue("@Tenhang", hangHoaObj.TenHang1);
            cmd.Parameters.AddWithValue("@Soluong", hangHoaObj.SoLuong1);
            cmd.Parameters.AddWithValue("@Dongianhap", hangHoaObj.DonGiaNhap1);
           // cmd.Parameters.AddWithValue("@Dongiaban", hangHoaObj.DonGiaBan1);


            cmd.Parameters.AddWithValue("@Manhom", hangHoaObj.MaNhom1);
            cmd.Parameters.AddWithValue("@Maloai", hangHoaObj.MaLoai1);
            cmd.Parameters.AddWithValue("@Madonvi", hangHoaObj.MaDonVi1);
            cmd.Parameters.AddWithValue("@Machatlieu", hangHoaObj.MaChatLieu1);
            cmd.Parameters.AddWithValue("@ManuocSx", hangHoaObj.MaNuocSX1);

            cmd.Parameters.AddWithValue("@Thoigianbaohanh", hangHoaObj.ThoiGianBH1);
            cmd.Parameters.AddWithValue("@Ghichu", hangHoaObj.GhiChu1);
            cmd.Parameters.AddWithValue("@Anh", hangHoaObj.Anh1);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();

        }

    }
}
