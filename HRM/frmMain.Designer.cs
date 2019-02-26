namespace HRM
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::HRM.SplashScreen1), true, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::HRM.WaitForm1), true, true, true);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barOrganization = new DevExpress.XtraBars.BarButtonItem();
            this.barMealOrder = new DevExpress.XtraBars.BarButtonItem();
            this.barNgay = new DevExpress.XtraBars.BarStaticItem();
            this.barGio = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barVersion = new DevExpress.XtraBars.BarStaticItem();
            this.bar_user = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barSweepCard = new DevExpress.XtraBars.BarButtonItem();
            this.barAttCount = new DevExpress.XtraBars.BarButtonItem();
            this.barShiftArranged = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barOvertimeRegis = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barInputQty = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barQtyManagement = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.barShiftSum = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKeDiemDanh = new DevExpress.XtraBars.BarButtonItem();
            this.barDashboard = new DevExpress.XtraBars.BarButtonItem();
            this.barNguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.barVaiTro = new DevExpress.XtraBars.BarButtonItem();
            this.barWindow = new DevExpress.XtraBars.BarButtonItem();
            this.barProcess = new DevExpress.XtraBars.BarButtonItem();
            this.barTypename = new DevExpress.XtraBars.BarButtonItem();
            this.barShift = new DevExpress.XtraBars.BarButtonItem();
            this.barAbsent = new DevExpress.XtraBars.BarButtonItem();
            this.barAttCountReport = new DevExpress.XtraBars.BarButtonItem();
            this.barQtyReport = new DevExpress.XtraBars.BarButtonItem();
            this.barHistory = new DevExpress.XtraBars.BarButtonItem();
            this.barPartname = new DevExpress.XtraBars.BarButtonItem();
            this.barProductList = new DevExpress.XtraBars.BarButtonItem();
            this.pageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageDuLieuGoc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageChamCong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pgr_QuetThe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgr_PhanCa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgr_DiemDanh = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageBaoCom = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageSanXuat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager2
            // 
            splashScreenManager2.ClosingDelay = 500;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barEmployee,
            this.barOrganization,
            this.barMealOrder,
            this.barNgay,
            this.barGio,
            this.barStaticItem1,
            this.barVersion,
            this.bar_user,
            this.barButtonItem2,
            this.barSweepCard,
            this.barAttCount,
            this.barShiftArranged,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barOvertimeRegis,
            this.barButtonItem10,
            this.barInputQty,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barButtonItem15,
            this.barQtyManagement,
            this.barButtonItem17,
            this.barShiftSum,
            this.btnThongKeDiemDanh,
            this.barDashboard,
            this.barNguoiDung,
            this.barVaiTro,
            this.barWindow,
            this.barProcess,
            this.barTypename,
            this.barShift,
            this.barAbsent,
            this.barAttCountReport,
            this.barQtyReport,
            this.barHistory,
            this.barPartname,
            this.barProductList});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 44;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.bar_user);
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barNgay);
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barGio);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageHeThong,
            this.pageDuLieuGoc,
            this.pageChamCong,
            this.pageBaoCom,
            this.pageSanXuat});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(971, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barEmployee
            // 
            this.barEmployee.Caption = "Nhân viên";
            this.barEmployee.Id = 1;
            this.barEmployee.ImageIndex = 0;
            this.barEmployee.LargeGlyph = global::HRM.Properties.Resources.quanly__1_;
            this.barEmployee.Name = "barEmployee";
            this.barEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // barOrganization
            // 
            this.barOrganization.Caption = "Tổ chức";
            this.barOrganization.Glyph = ((System.Drawing.Image)(resources.GetObject("barOrganization.Glyph")));
            this.barOrganization.Id = 2;
            this.barOrganization.ImageIndex = 1;
            this.barOrganization.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barOrganization.LargeGlyph")));
            this.barOrganization.Name = "barOrganization";
            this.barOrganization.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barOrganization.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnToChuc_ItemClick);
            // 
            // barMealOrder
            // 
            this.barMealOrder.Caption = "Bữa chính";
            this.barMealOrder.Id = 6;
            this.barMealOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barMealOrder.LargeGlyph")));
            this.barMealOrder.Name = "barMealOrder";
            this.barMealOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barNgay
            // 
            this.barNgay.Glyph = ((System.Drawing.Image)(resources.GetObject("barNgay.Glyph")));
            this.barNgay.Id = 7;
            this.barNgay.Name = "barNgay";
            this.barNgay.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barGio
            // 
            this.barGio.Glyph = ((System.Drawing.Image)(resources.GetObject("barGio.Glyph")));
            this.barGio.Id = 8;
            this.barGio.Name = "barGio";
            this.barGio.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Copyright 2018 micheal.achilles@yahoo.com. All rights reserved.";
            this.barStaticItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.Glyph")));
            this.barStaticItem1.Id = 9;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barVersion
            // 
            this.barVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barVersion.Caption = "Version 1.0.1";
            this.barVersion.Id = 10;
            this.barVersion.Name = "barVersion";
            this.barVersion.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bar_user
            // 
            this.bar_user.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_user.Glyph")));
            this.bar_user.Id = 11;
            this.bar_user.Name = "bar_user";
            this.bar_user.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Báo cáo";
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barSweepCard
            // 
            this.barSweepCard.Caption = "Quẹt thẻ";
            this.barSweepCard.Id = 13;
            this.barSweepCard.LargeGlyph = global::HRM.Properties.Resources.time;
            this.barSweepCard.Name = "barSweepCard";
            this.barSweepCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barAttCount
            // 
            this.barAttCount.Caption = "Điểm danh";
            this.barAttCount.Id = 14;
            this.barAttCount.LargeGlyph = global::HRM.Properties.Resources.btnGio;
            this.barAttCount.Name = "barAttCount";
            this.barAttCount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barShiftArranged
            // 
            this.barShiftArranged.Caption = "Sắp xếp";
            this.barShiftArranged.Id = 15;
            this.barShiftArranged.LargeGlyph = global::HRM.Properties.Resources.icon_mediroster_templates;
            this.barShiftArranged.Name = "barShiftArranged";
            this.barShiftArranged.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Kiểm tra";
            this.barButtonItem6.Id = 16;
            this.barButtonItem6.LargeGlyph = global::HRM.Properties.Resources.verify;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Đăng ký";
            this.barButtonItem7.Id = 18;
            this.barButtonItem7.LargeGlyph = global::HRM.Properties.Resources.overtime;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "barButtonItem8";
            this.barButtonItem8.Id = 19;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barOvertimeRegis
            // 
            this.barOvertimeRegis.Caption = "Đăng ký tăng ca";
            this.barOvertimeRegis.Id = 20;
            this.barOvertimeRegis.LargeGlyph = global::HRM.Properties.Resources.overtime;
            this.barOvertimeRegis.Name = "barOvertimeRegis";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Bữa phụ";
            this.barButtonItem10.Id = 21;
            this.barButtonItem10.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.LargeGlyph")));
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barInputQty
            // 
            this.barInputQty.Caption = "Nhập sản lượng";
            this.barInputQty.Glyph = ((System.Drawing.Image)(resources.GetObject("barInputQty.Glyph")));
            this.barInputQty.Id = 22;
            this.barInputQty.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barInputQty.LargeGlyph")));
            this.barInputQty.Name = "barInputQty";
            this.barInputQty.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Type name";
            this.barButtonItem12.Id = 23;
            this.barButtonItem12.LargeGlyph = global::HRM.Properties.Resources.partname;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Part name";
            this.barButtonItem13.Id = 24;
            this.barButtonItem13.LargeGlyph = global::HRM.Properties.Resources.typename;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Process";
            this.barButtonItem14.Id = 25;
            this.barButtonItem14.LargeGlyph = global::HRM.Properties.Resources.process;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Defect";
            this.barButtonItem15.Id = 26;
            this.barButtonItem15.LargeGlyph = global::HRM.Properties.Resources.defect;
            this.barButtonItem15.Name = "barButtonItem15";
            // 
            // barQtyManagement
            // 
            this.barQtyManagement.Caption = "Quản lý sản lượng, hiệu suất";
            this.barQtyManagement.Glyph = ((System.Drawing.Image)(resources.GetObject("barQtyManagement.Glyph")));
            this.barQtyManagement.Id = 27;
            this.barQtyManagement.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barQtyManagement.LargeGlyph")));
            this.barQtyManagement.Name = "barQtyManagement";
            this.barQtyManagement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem16_ItemClick);
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Caption = "Kiểm tra";
            this.barButtonItem17.Id = 28;
            this.barButtonItem17.LargeGlyph = global::HRM.Properties.Resources.verify;
            this.barButtonItem17.Name = "barButtonItem17";
            // 
            // barShiftSum
            // 
            this.barShiftSum.Caption = "Thống kê";
            this.barShiftSum.Glyph = ((System.Drawing.Image)(resources.GetObject("barShiftSum.Glyph")));
            this.barShiftSum.Id = 29;
            this.barShiftSum.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barShiftSum.LargeGlyph")));
            this.barShiftSum.Name = "barShiftSum";
            this.barShiftSum.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem18_ItemClick);
            // 
            // btnThongKeDiemDanh
            // 
            this.btnThongKeDiemDanh.Caption = "Thống kê";
            this.btnThongKeDiemDanh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThongKeDiemDanh.Glyph")));
            this.btnThongKeDiemDanh.Id = 30;
            this.btnThongKeDiemDanh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThongKeDiemDanh.LargeGlyph")));
            this.btnThongKeDiemDanh.Name = "btnThongKeDiemDanh";
            this.btnThongKeDiemDanh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barDashboard
            // 
            this.barDashboard.Caption = "Thống kê sản lượng, hiệu suất";
            this.barDashboard.Glyph = ((System.Drawing.Image)(resources.GetObject("barDashboard.Glyph")));
            this.barDashboard.Id = 31;
            this.barDashboard.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barDashboard.LargeGlyph")));
            this.barDashboard.Name = "barDashboard";
            // 
            // barNguoiDung
            // 
            this.barNguoiDung.Caption = "Người dùng";
            this.barNguoiDung.Glyph = ((System.Drawing.Image)(resources.GetObject("barNguoiDung.Glyph")));
            this.barNguoiDung.Id = 32;
            this.barNguoiDung.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barNguoiDung.LargeGlyph")));
            this.barNguoiDung.Name = "barNguoiDung";
            this.barNguoiDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNguoiDung_ItemClick);
            // 
            // barVaiTro
            // 
            this.barVaiTro.Caption = "Vai trò";
            this.barVaiTro.Glyph = ((System.Drawing.Image)(resources.GetObject("barVaiTro.Glyph")));
            this.barVaiTro.Id = 33;
            this.barVaiTro.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barVaiTro.LargeGlyph")));
            this.barVaiTro.Name = "barVaiTro";
            this.barVaiTro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barVaiTro_ItemClick);
            // 
            // barWindow
            // 
            this.barWindow.Caption = "Cửa sổ";
            this.barWindow.Glyph = ((System.Drawing.Image)(resources.GetObject("barWindow.Glyph")));
            this.barWindow.Id = 34;
            this.barWindow.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barWindow.LargeGlyph")));
            this.barWindow.Name = "barWindow";
            this.barWindow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barWindow_ItemClick);
            // 
            // barProcess
            // 
            this.barProcess.Caption = "Luồng truy cập";
            this.barProcess.Glyph = ((System.Drawing.Image)(resources.GetObject("barProcess.Glyph")));
            this.barProcess.Id = 35;
            this.barProcess.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barProcess.LargeGlyph")));
            this.barProcess.Name = "barProcess";
            this.barProcess.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barProcess_ItemClick);
            // 
            // barTypename
            // 
            this.barTypename.Caption = "Type name";
            this.barTypename.Glyph = ((System.Drawing.Image)(resources.GetObject("barTypename.Glyph")));
            this.barTypename.Id = 36;
            this.barTypename.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barTypename.LargeGlyph")));
            this.barTypename.Name = "barTypename";
            // 
            // barShift
            // 
            this.barShift.Caption = "Thiết lập ca";
            this.barShift.Glyph = ((System.Drawing.Image)(resources.GetObject("barShift.Glyph")));
            this.barShift.Id = 37;
            this.barShift.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barShift.LargeGlyph")));
            this.barShift.Name = "barShift";
            // 
            // barAbsent
            // 
            this.barAbsent.Caption = "Thiết lập ngày nghĩ";
            this.barAbsent.Glyph = ((System.Drawing.Image)(resources.GetObject("barAbsent.Glyph")));
            this.barAbsent.Id = 38;
            this.barAbsent.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barAbsent.LargeGlyph")));
            this.barAbsent.Name = "barAbsent";
            // 
            // barAttCountReport
            // 
            this.barAttCountReport.Caption = "Báo cáo";
            this.barAttCountReport.Glyph = ((System.Drawing.Image)(resources.GetObject("barAttCountReport.Glyph")));
            this.barAttCountReport.Id = 39;
            this.barAttCountReport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barAttCountReport.LargeGlyph")));
            this.barAttCountReport.Name = "barAttCountReport";
            this.barAttCountReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barAttCountReport_ItemClick);
            // 
            // barQtyReport
            // 
            this.barQtyReport.Caption = "Báo cáo sản lượng";
            this.barQtyReport.Glyph = ((System.Drawing.Image)(resources.GetObject("barQtyReport.Glyph")));
            this.barQtyReport.Id = 40;
            this.barQtyReport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barQtyReport.LargeGlyph")));
            this.barQtyReport.Name = "barQtyReport";
            this.barQtyReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQtyReport_ItemClick);
            // 
            // barHistory
            // 
            this.barHistory.Caption = "Quá trình làm việc";
            this.barHistory.Glyph = ((System.Drawing.Image)(resources.GetObject("barHistory.Glyph")));
            this.barHistory.Id = 41;
            this.barHistory.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barHistory.LargeGlyph")));
            this.barHistory.Name = "barHistory";
            this.barHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barHistory_ItemClick);
            // 
            // barPartname
            // 
            this.barPartname.Caption = "Part name";
            this.barPartname.Glyph = ((System.Drawing.Image)(resources.GetObject("barPartname.Glyph")));
            this.barPartname.Id = 42;
            this.barPartname.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barPartname.LargeGlyph")));
            this.barPartname.Name = "barPartname";
            // 
            // barProductList
            // 
            this.barProductList.Caption = "Vật tư";
            this.barProductList.Glyph = ((System.Drawing.Image)(resources.GetObject("barProductList.Glyph")));
            this.barProductList.Id = 43;
            this.barProductList.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barProductList.LargeGlyph")));
            this.barProductList.Name = "barProductList";
            this.barProductList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barProductList_ItemClick);
            // 
            // pageHeThong
            // 
            this.pageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.pageHeThong.Name = "pageHeThong";
            this.pageHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barOrganization);
            this.ribbonPageGroup2.ItemLinks.Add(this.barNguoiDung);
            this.ribbonPageGroup2.ItemLinks.Add(this.barVaiTro);
            this.ribbonPageGroup2.ItemLinks.Add(this.barWindow);
            this.ribbonPageGroup2.ItemLinks.Add(this.barProcess);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Bảo mật";
            // 
            // pageDuLieuGoc
            // 
            this.pageDuLieuGoc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.pageDuLieuGoc.Name = "pageDuLieuGoc";
            this.pageDuLieuGoc.Text = "Dữ liệu gốc";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barEmployee);
            this.ribbonPageGroup1.ItemLinks.Add(this.barShift);
            this.ribbonPageGroup1.ItemLinks.Add(this.barAbsent);
            this.ribbonPageGroup1.ItemLinks.Add(this.barHistory);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Nhân sự";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barTypename);
            this.ribbonPageGroup5.ItemLinks.Add(this.barPartname);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Quản lý hàng hóa";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barProductList);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Quản lý kho";
            // 
            // pageChamCong
            // 
            this.pageChamCong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pgr_QuetThe,
            this.pgr_PhanCa,
            this.pgr_DiemDanh});
            this.pageChamCong.Name = "pageChamCong";
            this.pageChamCong.Text = "Chấm công";
            // 
            // pgr_QuetThe
            // 
            this.pgr_QuetThe.ItemLinks.Add(this.barSweepCard);
            this.pgr_QuetThe.Name = "pgr_QuetThe";
            this.pgr_QuetThe.Text = "Dữ liệu quẹt thẻ";
            // 
            // pgr_PhanCa
            // 
            this.pgr_PhanCa.ItemLinks.Add(this.barShiftArranged);
            this.pgr_PhanCa.ItemLinks.Add(this.barShiftSum);
            this.pgr_PhanCa.Name = "pgr_PhanCa";
            this.pgr_PhanCa.Text = "Quản lý phân ca";
            // 
            // pgr_DiemDanh
            // 
            this.pgr_DiemDanh.ItemLinks.Add(this.barAttCount);
            this.pgr_DiemDanh.ItemLinks.Add(this.barAttCountReport);
            this.pgr_DiemDanh.Name = "pgr_DiemDanh";
            this.pgr_DiemDanh.Text = "Quản lý điểm danh";
            // 
            // pageBaoCom
            // 
            this.pageBaoCom.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.pageBaoCom.Name = "pageBaoCom";
            this.pageBaoCom.Text = "Báo cơm";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barMealOrder);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Báo suất ăn";
            // 
            // pageSanXuat
            // 
            this.pageSanXuat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.pageSanXuat.Name = "pageSanXuat";
            this.pageSanXuat.Text = "Sản xuất";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barInputQty);
            this.ribbonPageGroup4.ItemLinks.Add(this.barQtyManagement);
            this.ribbonPageGroup4.ItemLinks.Add(this.barQtyReport);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Năng xuất, hiệu quả";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.barVersion);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 687);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(971, 31);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alertControl1
            // 
            this.alertControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.alertControl1.AppearanceCaption.Options.UseForeColor = true;
            this.alertControl1.AppearanceText.ForeColor = System.Drawing.Color.Blue;
            this.alertControl1.AppearanceText.Options.UseForeColor = true;
            this.alertControl1.AutoFormDelay = 60000;
            this.alertControl1.FormMaxCount = 1;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 718);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "HRMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageDuLieuGoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barEmployee;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageBaoCom;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barOrganization;
        private DevExpress.XtraBars.BarButtonItem barMealOrder;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarStaticItem barNgay;
        private DevExpress.XtraBars.BarStaticItem barGio;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barVersion;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.BarStaticItem bar_user;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barSweepCard;
        private DevExpress.XtraBars.BarButtonItem barAttCount;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageChamCong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgr_QuetThe;
        private DevExpress.XtraBars.BarButtonItem barShiftArranged;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgr_DiemDanh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barOvertimeRegis;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barInputQty;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageSanXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem barQtyManagement;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgr_PhanCa;
        private DevExpress.XtraBars.BarButtonItem barShiftSum;
        private DevExpress.XtraBars.BarButtonItem btnThongKeDiemDanh;
        private DevExpress.XtraBars.BarButtonItem barDashboard;
        private DevExpress.XtraBars.BarButtonItem barNguoiDung;
        private DevExpress.XtraBars.BarButtonItem barVaiTro;
        private DevExpress.XtraBars.BarButtonItem barWindow;
        private DevExpress.XtraBars.BarButtonItem barProcess;
        private DevExpress.XtraBars.BarButtonItem barTypename;
        private DevExpress.XtraBars.BarButtonItem barShift;
        private DevExpress.XtraBars.BarButtonItem barAbsent;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraBars.BarButtonItem barAttCountReport;
        private DevExpress.XtraBars.BarButtonItem barQtyReport;
        private DevExpress.XtraBars.BarButtonItem barHistory;
        private DevExpress.XtraBars.BarButtonItem barPartname;
        private DevExpress.XtraBars.BarButtonItem barProductList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}

