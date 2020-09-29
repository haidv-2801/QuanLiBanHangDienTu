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
    public class HoaDonNhapDAL
    {

        static SqlConnection mycon = getConnectionSql.connectToSql();
        public static void insert(Obj_HoaDonNhap hoaDonNhapObj)
        {
            SqlCommand cmd = new SqlCommand("proc_insertIntoHoadonnhap", mycon);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@SoHDN", hoaDonNhapObj.SoHDN1);
            cmd.Parameters.AddWithValue("@MaNV", hoaDonNhapObj.MaNV1);
            cmd.Parameters.AddWithValue("@Ngaynhap", hoaDonNhapObj.NgayNhap1);
            cmd.Parameters.AddWithValue("@MaNCC", hoaDonNhapObj.MaNCC1);
            cmd.Parameters.AddWithValue("@Tongtien", hoaDonNhapObj.TongTien1);

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
