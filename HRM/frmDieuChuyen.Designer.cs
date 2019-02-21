namespace HRM
{
    partial class frmDieuChuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDieuChuyen));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grdDieuchuyen = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserFullCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescriptionVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TitleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserHireDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThuchien = new DevExpress.XtraEditors.SimpleButton();
            this.lkBoPhan = new DevExpress.XtraEditors.LookUpEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDieuchuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkBoPhan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grdDieuchuyen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grdDieuchuyen
            // 
            this.grdDieuchuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDieuchuyen.Location = new System.Drawing.Point(3, 43);
            this.grdDieuchuyen.MainView = this.gridView;
            this.grdDieuchuyen.Name = "grdDieuchuyen";
            this.grdDieuchuyen.Size = new System.Drawing.Size(681, 404);
            this.grdDieuchuyen.TabIndex = 0;
            this.grdDieuchuyen.UseEmbeddedNavigator = true;
            this.grdDieuchuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserFullCode,
            this.UserFullName,
            this.DescriptionVN,
            this.TitleName,
            this.UserHireDay});
            this.gridView.GridControl = this.grdDieuchuyen;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView.OptionsView.ShowGroupPanel = false;
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
            // DescriptionVN
            // 
            this.DescriptionVN.Caption = "Bộ phận";
            this.DescriptionVN.FieldName = "DescriptionVN";
            this.DescriptionVN.Name = "DescriptionVN";
            this.DescriptionVN.Visible = true;
            this.DescriptionVN.VisibleIndex = 2;
            // 
            // TitleName
            // 
            this.TitleName.Caption = "Chức vụ";
            this.TitleName.FieldName = "TitleName";
            this.TitleName.Name = "TitleName";
            this.TitleName.Visible = true;
            this.TitleName.VisibleIndex = 3;
            // 
            // UserHireDay
            // 
            this.UserHireDay.Caption = "Ngày vào làm";
            this.UserHireDay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.UserHireDay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.UserHireDay.FieldName = "UserHireDay";
            this.UserHireDay.Name = "UserHireDay";
            this.UserHireDay.Visible = true;
            this.UserHireDay.VisibleIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bộ phận:";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lkBoPhan, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnHuy, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnThuchien, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(681, 34);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(604, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(74, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnThuchien
            // 
            this.btnThuchien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThuchien.Image = global::HRM.Properties.Resources.ok;
            this.btnThuchien.Location = new System.Drawing.Point(524, 3);
            this.btnThuchien.Name = "btnThuchien";
            this.btnThuchien.Size = new System.Drawing.Size(74, 23);
            this.btnThuchien.TabIndex = 5;
            this.btnThuchien.Text = "Thực hiện";
            this.btnThuchien.Click += new System.EventHandler(this.btnThuchien_Click);
            // 
            // lkBoPhan
            // 
            this.lkBoPhan.Location = new System.Drawing.Point(83, 3);
            this.lkBoPhan.Name = "lkBoPhan";
            this.lkBoPhan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkBoPhan.Properties.Appearance.Options.UseFont = true;
            this.lkBoPhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkBoPhan.Size = new System.Drawing.Size(114, 22);
            this.lkBoPhan.TabIndex = 5;
            // 
            // frmDieuChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmDieuChuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Điều chuyển nhân sự";
            this.Load += new System.EventHandler(this.frmDieuChuyen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDieuchuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkBoPhan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl grdDieuchuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn UserFullCode;
        private DevExpress.XtraGrid.Columns.GridColumn UserFullName;
        private DevExpress.XtraGrid.Columns.GridColumn DescriptionVN;
        private DevExpress.XtraGrid.Columns.GridColumn TitleName;
        private DevExpress.XtraGrid.Columns.GridColumn UserHireDay;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.SimpleButton btnThuchien;
        private DevExpress.XtraEditors.LookUpEdit lkBoPhan;
    }
}