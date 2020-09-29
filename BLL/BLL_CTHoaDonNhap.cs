using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object;
using DAL;

namespace BLL
{
    public class BLL_CTHoaDonNhap
    {
        public static void insertIntoCTHoadonnhap(Obj_CTHoaDonNhap obj_CTHoaDonNhap)
        {
            CTHoaDonNhapDAL.insert(obj_CTHoaDonNhap);
        }
    }
}
