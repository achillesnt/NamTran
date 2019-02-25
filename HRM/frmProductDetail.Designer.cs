using DevExpress.XtraEditors;

namespace HRM
{
    partial class frmProductDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductDetail));
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabPrices = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPriceNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnPriceSave = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.txtCurrency = new DevExpress.XtraEditors.TextEdit();
            this.txtNote = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.gridPrice = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.price_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.currency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.effective_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price_note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tabTransaction = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.gridTransaction = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ad_process_access_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad_process_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad_process_description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad_process_access_isactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabPrices.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.tabTransaction.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.xtraTabControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblProductCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProductName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 517);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 83);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabPrices;
            this.xtraTabControl1.Size = new System.Drawing.Size(894, 431);
            this.xtraTabControl1.TabIndex = 5;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPrices,
            this.tabTransaction});
            // 
            // tabPrices
            // 
            this.tabPrices.Controls.Add(this.tableLayoutPanel5);
            this.tabPrices.Image = ((System.Drawing.Image)(resources.GetObject("tabPrices.Image")));
            this.tabPrices.Name = "tabPrices";
            this.tabPrices.Size = new System.Drawing.Size(888, 400);
            this.tabPrices.Text = "Prices";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.gridPrice, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(888, 400);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tableLayoutPanel6);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(691, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(194, 394);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Add New Price";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnPriceNew, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.btnPriceSave, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.txtValue, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtCurrency, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtNote, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.dateEdit, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(190, 372);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Value:";
            // 
            // btnPriceNew
            // 
            this.btnPriceNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPriceNew.Image = ((System.Drawing.Image)(resources.GetObject("btnPriceNew.Image")));
            this.btnPriceNew.Location = new System.Drawing.Point(17, 123);
            this.btnPriceNew.Name = "btnPriceNew";
            this.btnPriceNew.Size = new System.Drawing.Size(75, 23);
            this.btnPriceNew.TabIndex = 2;
            this.btnPriceNew.Text = "New";
            this.btnPriceNew.Click += new System.EventHandler(this.btnPriceNew_Click);
            // 
            // btnPriceSave
            // 
            this.btnPriceSave.Image = ((System.Drawing.Image)(resources.GetObject("btnPriceSave.Image")));
            this.btnPriceSave.Location = new System.Drawing.Point(98, 123);
            this.btnPriceSave.Name = "btnPriceSave";
            this.btnPriceSave.Size = new System.Drawing.Size(75, 23);
            this.btnPriceSave.TabIndex = 3;
            this.btnPriceSave.Text = "Save";
            this.btnPriceSave.Click += new System.EventHandler(this.btnPriceSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Eff. Date:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Note:";
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Location = new System.Drawing.Point(98, 3);
            this.txtValue.Name = "txtValue";
            this.txtValue.Properties.Mask.EditMask = "c2";
            this.txtValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValue.Size = new System.Drawing.Size(89, 20);
            this.txtValue.TabIndex = 4;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrency.Location = new System.Drawing.Point(98, 33);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(89, 20);
            this.txtCurrency.TabIndex = 5;
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Location = new System.Drawing.Point(98, 93);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(89, 20);
            this.txtNote.TabIndex = 6;
            // 
            // dateEdit
            // 
            this.dateEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit.EditValue = new System.DateTime(2019, 2, 25, 15, 21, 30, 285);
            this.dateEdit.Location = new System.Drawing.Point(98, 63);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(89, 20);
            this.dateEdit.TabIndex = 7;
            // 
            // gridPrice
            // 
            this.gridPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPrice.Location = new System.Drawing.Point(3, 3);
            this.gridPrice.MainView = this.gridView2;
            this.gridPrice.Name = "gridPrice";
            this.gridPrice.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gridPrice.Size = new System.Drawing.Size(682, 394);
            this.gridPrice.TabIndex = 1;
            this.gridPrice.UseEmbeddedNavigator = true;
            this.gridPrice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.price_id,
            this.value,
            this.currency,
            this.effective_date,
            this.price_note});
            this.gridView2.GridControl = this.gridPrice;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // price_id
            // 
            this.price_id.Caption = "price_id";
            this.price_id.FieldName = "price_id";
            this.price_id.Name = "price_id";
            this.price_id.OptionsColumn.AllowEdit = false;
            // 
            // value
            // 
            this.value.Caption = "Value";
            this.value.DisplayFormat.FormatString = "#,#.00";
            this.value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.value.FieldName = "value";
            this.value.Name = "value";
            this.value.OptionsColumn.AllowEdit = false;
            this.value.Visible = true;
            this.value.VisibleIndex = 1;
            // 
            // currency
            // 
            this.currency.Caption = "Currency";
            this.currency.FieldName = "currency";
            this.currency.Name = "currency";
            this.currency.OptionsColumn.AllowEdit = false;
            this.currency.Visible = true;
            this.currency.VisibleIndex = 2;
            // 
            // effective_date
            // 
            this.effective_date.Caption = "Eff. Date";
            this.effective_date.FieldName = "effective_date";
            this.effective_date.Name = "effective_date";
            this.effective_date.OptionsColumn.AllowEdit = false;
            this.effective_date.Visible = true;
            this.effective_date.VisibleIndex = 3;
            // 
            // price_note
            // 
            this.price_note.Caption = "Note";
            this.price_note.FieldName = "price_note";
            this.price_note.Name = "price_note";
            this.price_note.OptionsColumn.AllowEdit = false;
            this.price_note.Visible = true;
            this.price_note.VisibleIndex = 4;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // tabTransaction
            // 
            this.tabTransaction.Controls.Add(this.tableLayoutPanel7);
            this.tabTransaction.Image = ((System.Drawing.Image)(resources.GetObject("tabTransaction.Image")));
            this.tabTransaction.Name = "tabTransaction";
            this.tabTransaction.Size = new System.Drawing.Size(888, 400);
            this.tabTransaction.Text = "Transaction";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.gridTransaction, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(888, 400);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // gridTransaction
            // 
            this.gridTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTransaction.Location = new System.Drawing.Point(3, 3);
            this.gridTransaction.MainView = this.gridView3;
            this.gridTransaction.Name = "gridTransaction";
            this.gridTransaction.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit3});
            this.gridTransaction.Size = new System.Drawing.Size(882, 394);
            this.gridTransaction.TabIndex = 1;
            this.gridTransaction.UseEmbeddedNavigator = true;
            this.gridTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ad_process_access_id,
            this.ad_process_name,
            this.ad_process_description,
            this.ad_process_access_isactive});
            this.gridView3.GridControl = this.gridTransaction;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView3.OptionsSelection.MultiSelect = true;
            this.gridView3.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // ad_process_access_id
            // 
            this.ad_process_access_id.Caption = "ad_process_access_id";
            this.ad_process_access_id.FieldName = "ad_process_access_id";
            this.ad_process_access_id.Name = "ad_process_access_id";
            this.ad_process_access_id.OptionsColumn.AllowEdit = false;
            // 
            // ad_process_name
            // 
            this.ad_process_name.Caption = "name";
            this.ad_process_name.FieldName = "ad_process_name";
            this.ad_process_name.Name = "ad_process_name";
            this.ad_process_name.OptionsColumn.AllowEdit = false;
            this.ad_process_name.Visible = true;
            this.ad_process_name.VisibleIndex = 1;
            // 
            // ad_process_description
            // 
            this.ad_process_description.Caption = "description";
            this.ad_process_description.FieldName = "ad_process_description";
            this.ad_process_description.Name = "ad_process_description";
            this.ad_process_description.OptionsColumn.AllowEdit = false;
            this.ad_process_description.Visible = true;
            this.ad_process_description.VisibleIndex = 2;
            // 
            // ad_process_access_isactive
            // 
            this.ad_process_access_isactive.Caption = "isactive";
            this.ad_process_access_isactive.ColumnEdit = this.repositoryItemCheckEdit3;
            this.ad_process_access_isactive.FieldName = "ad_process_access_isactive";
            this.ad_process_access_isactive.Name = "ad_process_access_isactive";
            this.ad_process_access_isactive.Visible = true;
            this.ad_process_access_isactive.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // lblProductCode
            // 
            this.lblProductCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(3, 10);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(45, 19);
            this.lblProductCode.TabIndex = 6;
            this.lblProductCode.Text = "label2";
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(3, 50);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(45, 19);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "label2";
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 521);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.Name = "frmProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Chi Tiết";
            this.Load += new System.EventHandler(this.frmProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabPrices.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.tabTransaction.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabPrices;
        private DevExpress.XtraTab.XtraTabPage tabTransaction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private GroupControl groupControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label7;
        private SimpleButton btnPriceNew;
        private SimpleButton btnPriceSave;
        private DevExpress.XtraGrid.GridControl gridPrice;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private DevExpress.XtraGrid.GridControl gridTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn ad_process_access_id;
        private DevExpress.XtraGrid.Columns.GridColumn ad_process_name;
        private DevExpress.XtraGrid.Columns.GridColumn ad_process_description;
        private DevExpress.XtraGrid.Columns.GridColumn ad_process_access_isactive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private System.Windows.Forms.Label lblProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn price_id;
        private DevExpress.XtraGrid.Columns.GridColumn value;
        private DevExpress.XtraGrid.Columns.GridColumn currency;
        private DevExpress.XtraGrid.Columns.GridColumn effective_date;
        private System.Windows.Forms.Label lblProductName;
        private DevExpress.XtraGrid.Columns.GridColumn price_note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private TextEdit txtValue;
        private TextEdit txtCurrency;
        private TextEdit txtNote;
        private DateEdit dateEdit;
    }
}