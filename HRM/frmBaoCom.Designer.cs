namespace HRM
{
    partial class frmBaoCom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCom));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridBaoCom = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dept_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dept_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shift_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shift_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.att_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.A12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.A01 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.A07 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.A00 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AMn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AKh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.noticed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.create_time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.createdby = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lkBoPhan = new DevExpress.XtraEditors.LookUpEdit();
            this.lkShift = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.search = new DevExpress.XtraEditors.SimpleButton();
            this.export = new DevExpress.XtraEditors.SimpleButton();
            this.btnMealSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager3 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::HRM.WaitForm1), true, true);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBaoCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkBoPhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkShift.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridBaoCom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 476);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridBaoCom
            // 
            this.gridBaoCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBaoCom.EmbeddedNavigator.Enabled = false;
            this.gridBaoCom.Location = new System.Drawing.Point(3, 188);
            this.gridBaoCom.MainView = this.gridView1;
            this.gridBaoCom.Name = "gridBaoCom";
            this.gridBaoCom.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemGridLookUpEdit1});
            this.gridBaoCom.Size = new System.Drawing.Size(783, 285);
            this.gridBaoCom.TabIndex = 1;
            this.gridBaoCom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dept_id,
            this.dept_name,
            this.shift_id,
            this.shift_code,
            this.att_date,
            this.A12,
            this.A01,
            this.A07,
            this.A00,
            this.AMn,
            this.ACh,
            this.AKh,
            this.KhA,
            this.noticed,
            this.create_time,
            this.createdby});
            this.gridView1.GridControl = this.gridBaoCom;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // dept_id
            // 
            this.dept_id.Caption = "dept_id";
            this.dept_id.FieldName = "dept_id";
            this.dept_id.Name = "dept_id";
            // 
            // dept_name
            // 
            this.dept_name.Caption = "Bộ Phận";
            this.dept_name.FieldName = "dept_name";
            this.dept_name.Name = "dept_name";
            this.dept_name.OptionsColumn.AllowEdit = false;
            this.dept_name.Visible = true;
            this.dept_name.VisibleIndex = 0;
            // 
            // shift_id
            // 
            this.shift_id.Caption = "shift_id";
            this.shift_id.FieldName = "shift_id";
            this.shift_id.Name = "shift_id";
            // 
            // shift_code
            // 
            this.shift_code.Caption = "Ca Làm Việc";
            this.shift_code.FieldName = "shift_code";
            this.shift_code.Name = "shift_code";
            this.shift_code.OptionsColumn.AllowEdit = false;
            this.shift_code.Visible = true;
            this.shift_code.VisibleIndex = 1;
            // 
            // att_date
            // 
            this.att_date.Caption = "Ngày";
            this.att_date.FieldName = "att_date";
            this.att_date.Name = "att_date";
            this.att_date.OptionsColumn.AllowEdit = false;
            this.att_date.Visible = true;
            this.att_date.VisibleIndex = 2;
            // 
            // A12
            // 
            this.A12.Caption = "SL. Quẹt thẻ";
            this.A12.FieldName = "A12";
            this.A12.Name = "A12";
            this.A12.OptionsColumn.AllowEdit = false;
            // 
            // A01
            // 
            this.A01.Caption = "SL. Quên quẹt thẻ";
            this.A01.FieldName = "A01";
            this.A01.Name = "A01";
            this.A01.OptionsColumn.AllowEdit = false;
            // 
            // A07
            // 
            this.A07.Caption = "SL. Đi muộn";
            this.A07.FieldName = "A07";
            this.A07.Name = "A07";
            this.A07.OptionsColumn.AllowEdit = false;
            // 
            // A00
            // 
            this.A00.Caption = "Tổng số nhân viên có mặt";
            this.A00.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.A00.FieldName = "A00";
            this.A00.Name = "A00";
            this.A00.OptionsColumn.AllowEdit = false;
            this.A00.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "A00", "SUM={0:0.##}", ((short)(0)))});
            this.A00.Visible = true;
            this.A00.VisibleIndex = 3;
            // 
            // AMn
            // 
            this.AMn.Caption = "Sl. nv ăn mặn";
            this.AMn.FieldName = "AMn";
            this.AMn.Name = "AMn";
            this.AMn.OptionsColumn.AllowEdit = false;
            this.AMn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AMn", "SUM={0:0.##}", ((short)(0)))});
            this.AMn.Visible = true;
            this.AMn.VisibleIndex = 4;
            // 
            // ACh
            // 
            this.ACh.AppearanceHeader.BackColor = System.Drawing.Color.SandyBrown;
            this.ACh.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.ACh.AppearanceHeader.Options.UseBackColor = true;
            this.ACh.Caption = "SL. nv ăn chay";
            this.ACh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ACh.FieldName = "ACh";
            this.ACh.Name = "ACh";
            this.ACh.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ACh", "SUM={0:0.##}", ((short)(0)))});
            this.ACh.Visible = true;
            this.ACh.VisibleIndex = 5;
            // 
            // AKh
            // 
            this.AKh.AppearanceHeader.BackColor = System.Drawing.Color.SandyBrown;
            this.AKh.AppearanceHeader.Options.UseBackColor = true;
            this.AKh.Caption = "SL. phần ăn cho khách";
            this.AKh.FieldName = "AKh";
            this.AKh.Name = "AKh";
            this.AKh.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AKh", "SUM={0:0.##}", ((short)(0)))});
            this.AKh.Visible = true;
            this.AKh.VisibleIndex = 7;
            // 
            // KhA
            // 
            this.KhA.AppearanceHeader.BackColor = System.Drawing.Color.SandyBrown;
            this.KhA.AppearanceHeader.Options.UseBackColor = true;
            this.KhA.Caption = "SL. nv không ăn";
            this.KhA.FieldName = "KhA";
            this.KhA.Name = "KhA";
            this.KhA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KhA", "SUM={0:0.##}", ((short)(0)))});
            this.KhA.Visible = true;
            this.KhA.VisibleIndex = 6;
            // 
            // noticed
            // 
            this.noticed.AppearanceHeader.BackColor = System.Drawing.Color.SandyBrown;
            this.noticed.AppearanceHeader.Options.UseBackColor = true;
            this.noticed.Caption = "Ghi Chú";
            this.noticed.FieldName = "noticed";
            this.noticed.Name = "noticed";
            this.noticed.Visible = true;
            this.noticed.VisibleIndex = 10;
            // 
            // create_time
            // 
            this.create_time.Caption = "Created";
            this.create_time.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.create_time.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.create_time.FieldName = "create_time";
            this.create_time.Name = "create_time";
            this.create_time.OptionsColumn.AllowEdit = false;
            this.create_time.Visible = true;
            this.create_time.VisibleIndex = 9;
            // 
            // createdby
            // 
            this.createdby.Caption = "Createdby";
            this.createdby.FieldName = "createdby";
            this.createdby.Name = "createdby";
            this.createdby.Visible = true;
            this.createdby.VisibleIndex = 8;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.tableLayoutPanel3);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(783, 144);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Tìm kiếm thông tin";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(779, 122);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(253, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 116);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cơ sở";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lkBoPhan, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lkShift, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(208, 96);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // lkBoPhan
            // 
            this.lkBoPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkBoPhan.Location = new System.Drawing.Point(83, 3);
            this.lkBoPhan.Name = "lkBoPhan";
            this.lkBoPhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkBoPhan.Size = new System.Drawing.Size(122, 20);
            this.lkBoPhan.TabIndex = 3;
            // 
            // lkShift
            // 
            this.lkShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkShift.Location = new System.Drawing.Point(83, 51);
            this.lkShift.Name = "lkShift";
            this.lkShift.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkShift.Size = new System.Drawing.Size(122, 20);
            this.lkShift.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bộ phận:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ca làm việc:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioGroup);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại công việc";
            // 
            // radioGroup
            // 
            this.radioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioGroup.Location = new System.Drawing.Point(3, 17);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.radioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Thực hiện báo cơm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Thống kê số lượng đã báo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Thống kê số lượng hôm nay chưa báo cơm")});
            this.radioGroup.Size = new System.Drawing.Size(238, 96);
            this.radioGroup.TabIndex = 0;
            this.radioGroup.SelectedIndexChanged += new System.EventHandler(this.radioGroup_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(473, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 116);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khoản thời gian";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.dateEdit, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dateEdit1, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(208, 96);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // dateEdit
            // 
            this.dateEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit.EditValue = new System.DateTime(2018, 10, 18, 14, 4, 28, 834);
            this.dateEdit.Location = new System.Drawing.Point(83, 3);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdit.Size = new System.Drawing.Size(122, 20);
            this.dateEdit.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ ngày:";
            // 
            // dateEdit1
            // 
            this.dateEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(83, 51);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(122, 20);
            this.dateEdit1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đến ngày:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.search, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.export, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMealSubmit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(783, 29);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(3, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(74, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // export
            // 
            this.export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.export.Image = ((System.Drawing.Image)(resources.GetObject("export.Image")));
            this.export.Location = new System.Drawing.Point(706, 3);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(74, 23);
            this.export.TabIndex = 0;
            this.export.Text = "Export";
            this.export.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnMealSubmit
            // 
            this.btnMealSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMealSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnMealSubmit.Image")));
            this.btnMealSubmit.Location = new System.Drawing.Point(83, 3);
            this.btnMealSubmit.Name = "btnMealSubmit";
            this.btnMealSubmit.Size = new System.Drawing.Size(74, 23);
            this.btnMealSubmit.TabIndex = 2;
            this.btnMealSubmit.Text = "Submit";
            this.btnMealSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // splashScreenManager3
            // 
            this.splashScreenManager3.ClosingDelay = 500;
            // 
            // alertControl1
            // 
            this.alertControl1.AppearanceCaption.BackColor = System.Drawing.Color.Blue;
            this.alertControl1.AppearanceCaption.Options.UseBackColor = true;
            this.alertControl1.AutoFormDelay = 20000;
            this.alertControl1.AutoHeight = true;
            this.alertControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.CornflowerBlue;
            this.alertControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.alertControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.alertControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.alertControl1.BeforeFormShow += new DevExpress.XtraBars.Alerter.AlertFormEventHandler(this.alertControl1_BeforeFormShow);
            // 
            // frmBaoCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmBaoCom";
            this.Text = "Báo cơm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCom_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBaoCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkBoPhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkShift.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton export;
        private DevExpress.XtraEditors.SimpleButton search;
        private DevExpress.XtraGrid.GridControl gridBaoCom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnMealSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.RadioGroup radioGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.LookUpEdit lkBoPhan;
        private DevExpress.XtraEditors.LookUpEdit lkShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn dept_id;
        private DevExpress.XtraGrid.Columns.GridColumn dept_name;
        private DevExpress.XtraGrid.Columns.GridColumn shift_id;
        private DevExpress.XtraGrid.Columns.GridColumn shift_code;
        private DevExpress.XtraGrid.Columns.GridColumn att_date;
        private DevExpress.XtraGrid.Columns.GridColumn A12;
        private DevExpress.XtraGrid.Columns.GridColumn A01;
        private DevExpress.XtraGrid.Columns.GridColumn A07;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager3;
        private DevExpress.XtraGrid.Columns.GridColumn A00;
        private DevExpress.XtraGrid.Columns.GridColumn noticed;
        private DevExpress.XtraGrid.Columns.GridColumn create_time;
        private DevExpress.XtraGrid.Columns.GridColumn AMn;
        private DevExpress.XtraGrid.Columns.GridColumn ACh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraGrid.Columns.GridColumn AKh;
        private DevExpress.XtraGrid.Columns.GridColumn KhA;
        private DevExpress.XtraGrid.Columns.GridColumn createdby;
    }
}