using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_TangCa
    {
        public static DataTable LoadTangCa(string boPhan, string maNV, string mode)
        {
            string maBoPhan = DAO_BoPhan.LoadMaBoPhan(boPhan);
            string sChuoiTruyVan;
            if (mode == "Đăng ký cho hôm nay")
            {
                sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_get_oveertime_registering1('{0}','{1}')", maBoPhan, maNV);
            }
            else
            {
                sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_get_oveertime_registering2('{0}','{1}')", maBoPhan, maNV);
            }

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

        public static int ThemTangCa(DataTable dt, string fromHour, string toHour, string reason)
        {
            int sKetQua = 0;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string UserFullCode = dt.Rows[i]["STAFFID"].ToString();
                string Date = dt.Rows[i]["Date"].ToString();
                string Status = "Chưa xác nhận";
                if (string.IsNullOrEmpty(reason))
                {
                    sKetQua = 0;
                }
                else
                {
                    cmd.CommandText = string.Format("INSERT INTO OverTimeRegister (StaffID, [Date], FromHour, ToHour, Reason, Status) VALUES ('{0}','{1}','{2}','{3}',N'{4}',N'{5}')", UserFullCode, Date, fromHour, toHour, reason, Status);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        sKetQua = 1;
                    }
                    else
                    {
                        sKetQua = 0;
                    }
                }
                #region Procedure
                /*
                cmd.Parameters.Add("@DeptCode", dt.Rows[i]["DEPARTMENT"].ToString());
                cmd.Parameters.Add("@TOTAL", dt.Rows[i]["TOTAL"].ToString());
                cmd.Parameters.Add("@ATTENDANCE", dt.Rows[i]["ATTENDANCE"].ToString());
                cmd.Parameters.Add("@ABSENT", dt.Rows[i]["ABSENT"].ToString());
                cmd.Parameters.Add("@ACTUAL", dt.Rows[i]["ACTUAL"].ToString());
                cmd.Parameters.Add("@REASON", dt.Rows[i]["REASON"].ToString());
                cmd.Parameters.Add("@TIME", DateTime.Now);
                
                cmd.CommandText = string.Format("Insert Into LunchOrder Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",DeptCode,TOTAL,ATTENDANCE,ABSENT,ACTUAL,REASON,TIME);
                //cmd.ExecuteNonQuery();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Không hợp lệ: " + DeptCode, "Thông báo");
                    MessageBox.Show(ex.ToString());
                }
                */
                #endregion
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static int XoaTangCa(DataTable dt)
        {
            int sKetQua = 0;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string STAFFID = dt.Rows[i]["STAFFID"].ToString();
                string Date = dt.Rows[i]["Date"].ToString();
                string FromHour = dt.Rows[i]["FromHour"].ToString();
                string ToHour = dt.Rows[i]["ToHour"].ToString();

                cmd.CommandText = string.Format("DELETE OverTimeRegister WHERE StaffID='{0}' AND [Date] = '{1}' AND FromHour ='{2}' AND ToHour='{3}' AND Status = N'Chưa xác nhận'", STAFFID, Date, FromHour, ToHour);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    sKetQua = 1;
                }
                else
                {
                    sKetQua = 0;
                }
                #region Procedure
                /*
                cmd.Parameters.Add("@DeptCode", dt.Rows[i]["DEPARTMENT"].ToString());
                cmd.Parameters.Add("@TOTAL", dt.Rows[i]["TOTAL"].ToString());
                cmd.Parameters.Add("@ATTENDANCE", dt.Rows[i]["ATTENDANCE"].ToString());
                cmd.Parameters.Add("@ABSENT", dt.Rows[i]["ABSENT"].ToString());
                cmd.Parameters.Add("@ACTUAL", dt.Rows[i]["ACTUAL"].ToString());
                cmd.Parameters.Add("@REASON", dt.Rows[i]["REASON"].ToString());
                cmd.Parameters.Add("@TIME", DateTime.Now);
                
                cmd.CommandText = string.Format("Insert Into LunchOrder Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",DeptCode,TOTAL,ATTENDANCE,ABSENT,ACTUAL,REASON,TIME);
                //cmd.ExecuteNonQuery();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Không hợp lệ: " + DeptCode, "Thông báo");
                    MessageBox.Show(ex.ToString());
                }
                */
                #endregion
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static int XacNhanTangCa(DataTable dt)
        {
            int sKetQua = 0;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string STAFFID = dt.Rows[i]["STAFFID"].ToString();
                string Date = dt.Rows[i]["Date"].ToString();
                string FromHour = dt.Rows[i]["FromHour"].ToString();
                string ToHour = dt.Rows[i]["ToHour"].ToString();

                cmd.CommandText = string.Format("UPDATE OverTimeRegister SET Status = N'Đã xác nhận' WHERE StaffID ='{0}' AND [Date]='{1}' AND FromHour='{2}' AND ToHour='{3}'", STAFFID, Date, FromHour, ToHour);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    sKetQua = 1;
                }
                else
                {
                    sKetQua = 0;
                }
                #region Procedure
                /*
                cmd.Parameters.Add("@DeptCode", dt.Rows[i]["DEPARTMENT"].ToString());
                cmd.Parameters.Add("@TOTAL", dt.Rows[i]["TOTAL"].ToString());
                cmd.Parameters.Add("@ATTENDANCE", dt.Rows[i]["ATTENDANCE"].ToString());
                cmd.Parameters.Add("@ABSENT", dt.Rows[i]["ABSENT"].ToString());
                cmd.Parameters.Add("@ACTUAL", dt.Rows[i]["ACTUAL"].ToString());
                cmd.Parameters.Add("@REASON", dt.Rows[i]["REASON"].ToString());
                cmd.Parameters.Add("@TIME", DateTime.Now);
                
                cmd.CommandText = string.Format("Insert Into LunchOrder Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",DeptCode,TOTAL,ATTENDANCE,ABSENT,ACTUAL,REASON,TIME);
                //cmd.ExecuteNonQuery();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Không hợp lệ: " + DeptCode, "Thông báo");
                    MessageBox.Show(ex.ToString());
                }
                */
                #endregion
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }
    }
}
