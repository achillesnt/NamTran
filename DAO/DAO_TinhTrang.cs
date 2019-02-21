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
    public class DAO_TinhTrang
    {
        public static List<DTO_TinhTrang> LoadTinhTrang()
        {
            string sChuoiTruyVan = @"select * from Status";
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lê và có giá trị
            {
                List<DTO_TinhTrang> lstTinhTrangDTO = new List<DTO_TinhTrang>();
                DTO_TinhTrang ttDTO;
                for (int i = 0; i < dt.Rows.Count; i++) //Duyệt datatable và đưa vào list đối tượng NHANVIEN_DTO
                {
                    ttDTO = new DTO_TinhTrang();
                    ttDTO.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    ttDTO.StatusDescription = dt.Rows[i]["StatusDescription"].ToString();

                    //Add trình độ vào lstTinhTrangDTO
                    lstTinhTrangDTO.Add(ttDTO);
                }
                return lstTinhTrangDTO;
            }
            return null;
        }
    }
}
