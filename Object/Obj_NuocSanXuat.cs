using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_NuocSanXuat
    {
        private string MaNuocSX;
        private string TenNuocSX;

        public Obj_NuocSanXuat(string maNuocSX, string tenNuocSX)
        {
            MaNuocSX1 = maNuocSX;
            TenNuocSX1 = tenNuocSX;
        }

        public string MaNuocSX1 { get => MaNuocSX; set => MaNuocSX = value; }
        public string TenNuocSX1 { get => TenNuocSX; set => TenNuocSX = value; }
    }
}
