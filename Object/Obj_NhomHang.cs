using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_NhomHang
    {
        private string MaNhomHang;
        private string TenNhomHang;

        public Obj_NhomHang(string maNhomHang, string tenNhomHang)
        {
            MaNhomHang1 = maNhomHang;
            TenNhomHang1 = tenNhomHang;
        }

        public string MaNhomHang1 { get => MaNhomHang; set => MaNhomHang = value; }
        public string TenNhomHang1 { get => TenNhomHang; set => TenNhomHang = value; }
    }
}
