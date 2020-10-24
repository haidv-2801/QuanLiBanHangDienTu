using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_ChatLieu
    {
        private string MaCL;
        private string TenCL;

        public Obj_ChatLieu(string maCL, string tenCL)
        {
            MaCL1 = maCL;
            TenCL1 = tenCL;
        }

        public string MaCL1 { get => MaCL; set => MaCL = value; }
        public string TenCL1 { get => TenCL; set => TenCL = value; }
    }
}
