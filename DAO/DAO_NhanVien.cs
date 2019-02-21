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
    public class DAO_NhanVien
    {
        public static DataTable LoadNhanVien(string boPhan, int mode)
        {
            string maBoPhan = DAO_BoPhan.LoadMaBoPhan(boPhan);
            string sChuoiTruyVan;
            if (mode == 1)
            {
                sChuoiTruyVan = string.Format("SELECT * FROM view_staff WHERE dept_id IN ({0})", maBoPhan);
            }
            else
            {
                sChuoiTruyVan = string.Format("SELECT * FROM view_staff_copy WHERE dept_id_c IN ({0})", maBoPhan);
            }
            
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);

            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lê và có giá trị
            {
                return dt;              
            }else
            {
                return null;
            }
        }

        public static List<DTO_NhanVien> LoadNhanVienMaNV(string maNV)
        {
            string sChuoiTruyVan = string.Format("SELECT  A.*, B.ID, B.DescriptionVN, C.TitleName, D.PeopleName, E.Nationality, F.StatusDescription FROM UserInfo A, RelationDept B, Title C, Peoples D, Nationality E, Status F WHERE A.UserIDD = B.ID AND A.UserIDTitle = C.IDT AND A.UserPeople = D.ID AND A.UserNationality = E.ID AND A.UserStatusID = F.ID AND A.UserFullCode LIKE N'%{0}%'", maNV);

            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);

            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lê và có giá trị
            {
                List<DTO_NhanVien> lstNhanVienDTO = new List<DTO_NhanVien>();
                DTO_NhanVien nvDTO;
                for (int i = 0; i < dt.Rows.Count; i++) //duyệt datatable và đưa vào list đối tượng nhanvien_dto
                {
                    nvDTO = new DTO_NhanVien();
                    nvDTO.UserFullCode = dt.Rows[i]["UserFullCode"].ToString(); //Mã NV

                    nvDTO.UserFullName = dt.Rows[i]["UserFullName"].ToString(); //Họ tên

                    nvDTO.UserCardNo = dt.Rows[i]["UserCardNo"].ToString(); //Mã thẻ

                    nvDTO.UserBirthDay = dt.Rows[i]["UserBirthDay"].ToString(); //Ngày sinh

                    if (dt.Rows[i]["UserSex"].ToString() == "1")
                    {
                        nvDTO.UserSex = "Nữ";
                    }
                    else
                    {
                        nvDTO.UserSex = "Nam";
                    }

                    nvDTO.UserNativeCountry = dt.Rows[i]["UserNativeCountry"].ToString(); //Quê quán

                    nvDTO.UserAddress = dt.Rows[i]["UserAddress"].ToString(); //Địa chỉ

                    nvDTO.UserIDCard = dt.Rows[i]["UserIDCard"].ToString(); //CMND

                    nvDTO.DeptID = dt.Rows[i]["ID"].ToString(); //Bộ phận

                    nvDTO.DescriptionVN = dt.Rows[i]["DescriptionVN"].ToString(); //Bộ phận

                    nvDTO.StatusDescription = dt.Rows[i]["StatusDescription"].ToString(); //Tình trạng nhân viên

                    nvDTO.PeopleName = dt.Rows[i]["PeopleName"].ToString(); //Dân tộc

                    nvDTO.Nationality = dt.Rows[i]["Nationality"].ToString(); //Quốc tịch

                    nvDTO.TitleName = dt.Rows[i]["TitleName"].ToString(); //Chức vụ

                    nvDTO.UserHireDay = dt.Rows[i]["UserHireDay"].ToString(); //Ngày vào làm việc

                    nvDTO.UserInformDay = dt.Rows[i]["UserInformDay"].ToString(); //Ngày thông báo nghỉ việc

                    nvDTO.UserTerminalDay = dt.Rows[i]["UserTerminalDay"].ToString(); //Ngày nghỉ việc

                    nvDTO.UserBabyDay = dt.Rows[i]["UserBabyDay"].ToString(); //Ngày nghỉ thai sản

                    nvDTO.UserPhoneNumber = dt.Rows[i]["UserPhoneNumber"].ToString(); //Điện thoại 

                    //add nhân viên vào lstnhanvien_dto
                    lstNhanVienDTO.Add(nvDTO);
                }
                return lstNhanVienDTO;
            }
            return null;
        }

        public static bool UpdateNhanVien(DTO_NhanVien nv)
        {
            string sChuoiTruyVan = "";
            nv.DescriptionVN = nv.DescriptionVN;
            nv.TitleName = LayMaChucVu(nv.TitleName);
            nv.StatusDescription = LayMaTinhTrang(nv.StatusDescription);
            nv.PeopleName = LayMaDanToc(nv.PeopleName);
            nv.Nationality = LayMaQuocTich(nv.Nationality);

            nv.UserBirthDay = clConver.ConverDMY_MDY(DateTime.Parse(nv.UserBirthDay));
            nv.UserHireDay = clConver.ConverDMY_MDY(DateTime.Parse(nv.UserHireDay));

            if (nv.UserBabyDay != "")
            {
                nv.UserBabyDay = clConver.ConverDMY_MDY(DateTime.Parse(nv.UserBabyDay));
            }

            if (nv.UserInformDay != "")
            {
                nv.UserInformDay = clConver.ConverDMY_MDY(DateTime.Parse(nv.UserInformDay));
            }

            if (nv.UserTerminalDay != "")
            {
                nv.UserTerminalDay = clConver.ConverDMY_MDY(DateTime.Parse(nv.UserTerminalDay));
            }

            sChuoiTruyVan = string.Format("UPDATE UserInfo SET UserFullName = N'{0}', UserCardNo = '{1}', UserSex = '{2}', UserAddress = N'{3}', UserNativeCountry = N'{4}', UserIDCard = '{5}', UserIDD = '{6}', UserIDTitle = '{7}', UserPeople = N'{8}', UserNationality = N'{9}', UserStatusID = '{10}', UserPhoneNumber = '{11}', UserBirthDay = '{12}', UserHireDay = '{13}', UserInformDay = '{14}', UserTerminalDay = '{15}', UserBabyDay = '{16}' WHERE UserFullCode = '{17}'", nv.UserFullName, nv.UserCardNo, nv.UserSex, nv.UserAddress, nv.UserNativeCountry, nv.UserIDCard, nv.DescriptionVN, nv.TitleName, nv.PeopleName, nv.Nationality, nv.StatusDescription, nv.UserPhoneNumber, nv.UserBirthDay, nv.UserHireDay, nv.UserInformDay, nv.UserTerminalDay, nv.UserBabyDay, nv.UserFullCode);

            return DataProvider.TruyVanExecuteNonQuery(sChuoiTruyVan);
        }
        
        public static string LayMaBoPhan(string boPhan)
        {
            string sChuoiTruyVan = string.Format("SELECT ID FROM RelationDept WHERE DescriptionVN LIKE N'%{0}%'", boPhan);
            return DataProvider.TruyVanExecuteScalar(sChuoiTruyVan);
        }

        public static string LayMaChucVu(string chucVu)
        {
            string sChuoiTruyVan = string.Format("SELECT IDT FROM Title WHERE TitleName LIKE N'%{0}%'", chucVu);
            return DataProvider.TruyVanExecuteScalar(sChuoiTruyVan);
        }

        public static string LayMaTinhTrang(string tinhTrang)
        {
            string sChuoiTruyVan = string.Format("SELECT ID FROM Status WHERE StatusDescription LIKE N'%{0}%'", tinhTrang);
            return DataProvider.TruyVanExecuteScalar(sChuoiTruyVan);
        }

        public static string LayMaDanToc(string danToc)
        {
            string sChuoiTruyVan = string.Format("SELECT ID FROM Peoples WHERE PeopleName LIKE N'%{0}%'", danToc);
            return DataProvider.TruyVanExecuteScalar(sChuoiTruyVan);
        }

        public static string LayMaQuocTich(string quocTich)
        {
            string sChuoiTruyVan = string.Format("SELECT ID FROM Nationality WHERE Nationality LIKE N'%{0}%'", quocTich);
            return DataProvider.TruyVanExecuteScalar(sChuoiTruyVan);
        }

        public static int DieuChuyen(DataTable dt, string boPhan)
        {
            int sKetQua = 0;
            SqlConnection con = new SqlConnection(DataProvider.sChuoiKetNoi);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection.Open();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string UserFullCode = dt.Rows[i]["UserFullCode"].ToString();
                string maBoPhan = boPhan;
                cmd.CommandText = string.Format("UPDATE UserInfo SET UserIDD='{0}' WHERE UserFullCode='{1}'", maBoPhan, UserFullCode);
                if(cmd.ExecuteNonQuery()>0)
                {
                    sKetQua = 1;
                }
                else
                {
                    sKetQua = 0;
                }              
            }
            return sKetQua;
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public static string LaySoLuongNhanVienByMaBoPhan(string maBoPhan)
        {
            string sChuoiTruyVan = string.Format("SELECT COUNT(UserFullCode) FROM UserInfo WHERE UserStatusID IN (2,3,4) AND USERIDD='{0}'",maBoPhan);
            return DataProvider.TruyVanExecuteScalar(sChuoiTruyVan);
        }

        public static DataTable LoadStatus()
        {           
            string sChuoiTruyVan = string.Format("SELECT * FROM view_staff_status");
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lê và có giá trị
            {
                return dt;
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetEmployeeHistory(string startDate, string endDate, string deptid)
        {
            string sChuoiTruyVan = string.Format("SELECT * FROM fn_return_employeehistory('{0}','{1}','{2}')", startDate, endDate, deptid);
            DataTable dt = new DataTable();
            dt = DataProvider.TruyVanDataTable(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lê và có giá trị
            {
                return dt;
            }
            else
            {
                return null;
            }
        }
    }
}
