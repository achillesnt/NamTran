using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        //Phương thức dùng để kết nối đến cơ sở dữ liệu
        public static string sChuoiKetNoi = @"Data Source=db.seqvn.local;Initial Catalog=WiseEyeOn;User ID=sa;Password=111aaa!#;Connect Timeout=120";
        //public static string sChuoiKetNoi = @"Data Source=.\SQL;Initial Catalog=WiseEyeOn;User ID=sa;Password=111aaa!#;Connect Timeout=60";
        //public static string sChuoiKetNoi = ConfigService.ConnectionString;

        //Phương thức trả về đối tượng bảng ghi
        public static DataTable TruyVanDataTable(string sChuoiTruyVan)
        {
            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sChuoiTruyVan, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                con.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                con.Close();
                con.Dispose();
                return null;
            }

        }
        //Phương thức thực hiện các câu lệnh Insert, Update, Delete
        public static bool TruyVanExecuteNonQuery(string sChuoiTruyVan)
        {
            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sChuoiTruyVan;
            if(cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection.Open();
            try
            {               
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                cmd.Connection.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                cmd.Connection.Close();
                cmd.Dispose();
                return false;
            }
        }
        //Phương thức trả về 1 giá trị
        public static string TruyVanExecuteScalar(string sChuoiTruyVan)
        {
            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sChuoiTruyVan;
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection.Open();
            try
            {
                string sKQ = cmd.ExecuteScalar().ToString();
                cmd.Connection.Close();
                cmd.Dispose();
                return sKQ;
            }
            catch (Exception ex)
            {
                cmd.Connection.Close();
                cmd.Dispose();
                return null;
            }

        }
    }
}
