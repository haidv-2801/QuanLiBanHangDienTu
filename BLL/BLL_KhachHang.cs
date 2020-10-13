using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Object;

namespace BLL
{
    public class BLL_KhachHang
    {
        public static void insert(Obj_KhachHang obj_KhachHang)
        {
            KhachHangDAL.insert(obj_KhachHang);
        }

        public static void delete(string id)
        {
            KhachHangDAL.delete(id);
        }

        public static void update(Obj_KhachHang obj_KhachHang)
        {
            KhachHangDAL.update(obj_KhachHang);
        }
    }
}
