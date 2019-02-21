using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_BaoCom
    {
        public static DataTable LoadAttendance(string dtBoPhan)
        {
            return DAO_BaoCom.LoadAttendance(dtBoPhan);
        }
        public static DataTable LoadMeal(string fromDate, string toDate, string mode, string boPhan, string maCa)
        {
            return DAO_BaoCom.LoadMeal(fromDate, toDate, mode, boPhan, maCa);
        }

        public static bool InsertMeal(DataTable dt, string ad_user_id)
        {
            return DAO_BaoCom.InsertMeal(dt, ad_user_id);
        }
    }
}
