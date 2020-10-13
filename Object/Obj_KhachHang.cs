using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_KhachHang
    {
        private string Makhach;
        private string Tenkhach;
        private string Diachi;
        private string Dienthoai;

        public Obj_KhachHang(string makhach, string tenkhach, string diachi, string dienthoai)
        {
            Makhach1 = makhach;
            Tenkhach1 = tenkhach;
            Diachi1 = diachi;
            Dienthoai1 = dienthoai;
        }

        public string Makhach1 { get => Makhach; set => Makhach = value; }
        public string Tenkhach1 { get => Tenkhach; set => Tenkhach = value; }
        public string Diachi1 { get => Diachi; set => Diachi = value; }
        public string Dienthoai1 { get => Dienthoai; set => Dienthoai = value; }
    }
}
