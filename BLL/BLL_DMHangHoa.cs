using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Object;
using DAL;

namespace BLL
{
    public class BLL_DMHangHoa
    {
        public static void insertIntoDMHangHoa(Obj_HangHoa hangHoaObj)
        {
            HangHoaDAL.insert(hangHoaObj);
        }

        public static void deleteFromDMHangHoa(string id)
        {
            HangHoaDAL.delete(id);
        }

        public static void update(Obj_HangHoa hangHoaObj)
        {
            HangHoaDAL.update(hangHoaObj);
        }
    }
}
