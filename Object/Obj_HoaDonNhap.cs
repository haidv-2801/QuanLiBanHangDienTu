using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_HoaDonNhap
    {
        private string SoHDN;
        private string MaNV;
        private DateTime NgayNhap;
        private string MaNCC;
        private float TongTien;

        public Obj_HoaDonNhap(string soHDN, string maNV, DateTime ngayNhap, string maNCC, float tongTien)
        {
            SoHDN1 = soHDN;
            MaNV1 = maNV;
            NgayNhap1 = ngayNhap;
            MaNCC1 = maNCC;
            TongTien1 = tongTien;
        }

        public string SoHDN1 { get => SoHDN; set => SoHDN = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public DateTime NgayNhap1 { get => NgayNhap; set => NgayNhap = value; }
        public string MaNCC1 { get => MaNCC; set => MaNCC = value; }
        public float TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
