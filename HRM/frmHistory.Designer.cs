namespace HRM
{
    partial class frmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistory));
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelTong = new System.Windows.Forms.TableLayoutPanel();
            this.panelContentTotal = new System.Windows.Forms.TableLayoutPanel();
            this.panelContentControl = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lkBoPhan = new DevExpress.XtraEditors.LookUpEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.export = new DevExpress.XtraEditors.SimpleButton();
            this.search = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.staffid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userfullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userhiredate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userbirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.useridcard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deptid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deptdescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.historytype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beforecontent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aftercontent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created = new DevExpress.XtraGrid.Columns.GridColumn();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl();
            this.splashScreenManager5 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::HRM.WaitForm1), true, true);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.panelTong.SuspendLayout();
            this.panelContentTotal.SuspendLayout();
            this.panelContentControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkBoPhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // panelTong
            // 
            this.panelTong.ColumnCount = 1;
            this.panelTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTong.Controls.Add(this.panelContentTotal, 0, 0);
            this.panelTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTong.Location = new System.Drawing.Point(0, 0);
            this.panelTong.Name = "panelTong";
            this.panelTong.RowCount = 1;
            this.panelTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTong.Size = new System.Drawing.Size(789, 476);
            this.panelTong.TabIndex = 0;
            // 
            // panelContentTotal
            // 
            this.panelContentTotal.ColumnCount = 1;
            this.panelContentTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContentTotal.Controls.Add(this.panelContentControl, 0, 0);
            this.panelContentTotal.Controls.Add(this.gridControl, 0, 1);
            this.panelContentTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentTotal.Location = new System.Drawing.Point(3, 3);
            this.panelContentTotal.Name = "panelContentTotal";
            this.panelContentTotal.RowCount = 2;
            this.panelContentTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panelContentTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContentTotal.Size = new System.Drawing.Size(783, 470);
            this.panelContentTotal.TabIndex = 0;
            // 
            // panelContentControl
            // 
            this.panelContentControl.ColumnCount = 9;
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panelContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panelContentControl.Controls.Add(this.label3, 0, 0);
            this.panelContentControl.Controls.Add(this.label4, 2, 0);
            this.panelContentControl.Controls.Add(this.label5, 4, 0);
            this.panelContentControl.Controls.Add(this.lkBoPhan, 1, 0);
            this.panelContentControl.Controls.Add(this.dateEdit1, 3, 0);
            this.panelContentControl.Controls.Add(this.dateEdit2, 5, 0);
            this.panelContentControl.Controls.Add(this.export, 8, 0);
            this.panelContentControl.Controls.Add(this.search, 7, 0);
            this.panelContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentControl.Location = new System.Drawing.Point(3, 3);
            this.panelContentControl.Name = "panelContentControl";
            this.panelContentControl.RowCount = 1;
            this.panelContentControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContentControl.Size = new System.Drawing.Size(777, 29);
            this.panelContentControl.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bộ phận:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ ngày:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đến ngày:";
            // 
            // lkBoPhan
            // 
            this.lkBoPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkBoPhan.Location = new System.Drawing.Point(73, 3);
            this.lkBoPhan.Name = "lkBoPhan";
            this.lkBoPhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkBoPhan.Size = new System.Drawing.Size(114, 20);
            this.lkBoPhan.TabIndex = 6;
            // 
            // dateEdit1
            // 
            this.dateEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(263, 3);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(114, 20);
            this.dateEdit1.TabIndex = 7;
            // 
            // dateEdit2
            // 
            this.dateEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(453, 3);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(114, 20);
            this.dateEdit2.TabIndex = 8;
            // 
            // export
            // 
            this.export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.export.Image = ((System.Drawing.Image)(resources.GetObject("export.Image")));
            this.export.Location = new System.Drawing.Point(700, 3);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(74, 23);
            this.export.TabIndex = 10;
            this.export.Text = "Export";
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(620, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(74, 23);
            this.search.TabIndex = 9;
            this.search.Text = "Search";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(3, 38);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(777, 429);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.staffid,
            this.userfullname,
            this.userhiredate,
            this.userbirthday,
            this.useridcard,
            this.deptid,
            this.deptdescription,
            this.historytype,
            this.beforecontent,
            this.aftercontent,
            this.created});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            // 
            // staffid
            // 
            this.staffid.Caption = "Mã NV";
            this.staffid.FieldName = "staffid";
            this.staffid.Name = "staffid";
            this.staffid.OptionsColumn.AllowEdit = false;
            this.staffid.Visible = true;
            this.staffid.VisibleIndex = 0;
            // 
            // userfullname
            // 
            this.userfullname.Caption = "Họ tên";
            this.userfullname.FieldName = "userfullname";
            this.userfullname.Name = "userfullname";
            this.userfullname.OptionsColumn.AllowEdit = false;
            this.userfullname.Visible = true;
            this.userfullname.VisibleIndex = 1;
            // 
            // userhiredate
            // 
            this.userhiredate.Caption = "Ngày vào làm";
            this.userhiredate.FieldName = "userhiredate";
            this.userhiredate.Name = "userhiredate";
            this.userhiredate.OptionsColumn.AllowEdit = false;
            this.userhiredate.Visible = true;
            this.userhiredate.VisibleIndex = 2;
            // 
            // userbirthday
            // 
            this.userbirthday.Caption = "Ngày sinh";
            this.userbirthday.FieldName = "userbirthday";
            this.userbirthday.Name = "userbirthday";
            this.userbirthday.OptionsColumn.AllowEdit = false;
            // 
            // useridcard
            // 
            this.useridcard.Caption = "Số CMND";
            this.useridcard.FieldName = "useridcard";
            this.useridcard.Name = "useridcard";
            this.useridcard.OptionsColumn.AllowEdit = false;
            // 
            // deptid
            // 
            this.deptid.Caption = "deptid";
            this.deptid.FieldName = "deptid";
            this.deptid.Name = "deptid";
            this.deptid.OptionsColumn.AllowEdit = false;
            // 
            // deptdescription
            // 
            this.deptdescription.Caption = "Bộ phận hiện tại";
            this.deptdescription.FieldName = "deptdescription";
            this.deptdescription.Name = "deptdescription";
            this.deptdescription.OptionsColumn.AllowEdit = false;
            this.deptdescription.Visible = true;
            this.deptdescription.VisibleIndex = 3;
            // 
            // historytype
            // 
            this.historytype.Caption = "Loại thay đổi";
            this.historytype.FieldName = "historytype";
            this.historytype.Name = "historytype";
            this.historytype.OptionsColumn.AllowEdit = false;
            this.historytype.Visible = true;
            this.historytype.VisibleIndex = 4;
            // 
            // beforecontent
            // 
            this.beforecontent.Caption = "Trước thay đổi";
            this.beforecontent.FieldName = "beforecontent";
            this.beforecontent.Name = "beforecontent";
            this.beforecontent.OptionsColumn.AllowEdit = false;
            this.beforecontent.Visible = true;
            this.beforecontent.VisibleIndex = 5;
            // 
            // aftercontent
            // 
            this.aftercontent.Caption = "Sau thay đổi";
            this.aftercontent.FieldName = "aftercontent";
            this.aftercontent.Name = "aftercontent";
            this.aftercontent.OptionsColumn.AllowEdit = false;
            this.aftercontent.Visible = true;
            this.aftercontent.VisibleIndex = 6;
            // 
            // created
            // 
            this.created.Caption = "Thời gian";
            this.created.FieldName = "created";
            this.created.Name = "created";
            this.created.OptionsColumn.AllowEdit = false;
            this.created.Visible = true;
            this.created.VisibleIndex = 7;
            // 
            // alertControl1
            // 
            this.alertControl1.AutoHeight = true;
            this.alertControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.CornflowerBlue;
            this.alertControl1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.alertControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // splashScreenManager5
            // 
            this.splashScreenManager5.ClosingDelay = 500;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 476);
            this.Controls.Add(this.panelTong);
            this.MaximizeBox = false;
            this.Name = "frmHistory";
            this.Text = "Báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.panelTong.ResumeLayout(false);
            this.panelContentTotal.ResumeLayout(false);
            this.panelContentControl.ResumeLayout(false);
            this.panelContentControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkBoPhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelTong;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager3;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager5;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.TableLayoutPanel panelContentTotal;
        private System.Windows.Forms.TableLayoutPanel panelContentControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LookUpEdit lkBoPhan;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.SimpleButton export;
        private DevExpress.XtraEditors.SimpleButton search;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn staffid;
        private DevExpress.XtraGrid.Columns.GridColumn userfullname;
        private DevExpress.XtraGrid.Columns.GridColumn userhiredate;
        private DevExpress.XtraGrid.Columns.GridColumn userbirthday;
        private DevExpress.XtraGrid.Columns.GridColumn useridcard;
        private DevExpress.XtraGrid.Columns.GridColumn deptid;
        private DevExpress.XtraGrid.Columns.GridColumn deptdescription;
        private DevExpress.XtraGrid.Columns.GridColumn historytype;
        private DevExpress.XtraGrid.Columns.GridColumn beforecontent;
        private DevExpress.XtraGrid.Columns.GridColumn aftercontent;
        private DevExpress.XtraGrid.Columns.GridColumn created;
    }
}