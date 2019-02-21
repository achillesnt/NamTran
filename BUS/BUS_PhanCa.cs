using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_PhanCa
    {
        public static string PhanCa(DataTable dt, string effectiveDate, string shiftID)
        {
            return DAO_PhanCa.PhanCa(dt, effectiveDate, shiftID);
        }

        public static DataTable LoadBangPhanCa(string maNV)
        {
            return DAO_PhanCa.LoadBangPhanCa(maNV);
        }

        public static string UpdatePhanCa(DataTable dt)
        {
            return DAO_PhanCa.UpdatePhanCa(dt);
        }

        public static int XoaPhanCa(string s)
        {
            return DAO_PhanCa.XoaPhanCa(s);
        }

        public static DataTable ReportPhanCa(string fromDate, string toDate, string mode, string boPhan, string maCa)
        {
            return DAO_PhanCa.ReportPhanCa(fromDate, toDate, mode, boPhan, maCa);
        }
    }
}
