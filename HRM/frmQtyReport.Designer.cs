namespace HRM
{
    partial class frmQtyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQtyReport));
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelTong = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panelNgay = new System.Windows.Forms.TableLayoutPanel();
            this.panelNgayControl = new System.Windows.Forms.TableLayoutPanel();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.lkBoPhanNgay = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchNgay = new DevExpress.XtraEditors.SimpleButton();
            this.exportNgay = new DevExpress.XtraEditors.SimpleButton();
            this.lblQtyNgay = new System.Windows.Forms.Label();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelContentTotal = new System.Windows.Forms.TableLayoutPanel();
            this.panelContentControl = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lkBoPhanTotal = new DevExpress.XtraEditors.LookUpEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.searchTotal = new DevExpress.XtraEditors.SimpleButton();
            this.exportTotal = new DevExpress.XtraEditors.SimpleButton();
            this.lblQtyMonth = new System.Windows.Forms.Label();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.splashScreenManager5 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::HRM.WaitForm1), true, true);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.panelTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.panelNgay.SuspendLayout();
            this.panelNgayControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkBoPhanNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panelContentTotal.SuspendLayout();
            this.panelContentControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkBoPhanTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // panelTong
            // 
            this.panelTong.ColumnCount = 1;
            this.panelTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTong.Controls.Add(this.groupControl3, 0, 0);
            this.panelTong.Controls.Add(this.groupControl1, 0, 1);
            this.panelTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTong.Location = new System.Drawing.Point(0, 0);
            this.panelTong.Name = "panelTong";
            this.panelTong.RowCount = 2;
            this.panelTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTong.Size = new System.Drawing.Size(789, 476);
            this.panelTong.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.panelNgay);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(783, 232);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Sản lượng theo ngày";
            // 
            // panelNgay
            // 
            this.panelNgay.ColumnCount = 1;
            this.panelNgay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelNgay.Controls.Add(this.panelNgayControl, 0, 0);
            this.panelNgay.Controls.Add(this.chartControl1, 0, 1);
            this.panelNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNgay.Location = new System.Drawing.Point(2, 20);
            this.panelNgay.Name = "panelNgay";
            this.panelNgay.RowCount = 2;
            this.panelNgay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panelNgay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelNgay.Size = new System.Drawing.Size(779, 210);
            this.panelNgay.TabIndex = 2;
            // 
            // panelNgayControl
            // 
            this.panelNgayControl.ColumnCount = 7;
            this.panelNgayControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panelNgayControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelNgayControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panelNgayControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelNgayControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panelNgayControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panelNgayControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelNgayControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelNgayControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelNgayControl.Controls.Add(this.dateEdit, 3, 0);
            this.panelNgayControl.Controls.Add(this.lkBoPhanNgay, 1, 0);
            this.panelNgayControl.Controls.Add(this.label2, 2, 0);
            this.panelNgayControl.Controls.Add(this.label1, 0, 0);
            this.panelNgayControl.Controls.Add(this.searchNgay, 4, 0);
            this.panelNgayControl.Controls.Add(this.exportNgay, 5, 0);
            this.panelNgayControl.Controls.Add(this.lblQtyNgay, 6, 0);
            this.panelNgayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNgayControl.Location = new System.Drawing.Point(3, 3);
            this.panelNgayControl.Name = "panelNgayControl";
            this.panelNgayControl.RowCount = 1;
            this.panelNgayControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelNgayControl.Size = new System.Drawing.Size(773, 29);
            this.panelNgayControl.TabIndex = 1;
            // 
            // dateEdit
            // 
            this.dateEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit.EditValue = new System.DateTime(2018, 10, 18, 14, 4, 28, 834);
            this.dateEdit.Location = new System.Drawing.Point(263, 3);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdit.Size = new System.Drawing.Size(114, 20);
            this.dateEdit.TabIndex = 8;
            // 
            // lkBoPhanNgay
            // 
            this.lkBoPhanNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkBoPhanNgay.Location = new System.Drawing.Point(73, 3);
            this.lkBoPhanNgay.Name = "lkBoPhanNgay";
            this.lkBoPhanNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkBoPhanNgay.Size = new System.Drawing.Size(114, 20);
            this.lkBoPhanNgay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bộ phận:";
            // 
            // searchNgay
            // 
            this.searchNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchNgay.Image = ((System.Drawing.Image)(resources.GetObject("searchNgay.Image")));
            this.searchNgay.Location = new System.Drawing.Point(383, 3);
            this.searchNgay.Name = "searchNgay";
            this.searchNgay.Size = new System.Drawing.Size(74, 23);
            this.searchNgay.TabIndex = 1;
            this.searchNgay.Text = "Search";
            this.searchNgay.Click += new System.EventHandler(this.searchNgay_Click);
            // 
            // exportNgay
            // 
            this.exportNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportNgay.Image = ((System.Drawing.Image)(resources.GetObject("exportNgay.Image")));
            this.exportNgay.Location = new System.Drawing.Point(463, 3);
            this.exportNgay.Name = "exportNgay";
            this.exportNgay.Size = new System.Drawing.Size(74, 23);
            this.exportNgay.TabIndex = 0;
            this.exportNgay.Text = "Export";
            this.exportNgay.Click += new System.EventHandler(this.exportNgay_Click);
            // 
            // lblQtyNgay
            // 
            this.lblQtyNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtyNgay.AutoSize = true;
            this.lblQtyNgay.Location = new System.Drawing.Point(735, 16);
            this.lblQtyNgay.Name = "lblQtyNgay";
            this.lblQtyNgay.Size = new System.Drawing.Size(35, 13);
            this.lblQtyNgay.TabIndex = 9;
            this.lblQtyNgay.Text = "label3";
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(3, 38);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(773, 169);
            this.chartControl1.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelContentTotal);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 241);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(783, 232);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Sản lượng theo khoản thời gian";
            // 
            // panelContentTotal
            // 
            this.panelContentTotal.ColumnCount = 1;
            this.panelContentTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContentTotal.Controls.Add(this.panelContentControl, 0, 0);
            this.panelContentTotal.Controls.Add(this.chartControl2, 0, 1);
            this.panelContentTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentTotal.Location = new System.Drawing.Point(2, 20);
            this.panelContentTotal.Name = "panelContentTotal";
            this.panelContentTotal.RowCount = 2;
            this.panelContentTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panelContentTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContentTotal.Size = new System.Drawing.Size(779, 210);
            this.panelContentTotal.TabIndex = 0;
            // 
            // panelContentControl
            // 
            this.panelContentControl.ColumnCount = 9;
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContentControl.Controls.Add(this.label3, 0, 0);
            this.panelContentControl.Controls.Add(this.label4, 2, 0);
            this.panelContentControl.Controls.Add(this.label5, 4, 0);
            this.panelContentControl.Controls.Add(this.lkBoPhanTotal, 1, 0);
            this.panelContentControl.Controls.Add(this.dateEdit1, 3, 0);
            this.panelContentControl.Controls.Add(this.dateEdit2, 5, 0);
            this.panelContentControl.Controls.Add(this.searchTotal, 6, 0);
            this.panelContentControl.Controls.Add(this.exportTotal, 7, 0);
            this.panelContentControl.Controls.Add(this.lblQtyMonth, 8, 0);
            this.panelContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentControl.Location = new System.Drawing.Point(3, 3);
            this.panelContentControl.Name = "panelContentControl";
            this.panelContentControl.RowCount = 1;
            this.panelContentControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelContentControl.Size = new System.Drawing.Size(773, 29);
            this.panelContentControl.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bộ phận:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ ngày:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đến ngày:";
            // 
            // lkBoPhanTotal
            // 
            this.lkBoPhanTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkBoPhanTotal.Location = new System.Drawing.Point(73, 3);
            this.lkBoPhanTotal.Name = "lkBoPhanTotal";
            this.lkBoPhanTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkBoPhanTotal.Size = new System.Drawing.Size(114, 20);
            this.lkBoPhanTotal.TabIndex = 6;
            // 
            // dateEdit1
            // 
            this.dateEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(263, 3);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(114, 20);
            this.dateEdit1.TabIndex = 7;
            // 
            // dateEdit2
            // 
            this.dateEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(453, 3);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(114, 20);
            this.dateEdit2.TabIndex = 8;
            // 
            // searchTotal
            // 
            this.searchTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTotal.Image = ((System.Drawing.Image)(resources.GetObject("searchTotal.Image")));
            this.searchTotal.Location = new System.Drawing.Point(573, 3);
            this.searchTotal.Name = "searchTotal";
            this.searchTotal.Size = new System.Drawing.Size(74, 23);
            this.searchTotal.TabIndex = 9;
            this.searchTotal.Text = "Search";
            this.searchTotal.Click += new System.EventHandler(this.searchTotal_Click);
            // 
            // exportTotal
            // 
            this.exportTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportTotal.Image = ((System.Drawing.Image)(resources.GetObject("exportTotal.Image")));
            this.exportTotal.Location = new System.Drawing.Point(653, 3);
            this.exportTotal.Name = "exportTotal";
            this.exportTotal.Size = new System.Drawing.Size(74, 23);
            this.exportTotal.TabIndex = 10;
            this.exportTotal.Text = "Export";
            this.exportTotal.Click += new System.EventHandler(this.exportTotal_Click);
            // 
            // lblQtyMonth
            // 
            this.lblQtyMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtyMonth.AutoSize = true;
            this.lblQtyMonth.Location = new System.Drawing.Point(735, 16);
            this.lblQtyMonth.Name = "lblQtyMonth";
            this.lblQtyMonth.Size = new System.Drawing.Size(35, 13);
            this.lblQtyMonth.TabIndex = 11;
            this.lblQtyMonth.Text = "label6";
            // 
            // chartControl2
            // 
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(3, 38);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(773, 169);
            this.chartControl2.TabIndex = 1;
            // 
            // alertControl1
            // 
            this.alertControl1.AutoHeight = true;
            this.alertControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.CornflowerBlue;
            this.alertControl1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.alertControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // splashScreenManager5
            // 
            this.splashScreenManager5.ClosingDelay = 500;
            // 
            // frmQtyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 476);
            this.Controls.Add(this.panelTong);
            this.MaximizeBox = false;
            this.Name = "frmQtyReport";
            this.Text = "Báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQtyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.panelTong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.panelNgay.ResumeLayout(false);
            this.panelNgayControl.ResumeLayout(false);
            this.panelNgayControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkBoPhanNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panelContentTotal.ResumeLayout(false);
            this.panelContentControl.ResumeLayout(false);
            this.panelContentControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkBoPhanTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelTong;
        private DevExpress.XtraEditors.SimpleButton exportNgay;
        private DevExpress.XtraEditors.SimpleButton searchNgay;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.TableLayoutPanel panelNgayControl;
        private DevExpress.XtraEditors.LookUpEdit lkBoPhanNgay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager3;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel panelNgay;
        private System.Windows.Forms.Label lblQtyNgay;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel panelContentTotal;
        private System.Windows.Forms.TableLayoutPanel panelContentControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LookUpEdit lkBoPhanTotal;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.SimpleButton searchTotal;
        private DevExpress.XtraEditors.SimpleButton exportTotal;
        private System.Windows.Forms.Label lblQtyMonth;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}