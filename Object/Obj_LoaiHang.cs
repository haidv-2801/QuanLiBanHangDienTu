using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_LoaiHang
    {
        private string MaLH;
        private string TenLH;

        public Obj_LoaiHang(string maLH, string tenLH)
        {
            MaLH1 = maLH;
            TenLH1 = tenLH;
        }

        public string MaLH1 { get => MaLH; set => MaLH = value; }
        public string TenLH1 { get => TenLH; set => TenLH = value; }
    }
}
