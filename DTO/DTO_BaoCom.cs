using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BaoCom
    {
        public string DEPARTMENT { get; set; } //Bộ phận
        public string TOTAL { get; set; } //Tổng số
        public string ATTENDANCE { get; set; } //Có mặt
        public string ABSENT { get; set; } //Vắng mặt
        public string ORDER { get; set; } //Báo cơm
        public string ACTUAL { get; set; } //Số lượng báo thực tế
        public string REASON { get; set; } //Lý do
        public string TIME { get; set; } //Thời gian

    }
}
