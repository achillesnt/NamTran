using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DevExpress.XtraGrid.Columns;

namespace HRM
{
    public partial class frmRoleDetail : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        string ad_role_id, ad_role_description;
        Utility utility = new Utility();
        DataTable dtUser = new DataTable();
        DataTable dtWindow = new DataTable();
        DataTable dtProcess = new DataTable();

        DataTable dtlkUser = new DataTable();
        DataTable dtlkWindow = new DataTable();
        DataTable dtlkProcess = new DataTable();

        DataTable dtProcessPermission = new DataTable();
        public frmRoleDetail()
        {
            InitializeComponent();
        }

        public frmRoleDetail(string _role_id, string _description, DataTable dtProcess)
        {
            InitializeComponent();
            this.ad_role_id = _role_id;
            this.ad_role_description = _description;
            this.dtProcessPermission = dtProcess;
            utility.SearchProcess(this.Controls, dtProcessPermission);

            this.dtlkUser = BUS_HeThong.LoadAdUser();
            this.dtlkWindow = BUS_HeThong.LoadLKWindow();
            this.dtlkProcess = BUS_HeThong.LoadLKProcess();

            this.dtUser = BUS_HeThong.LoadUserByRole(ad_role_id);
            this.dtWindow = BUS_HeThong.LoadWindowByRole(ad_role_id);
            this.dtProcess = BUS_HeThong.LoadProcessByRole(ad_role_id);

            repositoryItemCheckEdit1.ValueChecked = "Y";
            repositoryItemCheckEdit1.ValueUnchecked = "N";
            repositoryItemCheckEdit2.ValueChecked = "Y";
            repositoryItemCheckEdit2.ValueUnchecked = "N";
            repositoryItemCheckEdit3.ValueChecked = "Y";
            repositoryItemCheckEdit3.ValueUnchecked = "N";
        }

