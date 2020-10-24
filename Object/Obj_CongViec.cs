using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Obj_CongViec
    {
        private string MaCV;
        private string TenCV;

        public Obj_CongViec(string maCV, string tenCV)
        {
            MaCV1 = maCV;
            TenCV1 = tenCV;
        }

        public string MaCV1 { get => MaCV; set => MaCV = value; }
        public string TenCV1 { get => TenCV; set => TenCV = value; }
    }
}
