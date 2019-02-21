using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChamCong
    {
        public string STAFFID { get; set; } //Mã nhân viên
        public string UserFullName { get; set; } //Họ tên
        public string CARDNO { get; set; } //Mã thẻ
        public string DescriptionVN { get; set; } //Bộ phận
        public string TitleName { get; set; } // Chức vụ
        public string READERID { get; set; } //Máy chấm công
        public string RECTIME { get; set; } //Thời gian chấm công
        public string TinhTrang { get; set; } //Tình trạng nhân viên đi làm? vắng
    }
}
