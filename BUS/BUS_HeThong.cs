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
    public class BUS_HeThong
    {
        public static DataTable LoadUserByRole(string ad_role_id)
        {
            return DAO_HeThong.LoadUserByRole(ad_role_id);
        }

        public static DataTable LoadWindowByRole(string ad_role_id)
        {
            return DAO_HeThong.LoadWindowByRole(ad_role_id);
        }

        public static DataTable LoadProcessByRole(string ad_role_id)
        {
            return DAO_HeThong.LoadProcessByRole(ad_role_id);
        }
        public static DataTable LoadRole()
        {
            return DAO_HeThong.LoadRole();
        }

        
        public static DataTable LoadRoleFull()
        {
            return DAO_HeThong.LoadRoleFull();
        }
        
        public static DataTable LoadAdUser()
        {
            return DAO_HeThong.LoadAdUser();
        }
        public static DataTable LoadAccount(string account, string pass)
        {
            return DAO_HeThong.LoadAccount(account, pass);
        }
        public static DataTable LoadAdUserFull(string ad_org_id)
        {
            return DAO_HeThong.LoadAdUserFull(ad_org_id);
        }

        public static DataTable LoadWindow(string ad_user_id)
        {
            return DAO_HeThong.LoadWindow(ad_user_id);
        }
        public static DataTable LoadProcess()
        {
            return DAO_HeThong.LoadProcess();
        }
        public static DataTable LoadLKWindow()
        {
            return DAO_HeThong.LoadLKWindow();
        }

        public static DataTable LoadProcess(string ad_user_id)
        {
            return DAO_HeThong.LoadProcess(ad_user_id);
        }

        public static DataTable LoadLKProcess()
        {
            return DAO_HeThong.LoadLKProcess();
        }

        public static DataTable LoadUserRoles(string ad_user_id)
        {
            return DAO_HeThong.LoadUserRoles(ad_user_id);
        }
        public static DataTable LoadWindow()
        {
            return DAO_HeThong.LoadWindow();
        }

        public static string UpdateWindow(DataTable dt)
        {
            return DAO_HeThong.UpdateWindow(dt);
        }
        public static string UpdateProcess(DataTable dt)
        {
            return DAO_HeThong.UpdateProcess(dt);
        }
        public static string UpdateUser(DataTable dtUpdateUser)
        {
            return DAO_HeThong.UpdateUser(dtUpdateUser);
        }

        public static string UpdateRole(DataTable dt)
        {
            return DAO_HeThong.UpdateRole(dt);
        }

        public static string UpdateUserRoles(DataTable dt, string processName)
        {
            return DAO_HeThong.UpdateUserRoles(dt, processName);
        }

        public static string UpdateWindowAccess(DataTable dt)
        {
            return DAO_HeThong.UpdateWindowAccess(dt);
        }

        public static string UpdateProcessAccess(DataTable dt)
        {
            return DAO_HeThong.UpdateProcessAccess(dt);
        }

        public static string DeleteUserRoles(DataTable dt, string processName)
        {
            return DAO_HeThong.DeleteUserRoles(dt, processName);
        }

        public static string DeleteWindowAccess(DataTable dt)
        {
            return DAO_HeThong.DeleteWindowAccess(dt);
        }

        public static string DeleteProcessAccess(DataTable dt)
        {
            return DAO_HeThong.DeleteProcessAccess(dt);
        }

        public static string DeleteRoles(DataTable dt)
        {
            return DAO_HeThong.DeleteRoles(dt);
        }

        public static bool CreateUserRoles(string ad_user_id, string ad_role_id)
        {
            return DAO_HeThong.CreateUserRoles(ad_user_id, ad_role_id);
        }

        public static bool CreateWindowAccess(string ad_window_id, string ad_role_id)
        {
            return DAO_HeThong.CreateWindowAccess(ad_window_id, ad_role_id);
        }

        public static bool CreateProcessAccess(string ad_process_id, string ad_role_id)
        {
            return DAO_HeThong.CreateProcessAccess(ad_process_id, ad_role_id);
        }

        public static bool CreateWindow(string name, string description)
        {
            return DAO_HeThong.CreateWindow(name, description);
        }
        public static bool CreateUser(string v_name, string v_description, string v_username, string v_password, string v_groupid, string v_ad_org_id)
        {
            return DAO_HeThong.CreateUser(v_name, v_description, v_username, v_password, v_groupid, v_ad_org_id);
        }

        public static bool CreateRole(string name, string description)
        {
            return DAO_HeThong.CreateRole(name, description);
        }
        public static DataTable GetNotify()
        {
            return DAO_HeThong.GetNotify();
        }
        /*
        public static DataTable LoadUser()
        {
            return DAO_HeThong.LoadUser();
        }
        */
    }
}
