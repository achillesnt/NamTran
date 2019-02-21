using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_Ca
    {
        public static DataTable LoadCa()
        {
            string sChuoiTruyVan = string.Format("SELECT ShiftID as id, ShiftCode as name, Onduty as checkin, Offduty as checkout FROM Shifts");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lê và có giá trị
            {
                return dt;
                /*
                List<DTO_Ca> lstCaDTO = new List<DTO_Ca>();
                DTO_Ca caDTO;
                for (int i = 0; i < dt.Rows.Count; i++) //Duyệt datatable và đưa vào list đối tượng NHANVIEN_DTO
                {
                    caDTO = new DTO_Ca();
                    caDTO.ShiftID = Convert.ToInt16(dt.Rows[i]["ShiftID"]);
                    caDTO.ShiftCode = dt.Rows[i]["ShiftCode"].ToString();
                    //Add trình độ vào lstTrinhDo_DTO
                    lstCaDTO.Add(caDTO);
                }
                return lstCaDTO;
                */
            }
            return null;
        }
        public static DataTable LoadCaShift(DateTime date, string dept_id)
        {
            string dateFormated = date.ToString("yyyy-MM-dd");
            string sChuoiTruyVan = string.Format("SELECT * FROM fn_return_shift_bydatebydept('{0}','{1}')", dateFormated, dept_id);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lê và có giá trị
            {
                return dt;
            }
            return null;
        }       
    }
}
