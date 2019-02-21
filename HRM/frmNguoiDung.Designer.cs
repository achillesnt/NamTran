using DevExpress.XtraEditors;

namespace HRM
{
    partial class frmNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiDung));
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUserUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.export = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grdNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ad_user_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad_client_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad_org_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.updatedby = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created = new DevExpress.XtraGrid.Columns.GridColumn();
            this.createdby = new DevExpress.XtraGrid.Columns.GridColumn();
            this.updated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.default_ad_client_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.default_ad_org_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.default_ad_role_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.islocked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad_group_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad_org_description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUserNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserSave = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lkBoPhan = new DevExpress.XtraEditors.LookUpEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGroup = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkBoPhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroup.Properties)).BeginInit();
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
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnUserUpdate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.export, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(894, 34);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUserUpdate.Image")));
            this.btnUserUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(94, 28);
            this.btnUserUpdate.TabIndex = 4;
            this.btnUserUpdate.Text = "Update";
            this.btnUserUpdate.ToolTip = "Cập nhật dữ liệu bên dưới";
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // export
            // 
            this.export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.export.Image = ((System.Drawing.Image)(resources.GetObject("export.Image")));
            this.export.Location = new System.Drawing.Point(103, 3);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(94, 28);
            this.export.TabIndex = 4;
            this.export.Text = "Export";
            this.export.ToolTip = "Trích xuất nội dung danh sách bên dưới ra excel";
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.grdNguoiDung, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(894, 471);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // grdNguoiDung
            // 
            this.grdNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNguoiDung.Location = new System.Drawing.Point(3, 3);
            this.grdNguoiDung.MainView = this.gridView1;
            this.grdNguoiDung.Name = "grdNguoiDung";
            this.grdNguoiDung.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1});
            this.grdNguoiDung.Size = new System.Drawing.Size(688, 465);
            this.grdNguoiDung.TabIndex = 2;
            this.grdNguoiDung.UseEmbeddedNavigator = true;
            this.grdNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ad_user_id,
            this.ad_client_id,
            this.ad_org_id,
            this.isactive,
            this.updatedby,
            this.created,
            this.createdby,
            this.updated,
            this.name,
            this.description,
            this.password,
            this.username,
            this.default_ad_client_id,
            this.default_ad_org_id,
            this.default_ad_role_id,
            this.islocked,
            this.ad_group_id,
            this.ad_org_description});
            this.gridView1.GridControl = this.grdNguoiDung;
            this.gridView1.GroupPanelText = "DANH SÁCH PHIẾU NHẬP SẢN LƯỢNG";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // ad_user_id
            // 
            this.ad_user_id.Caption = "ad_user_id";
            this.ad_user_id.FieldName = "ad_user_id";
            this.ad_user_id.Name = "ad_user_id";
            // 
            // ad_client_id
            // 
            this.ad_client_id.Caption = "ad_client_id";
            this.ad_client_id.FieldName = "ad_client_id";
            this.ad_client_id.Name = "ad_client_id";
            // 
            // ad_org_id
            // 
            this.ad_org_id.Caption = "ad_org_id";
            this.ad_org_id.FieldName = "ad_org_id";
            this.ad_org_id.Name = "ad_org_id";
            // 
            // isactive
            // 
            this.isactive.Caption = "isactive";
            this.isactive.ColumnEdit = this.repositoryItemCheckEdit1;
            this.isactive.FieldName = "isactive";
            this.isactive.Name = "isactive";
            this.isactive.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.isactive.Visible = true;
            this.isactive.VisibleIndex = 6;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // updatedby
            // 
            this.updatedby.Caption = "updatedby";
            this.updatedby.FieldName = "updatedby";
            this.updatedby.Name = "updatedby";
            // 
            // created
            // 
            this.created.Caption = "created";
            this.created.FieldName = "created";
            this.created.Name = "created";
            // 
            // createdby
            // 
            this.createdby.Caption = "createdby";
            this.createdby.FieldName = "createdby";
            this.createdby.Name = "createdby";
            // 
            // updated
            // 
            this.updated.Caption = "updated";
            this.updated.FieldName = "updated";
            this.updated.Name = "updated";
            // 
            // name
            // 
            this.name.Caption = "name";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 1;
            // 
            // description
            // 
            this.description.Caption = "description";
            this.description.FieldName = "description";
            this.description.Name = "description";
            this.description.Visible = true;
            this.description.VisibleIndex = 2;
            // 
            // password
            // 
            this.password.Caption = "password";
            this.password.ColumnEdit = this.repositoryItemTextEdit1;
            this.password.DisplayFormat.FormatString = "******";
            this.password.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.password.FieldName = "password";
            this.password.Name = "password";
            this.password.Visible = true;
            this.password.VisibleIndex = 4;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // username
            // 
            this.username.Caption = "username";
            this.username.FieldName = "username";
            this.username.Name = "username";
            this.username.OptionsColumn.AllowEdit = false;
            this.username.Visible = true;
            this.username.VisibleIndex = 3;
            // 
            // default_ad_client_id
            // 
            this.default_ad_client_id.Caption = "default_ad_client_id";
            this.default_ad_client_id.FieldName = "default_ad_client_id";
            this.default_ad_client_id.Name = "default_ad_client_id";
            // 
            // default_ad_org_id
            // 
            this.default_ad_org_id.Caption = "default_ad_org_id";
            this.default_ad_org_id.FieldName = "default_ad_org_id";
            this.default_ad_org_id.Name = "default_ad_org_id";
            // 
            // default_ad_role_id
            // 
            this.default_ad_role_id.Caption = "default_ad_role_id";
            this.default_ad_role_id.FieldName = "default_ad_role_id";
            this.default_ad_role_id.Name = "default_ad_role_id";
            // 
            // islocked
            // 
            this.islocked.Caption = "islocked";
            this.islocked.FieldName = "islocked";
            this.islocked.Name = "islocked";
            // 
            // ad_group_id
            // 
            this.ad_group_id.Caption = "groupid";
            this.ad_group_id.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ad_group_id.FieldName = "ad_group_id";
            this.ad_group_id.Name = "ad_group_id";
            this.ad_group_id.Visible = true;
            this.ad_group_id.VisibleIndex = 7;
            // 
            // ad_org_description
            // 
            this.ad_org_description.Caption = "organization";
            this.ad_org_description.FieldName = "ad_org_description";
            this.ad_org_description.Name = "ad_org_description";
            this.ad_org_description.OptionsColumn.AllowEdit = false;
            this.ad_org_description.Visible = true;
            this.ad_org_description.VisibleIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(697, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(194, 465);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Tạo người dùng";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnUserNew, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.btnUserSave, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtDescription, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtUsername, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtPassword, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lkBoPhan, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtGroup, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
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
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(98, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(89, 21);
            this.txtName.TabIndex = 3;
            // 
            // btnUserNew
            // 
            this.btnUserNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserNew.Image = ((System.Drawing.Image)(resources.GetObject("btnUserNew.Image")));
            this.btnUserNew.Location = new System.Drawing.Point(17, 183);
            this.btnUserNew.Name = "btnUserNew";
            this.btnUserNew.Size = new System.Drawing.Size(75, 23);
            this.btnUserNew.TabIndex = 6;
            this.btnUserNew.Text = "New";
            // 
            // btnUserSave
            // 
            this.btnUserSave.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSave.Image")));
            this.btnUserSave.Location = new System.Drawing.Point(98, 183);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(75, 23);
            this.btnUserSave.TabIndex = 7;
            this.btnUserSave.Text = "Save";
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Group:";
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(98, 33);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(89, 21);
            this.txtDescription.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Location = new System.Drawing.Point(98, 63);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(89, 21);
            this.txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(98, 93);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(89, 21);
            this.txtPassword.TabIndex = 10;
            // 
            // lkBoPhan
            // 
            this.lkBoPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkBoPhan.Location = new System.Drawing.Point(98, 153);
            this.lkBoPhan.Name = "lkBoPhan";
            this.lkBoPhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkBoPhan.Size = new System.Drawing.Size(89, 20);
            this.lkBoPhan.TabIndex = 5;
            this.lkBoPhan.ToolTip = "Chọn loại chứng từ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Organization:";
            // 
            // txtGroup
            // 
            this.txtGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGroup.Location = new System.Drawing.Point(98, 123);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Properties.Mask.BeepOnError = true;
            this.txtGroup.Properties.Mask.EditMask = "d";
            this.txtGroup.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGroup.Size = new System.Drawing.Size(89, 20);
            this.txtGroup.TabIndex = 11;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 521);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkBoPhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton export;
        private DevExpress.XtraGrid.GridControl grdNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton btnUserUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private LookUpEdit lkBoPhan;
        private SimpleButton btnUserNew;
        private SimpleButton btnUserSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn ad_user_id;
        private DevExpress.XtraGrid.Columns.GridColumn ad_client_id;
        private DevExpress.XtraGrid.Columns.GridColumn ad_org_id;
        private DevExpress.XtraGrid.Columns.GridColumn isactive;
        private DevExpress.XtraGrid.Columns.GridColumn updatedby;
        private DevExpress.XtraGrid.Columns.GridColumn created;
        private DevExpress.XtraGrid.Columns.GridColumn createdby;
        private DevExpress.XtraGrid.Columns.GridColumn updated;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraGrid.Columns.GridColumn password;
        private DevExpress.XtraGrid.Columns.GridColumn username;
        private DevExpress.XtraGrid.Columns.GridColumn default_ad_client_id;
        private DevExpress.XtraGrid.Columns.GridColumn default_ad_org_id;
        private DevExpress.XtraGrid.Columns.GridColumn default_ad_role_id;
        private DevExpress.XtraGrid.Columns.GridColumn islocked;
        private DevExpress.XtraGrid.Columns.GridColumn ad_group_id;
        private DevExpress.XtraGrid.Columns.GridColumn ad_org_description;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private TextEdit txtGroup;
    }
}