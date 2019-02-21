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
    public class DAO_ChamCong
    {
        public static DataTable LoadCheckin(string attDate, string tinhTrang, string boPhan, string maca)
        {
            string maBoPhan = DAO_BoPhan.LoadMaBoPhan(boPhan);
            string sChuoiTruyVan;
            int i = Convert.ToInt16(tinhTrang);
            if (i == 0)
            {
                sChuoiTruyVan = string.Format("SELECT * FROM view_attcount_notprocess WHERE dept_id IN ({0}) AND shift_id = '{1}' ORDER BY staff_id ASC", maBoPhan, maca);
            }
            else
            {
                sChuoiTruyVan = string.Format("SELECT * FROM view_attcount WHERE dept_id IN ({0}) AND shift_id LIKE '{1}' AND att_date = '{2}' ORDER BY staff_id ASC", maBoPhan, maca, attDate);
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

        public static DataTable LoadAbsent()
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM view_absent_symbol");
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

        public static bool InsertAttCount(string ad_user_id, DataTable dt)
        {
            bool sKetQua = false;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //sKetQua += sKetQua;
                string staff_id = dt.Rows[i]["staff_id"].ToString();
                string dept_id = dt.Rows[i]["dept_id"].ToString();
                string shift_id = dt.Rows[i]["shift_id"].ToString();
                string _date, absent_symbol_id;
                if (dt.Rows[i]["att_date"] != DBNull.Value)
                {
                    _date = Convert.ToDateTime(dt.Rows[i]["att_date"]).ToString("yyyy-MM-dd hh:mm:ss");
                    absent_symbol_id = "A12";
                }
                else
                {
                    _date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    if (dt.Rows[i]["att_reason"] != DBNull.Value && dt.Rows[i]["att_reason"] != string.Empty)
                    {
                        absent_symbol_id = dt.Rows[i]["att_reason"].ToString();
                    }
                    else
                    {
                        absent_symbol_id = "A04";
                    }
                }

                //string absent_symbol_id;

                cmd.CommandText = string.Format("INSERT INTO AttCount(staff_id, dept_id, shift_id, att_date, absent_symbol_id, createdby) VALUES('{0}','{1}','{2}','{3}','{4}', '{5}')", staff_id, dept_id, shift_id, _date, absent_symbol_id, ad_user_id);
                int y = Convert.ToInt16(cmd.ExecuteScalar());
                if (y == 0)
                {
                    sKetQua = true;
                }
                else
                {
                    sKetQua = false;
                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static bool UpdateAttCount(DataTable dt, string ad_user_id)
        {
            bool sKetQua = false;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //sKetQua += sKetQua;
                string attcount_id = dt.Rows[i]["attcount_id"].ToString();
                string att_reason = dt.Rows[i]["att_reason"].ToString();
                cmd.CommandText = string.Format("UPDATE AttCount SET absent_symbol_id = '{0}', updatedby = '{1}' WHERE attcount_id= '{2}'", att_reason, ad_user_id, attcount_id);
                int y = Convert.ToInt16(cmd.ExecuteScalar());
                if (y == 0)
                {
                    sKetQua = true;
                }
                else
                {
                    sKetQua = false;
                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }
        public static bool DeleteAttCount(DataTable dt, string ad_user_id)
        {
            bool sKetQua = false;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //sKetQua += sKetQua;
                string attcount_id = dt.Rows[i]["attcount_id"].ToString();
                cmd.CommandText = string.Format("DELETE AttCount WHERE attcount_id= '{0}'", attcount_id);
                int y = Convert.ToInt16(cmd.ExecuteScalar());
                if (y == 0)
                {
                    sKetQua = true;
                }
                else
                {
                    sKetQua = false;
                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static DataTable LoadAttrecord(string startDate, string endDate, string maNV, string boPhan)
        {
            string maBoPhan = DAO_BoPhan.LoadMaBoPhan(boPhan);

            string sChuoiTruyVan = string.Format("SELECT * FROM view_Attrecord WHERE attrecord_rectime BETWEEN '{0}' AND '{1}' AND staff_id LIKE N'%{2}%' AND dept_id IN ({3})", startDate, endDate, maNV, maBoPhan);

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

        public static DataTable ReportDiemDanh(string fromDate, string toDate, string mode, string boPhan, string maCa)
        {          
            //string sChuoiTruyVan;
            string sChuoiTruyVan = null;
            int i = Convert.ToInt16(mode);
            switch (i)
            {
                case 0:
                    {
                        if (Convert.ToInt16(maCa) == 0)
                        {
                            sChuoiTruyVan = string.Format("SELECT * FROM fn_return_attcount_notprocess_noshift({0}) ORDER BY staff_id ASC", boPhan);
                        }
                        else
                        {
                            sChuoiTruyVan = string.Format("SELECT * FROM fn_return_attcount_notprocess_shift({0},{1}) ORDER BY staff_id ASC", boPhan, maCa);
                        }
                        break;
                    }
                case 1:
                    {
                        string maBoPhan = DAO_BoPhan.LoadMaBoPhan(boPhan);
                        if (Convert.ToInt16(maCa) == 0)
                        {
                            sChuoiTruyVan = string.Format("SELECT * FROM view_attcount WHERE dept_id IN ({0}) AND att_date BETWEEN '{1}' AND '{2}' ORDER BY staff_id ASC", maBoPhan, fromDate, toDate);
                        }
                        else
                        {
                            sChuoiTruyVan = string.Format("SELECT * from view_attcount WHERE dept_id IN ({0}) AND shift_id = '{1}' AND att_date BETWEEN '{2}' AND '{3}' ORDER BY staff_id ASC", maBoPhan, maCa, fromDate, toDate);
                        }
                        break;
                    }
                case 2:
                    {
                        if (Convert.ToInt16(maCa) == 0)
                        {
                            sChuoiTruyVan = string.Format("SELECT * FROM fn_return_attcount_notprocess_noshift({0}) ORDER BY staff_id ASC", boPhan);
                        }
                        else
                        {
                            sChuoiTruyVan = string.Format("SELECT * FROM fn_return_attcount_notprocess_shift({0},{1}) ORDER BY staff_id ASC", boPhan, maCa);
                        }
                        break;
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

        public static DataTable ChartDiemDanh(string fromDate, string toDate, string boPhan, string maCa)
        {
            string sChuoiTruyVan = null;
            int i = Convert.ToInt16(maCa);
            if (i == 0)
            {
                sChuoiTruyVan = string.Format("SELECT * FROM fn_chart_attendance_noshift('{0}','{1}',{2}) ORDER BY att_date ASC", fromDate, toDate, boPhan);
            }
            else
            {
                sChuoiTruyVan = string.Format("SELECT * FROM fn_chart_attendance_shift('{0}','{1}',{2},{3}) ORDER BY att_date ASC", fromDate, toDate, boPhan, maCa);
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
