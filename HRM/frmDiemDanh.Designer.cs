namespace HRM
{
    partial class frmDiemDanh
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemDanh));
            this.att_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.att_reason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridDiemDanh = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.attcount_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.staff_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.staff_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dept_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dept_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.staff_status_description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shift_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shift_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.createdby = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created = new DevExpress.XtraGrid.Columns.GridColumn();
            this.updatedby = new DevExpress.XtraGrid.Columns.GridColumn();
            this.updated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
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
            this.Search = new DevExpress.XtraEditors.SimpleButton();
            this.Export = new DevExpress.XtraEditors.SimpleButton();
            this.btnAttCountSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCountUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCountDelete = new DevExpress.XtraEditors.SimpleButton();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl();
            this.splashScreenManager5 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::HRM.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiemDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
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
            // att_date
            // 
            this.att_date.Caption = "Điểm danh";
            this.att_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.att_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.att_date.FieldName = "att_date";
            this.att_date.Name = "att_date";
            this.att_date.OptionsColumn.AllowEdit = false;
            this.att_date.Visible = true;
            this.att_date.VisibleIndex = 5;
            // 
            // att_reason
            // 
            this.att_reason.Caption = "Ghi chú";
            this.att_reason.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.att_reason.FieldName = "att_reason";
            this.att_reason.Name = "att_reason";
            this.att_reason.Visible = true;
            this.att_reason.VisibleIndex = 6;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridDiemDanh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 476);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridDiemDanh
            // 
            this.gridDiemDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDiemDanh.Location = new System.Drawing.Point(3, 188);
            this.gridDiemDanh.MainView = this.gridView1;
            this.gridDiemDanh.Name = "gridDiemDanh";
            this.gridDiemDanh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.gridDiemDanh.Size = new System.Drawing.Size(783, 285);
            this.gridDiemDanh.TabIndex = 1;
            this.gridDiemDanh.UseEmbeddedNavigator = true;
            this.gridDiemDanh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.attcount_id,
            this.staff_id,
            this.staff_name,
            this.dept_id,
            this.dept_name,
            this.staff_status_description,
            this.shift_id,
            this.shift_code,
            this.att_date,
            this.att_reason,
            this.createdby,
            this.created,
            this.updatedby,
            this.updated});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.att_date;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            formatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.White;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue1.Expression = "IsNullOrEmpty([att_date]) = True";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gridDiemDanh;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // attcount_id
            // 
            this.attcount_id.Caption = "attcount_id";
            this.attcount_id.FieldName = "attcount_id";
            this.attcount_id.Name = "attcount_id";
            // 
            // staff_id
            // 
            this.staff_id.Caption = "Mã NV";
            this.staff_id.FieldName = "staff_id";
            this.staff_id.Name = "staff_id";
            this.staff_id.OptionsColumn.AllowEdit = false;
            this.staff_id.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.staff_id.Visible = true;
            this.staff_id.VisibleIndex = 0;
            // 
            // staff_name
            // 
            this.staff_name.Caption = "Họ và tên";
            this.staff_name.FieldName = "staff_name";
            this.staff_name.Name = "staff_name";
            this.staff_name.OptionsColumn.AllowEdit = false;
            this.staff_name.Visible = true;
            this.staff_name.VisibleIndex = 1;
            // 
            // dept_id
            // 
            this.dept_id.Caption = "dept_id";
            this.dept_id.FieldName = "dept_id";
            this.dept_id.Name = "dept_id";
            // 
            // dept_name
            // 
            this.dept_name.Caption = "Bộ phận";
            this.dept_name.FieldName = "dept_name";
            this.dept_name.Name = "dept_name";
            this.dept_name.OptionsColumn.AllowEdit = false;
            this.dept_name.Visible = true;
            this.dept_name.VisibleIndex = 2;
            // 
            // staff_status_description
            // 
            this.staff_status_description.Caption = "Tình trạng";
            this.staff_status_description.FieldName = "staff_status_description";
            this.staff_status_description.Name = "staff_status_description";
            this.staff_status_description.OptionsColumn.AllowEdit = false;
            this.staff_status_description.Visible = true;
            this.staff_status_description.VisibleIndex = 4;
            // 
            // shift_id
            // 
            this.shift_id.Caption = "shift_id";
            this.shift_id.FieldName = "shift_id";
            this.shift_id.Name = "shift_id";
            // 
            // shift_code
            // 
            this.shift_code.Caption = "Ca làm việc";
            this.shift_code.FieldName = "shift_code";
            this.shift_code.Name = "shift_code";
            this.shift_code.OptionsColumn.AllowEdit = false;
            this.shift_code.Visible = true;
            this.shift_code.VisibleIndex = 3;
            // 
            // createdby
            // 
            this.createdby.Caption = "createdby";
            this.createdby.FieldName = "createdby";
            this.createdby.Name = "createdby";
            this.createdby.OptionsColumn.AllowEdit = false;
            this.createdby.Visible = true;
            this.createdby.VisibleIndex = 7;
            // 
            // created
            // 
            this.created.Caption = "created";
            this.created.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.created.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.created.FieldName = "created";
            this.created.Name = "created";
            this.created.OptionsColumn.AllowEdit = false;
            this.created.Visible = true;
            this.created.VisibleIndex = 8;
            // 
            // updatedby
            // 
            this.updatedby.Caption = "updatedby";
            this.updatedby.FieldName = "updatedby";
            this.updatedby.Name = "updatedby";
            this.updatedby.OptionsColumn.AllowEdit = false;
            this.updatedby.Visible = true;
            this.updatedby.VisibleIndex = 9;
            // 
            // updated
            // 
            this.updated.Caption = "updated";
            this.updated.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.updated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.updated.FieldName = "updated";
            this.updated.Name = "updated";
            this.updated.OptionsColumn.AllowEdit = false;
            this.updated.Visible = true;
            this.updated.VisibleIndex = 10;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(779, 120);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(253, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 114);
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(208, 94);
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
            this.lkShift.Location = new System.Drawing.Point(83, 50);
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
            this.label3.Location = new System.Drawing.Point(12, 47);
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
            this.groupBox1.Size = new System.Drawing.Size(244, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại công việc";
            // 
            // radioGroup
            // 
            this.radioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioGroup.Location = new System.Drawing.Point(3, 17);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Thực hiện điểm danh"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Xem danh sách đã điểm danh"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Xem danh sách hôm nay chưa điểm danh")});
            this.radioGroup.Size = new System.Drawing.Size(238, 94);
            this.radioGroup.TabIndex = 0;
            this.radioGroup.SelectedIndexChanged += new System.EventHandler(this.radioGroup_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(473, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 114);
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(208, 94);
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
            this.dateEdit1.Location = new System.Drawing.Point(83, 50);
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
            this.label4.Location = new System.Drawing.Point(19, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đến ngày:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.Search, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Export, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAttCountSubmit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddCountUpdate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddCountDelete, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(783, 29);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Search
            // 
            this.Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.Location = new System.Drawing.Point(3, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(74, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Export
            // 
            this.Export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Export.Image = ((System.Drawing.Image)(resources.GetObject("Export.Image")));
            this.Export.Location = new System.Drawing.Point(706, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(74, 23);
            this.Export.TabIndex = 0;
            this.Export.Text = "Export";
            this.Export.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnAttCountSubmit
            // 
            this.btnAttCountSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAttCountSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnAttCountSubmit.Image")));
            this.btnAttCountSubmit.Location = new System.Drawing.Point(83, 3);
            this.btnAttCountSubmit.Name = "btnAttCountSubmit";
            this.btnAttCountSubmit.Size = new System.Drawing.Size(74, 23);
            this.btnAttCountSubmit.TabIndex = 2;
            this.btnAttCountSubmit.Text = "Submit";
            this.btnAttCountSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAddCountUpdate
            // 
            this.btnAddCountUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCountUpdate.Image")));
            this.btnAddCountUpdate.Location = new System.Drawing.Point(163, 3);
            this.btnAddCountUpdate.Name = "btnAddCountUpdate";
            this.btnAddCountUpdate.Size = new System.Drawing.Size(74, 23);
            this.btnAddCountUpdate.TabIndex = 3;
            this.btnAddCountUpdate.Text = "Update";
            this.btnAddCountUpdate.ToolTip = "Nút này dùng để cập nhật nội dung côt ghi chú";
            this.btnAddCountUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddCountDelete
            // 
            this.btnAddCountDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCountDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCountDelete.Image")));
            this.btnAddCountDelete.Location = new System.Drawing.Point(626, 3);
            this.btnAddCountDelete.Name = "btnAddCountDelete";
            this.btnAddCountDelete.Size = new System.Drawing.Size(74, 23);
            this.btnAddCountDelete.TabIndex = 4;
            this.btnAddCountDelete.Text = "Delete";
            this.btnAddCountDelete.Click += new System.EventHandler(this.btnAddCountDelete_Click);
            // 
            // alertControl1
            // 
            this.alertControl1.AutoHeight = true;
            this.alertControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.CornflowerBlue;
            this.alertControl1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.alertControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.alertControl1.BeforeFormShow += new DevExpress.XtraBars.Alerter.AlertFormEventHandler(this.alertControl1_BeforeFormShow);
            // 
            // splashScreenManager5
            // 
            this.splashScreenManager5.ClosingDelay = 500;
            // 
            // frmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmDiemDanh";
            this.Text = "Điểm danh nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiemDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton Export;
        private DevExpress.XtraEditors.SimpleButton Search;
        private DevExpress.XtraGrid.GridControl gridDiemDanh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn staff_id;
        private DevExpress.XtraGrid.Columns.GridColumn staff_name;
        private DevExpress.XtraGrid.Columns.GridColumn dept_name;
        private DevExpress.XtraGrid.Columns.GridColumn shift_code;
        private DevExpress.XtraGrid.Columns.GridColumn att_date;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnAttCountSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.RadioGroup radioGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.LookUpEdit lkBoPhan;
        private DevExpress.XtraEditors.LookUpEdit lkShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn att_reason;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private DevExpress.XtraGrid.Columns.GridColumn dept_id;
        private DevExpress.XtraGrid.Columns.GridColumn shift_id;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager3;
        private DevExpress.XtraEditors.SimpleButton btnAddCountUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn staff_status_description;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager4;
        private DevExpress.XtraGrid.Columns.GridColumn attcount_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager5;
        private DevExpress.XtraGrid.Columns.GridColumn createdby;
        private DevExpress.XtraGrid.Columns.GridColumn created;
        private DevExpress.XtraGrid.Columns.GridColumn updatedby;
        private DevExpress.XtraGrid.Columns.GridColumn updated;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.SimpleButton btnAddCountDelete;
    }
}