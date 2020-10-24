using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_DonViTinh
    {
        private string MaDVT;
        private string TenDVT;

        public Obj_DonViTinh(string maDVT, string tenDVT)
        {
            MaDVT1 = maDVT;
            TenDVT1 = tenDVT;
        }

        public string MaDVT1 { get => MaDVT; set => MaDVT = value; }
        public string TenDVT1 { get => TenDVT; set => TenDVT = value; }
    }
}
