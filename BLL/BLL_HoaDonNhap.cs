using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Object;

namespace BLL
{
    public class BLL_HoaDonNhap
    {
        public static void insertIntoHoadonnhap(Obj_HoaDonNhap hoaDonNhapObj)
        {
            HoaDonNhapDAL.insert(hoaDonNhapObj);
        }
    }
}
