using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_NhaCungCap
    {
        private string MaNCC;
        private string TenNCC;
        private string DiaChi;
        private string DienTHoai;

        public Obj_NhaCungCap(string maNCC, string tenNCC, string diaChi, string dienTHoai)
        {
            MaNCC1 = maNCC;
            TenNCC1 = tenNCC;
            DiaChi1 = diaChi;
            DienTHoai1 = dienTHoai;
        }

        public string MaNCC1 { get => MaNCC; set => MaNCC = value; }
        public string TenNCC1 { get => TenNCC; set => TenNCC = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string DienTHoai1 { get => DienTHoai; set => DienTHoai = value; }
    }
}
