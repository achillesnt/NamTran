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
    public class BUS_NhanVien
    {
        #region Lấy thông tin nhân viên
        //Phương thức lấy full list nhân viên
        public static DataTable LoadNhanVien(string boPhan, int mode)
        {
            return DAO_NhanVien.LoadNhanVien(boPhan, mode);
        }

        public static List<DTO_NhanVien> LoadNhanVienMaNV(string maNV)
        {
            return DAO_NhanVien.LoadNhanVienMaNV(maNV);
        }

        public static bool UpdateNhanVien(DTO_NhanVien nv)
        {
            return DAO_NhanVien.UpdateNhanVien(nv);
        }

        public static int DieuChuyen(DataTable dt, string boPhan)
        {
            return DAO_NhanVien.DieuChuyen(dt, boPhan);
        }

        public static string LaySoLuongNhanVienByMaBoPhan(string maBoPhan)
        {
            return DAO_NhanVien.LaySoLuongNhanVienByMaBoPhan(maBoPhan);
        }

        public static DataTable LoadStatus()
        {
            return DAO_NhanVien.LoadStatus();
        }
        #endregion
        #region Quá trình làm việc
        public static DataTable GetEmployeeHistory(string startDate, string endDate, string deptid)
        {
            return DAO_NhanVien.GetEmployeeHistory(startDate, endDate, deptid);
        }
        #endregion
    }
}
