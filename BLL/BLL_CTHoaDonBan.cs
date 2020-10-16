using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object;
using DAL;

namespace BLL
{
    public class BLL_CTHoaDonBan
    {
        public static void insert(Obj_CTHoaDonBan obj_CTHoaDonBan)
        {
            CTHoaDonBanDAL.insert(obj_CTHoaDonBan);
        }

        public static bool isDuplicateMahanghoa(string Sohdn, string Mahang)
        {
            return CTHoaDonNhapDAL.isDuplicateMaHH(Sohdn, Mahang);
        }
    }
}
