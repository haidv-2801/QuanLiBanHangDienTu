using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_HoaDonBan
    {
        private string SoHDB;
        private string MaNV;
        private DateTime NgayBan;
        private string MaKhach;
        private float TongTien;

        public Obj_HoaDonBan(string soHDB, string maNV, DateTime ngayBan, string maKhach, float tongTien)
        {
            SoHDB1 = soHDB;
            MaNV1 = maNV;
            NgayBan1 = ngayBan;
            MaKhach1 = maKhach;
            TongTien1 = tongTien;
        }

        public string SoHDB1 { get => SoHDB; set => SoHDB = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public DateTime NgayBan1 { get => NgayBan; set => NgayBan = value; }
        public string MaKhach1 { get => MaKhach; set => MaKhach = value; }
        public float TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
