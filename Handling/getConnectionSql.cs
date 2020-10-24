using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Handling
{
    public class getConnectionSql
    {
        public static SqlConnection connectToSql()
        {
            string query = "Data Source = HAI; Initial Catalog  = QLBanHangDienTu_bantest; Integrated Security=true; UID = sa; PWD = 123";
            return new SqlConnection(query);
        }
    }
}
