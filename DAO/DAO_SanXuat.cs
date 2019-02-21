using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_SanXuat
    {
        public static DataTable GetInout(string ad_ord_id, string startDate, string endDate)
        {
            string maBoPhan = DAO_BoPhan.LoadMaBoPhan(ad_ord_id);
            string sChuoiTruyVan = string.Format("SELECT * FROM view_m_inout WHERE dept_id IN ({0}) AND documentdate >= '{1}' AND documentdate <= '{2}' ORDER BY m_inout_id DESC", maBoPhan, startDate, endDate);

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

        public static DataTable GetInoutbydocumentno(string documentno)
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM view_m_inout WHERE documentno = '{0}' ORDER BY m_inout_id DESC", documentno);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }

        public static DataTable GetInoutLine(string m_inout_id)
        {
            //string maBoPhan = DAO_BoPhan.LoadMaBoPhan(deptID);
            string sChuoiTruyVan = string.Format("select * from view_m_inoutline where m_inout_id = '{0}' order by m_inoutline_id ASC", m_inout_id);

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

        public static DataTable GetTargetActualLine(string deptID, string fromDate, string toDate)
        {
            string maBoPhan = DAO_BoPhan.LoadMaBoPhan(deptID);
            string sChuoiTruyVan = string.Format("SELECT * FROM view_target_actual_line WHERE dept_id IN ({0}) AND documentdate >= '{1}' AND documentdate <= '{2}' ORDER BY documentdate DESC", maBoPhan, fromDate, toDate);

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

        public static DataTable LoadInputPeriod(string ad_user_org_id)
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM fn_return_input_bydeptid('{0}')", ad_user_org_id);
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

        public static DataTable LoadTypename()
        {
            string sChuoiTruyVan = string.Format("select * from view_typename");
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

        public static DataTable LoadPartname()
        {
            string sChuoiTruyVan = string.Format("select * from view_partname");
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
        public static DataTable LoadRecentTypePart(string ad_org_id)
        {
            string sChuoiTruyVan = string.Format("select * from fn_get_recent_typepart('{0}')", ad_org_id);
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

        public static DataTable LoadDocumenttype()
        {
            string sChuoiTruyVan = string.Format("select * from view_document_type");
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

        public static bool InputLine(string m_inout_id, string inputcode, string headcount, string outputqty, string note)
        {
            //string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            cmd.CommandText = string.Format("select count(*) from m_inoutline where m_inout_id = '{0}' and inputcode = '{1}'", m_inout_id, inputcode);
            int y = Convert.ToInt16(cmd.ExecuteScalar());
            if (y == 0)
            {
                cmd.CommandText = string.Format("insert into m_inoutline(m_inout_id, headcount, inputcode, output, reason) VALUES('{0}','{1}','{2}','{3}',N'{4}')", m_inout_id, headcount, inputcode, outputqty, note);
                cmd.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static bool InputInout(string ad_org_id, string typename, string partcode, string documenttype, string documentstatus)
        {
            string documentdate = DateTime.Now.Date.ToString("yyyy-MM-dd");
            //string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            cmd.CommandText = string.Format("select count(*) from m_inout where dept_id = '{0}' and typecode = '{1}' and partcode = '{2}' and document_type_code = '{3}' and documentdate = '{4}'", ad_org_id, typename, partcode, documenttype, documentdate);
            int y = Convert.ToInt16(cmd.ExecuteScalar());
            if (y == 0)
            {
                cmd.CommandText = string.Format("insert into m_inout(dept_id, typecode, partcode, document_type_code, document_status_code) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", ad_org_id, typename, partcode, documenttype, documentstatus);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static bool RemoveLine(string _inoutline_id)
        {
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            cmd.CommandText = string.Format("delete m_inoutline where m_inoutline_id = '{0}'", _inoutline_id);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Error");
                return false;
            }
        }

        public static bool RemoveInout(string sochungtu)
        {
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            cmd.CommandText = string.Format("delete m_inout where documentno = '{0}'", sochungtu);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString(), "Error");
                return false;
            }
        }
        public static DataTable ChartQtyDaily(string date, string boPhan)
        {
            string sChuoiTruyVan = string.Format("select * from fn_chart_qty_daily('{0}','{1}')", date, boPhan);
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
        public static DataTable ChartQtyMonthly(string fromDate, string toDate, string boPhan)
        {
            string sChuoiTruyVan = string.Format("select * from fn_chart_qty_monthly('{0}','{1}','{2}')", fromDate, toDate, boPhan);
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
        public static string ChartQtyTotal(string fromDate, string toDate, string boPhan)
        {
            string sChuoiTruyVan = string.Format("select * from fn_chart_qty_total('{0}','{1}','{2}')", fromDate, toDate, boPhan);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "0";
            }
        }
    }
}
