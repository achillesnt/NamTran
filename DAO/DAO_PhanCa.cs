using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_PhanCa
    {
        public static string PhanCa(DataTable dt, string effectiveDate, string shiftID)
        {
            string sKetQua=null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //sKetQua += sKetQua;
                string StaffID = dt.Rows[i]["UserFullCode"].ToString();
                cmd.CommandText = string.Format("SELECT COUNT(*) FROM PhanCa WHERE STAFFID =N'{0}' AND EffectiveDate = '{1}'", StaffID, effectiveDate);
                int y = Convert.ToInt16(cmd.ExecuteScalar());
                if(y == 0)
                {
                    //sKetQua = "";
                    cmd.CommandText = string.Format("INSERT INTO PhanCa(STAFFID, EffectiveDate, ShiftID) VALUES('{0}','{1}','{2}')", StaffID, effectiveDate, shiftID);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    sKetQua += "\n" + StaffID; 
                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static DataTable LoadBangPhanCa(string maNV)
        {
            //string startMonth = DateTime.Now.Date.AddMonths(-2).ToString("yyyy-MM-dd hh:mm:ss");
            //string endMonth = DateTime.Now.Date.AddMonths(2).ToString("yyyy-MM-dd hh:mm:ss");
            string sChuoiTruyVan = string.Format("SELECT * FROM view_shift_arranged WHERE staff_id = N'{0}' ORDER BY shift_arrange_effective DESC", maNV);

            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);

            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lê và có giá trị
            {
                return dt;
            }
            return null;
        }

        public static string UpdatePhanCa(DataTable dt)
        {
            string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            DateTime curDate = DateTime.Now.Date;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string shift_arrange_id = dt.Rows[i]["shift_arrange_id"].ToString();
                string staff_id = dt.Rows[i]["staff_id"].ToString();
                string shift_arrange_effective = (Convert.ToDateTime(dt.Rows[i]["shift_arrange_effective"].ToString())).ToString("yyyy-MM-dd");
                string shift_id = dt.Rows[i]["shift_id"].ToString();

                cmd.CommandText = string.Format("SELECT EffectiveDate FROM PhanCa WHERE ID ='{0}'", shift_arrange_id);
                DateTime orgDate = Convert.ToDateTime(cmd.ExecuteScalar());
                TimeSpan diff = orgDate - curDate;
                double diffDays = diff.TotalDays;
                if(diffDays >=0)
                {
                    cmd.CommandText = string.Format("SELECT COUNT(*) FROM PhanCa WHERE STAFFID =N'{0}' AND EffectiveDate = '{1}' AND NOT ID ='{2}'", staff_id, shift_arrange_effective, shift_arrange_id);
                    int y = Convert.ToInt16(cmd.ExecuteScalar());
                    if (y == 0)
                    {
                        cmd.CommandText = string.Format("UPDATE PhanCa SET EffectiveDate = '{0}', ShiftID = '{1}' WHERE ID = '{2}'", shift_arrange_effective, shift_id, shift_arrange_id);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        sKetQua += "\n" + shift_arrange_effective;
                    }
                }
                else
                {
                    sKetQua += "\n" + shift_arrange_effective;
                }                             
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();          
        }

        public static int XoaPhanCa(string s)
        {
            int sKetQua = 0;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            cmd.CommandText = string.Format("DELETE PhanCa WHERE ID IN ({0})", s);
            if(cmd.ExecuteNonQuery() > 0)
            {
                sKetQua = 1;
            }
            else
            {
                sKetQua = 0;
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static DataTable ReportPhanCa(string fromDate, string toDate, string mode, string boPhan, string maCa)
        {
            string maBoPhan = DAO_BoPhan.LoadMaBoPhan(boPhan);
            string sChuoiTruyVan;
            
            int i = Convert.ToInt16(mode);
            if (i == 0)
            {
                sChuoiTruyVan = string.Format("SELECT * FROM view_report_phanca_notyet WHERE dept_id IN ({0}) ORDER BY staff_id ASC", maBoPhan);
            }
            else
            {
                if (Convert.ToInt16(maCa) == 0)
                {
                    sChuoiTruyVan = string.Format("SELECT * from view_report_phanca_done WHERE dept_id IN ({0}) AND phanca_effective_date BETWEEN '{1}' AND '{2}' ORDER BY staff_id ASC", maBoPhan, fromDate, toDate);
                }
                else
                {
                    sChuoiTruyVan = string.Format("SELECT * from view_report_phanca_done WHERE dept_id IN ({0}) AND shift_id = '{1}' AND phanca_effective_date BETWEEN '{2}' AND '{3}' ORDER BY staff_id ASC", maBoPhan, maCa, fromDate, toDate);
                }                
            }
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }
    }
}
