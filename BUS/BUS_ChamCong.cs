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
    public class BUS_ChamCong
    {
        public static DataTable LoadCheckin(string attDate, string tinhTrang, string boPhan, string maca)
        {
            return DAO_ChamCong.LoadCheckin(attDate, tinhTrang, boPhan, maca);
        }

        public static DataTable LoadAbsent()
        {
            return DAO_ChamCong.LoadAbsent();
        }
        public static bool InsertAttCount(string ad_user_id, DataTable dt)
        {
            return DAO_ChamCong.InsertAttCount(ad_user_id, dt);
        }
        public static bool UpdateAttCount(DataTable dt, string ad_user_id)
        {
            return DAO_ChamCong.UpdateAttCount(dt, ad_user_id);
        }
        public static bool DeleteAttCount(DataTable dt, string ad_user_id)
        {
            return DAO_ChamCong.DeleteAttCount(dt, ad_user_id);
        }

        public static DataTable LoadAttrecord(string fromDate, string toDate, string maNV, string maBoPhan)
        {
            return DAO_ChamCong.LoadAttrecord(fromDate, toDate, maNV, maBoPhan);
        }

        public static DataTable ReportDiemDanh(string fromDate, string toDate, string mode, string boPhan, string maCa)
        {
            return DAO_ChamCong.ReportDiemDanh(fromDate, toDate, mode, boPhan, maCa);
        }

        public static DataTable ChartDiemDanh(string fromDate, string toDate, string boPhan, string maCa)
        {
            return DAO_ChamCong.ChartDiemDanh(fromDate, toDate, boPhan, maCa);
        }
    }
}
