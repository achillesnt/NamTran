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
    public class DAO_HeThong
    {
        public static DataTable LoadUserByRole(string ad_role_id)
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_return_user_by_role('{0}')", ad_role_id);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }

        public static DataTable LoadWindowByRole(string ad_role_id)
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_return_window_by_role('{0}')", ad_role_id);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }

        public static DataTable LoadProcessByRole(string ad_role_id)
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_return_process_by_role('{0}')", ad_role_id);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static DataTable LoadRole()
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_ad_role( )");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }

        public static DataTable LoadRoleFull()
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_ad_role_full( )");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }

        public static DataTable LoadAdUser()
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_ad_user( )");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static DataTable LoadAccount(string account, string pass)
        {
            //string sChuoiTruyVan = string.Format("SELECT * FROM view_user_account WHERE user_account = '{0}' AND user_password = '{1}'", account, pass);
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_GetUserTable('{0}','{1}')", account, pass);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static DataTable LoadWindow(string ad_user_id)
        {
            //string sChuoiTruyVan = string.Format("SELECT * FROM view_user_account WHERE user_account = '{0}' AND user_password = '{1}'", account, pass);
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_ad_window_access_by_ad_user_id('{0}')", ad_user_id);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static DataTable LoadProcess()
        {
            //string sChuoiTruyVan = string.Format("SELECT * FROM view_user_account WHERE user_account = '{0}' AND user_password = '{1}'", account, pass);
            string sChuoiTruyVan = string.Format("SELECT * FROM view_process");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }

        public static DataTable LoadLKWindow()
        {
            //string sChuoiTruyVan = string.Format("SELECT * FROM view_user_account WHERE user_account = '{0}' AND user_password = '{1}'", account, pass);
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_ad_lkwindow()");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static DataTable LoadProcess(string ad_user_id)
        {
            //string sChuoiTruyVan = string.Format("SELECT * FROM view_user_account WHERE user_account = '{0}' AND user_password = '{1}'", account, pass);
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_ad_process_access_by_ad_user_id('{0}')", ad_user_id);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static DataTable LoadLKProcess()
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_ad_lkprocess()");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static DataTable LoadUserRoles(string ad_user_id)
        {
            //string sChuoiTruyVan = string.Format("SELECT * FROM view_user_account WHERE user_account = '{0}' AND user_password = '{1}'", account, pass);
            string sChuoiTruyVan = string.Format("SELECT * from fn_ad_user_roles_by_ad_user_id('{0}')", ad_user_id);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static DataTable LoadAdUserFull(string ad_org_id)
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM fn_return_userlist('{0}')", ad_org_id);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static DataTable LoadWindow()
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM view_window");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static string UpdateUser(DataTable dt)
        {
            string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ad_user_id = dt.Rows[i]["ad_user_id"].ToString();
                string username = dt.Rows[i]["username"].ToString();
                string isactive = dt.Rows[i]["isactive"].ToString();
                string name = dt.Rows[i]["name"].ToString();
                string description = dt.Rows[i]["description"].ToString();
                string password = dt.Rows[i]["password"].ToString();
                string ad_group_id = dt.Rows[i]["ad_group_id"].ToString();

                cmd.CommandText = string.Format("UPDATE ad_user SET name ='{0}', description =N'{1}', password ='{2}', isactive ='{3}', ad_group_id ='{4}' WHERE ad_user_id ='{5}'", name, description, password, isactive, ad_group_id, ad_user_id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    sKetQua = null;
                }
                else
                {
                    sKetQua += "\n" + username;
                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }
        public static string UpdateWindow(DataTable dt)
        {
            string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ad_window_id = dt.Rows[i]["ad_window_id"].ToString();
                string isactive = dt.Rows[i]["isactive"].ToString();
                string name = dt.Rows[i]["name"].ToString();
                string description = dt.Rows[i]["description"].ToString();

                cmd.CommandText = string.Format("UPDATE ad_window SET name ='{0}', description =N'{1}', isactive ='{2}' WHERE ad_window_id ='{3}'", name, description, isactive, ad_window_id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    sKetQua = null;
                }
                else
                {
                    sKetQua += "\n" + name;
                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }
        public static string UpdateProcess(DataTable dt)
        {
            string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ad_process_id = dt.Rows[i]["ad_process_id"].ToString();
                string isactive = dt.Rows[i]["isactive"].ToString();
                string name = dt.Rows[i]["name"].ToString();
                string description = dt.Rows[i]["description"].ToString();

                cmd.CommandText = string.Format("UPDATE ad_process SET name ='{0}', description =N'{1}', isactive ='{2}' WHERE ad_process_id ='{3}'", name, description, isactive, ad_process_id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    sKetQua = null;
                }
                else
                {
                    sKetQua += "\n" + name;
                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static string UpdateRole(DataTable dt)
        {
            string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ad_role_id = dt.Rows[i]["ad_role_id"].ToString();
                string isactive = dt.Rows[i]["isactive"].ToString();
                string name = dt.Rows[i]["name"].ToString();
                string description = dt.Rows[i]["description"].ToString();

                cmd.CommandText = string.Format("UPDATE ad_role SET name ='{0}', description =N'{1}', isactive ='{2}' WHERE ad_role_id ='{3}'", name, description, isactive, ad_role_id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    sKetQua = null;
                }
                else
                {
                    sKetQua += "\n" + name;
                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }
        public static string UpdateUserRoles(DataTable dt, string processName)
        {
            string sKetQua = null;
            string isactive = null;
            string ad_role_description = null;
            string ad_user_username = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ad_user_roles_id = dt.Rows[i]["ad_user_roles_id"].ToString();
                if (string.Compare(processName, "btnUserRolesUpdate") == 0)
                {
                    isactive = dt.Rows[i]["isactive"].ToString();
                    ad_role_description = dt.Rows[i]["ad_role_description"].ToString();
                }
                else
                {
                    isactive = dt.Rows[i]["ad_user_role_isactive"].ToString();
                    ad_user_username = dt.Rows[i]["ad_user_username"].ToString();
                }

                cmd.CommandText = string.Format("UPDATE ad_user_roles SET isactive ='{0}' WHERE ad_user_roles_id ='{1}'", isactive, ad_user_roles_id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    sKetQua = null;
                }
                else
                {
                    if (string.Compare(processName, "btnUserRolesUpdate") == 0)
                    {
                        sKetQua += "\n" + ad_role_description;
                    }
                    else
                    {
                        sKetQua += "\n" + ad_user_username;
                    }

                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }
        public static string UpdateWindowAccess(DataTable dt)
        {
            string sKetQua = null;
            string isactive = null;
            string ad_window_access_id = null;
            string ad_window_description = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ad_window_access_id = dt.Rows[i]["ad_window_access_id"].ToString();
                isactive = dt.Rows[i]["ad_window_access_isactive"].ToString();
                ad_window_description = dt.Rows[i]["ad_window_description"].ToString();

                cmd.CommandText = string.Format("UPDATE ad_window_access SET isactive ='{0}' WHERE ad_window_access_id ='{1}'", isactive, ad_window_access_id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    sKetQua = null;
                }
                else
                {
                    sKetQua += "\n" + ad_window_description;
                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static string UpdateProcessAccess(DataTable dt)
        {
            string sKetQua = null;
            string isactive = null;
            string ad_process_access_id = null;
            string ad_process_description = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ad_process_access_id = dt.Rows[i]["ad_process_access_id"].ToString();
                isactive = dt.Rows[i]["ad_process_access_isactive"].ToString();
                ad_process_description = dt.Rows[i]["ad_process_description"].ToString();

                cmd.CommandText = string.Format("UPDATE ad_process_access SET isactive ='{0}' WHERE ad_process_access_id ='{1}'", isactive, ad_process_access_id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    sKetQua = null;
                }
                else
                {
                    sKetQua += "\n" + ad_process_description;
                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static string DeleteUserRoles(DataTable dt, string processName)
        {
            string sKetQua = null;
            string ad_user_roles_id = null;
            string ad_user_username = null;
            string ad_role_description = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ad_user_roles_id = dt.Rows[i]["ad_user_roles_id"].ToString();
                if (string.Compare(processName, "btnUserRolesDelete") == 0)
                {
                    ad_role_description = dt.Rows[i]["ad_role_description"].ToString();
                }
                else
                {
                    ad_user_username = dt.Rows[i]["ad_user_username"].ToString();
                }
                cmd.CommandText = string.Format("DELETE ad_user_roles WHERE ad_user_roles_id ='{0}'", ad_user_roles_id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    sKetQua = null;
                }
                else
                {
                    if (string.Compare(processName, "btnUserRolesDelete") == 0)
                    {
                        sKetQua += "\n" + ad_role_description;
                    }
                    else
                    {
                        sKetQua += "\n" + ad_user_username;
                    }

                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }
        public static string DeleteWindowAccess(DataTable dt)
        {
            string sKetQua = null;
            string isactive = null;
            string ad_window_access_id = null;
            string ad_window_description = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ad_window_access_id = dt.Rows[i]["ad_window_access_id"].ToString();
                isactive = dt.Rows[i]["ad_window_access_isactive"].ToString();
                ad_window_description = dt.Rows[i]["ad_window_description"].ToString();

                cmd.CommandText = string.Format("DELETE ad_window_access WHERE ad_window_access_id ='{1}'", isactive, ad_window_access_id);
                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        sKetQua = null;
                    }
                    else
                    {
                        sKetQua += "\n" + ad_window_description;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString(), "Không thành công");
                    sKetQua += "\n" + ad_window_description;
                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }
        public static string DeleteProcessAccess(DataTable dt)
        {
            string sKetQua = null;
            string isactive = null;
            string ad_process_access_id = null;
            string ad_process_description = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ad_process_access_id = dt.Rows[i]["ad_process_access_id"].ToString();
                isactive = dt.Rows[i]["ad_process_access_isactive"].ToString();
                ad_process_description = dt.Rows[i]["ad_process_description"].ToString();

                cmd.CommandText = string.Format("DELETE ad_process_access WHERE ad_process_access_id ='{1}'", isactive, ad_process_access_id);
                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        sKetQua = null;
                    }
                    else
                    {
                        sKetQua += "\n" + ad_process_description;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString(), "Không thành công");
                    sKetQua += "\n" + ad_process_description;
                }
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static string DeleteRoles(DataTable dt)
        {
            string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ad_role_id = dt.Rows[i]["ad_role_id"].ToString();
                string name = dt.Rows[i]["name"].ToString();

                cmd.CommandText = string.Format("DELETE ad_role WHERE ad_role_id ='{0}'", ad_role_id);
                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        sKetQua = null;
                    }
                    else
                    {
                        sKetQua += "\n" + name;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString(), "Không thành công");
                    sKetQua += "\n" + name;
                }

            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }
        public static bool CreateUserRoles(string ad_user_id, string ad_role_id)
        {
            string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            cmd.CommandText = string.Format("INSERT INTO ad_user_roles(ad_user_id, ad_role_id, isactive) VALUES('{0}','{1}','Y')", ad_user_id, ad_role_id);
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
        public static bool CreateWindowAccess(string ad_window_id, string ad_role_id)
        {
            string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            cmd.CommandText = string.Format("INSERT INTO ad_window_access(ad_window_id, ad_role_id, isactive) VALUES('{0}','{1}','Y')", ad_window_id, ad_role_id);
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

        public static bool CreateProcessAccess(string ad_process_id, string ad_role_id)
        {
            string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            cmd.CommandText = string.Format("INSERT INTO ad_process_access(ad_process_id, ad_role_id, isactive) VALUES('{0}','{1}','Y')", ad_process_id, ad_role_id);
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
        public static bool CreateUser(string name, string description, string username, string password, string groupid, string ad_org_id)
        {
            string sChuoiTruyVan = string.Format("INSERT INTO ad_user(ad_org_id, isactive, name, description, password, username, ad_group_id) VALUES('{0}','{1}','{2}',N'{3}','{4}','{5}','{6}')", ad_org_id, "Y", name, description, password, username, groupid);
            if (DataProvider.TruyVanExecuteNonQuery(sChuoiTruyVan))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CreateWindow(string name, string description)
        {
            string sChuoiTruyVan = string.Format("INSERT INTO ad_window( isactive, name, description) VALUES('{0}','{1}','{2}')", "Y", name, description);
            if (DataProvider.TruyVanExecuteNonQuery(sChuoiTruyVan))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CreateRole(string name, string description)
        {
            string sChuoiTruyVan = string.Format("INSERT INTO ad_role(isactive, name, description) VALUES('{0}','{1}',N'{2}')", "Y", name, description);
            if (DataProvider.TruyVanExecuteNonQuery(sChuoiTruyVan))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable GetNotify()
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM fn_ad_notify()");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
    }

    /*
    public static DataTable LoadUser()
    {
        //string sChuoiTruyVan = string.Format("SELECT * FROM view_user_account WHERE user_account = '{0}' AND user_password = '{1}'", account, pass);
        string sChuoiTruyVan = string.Format("SELECT ad_user_id as id, username FROM ad_user");
        DataTable dt = new DataTable();
        dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
        if(dt!=null && dt.Rows.Count > 0)
        {
            return dt;
        }
        else
        {
            return null;
        }
    }
    */
}
