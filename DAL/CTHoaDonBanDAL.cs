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
    public class CTHoaDonBanDAL
    {

        static SqlConnection mycon = getConnectionSql.connectToSql();
        public static void insert(Obj_CTHoaDonBan obj_CTHoaDonBan)
        {
            SqlCommand cmd = new SqlCommand("proc_insertIntoCTHoadonban", mycon);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@SoHDB", obj_CTHoaDonBan.SoHDB1);
            cmd.Parameters.AddWithValue("@Mahang", obj_CTHoaDonBan.MaHang1);
            cmd.Parameters.AddWithValue("@Soluong", obj_CTHoaDonBan.SoLuong1);
            cmd.Parameters.AddWithValue("@Dongia", obj_CTHoaDonBan.DonGia1);
            cmd.Parameters.AddWithValue("@Giamgia", obj_CTHoaDonBan.GiamGia1);
            cmd.Parameters.AddWithValue("@Thanhtien", obj_CTHoaDonBan.ThanhTien1);

            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();

        }

        public static bool isDuplicateMaHH(string Sohdn, string Mahanghoa)
        {
            SqlCommand cmd = new SqlCommand("DuplicateMahanghoa", mycon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Sohdn", Sohdn);
            cmd.Parameters.AddWithValue("@Mahang", Mahanghoa);

            DataTable tb = new DataTable();

            mycon.Open();

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);

            mycon.Close();

            return tb.Rows.Count > 0;
        }
    }
}
