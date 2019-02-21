using DevExpress.XtraEditors;

namespace HRM
{
    partial class frmUserRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserRoles));
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUserRolesUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserRolesDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserRolesCreate = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lkRole = new DevExpress.XtraEditors.LookUpEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grdUserRoles = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ad_user_roles_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad_user_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad_role_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ad_role_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad_role_description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkRole.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(751, 363);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 359);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnUserRolesUpdate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUserRolesDelete, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUserRolesCreate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lkRole, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(741, 34);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnUserRolesUpdate
            // 
            this.btnUserRolesUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserRolesUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUserRolesUpdate.Image")));
            this.btnUserRolesUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnUserRolesUpdate.Name = "btnUserRolesUpdate";
            this.btnUserRolesUpdate.Size = new System.Drawing.Size(94, 28);
            this.btnUserRolesUpdate.TabIndex = 4;
            this.btnUserRolesUpdate.Text = "Update";
            this.btnUserRolesUpdate.ToolTip = "Cập nhật dữ liệu bên dưới";
            this.btnUserRolesUpdate.Click += new System.EventHandler(this.btnUserRolesUpdate_Click);
            // 
            // btnUserRolesDelete
            // 
            this.btnUserRolesDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserRolesDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnUserRolesDelete.Image")));
            this.btnUserRolesDelete.Location = new System.Drawing.Point(103, 3);
            this.btnUserRolesDelete.Name = "btnUserRolesDelete";
            this.btnUserRolesDelete.Size = new System.Drawing.Size(94, 28);
            this.btnUserRolesDelete.TabIndex = 4;
            this.btnUserRolesDelete.Text = "Delete";
            this.btnUserRolesDelete.ToolTip = "Trích xuất nội dung danh sách bên dưới ra excel";
            this.btnUserRolesDelete.Click += new System.EventHandler(this.btnUserRolesDelete_Click);
            // 
            // btnUserRolesCreate
            // 
            this.btnUserRolesCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserRolesCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnUserRolesCreate.Image")));
            this.btnUserRolesCreate.Location = new System.Drawing.Point(203, 3);
            this.btnUserRolesCreate.Name = "btnUserRolesCreate";
            this.btnUserRolesCreate.Size = new System.Drawing.Size(94, 28);
            this.btnUserRolesCreate.TabIndex = 7;
            this.btnUserRolesCreate.Text = "Create";
            this.btnUserRolesCreate.Click += new System.EventHandler(this.btnUserRolesCreate_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vai trò:";
            // 
            // lkRole
            // 
            this.lkRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lkRole.Location = new System.Drawing.Point(403, 3);
            this.lkRole.Name = "lkRole";
            this.lkRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkRole.Size = new System.Drawing.Size(194, 20);
            this.lkRole.TabIndex = 5;
            this.lkRole.ToolTip = "Chọn loại chứng từ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.grdUserRoles, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(741, 313);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // grdUserRoles
            // 
            this.grdUserRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUserRoles.Location = new System.Drawing.Point(3, 3);
            this.grdUserRoles.MainView = this.gridView1;
            this.grdUserRoles.Name = "grdUserRoles";
            this.grdUserRoles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1});
            this.grdUserRoles.Size = new System.Drawing.Size(735, 307);
            this.grdUserRoles.TabIndex = 2;
            this.grdUserRoles.UseEmbeddedNavigator = true;
            this.grdUserRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ad_user_roles_id,
            this.ad_user_id,
            this.ad_role_id,
            this.isactive,
            this.ad_role_name,
            this.ad_role_description});
            this.gridView1.GridControl = this.grdUserRoles;
            this.gridView1.GroupPanelText = "DANH SÁCH PHIẾU NHẬP SẢN LƯỢNG";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ad_user_roles_id
            // 
            this.ad_user_roles_id.Caption = "ad_user_roles_id";
            this.ad_user_roles_id.FieldName = "ad_user_roles_id";
            this.ad_user_roles_id.Name = "ad_user_roles_id";
            // 
            // ad_user_id
            // 
            this.ad_user_id.Caption = "ad_user_id";
            this.ad_user_id.FieldName = "ad_user_id";
            this.ad_user_id.Name = "ad_user_id";
            // 
            // ad_role_id
            // 
            this.ad_role_id.Caption = "ad_role_id";
            this.ad_role_id.FieldName = "ad_role_id";
            this.ad_role_id.Name = "ad_role_id";
            // 
            // isactive
            // 
            this.isactive.Caption = "isactive";
            this.isactive.ColumnEdit = this.repositoryItemCheckEdit1;
            this.isactive.FieldName = "isactive";
            this.isactive.Name = "isactive";
            this.isactive.Visible = true;
            this.isactive.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // ad_role_name
            // 
            this.ad_role_name.Caption = "name";
            this.ad_role_name.FieldName = "ad_role_name";
            this.ad_role_name.Name = "ad_role_name";
            this.ad_role_name.Visible = true;
            this.ad_role_name.VisibleIndex = 1;
            // 
            // ad_role_description
            // 
            this.ad_role_description.Caption = "description";
            this.ad_role_description.FieldName = "ad_role_description";
            this.ad_role_description.Name = "ad_role_description";
            this.ad_role_description.Visible = true;
            this.ad_role_description.VisibleIndex = 2;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // frmUserRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 363);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.Name = "frmUserRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý vai trò người dùng";
            this.Load += new System.EventHandler(this.frmUserRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkRole.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUserRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnUserRolesDelete;
        private DevExpress.XtraGrid.GridControl grdUserRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton btnUserRolesUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private LookUpEdit lkRole;
        private SimpleButton btnUserRolesCreate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn ad_user_roles_id;
        private DevExpress.XtraGrid.Columns.GridColumn ad_user_id;
        private DevExpress.XtraGrid.Columns.GridColumn ad_role_id;
        private DevExpress.XtraGrid.Columns.GridColumn isactive;
        private DevExpress.XtraGrid.Columns.GridColumn ad_role_name;
        private DevExpress.XtraGrid.Columns.GridColumn ad_role_description;
    }
}