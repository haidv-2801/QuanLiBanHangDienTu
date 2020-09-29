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
    public class CTHoaDonNhapDAL
    {

        static SqlConnection mycon = getConnectionSql.connectToSql();
        public static void insert(Obj_CTHoaDonNhap obj_CTHoaDonNhap)
        {
            SqlCommand cmd = new SqlCommand("proc_insertIntoCTHoadonnhap", mycon);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@SoHDN", obj_CTHoaDonNhap.SoHDN1);
            cmd.Parameters.AddWithValue("@Mahang", obj_CTHoaDonNhap.MaHang1);
            cmd.Parameters.AddWithValue("@Soluong", obj_CTHoaDonNhap.SoLuong1);
            cmd.Parameters.AddWithValue("@Dongia", obj_CTHoaDonNhap.DonGia1);
            cmd.Parameters.AddWithValue("@Giamgia", obj_CTHoaDonNhap.GiamGia1);
            cmd.Parameters.AddWithValue("@Thanhtien", obj_CTHoaDonNhap.ThanhTien1);

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
