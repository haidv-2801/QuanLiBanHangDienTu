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
    public class BLL_TaiKhoan
    {
        public static void insert(TaiKhoan taiKhoan)
        {
            TaiKhoanDAL.insert(taiKhoan);
        }

        public static void delete(string id)
        {
            TaiKhoanDAL.delete(id);
        }

        public static void update(TaiKhoan taiKhoan)
        { 
            TaiKhoanDAL.update(taiKhoan);
        }

    }
}
