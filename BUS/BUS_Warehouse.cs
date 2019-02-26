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
    public class BUS_Warehouse
    {
        public static DataTable LoadProductList(string vDate)
        {
            return DAO_Warehouse.LoadProductList(vDate);
        }
        public static DataTable LoadUnit()
        {
            return DAO_Warehouse.LoadUnit();
        }
        public static DataTable LoadCategory()
        {
            return DAO_Warehouse.LoadCategory();
        }
        public static DataTable LoadWarehouse()
        {
            return DAO_Warehouse.LoadWarehouse();
        }
        public static string UpdateProduct(object unit_id, object category_id, object warehouse_id, string product_name, string product_description, string product_note, string minimum, string isActive, string location, string product_id)
        {
            return DAO_Warehouse.UpdateProduct(unit_id, category_id, warehouse_id, product_name, product_description, product_note, minimum, isActive, location, product_id);
        }
        public static DataTable LoadPriceByProduct(string product_id)
        {
            return DAO_Warehouse.LoadPriceByProduct(product_id);
        }
        public static string UpdatePrice(string _price_id, string value, string currency, DateTime _date, string note)
        {
            return DAO_Warehouse.UpdatePrice(_price_id, value, currency, _date, note);
        }
        public static bool CreatePrice(string product_id, string value, string currency, DateTime _date, string note)
        {
            return DAO_Warehouse.CreatePrice( product_id, value, currency, _date, note);
        }       
        public static bool CreateProduct(string txtMaVT, string txtName, string txtGhiChu, string txtMoTa, string txtTonKho, string txtViTri, string category, string unit, string warehouse)
        {
            return DAO_Warehouse.CreateProduct(txtMaVT, txtName, txtGhiChu, txtMoTa, txtTonKho, txtViTri, category, unit, warehouse);
        }
        public static string UpdateAccessories(DataTable dt, string i_variable)
        {
            return DAO_Warehouse.UpdateAccessories(dt, i_variable);
        }
        public static bool CreateAccessories(string name, string description, string i_variable)
        {
            return DAO_Warehouse.CreateAccessories(name, description, i_variable);
        }
    }
}
