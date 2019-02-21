namespace HRM
{
    partial class frmQLSapXepCa
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.treeView = new System.Windows.Forms.TreeView();
            this.grdNhanvien = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.staff_id_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.staff_name_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dept_id_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dept_name_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.title_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.staff_hire_date_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.staff_status_id_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.staff_status_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.address_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idcard_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.birthday_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mobilephone_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.country_c = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdPhanCa = new DevExpress.XtraGrid.GridControl();
            this.gridViewPhanCa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.shift_arrange_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.staff_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.staff_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dept_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dept_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shift_arrange_effective = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shift_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.riLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.shiftLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShiftAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnShiftUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnShiftDelete = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhanCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhanCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grdPhanCa, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 584);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(833, 266);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.groupControl3, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.grdNhanvien, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(827, 260);
            this.tableLayoutPanel12.TabIndex = 3;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.treeView);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(194, 254);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Sơ đồ tổ chức";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(2, 20);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(190, 232);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // grdNhanvien
            // 
            this.grdNhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhanvien.Location = new System.Drawing.Point(203, 3);
            this.grdNhanvien.MainView = this.gridViewNhanVien;
            this.grdNhanvien.Name = "grdNhanvien";
            this.grdNhanvien.Size = new System.Drawing.Size(621, 254);
            this.grdNhanvien.TabIndex = 1;
            this.grdNhanvien.UseEmbeddedNavigator = true;
            this.grdNhanvien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhanVien});
            this.grdNhanvien.Click += new System.EventHandler(this.grdNhanvien_Click);
            // 
            // gridViewNhanVien
            // 
            this.gridViewNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.staff_id_c,
            this.staff_name_c,
            this.dept_id_c,
            this.dept_name_c,
            this.title_c,
            this.staff_hire_date_c,
            this.staff_status_id_c,
            this.staff_status_c,
            this.address_c,
            this.idcard_c,
            this.birthday_c,
            this.mobilephone_c,
            this.country_c});
            this.gridViewNhanVien.GridControl = this.grdNhanvien;
            this.gridViewNhanVien.GroupPanelText = "Danh sách nhân viên";
            this.gridViewNhanVien.Name = "gridViewNhanVien";
            this.gridViewNhanVien.OptionsBehavior.Editable = false;
            this.gridViewNhanVien.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewNhanVien.OptionsSelection.MultiSelect = true;
            this.gridViewNhanVien.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewNhanVien.OptionsView.ShowGroupPanel = false;
            // 
            // staff_id_c
            // 
            this.staff_id_c.Caption = "Mã NV";
            this.staff_id_c.FieldName = "staff_id_c";
            this.staff_id_c.Name = "staff_id_c";
            this.staff_id_c.Visible = true;
            this.staff_id_c.VisibleIndex = 1;
            // 
            // staff_name_c
            // 
            this.staff_name_c.Caption = "Họ Và Tên";
            this.staff_name_c.FieldName = "staff_name_c";
            this.staff_name_c.Name = "staff_name_c";
            this.staff_name_c.Visible = true;
            this.staff_name_c.VisibleIndex = 2;
            // 
            // dept_id_c
            // 
            this.dept_id_c.Caption = "dept_id_c";
            this.dept_id_c.FieldName = "dept_id_c";
            this.dept_id_c.Name = "dept_id_c";
            // 
            // dept_name_c
            // 
            this.dept_name_c.Caption = "Bộ Phận";
            this.dept_name_c.FieldName = "dept_name_c";
            this.dept_name_c.Name = "dept_name_c";
            this.dept_name_c.Visible = true;
            this.dept_name_c.VisibleIndex = 3;
            // 
            // title_c
            // 
            this.title_c.Caption = "Chức vụ";
            this.title_c.FieldName = "title_c";
            this.title_c.Name = "title_c";
            this.title_c.Visible = true;
            this.title_c.VisibleIndex = 4;
            // 
            // staff_hire_date_c
            // 
            this.staff_hire_date_c.Caption = "Ngày vào làm";
            this.staff_hire_date_c.FieldName = "staff_hire_date_c";
            this.staff_hire_date_c.Name = "staff_hire_date_c";
            this.staff_hire_date_c.Visible = true;
            this.staff_hire_date_c.VisibleIndex = 5;
            // 
            // staff_status_id_c
            // 
            this.staff_status_id_c.Caption = "staff_status_id_c";
            this.staff_status_id_c.FieldName = "staff_status_id_c";
            this.staff_status_id_c.Name = "staff_status_id_c";
            // 
            // staff_status_c
            // 
            this.staff_status_c.Caption = "Tình Trạng";
            this.staff_status_c.FieldName = "staff_status_c";
            this.staff_status_c.Name = "staff_status_c";
            this.staff_status_c.Visible = true;
            this.staff_status_c.VisibleIndex = 6;
            // 
            // address_c
            // 
            this.address_c.Caption = "Địa chỉ";
            this.address_c.FieldName = "address_c";
            this.address_c.Name = "address_c";
            // 
            // idcard_c
            // 
            this.idcard_c.Caption = "CMND";
            this.idcard_c.FieldName = "idcard_c";
            this.idcard_c.Name = "idcard_c";
            this.idcard_c.Visible = true;
            this.idcard_c.VisibleIndex = 7;
            // 
            // birthday_c
            // 
            this.birthday_c.Caption = "Ngày Sinh";
            this.birthday_c.FieldName = "birthday_c";
            this.birthday_c.Name = "birthday_c";
            this.birthday_c.Visible = true;
            this.birthday_c.VisibleIndex = 8;
            // 
            // mobilephone_c
            // 
            this.mobilephone_c.Caption = "Số Điện Thoại";
            this.mobilephone_c.FieldName = "mobilephone_c";
            this.mobilephone_c.Name = "mobilephone_c";
            // 
            // country_c
            // 
            this.country_c.Caption = "Quốc Tịch";
            this.country_c.FieldName = "country_c";
            this.country_c.Name = "country_c";
            // 
            // grdPhanCa
            // 
            this.grdPhanCa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPhanCa.Location = new System.Drawing.Point(3, 315);
            this.grdPhanCa.MainView = this.gridViewPhanCa;
            this.grdPhanCa.Name = "grdPhanCa";
            this.grdPhanCa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit1,
            this.riLookup,
            this.shiftLookup,
            this.repositoryItemGridLookUpEdit1});
            this.grdPhanCa.Size = new System.Drawing.Size(833, 266);
            this.grdPhanCa.TabIndex = 5;
            this.grdPhanCa.UseEmbeddedNavigator = true;
            this.grdPhanCa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhanCa});
            // 
            // gridViewPhanCa
            // 
            this.gridViewPhanCa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.shift_arrange_id,
            this.staff_id,
            this.staff_name,
            this.dept_id,
            this.dept_name,
            this.shift_arrange_effective,
            this.shift_id});
            this.gridViewPhanCa.GridControl = this.grdPhanCa;
            this.gridViewPhanCa.GroupPanelText = "Danh sách phân ca";
            this.gridViewPhanCa.Name = "gridViewPhanCa";
            this.gridViewPhanCa.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewPhanCa.OptionsSelection.MultiSelect = true;
            this.gridViewPhanCa.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewPhanCa.OptionsView.ShowGroupPanel = false;
            // 
            // shift_arrange_id
            // 
            this.shift_arrange_id.Caption = "No.";
            this.shift_arrange_id.FieldName = "shift_arrange_id";
            this.shift_arrange_id.Name = "shift_arrange_id";
            this.shift_arrange_id.OptionsColumn.AllowEdit = false;
            this.shift_arrange_id.Width = 20;
            // 
            // staff_id
            // 
            this.staff_id.Caption = "Mã NV";
            this.staff_id.FieldName = "staff_id";
            this.staff_id.Name = "staff_id";
            this.staff_id.OptionsColumn.AllowEdit = false;
            this.staff_id.Visible = true;
            this.staff_id.VisibleIndex = 1;
            this.staff_id.Width = 135;
            // 
            // staff_name
            // 
            this.staff_name.Caption = "Họ và tên";
            this.staff_name.FieldName = "staff_name";
            this.staff_name.Name = "staff_name";
            this.staff_name.OptionsColumn.AllowEdit = false;
            this.staff_name.Visible = true;
            this.staff_name.VisibleIndex = 2;
            this.staff_name.Width = 135;
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
            this.dept_name.VisibleIndex = 3;
            this.dept_name.Width = 135;
            // 
            // shift_arrange_effective
            // 
            this.shift_arrange_effective.Caption = "Ngày bắt đầu hiệu lực";
            this.shift_arrange_effective.DisplayFormat.FormatString = "d";
            this.shift_arrange_effective.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.shift_arrange_effective.FieldName = "shift_arrange_effective";
            this.shift_arrange_effective.Name = "shift_arrange_effective";
            this.shift_arrange_effective.Visible = true;
            this.shift_arrange_effective.VisibleIndex = 4;
            this.shift_arrange_effective.Width = 135;
            // 
            // shift_id
            // 
            this.shift_id.Caption = "Ca";
            this.shift_id.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.shift_id.FieldName = "shift_id";
            this.shift_id.Name = "shift_id";
            this.shift_id.Visible = true;
            this.shift_id.VisibleIndex = 5;
            this.shift_id.Width = 135;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // riLookup
            // 
            this.riLookup.AutoHeight = false;
            this.riLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLookup.Name = "riLookup";
            // 
            // shiftLookup
            // 
            this.shiftLookup.AutoHeight = false;
            this.shiftLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shiftLookup.Name = "shiftLookup";
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 34);
            this.panel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnShiftAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnShiftUpdate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnShiftDelete, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(831, 32);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnShiftAdd
            // 
            this.btnShiftAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShiftAdd.Image = global::HRM.Properties.Resources.Add;
            this.btnShiftAdd.Location = new System.Drawing.Point(3, 4);
            this.btnShiftAdd.Name = "btnShiftAdd";
            this.btnShiftAdd.Size = new System.Drawing.Size(74, 23);
            this.btnShiftAdd.TabIndex = 2;
            this.btnShiftAdd.Text = "Phân ca";
            this.btnShiftAdd.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnShiftUpdate
            // 
            this.btnShiftUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShiftUpdate.Image = global::HRM.Properties.Resources.change;
            this.btnShiftUpdate.Location = new System.Drawing.Point(163, 4);
            this.btnShiftUpdate.Name = "btnShiftUpdate";
            this.btnShiftUpdate.Size = new System.Drawing.Size(74, 23);
            this.btnShiftUpdate.TabIndex = 4;
            this.btnShiftUpdate.Text = "Cập nhật";
            this.btnShiftUpdate.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnShiftDelete
            // 
            this.btnShiftDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShiftDelete.Image = global::HRM.Properties.Resources.deletered;
            this.btnShiftDelete.Location = new System.Drawing.Point(83, 4);
            this.btnShiftDelete.Name = "btnShiftDelete";
            this.btnShiftDelete.Size = new System.Drawing.Size(74, 23);
            this.btnShiftDelete.TabIndex = 3;
            this.btnShiftDelete.Text = "Xóa";
            this.btnShiftDelete.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // frmQLSapXepCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 584);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmQLSapXepCa";
            this.Text = "Quản lý phân ca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLSapXepCa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhanCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhanCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnShiftAdd;
        private DevExpress.XtraEditors.SimpleButton btnShiftDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl grdNhanvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhanVien;
        private System.Windows.Forms.TreeView treeView;
        private DevExpress.XtraGrid.GridControl grdPhanCa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhanCa;
        private DevExpress.XtraGrid.Columns.GridColumn staff_id;
        private DevExpress.XtraGrid.Columns.GridColumn staff_name;
        private DevExpress.XtraGrid.Columns.GridColumn dept_name;
        private DevExpress.XtraGrid.Columns.GridColumn shift_arrange_effective;
        private DevExpress.XtraGrid.Columns.GridColumn shift_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnShiftUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn shift_arrange_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookup;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit shiftLookup;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn dept_id;
        private DevExpress.XtraGrid.Columns.GridColumn staff_id_c;
        private DevExpress.XtraGrid.Columns.GridColumn staff_name_c;
        private DevExpress.XtraGrid.Columns.GridColumn dept_id_c;
        private DevExpress.XtraGrid.Columns.GridColumn dept_name_c;
        private DevExpress.XtraGrid.Columns.GridColumn title_c;
        private DevExpress.XtraGrid.Columns.GridColumn staff_hire_date_c;
        private DevExpress.XtraGrid.Columns.GridColumn staff_status_id_c;
        private DevExpress.XtraGrid.Columns.GridColumn staff_status_c;
        private DevExpress.XtraGrid.Columns.GridColumn address_c;
        private DevExpress.XtraGrid.Columns.GridColumn idcard_c;
        private DevExpress.XtraGrid.Columns.GridColumn birthday_c;
        private DevExpress.XtraGrid.Columns.GridColumn mobilephone_c;
        private DevExpress.XtraGrid.Columns.GridColumn country_c;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
    }
}