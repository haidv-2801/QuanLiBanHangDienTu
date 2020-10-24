using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_CaLam
    {
        private string MaCaLam;
        private string TenCaLam;

        public Obj_CaLam(string maCaLam, string tenCaLam)
        {
            MaCaLam1 = maCaLam;
            TenCaLam1 = tenCaLam;
        }

        public string MaCaLam1 { get => MaCaLam; set => MaCaLam = value; }
        public string TenCaLam1 { get => TenCaLam; set => TenCaLam = value; }
    }
}
