using DevExpress.XtraEditors;

namespace HRM
{
    partial class frmNhSanLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhSanLuong));
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.export = new DevExpress.XtraEditors.SimpleButton();
            this.btnQtyDelete = new DevExpress.XtraEditors.SimpleButton();
            this.search = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grdInout = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_inout_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.documentno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dept_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deptname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typecode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.document_type_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.document_type_description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.documentdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.document_status_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.document_status_description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.createtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad_group_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lkTypename = new DevExpress.XtraEditors.LookUpEdit();
            this.lkDocumenttype = new DevExpress.XtraEditors.LookUpEdit();
            this.btnQtyNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnQtySave = new DevExpress.XtraEditors.SimpleButton();
            this.lkPartname = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkTypename.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDocumenttype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPartname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Location = new System.Drawing.Point(5, 74);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(345, 421);
            this.gridSplitContainer1.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.tableLayoutPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(904, 521);
            this.panelControl1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 517);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.export, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnQtyDelete, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.search, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateEdit1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateEdit2, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(894, 34);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // export
            // 
            this.export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.export.Image = ((System.Drawing.Image)(resources.GetObject("export.Image")));
            this.export.Location = new System.Drawing.Point(697, 3);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(94, 28);
            this.export.TabIndex = 4;
            this.export.Text = "Export";
            this.export.ToolTip = "Trích xuất nội dung danh sách bên dưới ra excel";
            this.export.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnQtyDelete
            // 
            this.btnQtyDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQtyDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnQtyDelete.Image")));
            this.btnQtyDelete.Location = new System.Drawing.Point(797, 3);
            this.btnQtyDelete.Name = "btnQtyDelete";
            this.btnQtyDelete.Size = new System.Drawing.Size(94, 28);
            this.btnQtyDelete.TabIndex = 4;
            this.btnQtyDelete.Text = "Xóa";
            this.btnQtyDelete.ToolTip = "Xóa dòng dữ liệu được chọn bên dưới";
            this.btnQtyDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(597, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(94, 28);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "To:";
            // 
            // dateEdit1
            // 
            this.dateEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit1.EditValue = new System.DateTime(2018, 12, 3, 23, 17, 51, 418);
            this.dateEdit1.Location = new System.Drawing.Point(53, 3);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(94, 20);
            this.dateEdit1.TabIndex = 8;
            // 
            // dateEdit2
            // 
            this.dateEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit2.EditValue = new System.DateTime(2018, 12, 3, 23, 17, 51, 418);
            this.dateEdit2.Location = new System.Drawing.Point(203, 3);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(94, 20);
            this.dateEdit2.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.Controls.Add(this.grdInout, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(894, 471);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // grdInout
            // 
            this.grdInout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdInout.Location = new System.Drawing.Point(3, 3);
            this.grdInout.MainView = this.gridView;
            this.grdInout.Name = "grdInout";
            this.grdInout.Size = new System.Drawing.Size(638, 465);
            this.grdInout.TabIndex = 2;
            this.grdInout.UseEmbeddedNavigator = true;
            this.grdInout.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.m_inout_id,
            this.documentno,
            this.dept_id,
            this.deptname,
            this.typecode,
            this.typename,
            this.partcode,
            this.partname,
            this.document_type_code,
            this.document_type_description,
            this.documentdate,
            this.document_status_code,
            this.document_status_description,
            this.createtime,
            this.ad_group_id});
            this.gridView.GridControl = this.grdInout;
            this.gridView.GroupPanelText = "DANH SÁCH PHIẾU NHẬP SẢN LƯỢNG";
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            this.gridView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView_RowStyle);
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            this.gridView.RowCountChanged += new System.EventHandler(this.gridView_RowCountChanged);
            // 
            // m_inout_id
            // 
            this.m_inout_id.Caption = "m_inout_id";
            this.m_inout_id.FieldName = "m_inout_id";
            this.m_inout_id.Name = "m_inout_id";
            // 
            // documentno
            // 
            this.documentno.Caption = "Số chứng từ";
            this.documentno.FieldName = "documentno";
            this.documentno.Name = "documentno";
            this.documentno.Visible = true;
            this.documentno.VisibleIndex = 0;
            this.documentno.Width = 100;
            // 
            // dept_id
            // 
            this.dept_id.Caption = "dept_id";
            this.dept_id.FieldName = "dept_id";
            this.dept_id.Name = "dept_id";
            // 
            // deptname
            // 
            this.deptname.Caption = "Chuyền";
            this.deptname.FieldName = "deptname";
            this.deptname.Name = "deptname";
            this.deptname.Visible = true;
            this.deptname.VisibleIndex = 1;
            this.deptname.Width = 100;
            // 
            // typecode
            // 
            this.typecode.Caption = "typecode";
            this.typecode.FieldName = "typecode";
            this.typecode.Name = "typecode";
            // 
            // typename
            // 
            this.typename.Caption = "Type name";
            this.typename.FieldName = "typename";
            this.typename.Name = "typename";
            this.typename.Visible = true;
            this.typename.VisibleIndex = 2;
            this.typename.Width = 151;
            // 
            // partcode
            // 
            this.partcode.Caption = "partcode";
            this.partcode.FieldName = "partcode";
            this.partcode.Name = "partcode";
            // 
            // partname
            // 
            this.partname.Caption = "Partname";
            this.partname.FieldName = "partname";
            this.partname.Name = "partname";
            this.partname.Visible = true;
            this.partname.VisibleIndex = 3;
            // 
            // document_type_code
            // 
            this.document_type_code.Caption = "document_type_code";
            this.document_type_code.FieldName = "document_type_code";
            this.document_type_code.Name = "document_type_code";
            // 
            // document_type_description
            // 
            this.document_type_description.Caption = "Loại chứng từ";
            this.document_type_description.FieldName = "document_type_description";
            this.document_type_description.Name = "document_type_description";
            this.document_type_description.Visible = true;
            this.document_type_description.VisibleIndex = 4;
            this.document_type_description.Width = 138;
            // 
            // documentdate
            // 
            this.documentdate.Caption = "Ngày nhập";
            this.documentdate.FieldName = "documentdate";
            this.documentdate.Name = "documentdate";
            this.documentdate.Visible = true;
            this.documentdate.VisibleIndex = 5;
            this.documentdate.Width = 181;
            // 
            // document_status_code
            // 
            this.document_status_code.Caption = "document_status_code";
            this.document_status_code.FieldName = "document_status_code";
            this.document_status_code.Name = "document_status_code";
            // 
            // document_status_description
            // 
            this.document_status_description.Caption = "Trạng thái chứng từ";
            this.document_status_description.FieldName = "document_status_description";
            this.document_status_description.Name = "document_status_description";
            this.document_status_description.Visible = true;
            this.document_status_description.VisibleIndex = 6;
            this.document_status_description.Width = 206;
            // 
            // createtime
            // 
            this.createtime.Caption = "created";
            this.createtime.FieldName = "createtime";
            this.createtime.Name = "createtime";
            this.createtime.Visible = true;
            this.createtime.VisibleIndex = 7;
            // 
            // ad_group_id
            // 
            this.ad_group_id.Caption = "ad_group_id";
            this.ad_group_id.FieldName = "ad_group_id";
            this.ad_group_id.Name = "ad_group_id";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(647, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(244, 465);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Tạo phiếu nhập";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtDate, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lkTypename, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lkDocumenttype, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnQtyNew, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.btnQtySave, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.lkPartname, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(240, 443);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại chứng từ:";
            // 
            // txtDate
            // 
            this.txtDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(99, 3);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(138, 21);
            this.txtDate.TabIndex = 3;
            // 
            // lkTypename
            // 
            this.lkTypename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkTypename.Location = new System.Drawing.Point(99, 33);
            this.lkTypename.Name = "lkTypename";
            this.lkTypename.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTypename.Size = new System.Drawing.Size(138, 20);
            this.lkTypename.TabIndex = 4;
            this.lkTypename.ToolTip = "Chọn typename";
            this.lkTypename.EditValueChanged += new System.EventHandler(this.lkTypename_EditValueChanged);
            // 
            // lkDocumenttype
            // 
            this.lkDocumenttype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkDocumenttype.Location = new System.Drawing.Point(99, 93);
            this.lkDocumenttype.Name = "lkDocumenttype";
            this.lkDocumenttype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDocumenttype.Size = new System.Drawing.Size(138, 20);
            this.lkDocumenttype.TabIndex = 5;
            this.lkDocumenttype.ToolTip = "Chọn loại chứng từ";
            // 
            // btnQtyNew
            // 
            this.btnQtyNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQtyNew.Image = ((System.Drawing.Image)(resources.GetObject("btnQtyNew.Image")));
            this.btnQtyNew.Location = new System.Drawing.Point(18, 123);
            this.btnQtyNew.Name = "btnQtyNew";
            this.btnQtyNew.Size = new System.Drawing.Size(75, 23);
            this.btnQtyNew.TabIndex = 6;
            this.btnQtyNew.Text = "New";
            // 
            // btnQtySave
            // 
            this.btnQtySave.Image = ((System.Drawing.Image)(resources.GetObject("btnQtySave.Image")));
            this.btnQtySave.Location = new System.Drawing.Point(99, 123);
            this.btnQtySave.Name = "btnQtySave";
            this.btnQtySave.Size = new System.Drawing.Size(75, 23);
            this.btnQtySave.TabIndex = 7;
            this.btnQtySave.Text = "Save";
            this.btnQtySave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lkPartname
            // 
            this.lkPartname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkPartname.Location = new System.Drawing.Point(99, 63);
            this.lkPartname.Name = "lkPartname";
            this.lkPartname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPartname.Size = new System.Drawing.Size(138, 20);
            this.lkPartname.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Part name:";
            // 
            // frmNhSanLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 521);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhSanLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập sản lượng, hiệu suất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhSanLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdInout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkTypename.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDocumenttype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPartname.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton export;
        private DevExpress.XtraGrid.GridControl grdInout;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn documentno;
        private DevExpress.XtraGrid.Columns.GridColumn deptname;
        private DevExpress.XtraGrid.Columns.GridColumn typename;
        private DevExpress.XtraGrid.Columns.GridColumn documentdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SimpleButton btnQtyDelete;
        private DevExpress.XtraGrid.Columns.GridColumn document_status_description;
        private DevExpress.XtraGrid.Columns.GridColumn document_type_description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private LookUpEdit lkTypename;
        private LookUpEdit lkDocumenttype;
        private SimpleButton btnQtyNew;
        private SimpleButton btnQtySave;
        private DevExpress.XtraGrid.Columns.GridColumn m_inout_id;
        private DevExpress.XtraGrid.Columns.GridColumn dept_id;
        private DevExpress.XtraGrid.Columns.GridColumn typecode;
        private DevExpress.XtraGrid.Columns.GridColumn document_type_code;
        private DevExpress.XtraGrid.Columns.GridColumn document_status_code;
        private DevExpress.XtraGrid.Columns.GridColumn createtime;
        private DevExpress.XtraGrid.Columns.GridColumn ad_group_id;
        private LookUpEdit lkPartname;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn partcode;
        private DevExpress.XtraGrid.Columns.GridColumn partname;
        private SimpleButton search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DateEdit dateEdit1;
        private DateEdit dateEdit2;
    }
}