        private void btnRoleDetailUpdate_Click(object sender, EventArgs e)
        {
            string activeTab = xtraTabControl1.SelectedTabPage.Name.ToString();
            DataTable dt = new DataTable();
            dt = tabGridView(activeTab);
            switch (activeTab)
            {
                case "tabUser":
                    {
                        if (gridView1.SelectedRowsCount > 0)
                        {
                            string sKetQua = BUS_HeThong.UpdateUserRoles(dt, "btnRoleDetailUpdate");
                            if (string.IsNullOrEmpty(sKetQua))
                            {
                                MessageBox.Show(this, "Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(this, "Những username sau cập nhật không thành công: " + sKetQua, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
                case "tabWindow":
                    {
                        if (gridView2.SelectedRowsCount > 0)
                        {
                            string sKetQua = BUS_HeThong.UpdateWindowAccess(dt);
                            if (string.IsNullOrEmpty(sKetQua))
                            {
                                MessageBox.Show(this, "Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(this, "Những username sau cập nhật không thành công: " + sKetQua, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
                case "tabProcess":
                    {
                        if (gridView3.SelectedRowsCount > 0)
                        {
                            string sKetQua = BUS_HeThong.UpdateProcessAccess(dt);
                            if (string.IsNullOrEmpty(sKetQua))
                            {
                                MessageBox.Show(this, "Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(this, "Những username sau cập nhật không thành công: " + sKetQua, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
            }
        }

        private void btnRoleDetailDelete_Click(object sender, EventArgs e)
        {
            string activeTab = xtraTabControl1.SelectedTabPage.Name.ToString();
            DataTable dt = new DataTable();
            dt = tabGridView(activeTab);
            switch (activeTab)
            {
                case "tabUser":
                    {
                        if (gridView1.SelectedRowsCount > 0)
                        {
                            string sKetQua = BUS_HeThong.DeleteUserRoles(dt, "btnRoleDetailDelete");
                            if (string.IsNullOrEmpty(sKetQua))
                            {
                                MessageBox.Show(this, "Remove thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(this, "Những vai trò sau remove không thành công: " + sKetQua, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
                case "tabWindow":
                    {
                        if (gridView2.SelectedRowsCount > 0)
                        {
                            string sKetQua = BUS_HeThong.DeleteWindowAccess(dt);
                            if (string.IsNullOrEmpty(sKetQua))
                            {
                                MessageBox.Show(this, "Remove thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(this, "Những cửa sổ sau remove không thành công: " + sKetQua, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
                case "tabProcess":
                    {
                        if (gridView3.SelectedRowsCount > 0)
                        {
                            string sKetQua = BUS_HeThong.DeleteProcessAccess(dt);
                            if (string.IsNullOrEmpty(sKetQua))
                            {
                                MessageBox.Show(this, "Remove thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(this, "Những process sau remove không thành công: " + sKetQua, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
            }

        }

        private DataTable tabGridView(string tabName)
        {
            DataTable dt = new DataTable();
            switch(tabName)
            {
                case "tabUser":
                    {
                        #region Method 03    
                        int[] selectedRowHandles = gridView1.GetSelectedRows();
                        foreach (GridColumn column in gridView1.Columns)
                        {
                            dt.Columns.Add(column.FieldName, column.ColumnType);
                        }
                        for (int index = 0; index < selectedRowHandles.Length; index++)
                        {
                            DataRow row = dt.NewRow();
                            foreach (GridColumn column in gridView1.Columns)
                            {
                                row[column.FieldName] = gridView1.GetRowCellValue(selectedRowHandles[index], column);
                            }
                            dt.Rows.Add(row);
                        }
                        #endregion
                        break;
                    }
                case "tabWindow":
                    {
                        #region Method 03    
                        int[] selectedRowHandles = gridView2.GetSelectedRows();
                        foreach (GridColumn column in gridView2.Columns)
                        {
                            dt.Columns.Add(column.FieldName, column.ColumnType);
                        }
                        for (int index = 0; index < selectedRowHandles.Length; index++)
                        {
                            DataRow row = dt.NewRow();
                            foreach (GridColumn column in gridView2.Columns)
                            {
                                row[column.FieldName] = gridView2.GetRowCellValue(selectedRowHandles[index], column);
                            }
                            dt.Rows.Add(row);
                        }
                        #endregion
                        break;
                    }
                case "tabProcess":
                    {
                        #region Method 03    
                        int[] selectedRowHandles = gridView3.GetSelectedRows();
                        foreach (GridColumn column in gridView3.Columns)
                        {
                            dt.Columns.Add(column.FieldName, column.ColumnType);
                        }
                        for (int index = 0; index < selectedRowHandles.Length; index++)
                        {
                            DataRow row = dt.NewRow();
                            foreach (GridColumn column in gridView3.Columns)
                            {
                                row[column.FieldName] = gridView3.GetRowCellValue(selectedRowHandles[index], column);
                            }
                            dt.Rows.Add(row);
                        }
                        #endregion
                        break;
                    }
            }
            return dt;
        }

        private void btnRoleDetailUserSave_Click(object sender, EventArgs e)
        {
            string ad_user_id = lkUser.EditValue.ToString();
            if (BUS_HeThong.CreateUserRoles(ad_user_id, ad_role_id))
            {
                MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm người dùng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRoleDetailWindowSave_Click(object sender, EventArgs e)
        {
            string ad_window_id = lkWindow.EditValue.ToString();
            if (BUS_HeThong.CreateWindowAccess(ad_window_id, ad_role_id))
            {
                MessageBox.Show("Thêm cửa sổ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm cửa sổ không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRoleDetailProcessSave_Click(object sender, EventArgs e)
        {
            string ad_process_id = lkProcess.EditValue.ToString();
            if (BUS_HeThong.CreateProcessAccess(ad_process_id, ad_role_id))
            {
                MessageBox.Show("Thêm process thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm process không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRoleDetail_Load(object sender, EventArgs e)
        {
            gridUser.DataSource = dtUser;
            gridWindow.DataSource = dtWindow;
            gridProcess.DataSource = dtProcess;
            label2.Text = "Vai trò: " + ad_role_description;

            #region Xử lý lookupEdit

            lkUser.Properties.DataSource = dtlkUser;
            lkUser.Properties.DisplayMember = "username";
            lkUser.Properties.ValueMember = "id";
            lkUser.Properties.NullText = "Chọn bộ người dùng";
            lkUser.EditValue = dtlkUser.Rows[0][0];

            lkUser.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkUser.Properties.DropDownRows = dtlkUser.Rows.Count;
            //lkInput.Properties.ReadOnly = true  

            lkWindow.Properties.DataSource = dtlkWindow;
            lkWindow.Properties.DisplayMember = "description";
            lkWindow.Properties.ValueMember = "id";
            lkWindow.Properties.NullText = "Chọn cửa sổ";
            lkWindow.EditValue = dtlkUser.Rows[0][0];

            lkWindow.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkWindow.Properties.DropDownRows = dtlkWindow.Rows.Count;
            //lkInput.Properties.ReadOnly = true  

            lkProcess.Properties.DataSource = dtlkProcess;
            lkProcess.Properties.DisplayMember = "description";
            lkProcess.Properties.ValueMember = "id";
            lkProcess.Properties.NullText = "Chọn quy trình";
            lkProcess.EditValue = dtlkProcess.Rows[0][0];

            lkProcess.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkProcess.Properties.DropDownRows = dtlkProcess.Rows.Count;
            //lkInput.Properties.ReadOnly = true  
            #endregion
        }


    }
}