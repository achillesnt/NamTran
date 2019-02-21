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
    public class BUS_TangCa
    {
        public static DataTable LoadTangCa(string boPhan, string maNV, string mode)
        {
            return DAO_TangCa.LoadTangCa(boPhan, maNV, mode);
        }

        public static int ThemTangCa(DataTable dt, string fromHour, string toHour, string reason)
        {
            return DAO_TangCa.ThemTangCa(dt,fromHour,toHour, reason);
        }

        public static int XoaTangCa(DataTable dt)
        {
            return DAO_TangCa.XoaTangCa(dt);
        }

        public static int XacNhanTangCa(DataTable dt)
        {
            return DAO_TangCa.XacNhanTangCa(dt);
        }
    }
}
