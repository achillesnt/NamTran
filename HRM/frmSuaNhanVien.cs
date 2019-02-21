using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace HRM
{
    public partial class frmSuaNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public string maNV;
        string BoPhan;
        List<DTO_NhanVien> lstNhanVien;
        public frmSuaNhanVien()
        {
            InitializeComponent();
        }

        public frmSuaNhanVien(string tmpNV, string tmpBoPhan)
        {
            InitializeComponent();
            this.maNV = tmpNV;
            this.BoPhan = tmpBoPhan;
        }

        public void LoadChucNang()
        {
            LoadCombobox();
            lstNhanVien = BUS_NhanVien.LoadNhanVienMaNV(maNV);
            txtMaNV.Text = lstNhanVien[0].UserFullCode;
            txtHoten.Text = lstNhanVien[0].UserFullName;
            txtMathe.Text = lstNhanVien[0].UserCardNo;
            txtQuequan.Text = lstNhanVien[0].UserNativeCountry;
            txtHokhau.Text = lstNhanVien[0].UserAddress;
            txtDantoc.Text = lstNhanVien[0].PeopleName;
            txtQuoctich.Text = lstNhanVien[0].Nationality;
            txtCMND.Text = lstNhanVien[0].UserIDCard;
            txtDienthoai.Text = lstNhanVien[0].UserPhoneNumber;

            dteNgaysinh.Text = lstNhanVien[0].UserBirthDay;
            dteNgaynhanviec.Text = lstNhanVien[0].UserHireDay;
            dteNgaythongbao.Text = lstNhanVien[0].UserInformDay;
            dteNgaynghiviec.Text = lstNhanVien[0].UserTerminalDay;
            dteNgaythaisan.Text = lstNhanVien[0].UserBabyDay;

            cmbGioitinh.Items.Add("Nam");
            cmbGioitinh.Items.Add("Nữ");
            cmbGioitinh.Text = lstNhanVien[0].UserSex;

            //cmbBophan.Text = lstNhanVien[0].DescriptionVN;
            cmbTinhtrang.Text = lstNhanVien[0].StatusDescription;
            cmbChucvu.Text = lstNhanVien[0].TitleName;

            lblDisplay.Text = lstNhanVien[0].UserFullName;
            lblDisplay.Left = (this.ClientSize.Width - lblDisplay.Width) / 2;
            
        }

        public void LoadCombobox()
        {
            #region Xử lý lookupEdit
            DataTable lstBoPhan = BUS_BoPhan.LoadBoPhan(BoPhan);

            lkBoPhan.Properties.DataSource = lstBoPhan;
            lkBoPhan.Properties.DisplayMember = "description";
            lkBoPhan.Properties.ValueMember = "id";
            lkBoPhan.Properties.NullText = "Chọn bộ phận";
            lkBoPhan.EditValue = lstBoPhan.Rows[0][0];

            lkBoPhan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkBoPhan.Properties.DropDownRows = lstBoPhan.Rows.Count;
            //lkInput.Properties.ReadOnly = true;
            #endregion


            //Gọi nghiệp vụ load tình trạng từ class BUL
            cmbTinhtrang.DataSource = BUS_TinhTrang.LoadTinhTrang();
            cmbTinhtrang.DisplayMember = "StatusDescription";
            cmbTinhtrang.ValueMember = "ID";

            //Gọi nghiệp vụ load tình trạng từ class BUL
            cmbChucvu.DataSource = BUS_ChucVu.LoadChucVu();
            cmbChucvu.DisplayMember = "TitleName";
            cmbChucvu.ValueMember = "IDT";
        }

        private void frmSuaNhanVien_Load(object sender, EventArgs e)
        {
            LoadChucNang();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            LoadChucNang();
        }

        private bool KiemTra()
        {
            bool ketQua = false;

            if (cmbTinhtrang.Text == "Đang làm việc")
            {
                ketQua = true;
            }

            if (cmbTinhtrang.Text== "Nghỉ thai sản")
            {
                if(dteNgaythaisan.Text=="")
                {
                    MessageBox.Show("Ngày nghỉ thai sản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ketQua = false;
                }
                else
                {
                    ketQua = true;
                }
            }

            if (cmbTinhtrang.Text == "Thông báo nghỉ")
            {
                if (dteNgaythongbao.Text == "")
                {
                    MessageBox.Show("Ngày thông báo nghỉ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ketQua = false;
                }
                else
                {
                    ketQua = true;
                }
            }

            if (cmbTinhtrang.Text == "Đã nghỉ việc")
            {
                if (dteNgaynghiviec.Text == "")
                {
                    MessageBox.Show("Ngày nghỉ việc không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ketQua = false;
                }
                else
                {
                    ketQua = true;
                }
            }

            return ketQua;
        }
        private void btCapnhat_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.UserFullCode = txtMaNV.Text;
            nv.UserFullName = txtHoten.Text;
            nv.UserCardNo = txtMathe.Text;
            nv.UserNativeCountry = txtQuequan.Text;
            nv.UserAddress = txtHokhau.Text;
            nv.PeopleName = txtDantoc.Text;
            nv.Nationality = txtQuoctich.Text;
            nv.UserIDCard = txtCMND.Text;
            nv.UserPhoneNumber = txtDienthoai.Text;

            if (cmbGioitinh.Text == "Nam")
            {
                nv.UserSex = "0";
            }
            else
            {
                nv.UserSex = "1";
            }
            nv.DescriptionVN = lkBoPhan.EditValue.ToString();
            nv.StatusDescription = cmbTinhtrang.Text;
            nv.TitleName = cmbChucvu.Text;

            nv.UserBirthDay = dteNgaysinh.Text;
            nv.UserHireDay = dteNgaynhanviec.Text;
            nv.UserInformDay = dteNgaythongbao.Text;
            nv.UserTerminalDay = dteNgaynghiviec.Text;
            nv.UserBabyDay = dteNgaythaisan.Text;

            if(KiemTra())
            {
                if (BUS_NhanVien.UpdateNhanVien(nv) == true)
                {
                    MessageBox.Show("Sửa thông tin cho nhân viên " + lblDisplay.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}