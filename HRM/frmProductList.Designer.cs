using DevExpress.XtraEditors;

namespace HRM
{
    partial class frmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductList));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtLoKho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhomVT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.checkEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.grdProductList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.product_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.product_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.product_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.product_description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.category_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unit_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.warehouse_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.product_note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.location = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.warehouse_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unit_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.category_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.currency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.minimum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProductListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnProductListEdit = new DevExpress.XtraEditors.SimpleButton();
            this.Export = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTrangThai = new System.Windows.Forms.Label();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::HRM.WaitForm1), true, true);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit.Properties)).BeginInit();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 613);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tableLayoutPanel2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(833, 194);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Thông tin chi tiết";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(829, 172);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(823, 166);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtMaVT, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtTenVT, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtMoTa, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtDonVi, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtViTri, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtLoKho, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtNhomVT, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtTonKho, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtGhiChu, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.checkEdit, 3, 4);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(817, 160);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label1.Location = new System.Drawing.Point(29, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã VT:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên VT:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label3.Location = new System.Drawing.Point(35, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label4.Location = new System.Drawing.Point(600, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn vị:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label5.Location = new System.Drawing.Point(609, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vị trí:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label6.Location = new System.Drawing.Point(600, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lô kho:";
            // 
            // txtMaVT
            // 
            this.txtMaVT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaVT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVT.Location = new System.Drawing.Point(84, 3);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(484, 22);
            this.txtMaVT.TabIndex = 5;
            // 
            // txtTenVT
            // 
            this.txtTenVT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenVT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVT.Location = new System.Drawing.Point(84, 35);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(484, 22);
            this.txtTenVT.TabIndex = 5;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(84, 67);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(484, 22);
            this.txtMoTa.TabIndex = 5;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDonVi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(655, 3);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(159, 22);
            this.txtDonVi.TabIndex = 6;
            // 
            // txtViTri
            // 
            this.txtViTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtViTri.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTri.Location = new System.Drawing.Point(655, 35);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(159, 22);
            this.txtViTri.TabIndex = 7;
            // 
            // txtLoKho
            // 
            this.txtLoKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLoKho.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoKho.Location = new System.Drawing.Point(655, 67);
            this.txtLoKho.Name = "txtLoKho";
            this.txtLoKho.Size = new System.Drawing.Size(159, 22);
            this.txtLoKho.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label7.Location = new System.Drawing.Point(11, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhóm VT:";
            // 
            // txtNhomVT
            // 
            this.txtNhomVT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhomVT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhomVT.Location = new System.Drawing.Point(84, 99);
            this.txtNhomVT.Name = "txtNhomVT";
            this.txtNhomVT.Size = new System.Drawing.Size(484, 22);
            this.txtNhomVT.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label8.Location = new System.Drawing.Point(597, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tồn TT:";
            // 
            // txtTonKho
            // 
            this.txtTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTonKho.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTonKho.Location = new System.Drawing.Point(655, 99);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(159, 22);
            this.txtTonKho.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label9.Location = new System.Drawing.Point(591, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Is Active:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label10.Location = new System.Drawing.Point(23, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(84, 131);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(484, 22);
            this.txtGhiChu.TabIndex = 5;
            // 
            // checkEdit
            // 
            this.checkEdit.Location = new System.Drawing.Point(655, 131);
            this.checkEdit.Name = "checkEdit";
            this.checkEdit.Properties.Caption = "";
            this.checkEdit.Size = new System.Drawing.Size(114, 19);
            this.checkEdit.TabIndex = 9;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Controls.Add(this.grdProductList, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 243);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(833, 367);
            this.tableLayoutPanel12.TabIndex = 3;
            // 
            // grdProductList
            // 
            this.grdProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProductList.Location = new System.Drawing.Point(3, 3);
            this.grdProductList.MainView = this.gridView1;
            this.grdProductList.Name = "grdProductList";
            this.grdProductList.Size = new System.Drawing.Size(827, 361);
            this.grdProductList.TabIndex = 1;
            this.grdProductList.UseEmbeddedNavigator = true;
            this.grdProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdProductList.Click += new System.EventHandler(this.grdProductList_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.product_id,
            this.product_code,
            this.product_name,
            this.product_description,
            this.category_id,
            this.unit_id,
            this.warehouse_id,
            this.product_note,
            this.location,
            this.isactive,
            this.warehouse_name,
            this.unit_name,
            this.category_name,
            this.value,
            this.currency,
            this.minimum});
            this.gridView1.GridControl = this.grdProductList;
            this.gridView1.GroupPanelText = "Danh sách nhân viên";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // product_id
            // 
            this.product_id.Caption = "product_id";
            this.product_id.FieldName = "product_id";
            this.product_id.Name = "product_id";
            // 
            // product_code
            // 
            this.product_code.Caption = "Mã VT";
            this.product_code.FieldName = "product_code";
            this.product_code.Name = "product_code";
            this.product_code.Visible = true;
            this.product_code.VisibleIndex = 0;
            this.product_code.Width = 104;
            // 
            // product_name
            // 
            this.product_name.Caption = "Tên VT";
            this.product_name.FieldName = "product_name";
            this.product_name.Name = "product_name";
            this.product_name.Visible = true;
            this.product_name.VisibleIndex = 1;
            this.product_name.Width = 224;
            // 
            // product_description
            // 
            this.product_description.Caption = "Mô Tả";
            this.product_description.FieldName = "product_description";
            this.product_description.Name = "product_description";
            this.product_description.Visible = true;
            this.product_description.VisibleIndex = 2;
            this.product_description.Width = 128;
            // 
            // category_id
            // 
            this.category_id.Caption = "category_id";
            this.category_id.FieldName = "category_id";
            this.category_id.Name = "category_id";
            // 
            // unit_id
            // 
            this.unit_id.Caption = "unit_id";
            this.unit_id.FieldName = "unit_id";
            this.unit_id.Name = "unit_id";
            // 
            // warehouse_id
            // 
            this.warehouse_id.Caption = "warehouse_id";
            this.warehouse_id.FieldName = "warehouse_id";
            this.warehouse_id.Name = "warehouse_id";
            // 
            // product_note
            // 
            this.product_note.Caption = "Ghi Chú";
            this.product_note.FieldName = "product_note";
            this.product_note.Name = "product_note";
            // 
            // location
            // 
            this.location.Caption = "Vị Trí";
            this.location.FieldName = "location";
            this.location.Name = "location";
            // 
            // isactive
            // 
            this.isactive.Caption = "isactive";
            this.isactive.FieldName = "isactive";
            this.isactive.Name = "isactive";
            // 
            // warehouse_name
            // 
            this.warehouse_name.Caption = "Lưu Kho";
            this.warehouse_name.FieldName = "warehouse_name";
            this.warehouse_name.Name = "warehouse_name";
            // 
            // unit_name
            // 
            this.unit_name.Caption = "Đơn Vị";
            this.unit_name.FieldName = "unit_name";
            this.unit_name.Name = "unit_name";
            this.unit_name.Visible = true;
            this.unit_name.VisibleIndex = 4;
            this.unit_name.Width = 67;
            // 
            // category_name
            // 
            this.category_name.Caption = "Nhóm VT";
            this.category_name.FieldName = "category_name";
            this.category_name.Name = "category_name";
            this.category_name.Visible = true;
            this.category_name.VisibleIndex = 3;
            this.category_name.Width = 67;
            // 
            // value
            // 
            this.value.Caption = "Đơn Giá";
            this.value.DisplayFormat.FormatString = "#,#.00";
            this.value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.value.FieldName = "value";
            this.value.Name = "value";
            this.value.Visible = true;
            this.value.VisibleIndex = 5;
            this.value.Width = 67;
            // 
            // currency
            // 
            this.currency.Caption = "Tiền Tệ";
            this.currency.FieldName = "currency";
            this.currency.Name = "currency";
            this.currency.Visible = true;
            this.currency.VisibleIndex = 6;
            this.currency.Width = 77;
            // 
            // minimum
            // 
            this.minimum.Caption = "minimum";
            this.minimum.FieldName = "minimum";
            this.minimum.Name = "minimum";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 34);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 7;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel9.Controls.Add(this.btnProductListAdd, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnProductListEdit, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.Export, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.simpleButton1, 6, 0);
            this.tableLayoutPanel9.Controls.Add(this.txtTrangThai, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.txtTimKiem, 5, 0);
            this.tableLayoutPanel9.Controls.Add(this.label11, 4, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(831, 32);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // btnProductListAdd
            // 
            this.btnProductListAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProductListAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnProductListAdd.Image")));
            this.btnProductListAdd.Location = new System.Drawing.Point(3, 4);
            this.btnProductListAdd.Name = "btnProductListAdd";
            this.btnProductListAdd.Size = new System.Drawing.Size(69, 23);
            this.btnProductListAdd.TabIndex = 5;
            this.btnProductListAdd.Text = "Thêm";
            this.btnProductListAdd.ToolTip = "Tạo mới";
            this.btnProductListAdd.Click += new System.EventHandler(this.btnProductListAdd_Click);
            // 
            // btnProductListEdit
            // 
            this.btnProductListEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProductListEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnProductListEdit.Image")));
            this.btnProductListEdit.Location = new System.Drawing.Point(78, 4);
            this.btnProductListEdit.Name = "btnProductListEdit";
            this.btnProductListEdit.Size = new System.Drawing.Size(69, 23);
            this.btnProductListEdit.TabIndex = 6;
            this.btnProductListEdit.Text = "Sửa";
            this.btnProductListEdit.ToolTip = "Sửa thông tin vật tư";
            this.btnProductListEdit.Click += new System.EventHandler(this.btnProductListEdit_Click);
            // 
            // Export
            // 
            this.Export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Export.Image = ((System.Drawing.Image)(resources.GetObject("Export.Image")));
            this.Export.Location = new System.Drawing.Point(153, 4);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(69, 23);
            this.Export.TabIndex = 7;
            this.Export.Text = "Export";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(759, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(69, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.ToolTip = "Tìm theo tên";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.AutoSize = true;
            this.txtTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.txtTrangThai.ForeColor = System.Drawing.Color.Transparent;
            this.txtTrangThai.Location = new System.Drawing.Point(228, 0);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(41, 13);
            this.txtTrangThai.TabIndex = 9;
            this.txtTrangThai.Text = "label11";
            this.txtTrangThai.TextChanged += new System.EventHandler(this.txtTrangThai_TextChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.Location = new System.Drawing.Point(609, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(144, 20);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.ToolTip = "Nhập tên vật tư cần tìm";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label11.Location = new System.Drawing.Point(551, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên VT:";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 613);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmProductList";
            this.Text = "Quản lý danh mục vật tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProductList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit.Properties)).EndInit();
            this.tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.TextBox txtLoKho;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private DevExpress.XtraGrid.GridControl grdProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnProductListAdd;
        private DevExpress.XtraEditors.SimpleButton btnProductListEdit;
        private DevExpress.XtraEditors.SimpleButton Export;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNhomVT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn product_id;
        private DevExpress.XtraGrid.Columns.GridColumn product_code;
        private DevExpress.XtraGrid.Columns.GridColumn product_name;
        private DevExpress.XtraGrid.Columns.GridColumn product_description;
        private DevExpress.XtraGrid.Columns.GridColumn category_id;
        private DevExpress.XtraGrid.Columns.GridColumn unit_id;
        private DevExpress.XtraGrid.Columns.GridColumn warehouse_id;
        private DevExpress.XtraGrid.Columns.GridColumn product_note;
        private DevExpress.XtraGrid.Columns.GridColumn location;
        private DevExpress.XtraGrid.Columns.GridColumn isactive;
        private DevExpress.XtraGrid.Columns.GridColumn warehouse_name;
        private DevExpress.XtraGrid.Columns.GridColumn unit_name;
        private DevExpress.XtraGrid.Columns.GridColumn category_name;
        private DevExpress.XtraGrid.Columns.GridColumn value;
        private DevExpress.XtraGrid.Columns.GridColumn currency;
        private DevExpress.XtraGrid.Columns.GridColumn minimum;
        private SimpleButton simpleButton1;
        private CheckEdit checkEdit;
        private System.Windows.Forms.Label txtTrangThai;
        private TextEdit txtTimKiem;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.Label label11;
    }
}