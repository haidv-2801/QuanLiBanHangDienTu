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
    public class BLL_NhanVien
    {
        public static void insert(Obj_NhanVien obj_NhanVien)
        {
            NhanVienDAL.insert(obj_NhanVien);
        }

        public static void delete(string id)
        {
            NhanVienDAL.delete(id);
        }

        public static void update(Obj_NhanVien obj_NhanVien)
        {
            NhanVienDAL.update(obj_NhanVien);
        }

    }
}
