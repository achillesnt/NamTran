using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class DAO_BoPhan
    {
        public static DataTable LoadBoPhan(string boPhan)
        {
            string maBoPhan = LoadMaBoPhan(boPhan);
            string sChuoiTruyVan = string.Format("select ID as id, DescriptionVN as description from RelationDept Where ID IN ({0}) AND Enable='1'",maBoPhan);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lê và có giá trị
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public static DataTable LoadNode(string boPhan)
        {
            string maBoPhan = LoadMaBoPhan(boPhan);
            string sChuoiTruyVan = string.Format("select * from RelationDept Where ID IN ({0}) AND Enable='1'",maBoPhan);
            return DataProvider.TruyVanDataTable(sChuoiTruyVan);
        }

        public static string LoadMaBoPhan(string maBoPhan)
        {
            DataTable dt = new DataTable();
            string sChuoiMa = "";
            string sChuoiTruyVan = string.Format("WITH temp(ID, DescriptionVN, alevel) as (Select ID, DescriptionVN, 0 as aLevel From RelationDept Where ID = '{0}' Union All Select b.id, b.DescriptionVN, a.alevel + 1 From temp as a, RelationDept as b Where a.id = b.RelationID) Select * From temp",maBoPhan);
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(i< dt.Rows.Count-1)
                {
                    sChuoiMa += dt.Rows[i]["ID"].ToString() + ",";
                }
                else
                {
                    sChuoiMa += dt.Rows[i]["ID"].ToString();
                }
            }
            return sChuoiMa;
        }

        public static string LoadDeptCode(string maBoPhan)
        {
            DataTable dt = new DataTable();
            string sChuoiMa = "";
            string sChuoiTruyVan = string.Format("WITH temp(ID, DeptCode, alevel) as (Select ID, DeptCode, 0 as aLevel From RelationDept Where ID IN ({0}) Union All Select b.id, b.DeptCode, a.alevel + 1 From temp as a, RelationDept as b Where a.id = b.RelationID) Select * From temp", maBoPhan);
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i < dt.Rows.Count - 1)
                {
                    sChuoiMa += "'" + dt.Rows[i]["DeptCode"].ToString() +"'" + ",";
                }
                else
                {
                    sChuoiMa += "'" + dt.Rows[i]["DeptCode"].ToString() + "'";
                }
            }
            return sChuoiMa;
        }

        public static int UpdateBoPhan(string id, string maBoPhan, string tenTA, string tenTV, string tinhTrang)
        {
            int i = 0;
            string sChuoiTruyVan = string.Format("UPDATE RelationDept SET DeptCode='{0}', Description='{1}', DescriptionVN=N'{2}', Enable='{3}' WHERE ID='{4}'",maBoPhan, tenTA, tenTV, tinhTrang, id);
            if(DataProvider.TruyVanExecuteNonQuery(sChuoiTruyVan))
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
            return i;
        }

        public static int InsertBoPhan(string maBoPhan, string tenTA, string tenTV, string tinhTrang, string parentID, string levelID)
        {
            int i = 0;
            string sChuoiKiemTra = string.Format("SELECT COUNT(DeptCode) FROM RelationDept WHERE DeptCode ='{0}'",maBoPhan);
            string sChuoiInsert = string.Format("INSERT INTO RelationDept(DeptCode,Description,DescriptionVN,Enable,RelationID,LevelID) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", maBoPhan, tenTA, tenTV, tinhTrang, parentID,levelID);
            if(Convert.ToInt16(DataProvider.TruyVanExecuteScalar(sChuoiKiemTra)) > 0)
            {
                i = 0;
            }
            else
            {
                if(DataProvider.TruyVanExecuteNonQuery(sChuoiInsert))
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }
            }

            return i;
        }

        public static string KiemTraPhuThuoc(string boPhan)
        {
            string maBoPhan = DAO_BoPhan.LoadMaBoPhan(boPhan);
            string sChuoiTruyVan = string.Format("SELECT COUNT(UserFullCode) FROM UserInfo WHERE UserIDD IN ({0})", maBoPhan);
            return DataProvider.TruyVanExecuteScalar(sChuoiTruyVan);
        }
    }
}
