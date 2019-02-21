using DevExpress.XtraEditors;

namespace HRM
{
    partial class frmQLSanLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSanLuong));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.output_actual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.search = new DevExpress.XtraEditors.SimpleButton();
            this.export = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStart = new DevExpress.XtraEditors.DateEdit();
            this.dtpEnd = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grdTargetActualLine = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.deptname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.documentdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inputname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.headcount_target = new DevExpress.XtraGrid.Columns.GridColumn();
            this.headcount_actual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.output_target = new DevExpress.XtraGrid.Columns.GridColumn();
            this.effeciency_target = new DevExpress.XtraGrid.Columns.GridColumn();
            this.effeciency_actual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lkDocumenttype = new DevExpress.XtraEditors.LookUpEdit();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lkTypename = new DevExpress.XtraEditors.LookUpEdit();
            this.splashScreenManager2 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::HRM.WaitForm1), true, true);
            this.partname = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTargetActualLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkDocumenttype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTypename.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // output_actual
            // 
            this.output_actual.Caption = "Sản lượng thực tế (pcs)";
            this.output_actual.FieldName = "output_actual";
            this.output_actual.Name = "output_actual";
            this.output_actual.Visible = true;
            this.output_actual.VisibleIndex = 8;
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
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.search, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.export, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpStart, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpEnd, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(894, 34);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(697, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(94, 28);
            this.search.TabIndex = 9;
            this.search.Text = "Search";
            this.search.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // export
            // 
            this.export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.export.Image = ((System.Drawing.Image)(resources.GetObject("export.Image")));
            this.export.Location = new System.Drawing.Point(797, 3);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(94, 28);
            this.export.TabIndex = 4;
            this.export.Text = "Export";
            this.export.ToolTip = "Trích xuất nội dung danh sách bên dưới ra excel";
            this.export.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Từ ngày:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Đến ngày:";
            // 
            // dtpStart
            // 
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStart.EditValue = new System.DateTime(2018, 12, 3, 21, 24, 59, 602);
            this.dtpStart.Location = new System.Drawing.Point(83, 3);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpStart.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpStart.Size = new System.Drawing.Size(94, 20);
            this.dtpStart.TabIndex = 12;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEnd.EditValue = new System.DateTime(2018, 12, 3, 21, 24, 39, 321);
            this.dtpEnd.Location = new System.Drawing.Point(263, 3);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEnd.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpEnd.Size = new System.Drawing.Size(94, 20);
            this.dtpEnd.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.grdTargetActualLine, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(894, 471);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // grdTargetActualLine
            // 
            this.grdTargetActualLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTargetActualLine.Location = new System.Drawing.Point(3, 3);
            this.grdTargetActualLine.MainView = this.gridView;
            this.grdTargetActualLine.Name = "grdTargetActualLine";
            this.grdTargetActualLine.Size = new System.Drawing.Size(888, 465);
            this.grdTargetActualLine.TabIndex = 2;
            this.grdTargetActualLine.UseEmbeddedNavigator = true;
            this.grdTargetActualLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.gridView1});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.deptname,
            this.typename,
            this.partname,
            this.documentdate,
            this.inputname,
            this.headcount_target,
            this.headcount_actual,
            this.output_target,
            this.output_actual,
            this.effeciency_target,
            this.effeciency_actual,
            this.reason});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[output_actual] > [output_target]";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "[output_actual] < [output_target]";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.gridView.FormatRules.Add(gridFormatRule1);
            this.gridView.FormatRules.Add(gridFormatRule2);
            this.gridView.GridControl = this.grdTargetActualLine;
            this.gridView.GroupPanelText = "DANH SÁCH PHIẾU NHẬP SẢN LƯỢNG";
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            this.gridView.RowCountChanged += new System.EventHandler(this.gridView_RowCountChanged);
            // 
            // deptname
            // 
            this.deptname.Caption = "Chuyền";
            this.deptname.FieldName = "deptname";
            this.deptname.Name = "deptname";
            this.deptname.Visible = true;
            this.deptname.VisibleIndex = 0;
            // 
            // typename
            // 
            this.typename.Caption = "Typename";
            this.typename.FieldName = "typename";
            this.typename.Name = "typename";
            this.typename.Visible = true;
            this.typename.VisibleIndex = 1;
            // 
            // documentdate
            // 
            this.documentdate.Caption = "Ngày nhập";
            this.documentdate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.documentdate.FieldName = "documentdate";
            this.documentdate.Name = "documentdate";
            this.documentdate.Visible = true;
            this.documentdate.VisibleIndex = 3;
            // 
            // inputname
            // 
            this.inputname.Caption = "Lượt nhập";
            this.inputname.FieldName = "inputname";
            this.inputname.Name = "inputname";
            this.inputname.Visible = true;
            this.inputname.VisibleIndex = 4;
            // 
            // headcount_target
            // 
            this.headcount_target.Caption = "Số người đầu vào (persons)";
            this.headcount_target.FieldName = "headcount_target";
            this.headcount_target.Name = "headcount_target";
            this.headcount_target.Visible = true;
            this.headcount_target.VisibleIndex = 5;
            // 
            // headcount_actual
            // 
            this.headcount_actual.Caption = "Số người thực tế (persons)";
            this.headcount_actual.FieldName = "headcount_actual";
            this.headcount_actual.Name = "headcount_actual";
            this.headcount_actual.Visible = true;
            this.headcount_actual.VisibleIndex = 6;
            // 
            // output_target
            // 
            this.output_target.Caption = "Sản lượng đầu vào (pcs)";
            this.output_target.FieldName = "output_target";
            this.output_target.Name = "output_target";
            this.output_target.Visible = true;
            this.output_target.VisibleIndex = 7;
            // 
            // effeciency_target
            // 
            this.effeciency_target.Caption = "Hiệu suất đầu vào (mins/pcs)";
            this.effeciency_target.FieldName = "effeciency_target";
            this.effeciency_target.Name = "effeciency_target";
            this.effeciency_target.Visible = true;
            this.effeciency_target.VisibleIndex = 9;
            // 
            // effeciency_actual
            // 
            this.effeciency_actual.Caption = "Hiệu suất thực tế (mins/pcs)";
            this.effeciency_actual.FieldName = "effeciency_actual";
            this.effeciency_actual.Name = "effeciency_actual";
            this.effeciency_actual.Visible = true;
            this.effeciency_actual.VisibleIndex = 10;
            // 
            // reason
            // 
            this.reason.Caption = "Note";
            this.reason.FieldName = "reason";
            this.reason.Name = "reason";
            this.reason.Visible = true;
            this.reason.VisibleIndex = 11;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdTargetActualLine;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 100);
            this.groupControl1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtDate, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lkDocumenttype, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnNew, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnSave, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(190, 443);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại chứng từ:";
            // 
            // txtDate
            // 
            this.txtDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(98, 3);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(89, 20);
            this.txtDate.TabIndex = 3;
            // 
            // lkDocumenttype
            // 
            this.lkDocumenttype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkDocumenttype.Location = new System.Drawing.Point(98, 63);
            this.lkDocumenttype.Name = "lkDocumenttype";
            this.lkDocumenttype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDocumenttype.Size = new System.Drawing.Size(89, 20);
            this.lkDocumenttype.TabIndex = 5;
            this.lkDocumenttype.ToolTip = "Chọn loại chứng từ";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(17, 93);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(98, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            // 
            // lkTypename
            // 
            this.lkTypename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkTypename.Location = new System.Drawing.Point(98, 33);
            this.lkTypename.Name = "lkTypename";
            this.lkTypename.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTypename.Size = new System.Drawing.Size(89, 20);
            this.lkTypename.TabIndex = 4;
            this.lkTypename.ToolTip = "Chọn typename";
            // 
            // splashScreenManager2
            // 
            this.splashScreenManager2.ClosingDelay = 500;
            // 
            // partname
            // 
            this.partname.Caption = "Partname";
            this.partname.FieldName = "partname";
            this.partname.Name = "partname";
            this.partname.Visible = true;
            this.partname.VisibleIndex = 2;
            // 
            // frmQLSanLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 521);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQLSanLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản lượng, hiệu suất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLSanLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTargetActualLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkDocumenttype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTypename.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton export;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private LookUpEdit lkTypename;
        private LookUpEdit lkDocumenttype;
        private SimpleButton btnNew;
        private SimpleButton btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraGrid.GridControl grdTargetActualLine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn deptname;
        private DevExpress.XtraGrid.Columns.GridColumn typename;
        private DevExpress.XtraGrid.Columns.GridColumn documentdate;
        private DevExpress.XtraGrid.Columns.GridColumn inputname;
        private DevExpress.XtraGrid.Columns.GridColumn headcount_target;
        private DevExpress.XtraGrid.Columns.GridColumn headcount_actual;
        private DevExpress.XtraGrid.Columns.GridColumn output_target;
        private DevExpress.XtraGrid.Columns.GridColumn output_actual;
        private DevExpress.XtraGrid.Columns.GridColumn effeciency_target;
        private DevExpress.XtraGrid.Columns.GridColumn effeciency_actual;
        private SimpleButton search;
        private DevExpress.XtraGrid.Columns.GridColumn reason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DateEdit dtpStart;
        private DateEdit dtpEnd;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private DevExpress.XtraGrid.Columns.GridColumn partname;
    }
}