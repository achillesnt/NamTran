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
    public class DAO_BaoCom
    {
        //Phương thức load bảng tổng hợp dữ liệu phục vụ báo cơm

        public static DataTable LoadAttendance(string dtBoPhan)
        {
            string maBoPhan = DAO_BoPhan.LoadMaBoPhan(dtBoPhan);
            string sChuoiTruyVan = string.Format("select * from v_daily_attendance where deptid IN ({0})", maBoPhan);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);

            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lê và có giá trị
            {               
                return dt;
            }
            return null;
        }

        public static DataTable LoadMeal(string fromDate, string toDate, string mode, string boPhan, string maCa)
        {
            string maBoPhan = DAO_BoPhan.LoadMaBoPhan(boPhan);
            string sChuoiTruyVan = null;
            int i = Convert.ToInt16(mode);
            switch(i)
            {
                case 0:
                    {
                        if (Convert.ToInt16(maCa) == 0)
                        {
                            sChuoiTruyVan = string.Format("SELECT * FROM view_attcount_sum WHERE dept_id IN ({0}) ORDER BY dept_id ASC", maBoPhan);
                        }
                        else
                        {
                            sChuoiTruyVan = string.Format("SELECT * from view_attcount_sum WHERE dept_id IN ({0}) AND shift_id = '{1}' ORDER BY dept_id ASC", maBoPhan, maCa);
                        }
                        break;
                    }
                case 1:
                    {
                        if (Convert.ToInt16(maCa) == 0)
                        {
                            sChuoiTruyVan = string.Format("SELECT * FROM view_mealorder WHERE dept_id IN ({0}) AND att_date BETWEEN '{1}' AND '{2}' ORDER BY dept_id ASC", maBoPhan, fromDate, toDate);
                        }
                        else
                        {
                            sChuoiTruyVan = string.Format("SELECT * from view_mealorder WHERE dept_id IN ({0}) AND shift_id = '{1}' AND att_date BETWEEN '{2}' AND '{3}' ORDER BY dept_id ASC", maBoPhan, maCa, fromDate, toDate);
                        }
                        break;
                    }
                case 2:
                    {
                        if (Convert.ToInt16(maCa) == 0)
                        {
                            sChuoiTruyVan = string.Format("SELECT * FROM view_attcount_sum WHERE dept_id IN ({0}) ORDER BY dept_id ASC", maBoPhan);
                        }
                        else
                        {
                            sChuoiTruyVan = string.Format("SELECT * from view_attcount_sum WHERE dept_id IN ({0}) AND shift_id = '{1}' ORDER BY dept_id ASC", maBoPhan, maCa);
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

        public static bool InsertMeal(DataTable dt, string ad_user_id)
        {
            bool sKetQua = false;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string dept_id = dt.Rows[i]["dept_id"].ToString();
                string shift_id = dt.Rows[i]["shift_id"].ToString();
                string A12 = dt.Rows[i]["A12"].ToString();
                string att_date = Convert.ToDateTime(dt.Rows[i]["att_date"]).ToString("yyyy-MM-dd HH:mm:ss");
                string A00 = dt.Rows[i]["A00"].ToString();
                string AMn = dt.Rows[i]["AMn"].ToString();
                string ACh = dt.Rows[i]["ACh"].ToString();
                string A07 = dt.Rows[i]["A07"].ToString();
                string A01 = dt.Rows[i]["A01"].ToString();
                string AKh = dt.Rows[i]["AKh"].ToString();
                string KhA = dt.Rows[i]["KhA"].ToString();
                //string A01 = dt.Rows[i]["A01"].ToString();
                string noticed;
                /*
                if (dt.Rows[i]["A07"] !=DBNull.Value)
                {
                    A07 = dt.Rows[i]["A07"].ToString();
                }
                else
                {
                    A07 = "0";
                }
                if (dt.Rows[i]["A01"] != DBNull.Value)
                {
                    A01 = dt.Rows[i]["A01"].ToString();
                }
                else
                {
                    A01 = "0";
                }
                */
                if (dt.Rows[i]["noticed"] != DBNull.Value)
                {
                    noticed = dt.Rows[i]["noticed"].ToString();
                }
                else
                {
                    noticed = "";
                }                            
                cmd.CommandText = string.Format("INSERT INTO MealOrder(dept_id, shift_id, att_date, A12, A01, A07, A00, AMn, ACh, noticed, AKh, KhA, createdby) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',N'{9}','{10}','{11}','{12}')", dept_id, shift_id, att_date, A12, A01, A07, A00, AMn, ACh,noticed, AKh, KhA, ad_user_id);
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
    }
}
