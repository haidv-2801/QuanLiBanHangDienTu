using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Handling
{
    public class Automatically
    {
        static SqlConnection mycon;
        public static string autoGetKey(string procName)
        {
            mycon = getConnectionSql.connectToSql();

            SqlCommand cmd = new SqlCommand(procName, mycon);

            mycon.Open();
            var res = cmd.ExecuteScalar();
            mycon.Close();

            return res.ToString();
        }

       

        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            int hr = int.Parse(hour);
            if(hr >= 1 && hr <= 12)
            {
                if (hour == "12")
                    h = "0";
                else
                    h = (int.Parse(hour) + 12).ToString();
            }
            return h;
        }

        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }
    }
}
