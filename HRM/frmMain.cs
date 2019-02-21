using DevExpress.XtraTabbedMdi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using BUS;

namespace HRM
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string ad_user_id, ad_org_id, ad_user_username, ad_org_description;

        DataTable dtUser = new DataTable();
        DataTable dtWindow = new DataTable();
        DataTable dtProcess = new DataTable();

        public delegate void Thoat();
        public Thoat thoat;    
        Utility utility = new Utility();
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(DataTable dt)
        {
            InitializeComponent();
            this.dtUser = dt;
            ad_user_id = dt.Rows[0]["ad_user_id"].ToString();
            ad_org_id = dt.Rows[0]["ad_org_id"].ToString();
            ad_user_username = dt.Rows[0]["username"].ToString();
            ad_org_description = dt.Rows[0]["ad_org_description"].ToString();

            dtWindow = BUS_HeThong.LoadWindow(ad_user_id);
            dtProcess = BUS_HeThong.LoadProcess(ad_user_id);
            utility.SearchWindow(this.ribbonControl1, dtWindow);
            //utility.FindRibbonBarItem(this.ribbonControl1, "bar");
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmNhanVienFinal qlNhanvien = new frmNhanVienFinal(ad_org_id, ad_org_description, dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlNhanvien.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlNhanvien.MdiParent = this;
            qlNhanvien.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnQuetThe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuetThe qlChamCong = new frmQuetThe(ad_org_id);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlChamCong.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlChamCong.MdiParent = this;
            qlChamCong.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfor = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfor.ProductVersion;
            barVersion.Caption = "Version " + version;
            XtraTabbedMdiManager mdiManager = new XtraTabbedMdiManager();
            mdiManager.MdiParent = this;

            /*
            maBoPhan = dt.Rows[0]["dept_id"].ToString();
            tenBoPhan = dt.Rows[0]["dept_name"].ToString();
            tenUser = dt.Rows[0]["user_fullname"].ToString();
            user_level_id = dt.Rows[0]["user_level_id"].ToString();
            Permission(user_level_id);
            */
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBaoCom qlBaoCom = new frmBaoCom(ad_user_id, ad_org_id, dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlBaoCom.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlBaoCom.MdiParent = this;
            qlBaoCom.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string ngay = "Ngày: " + DateTime.Now.Day.ToString() + "/";
            ngay += DateTime.Now.Month.ToString() + "/";
            ngay += DateTime.Now.Year.ToString();
            string gio = "Giờ: " + DateTime.Now.Hour.ToString() + ":";
            gio += DateTime.Now.Minute.ToString() + ":";
            gio += DateTime.Now.Second.ToString();
            //string nguoidung = "Đăng nhập dưới tên: " + dt.Rows[0]["ten"].ToString();
            //bar_user.Caption = nguoidung;
            barNgay.Caption = ngay;
            barGio.Caption = gio;
            bar_user.Caption = "Đăng nhập: " + ad_user_username;
            if(DateTime.Now.Minute % 50 == 0)
            {
                string title = null;
                string content = null;
                int timeDisplay;
                DataTable dtNotify = BUS_HeThong.GetNotify();
                if(dtNotify!=null && dtNotify.Rows.Count >0)
                {
                    title = dtNotify.Rows[0]["title"].ToString();
                    content = dtNotify.Rows[0]["content"].ToString();
                    timeDisplay = Convert.ToInt16(dtNotify.Rows[0]["time"].ToString());
                    alertControl1.AutoFormDelay = timeDisplay * 1000;
                    if(DateTime.Now.Second == 10)
                    {
                        alertControl1.Show(this, title, content);
                    }                 
                }
            }
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
            frmBCBaoCom bcBaoCom = new frmBCBaoCom(maBoPhan);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (bcBaoCom.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            bcBaoCom.MdiParent = this;
            bcBaoCom.Show();
            */
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuetThe qlChamCong = new frmQuetThe(ad_org_id);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlChamCong.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlChamCong.MdiParent = this;
            qlChamCong.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            frmDiemDanh qlDiemDanh = new frmDiemDanh(ad_user_id, ad_org_id, dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlDiemDanh.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlDiemDanh.MdiParent = this;
            qlDiemDanh.Show();
            
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmQLSapXepCa qlPhanCa = new frmQLSapXepCa(ad_org_id, ad_org_description, dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlPhanCa.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlPhanCa.MdiParent = this;
            qlPhanCa.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmNhSanLuong nhSanLuong = new frmNhSanLuong(ad_user_id, ad_org_id, dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (nhSanLuong.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            nhSanLuong.MdiParent = this;
            nhSanLuong.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            frmReportPhanCa reportPhanCa = new frmReportPhanCa(ad_org_id);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (reportPhanCa.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            reportPhanCa.MdiParent = this;
            reportPhanCa.Show();
            
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmQLSanLuong qlSanLuong = new frmQLSanLuong(ad_org_id);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlSanLuong.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlSanLuong.MdiParent = this;
            qlSanLuong.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmNguoiDung nguoiDung = new frmNguoiDung(ad_user_id, ad_org_id, dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (nguoiDung.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            nguoiDung.MdiParent = this;
            nguoiDung.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barVaiTro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmRole role = new frmRole(dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (role.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            role.MdiParent = this;
            role.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barAttCountReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmAttReport attReport = new frmAttReport(ad_user_id, ad_org_id, dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (attReport.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            attReport.MdiParent = this;
            attReport.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barQtyReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmQtyReport qtyReport = new frmQtyReport(ad_user_id, ad_org_id, dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qtyReport.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qtyReport.MdiParent = this;
            qtyReport.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmHistory history = new frmHistory(ad_user_id, ad_org_id, dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (history.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            history.MdiParent = this;
            history.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barWindow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmWindow window = new frmWindow(ad_user_id, ad_org_id, dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (window.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            window.MdiParent = this;
            window.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barProcess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmProcess process = new frmProcess(ad_user_id, ad_org_id, dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (process.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            process.MdiParent = this;
            process.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            thoat();
        }

        private void btnToChuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmToChuc qlToChuc = new frmToChuc(ad_org_id, ad_org_description, dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (qlToChuc.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            qlToChuc.MdiParent = this;
            qlToChuc.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void Permission(string _user_level_id)
        {
            int i = Convert.ToInt16(_user_level_id);
            barOrganization.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            barOvertimeRegis.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            switch (i)
            {
                case 1:
                    pageDuLieuGoc.Visible = false;
                    pageBaoCom.Visible = false;
                    pgr_PhanCa.Visible = false;
                    pageSanXuat.Visible = true;
                    break;
                case 2:
                    pageDuLieuGoc.Visible = true;
                    pageBaoCom.Visible = true;
                    pgr_PhanCa.Visible = true;
                    pageSanXuat.Visible = false;
                    break;
                default:
                    pageDuLieuGoc.Visible = true;
                    pageBaoCom.Visible = true;
                    pgr_PhanCa.Visible = true;
                    pageSanXuat.Visible = true;
                    break;
            }
        }
    }
}
