using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Object;

namespace BLL
{
    public class BLL_NhaCungCap
    {
        public static void insert(Obj_NhaCungCap obj_NhaCungCap)
        {
            NhaCungCapDAL.insert(obj_NhaCungCap);
        }

        public static void delete(string id)
        {
            NhaCungCapDAL.delete(id);
        }

        public static void update(Obj_NhaCungCap obj_NhaCungCap)
        {
            NhaCungCapDAL.update(obj_NhaCungCap);
        }
    }
}
