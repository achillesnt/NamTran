namespace HRM
{
    partial class frmPhanCa
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayHieuLuc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lkShift = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserFullCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TitleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescriptionVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserHireDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShiftArrSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkShift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(653, 342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpNgayHieuLuc, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lkShift, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(647, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày hiệu lực:";
            // 
            // dtpNgayHieuLuc
            // 
            this.dtpNgayHieuLuc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHieuLuc.Location = new System.Drawing.Point(123, 3);
            this.dtpNgayHieuLuc.Name = "dtpNgayHieuLuc";
            this.dtpNgayHieuLuc.Size = new System.Drawing.Size(104, 23);
            this.dtpNgayHieuLuc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên ca:";
            // 
            // lkShift
            // 
            this.lkShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkShift.Location = new System.Drawing.Point(313, 3);
            this.lkShift.Name = "lkShift";
            this.lkShift.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkShift.Size = new System.Drawing.Size(104, 20);
            this.lkShift.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 83);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(647, 256);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserFullCode,
            this.UserFullName,
            this.TitleName,
            this.DescriptionVN,
            this.UserHireDay});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // UserFullCode
            // 
            this.UserFullCode.Caption = "Mã NV";
            this.UserFullCode.FieldName = "UserFullCode";
            this.UserFullCode.Name = "UserFullCode";
            this.UserFullCode.Visible = true;
            this.UserFullCode.VisibleIndex = 0;
            // 
            // UserFullName
            // 
            this.UserFullName.Caption = "Họ và tên";
            this.UserFullName.FieldName = "UserFullName";
            this.UserFullName.Name = "UserFullName";
            this.UserFullName.Visible = true;
            this.UserFullName.VisibleIndex = 1;
            // 
            // TitleName
            // 
            this.TitleName.Caption = "Chức vụ";
            this.TitleName.FieldName = "TitleName";
            this.TitleName.Name = "TitleName";
            this.TitleName.Visible = true;
            this.TitleName.VisibleIndex = 2;
            // 
            // DescriptionVN
            // 
            this.DescriptionVN.Caption = "Bộ phận";
            this.DescriptionVN.FieldName = "DescriptionVN";
            this.DescriptionVN.Name = "DescriptionVN";
            this.DescriptionVN.Visible = true;
            this.DescriptionVN.VisibleIndex = 3;
            // 
            // UserHireDay
            // 
            this.UserHireDay.Caption = "Ngày vào làm";
            this.UserHireDay.DisplayFormat.FormatString = "d";
            this.UserHireDay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.UserHireDay.FieldName = "UserHireDay";
            this.UserHireDay.Name = "UserHireDay";
            this.UserHireDay.Visible = true;
            this.UserHireDay.VisibleIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnShiftArrSubmit, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnHuy, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(647, 34);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnShiftArrSubmit
            // 
            this.btnShiftArrSubmit.Image = global::HRM.Properties.Resources.ok;
            this.btnShiftArrSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnShiftArrSubmit.Name = "btnShiftArrSubmit";
            this.btnShiftArrSubmit.Size = new System.Drawing.Size(74, 23);
            this.btnShiftArrSubmit.TabIndex = 0;
            this.btnShiftArrSubmit.Text = "Submit";
            this.btnShiftArrSubmit.Click += new System.EventHandler(this.btnThucThi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::HRM.Properties.Resources.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(83, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Cancel";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmPhanCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 342);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmPhanCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phân Ca";
            this.Load += new System.EventHandler(this.frmPhanCa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkShift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayHieuLuc;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton btnShiftArrSubmit;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraGrid.Columns.GridColumn UserFullCode;
        private DevExpress.XtraGrid.Columns.GridColumn UserFullName;
        private DevExpress.XtraGrid.Columns.GridColumn TitleName;
        private DevExpress.XtraGrid.Columns.GridColumn DescriptionVN;
        private DevExpress.XtraGrid.Columns.GridColumn UserHireDay;
        private DevExpress.XtraEditors.LookUpEdit lkShift;
    }
}