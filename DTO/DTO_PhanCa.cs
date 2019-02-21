using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhanCa
    {
        public string ID { get; set; }
        public string STAFFID { get; set; } //Mã nhân viên
        public string UserFullName { get; set; } //Họ tên
        public string DescriptionVN { get; set; } //Bộ phận
        public string EffectiveDate { get; set; } //Ngày bắt đầu
        public string ShiftID { get; set; } //Mã ca 
        public string ShiftCode { get; set; } //Tên ca   
    }
}
