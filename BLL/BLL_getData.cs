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
    public class BLL_getData
    {
        public static DataTable getTable(string procName)
        {
            return getDataDAL.getTable(procName);
        }

        public static DataTable getTableById(string procName, string id)
        {
            return getDataDAL.getTableById(procName, id);
        }

        public static DataSet SPBanChayNhat(string Manhanvien)
        {
            return getDataDAL.SPBanChayNhat(Manhanvien);
        }

        public static DataSet HoadonVaTongtien(string MaNCC)
        {
            return getDataDAL.HoadonVaTongtien(MaNCC);
        }

        public static DataSet Doanhthu(string quy, string nam)
        {
            return getDataDAL.Doanhthu(quy, nam);
        }

        public static DataSet NCCKhonggiaohang(string thang, string nam)
        {
            return getDataDAL.NCCKhonggiaohang(thang, nam);
        }

    }
}
