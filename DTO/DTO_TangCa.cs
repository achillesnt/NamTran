using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TangCa
    {
        public int OverTimeID { get; set; } //Mã tăng ca
        public int ShiftID { get; set; } //Mã ca
        public string ShiftCode { get; set; } //Tên ca
        public string STAFFID { get; set; } //Mã nhân viên
        public string UserFullName { get; set; } //Họ tên
        public string Date { get; set; } //Ngày tăng ca
        public string DescriptionVN { get; set; } //Bộ phận
        public string FromHour { get; set; } //Bắt đầu tăng ca
        public string ToHour { get; set; } //Kết thúc tăng ca
        public string Reason { get; set; } //Lý do tăng ca
        public string Status { get; set; }//Trạng thái
    }
}
