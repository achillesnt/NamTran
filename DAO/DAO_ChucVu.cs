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
    public class DAO_ChucVu
    {
        public static List<DTO_ChucVu> LoadChucVu()
        {
            string sChuoiTruyVan = @"select * from Title";
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lê và có giá trị
            {
                List<DTO_ChucVu> lstChucVuDTO = new List<DTO_ChucVu>();
                DTO_ChucVu cvDTO;
                for (int i = 0; i < dt.Rows.Count; i++) //Duyệt datatable và đưa vào list đối tượng NHANVIEN_DTO
                {
                    cvDTO = new DTO_ChucVu();
                    cvDTO.IDT = Convert.ToInt32(dt.Rows[i]["IDT"].ToString());
                    cvDTO.TitleName = dt.Rows[i]["TitleName"].ToString();

                    //Add trình độ vào lstTinhTrangDTO
                    lstChucVuDTO.Add(cvDTO);
                }
                return lstChucVuDTO;
            }
            return null;
        }
    }
}
