using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
//using System.Windows.Forms;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_BoPhan
    {
        public static DataTable LoadBoPhan(string boPhan)
        {
            return DAO_BoPhan.LoadBoPhan(boPhan);
        }

        public static DataTable LoadNode(string maBoPhan)
        {
            return DAO_BoPhan.LoadNode(maBoPhan);
        }

        public static int UpdateBoPhan(string id, string maBoPhan, string tenTA, string tenTV, string tinhTrang)
        {
            return DAO_BoPhan.UpdateBoPhan(id, maBoPhan, tenTA, tenTV, tinhTrang);
        }

        public static int InsertBoPhan(string maBoPhan, string tenTA, string tenTV, string tinhTrang, string parentID, string levelID)
        {
            return DAO_BoPhan.InsertBoPhan(maBoPhan, tenTA, tenTV, tinhTrang, parentID, levelID);
        }

        public static string KiemTraPhuThuoc(string boPhan)
        {
            return DAO_BoPhan.KiemTraPhuThuoc(boPhan);
        }

    }
}
