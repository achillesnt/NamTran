using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.IO;

namespace DTO
{
    public class DTO_NhanVien
    {
        public string UserFullCode { get; set; } //Mã nhân viên
        public string UserFullName { get; set; } //Họ tên
        public string UserCardNo { get; set; } //Mã thẻ
        public string UserBirthDay { get; set; } //Ngày sinh
        public string UserSex { get; set; } //Giới tính
        public string UserNativeCountry { get; set; } //Quê quán
        public string UserAddress { get; set; } //Hộ khẩu thường trú
        public string UserIDCard { get; set; } //Chứng minh thư
        public string DeptID { get; set; } //Bộ phận
        public string DescriptionVN { get; set; } //Bộ phận
        public string PeopleName { get; set; } //Dân tộc
        public string Nationality { get; set; } //Quốc tịch
        public string TitleName { get; set; } //Chức vụ
        public string UserHireDay { get; set; } //Ngày vào làm việc
        public string UserInformDay { get; set; } //Ngày thông báo
        public string UserTerminalDay { get; set; } //Ngày nghỉ việc
        public string UserBabyDay { get; set; } //Ngày nghỉ thai sản
        public string UserPhoneNumber { get; set; } //Điện thoại
        public string StatusDescription { get; set; } //Tình trạng nhân viên

    }
}
