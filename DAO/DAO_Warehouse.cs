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
    public class DAO_Warehouse
    {
        public static DataTable LoadProductList(string vDate)
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_return_productlist('{0}')", vDate);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static DataTable LoadUnit()
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_return_unitlist()");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static DataTable LoadCategory()
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_return_categorylist()");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static DataTable LoadWarehouse()
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_return_warehouselist()");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }

        public static string UpdateProduct(object unit_id, object category_id, object warehouse_id, string product_name, string product_description, string product_note, string minimum, string isActive, string location, string product_id)
        {
            string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            cmd.CommandText = string.Format("UPDATE product SET product_name = N'{0}', product_description = N'{1}', product_note = N'{2}', category_id = '{3}', unit_id = '{4}', warehouse_id = '{5}', location = '{6}', isactive = '{7}', minimum = '{8}' WHERE product_id = '{9}'", product_name, product_description, product_note, category_id, unit_id, warehouse_id, location, isActive, minimum, product_id);
            if (cmd.ExecuteNonQuery() > 0)
            {
                sKetQua = null;
            }
            else
            {
                sKetQua = product_id;
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }
        public static DataTable LoadPriceByProduct(string product_id)
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM dbo.fn_return_price_byproduct('{0}') order by price_id desc", product_id);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            return dt;
        }
        public static string UpdatePrice(string _price_id, string value, string currency, DateTime _date, string note)
        {
            string sKetQua = null;
            string eff_date = _date.ToString("yyyy-MM-dd");
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            cmd.CommandText = string.Format("UPDATE prices SET value = N'{0}', currency = N'{1}', effective_date = N'{2}', price_note = '{3}' WHERE price_id = '{4}'", value, currency, eff_date, note, _price_id);
            if (cmd.ExecuteNonQuery() > 0)
            {
                sKetQua = null;
            }
            else
            {
                sKetQua = _price_id;
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }
        public static bool CreatePrice(string product_id, string value, string currency, DateTime _date, string note)
        {
            string eff_date = _date.ToString("yyyy-MM-dd");
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            cmd.CommandText = string.Format("INSERT INTO prices(value, currency, effective_date, price_note, product_id) VALUES('{0}','{1}','{2}','{3}','{4}')", value, currency, eff_date, note, product_id);
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
        public static bool CreateProduct(string txtMaVT, string txtName, string txtGhiChu, string txtMoTa, string txtTonKho, string txtViTri, string category, string unit, string warehouse)
        {
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            cmd.CommandText = string.Format("INSERT INTO product(product_code, product_name, product_note, product_description, minimum, location, category_id, unit_id, warehouse_id, isactive) VALUES('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}','{6}','{7}','{8}','{9}')", txtMaVT, txtName, txtGhiChu, txtMoTa, txtTonKho, txtViTri, category, unit, warehouse, "Y");
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
        public static string UpdateAccessories(DataTable dt, string i_variable)
        {
            string sKetQua = null;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmd.CommandText = string.Format("UPDATE {0} SET {0}_name = N'{1}', {0}_description = N'{2}' WHERE {0}_id = '{3}'", i_variable, dt.Rows[i]["name"].ToString(), dt.Rows[i]["description"].ToString(), dt.Rows[i]["id"].ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    sKetQua = null;
                }
                else
                {
                    sKetQua += dt.Rows[i]["id"].ToString();
                }
            }

            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }
        public static bool CreateAccessories(string name, string description, string i_variable)
        {
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();
            cmd.CommandText = string.Format("INSERT INTO {0} ({0}_name, {0}_description) VALUES(N'{1}',N'{2}')", i_variable, name, description);
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
    }
}
