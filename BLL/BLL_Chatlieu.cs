using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Object;

namespace BLL
{
    public class BLL_Chatlieu
    {
        public static void insert(Obj_ChatLieu obj_ChatLieu)
        {
            ChatLieuDAL.insert(obj_ChatLieu);
        }

        public static void delete(string id)
        {
            ChatLieuDAL.delete(id);
        }

        public static void update(Obj_ChatLieu obj_ChatLieu)
        {
            ChatLieuDAL.update(obj_ChatLieu);
        }
    }
}
