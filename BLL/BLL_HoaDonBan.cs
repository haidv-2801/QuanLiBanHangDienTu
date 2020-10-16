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
    public class BLL_HoaDonBan
    {
        public static void insert(Obj_HoaDonBan obj_HoaDonBan)
        {
            HoaDonBanDAL.insert(obj_HoaDonBan);
        }
    }
}
