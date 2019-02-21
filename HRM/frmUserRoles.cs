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
    public partial class frmUserRoles : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        string v_ad_user_id, v_ad_org_id, v_ad_org_description;
        Utility utility = new Utility();
        DataTable dtUserRoles = new DataTable();
        DataTable dtRole = new DataTable();
        DataTable dtProcess = new DataTable();

        private void frmUserRoles_Load(object sender, EventArgs e)
        {
            #region Xử lý lookupEdit
            lkRole.Properties.DataSource = dtRole;
            lkRole.Properties.DisplayMember = "description";
            lkRole.Properties.ValueMember = "id";
            lkRole.Properties.NullText = "Chọn vai trò";
            lkRole.EditValue = dtRole.Rows[0][0];

            lkRole.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkRole.Properties.DropDownRows = dtRole.Rows.Count;
            //lkInput.Properties.ReadOnly = true  
            #endregion

            grdUserRoles.DataSource = dtUserRoles;
            repositoryItemCheckEdit1.ValueChecked = "Y";
            repositoryItemCheckEdit1.ValueUnchecked = "N";
        }

        private void btnUserRolesUpdate_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                #region Method 03    
                int[] selectedRowHandles = gridView1.GetSelectedRows();
                DataTable dtUpdateUserRoles = new DataTable();
                foreach (GridColumn column in gridView1.Columns)
                {
                    dtUpdateUserRoles.Columns.Add(column.FieldName, column.ColumnType);
                }
                for (int index = 0; index < selectedRowHandles.Length; index++)
                {
                    DataRow row = dtUpdateUserRoles.NewRow();
                    foreach (GridColumn column in gridView1.Columns)
                    {
                        row[column.FieldName] = gridView1.GetRowCellValue(selectedRowHandles[index], column);
                    }
                    dtUpdateUserRoles.Rows.Add(row);
                }
                #endregion   
                string sKetQua = BUS_HeThong.UpdateUserRoles(dtUpdateUserRoles, "btnUserRolesUpdate");
                if (string.IsNullOrEmpty(sKetQua))
                {
                    MessageBox.Show(this, "Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Những vai trò sau cập nhật không thành công: " + sKetQua, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUserRolesDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                #region Method 03    
                int[] selectedRowHandles = gridView1.GetSelectedRows();
                DataTable dtDeleteUserRoles = new DataTable();
                foreach (GridColumn column in gridView1.Columns)
                {
                    dtDeleteUserRoles.Columns.Add(column.FieldName, column.ColumnType);
                }
                for (int index = 0; index < selectedRowHandles.Length; index++)
                {
                    DataRow row = dtDeleteUserRoles.NewRow();
                    foreach (GridColumn column in gridView1.Columns)
                    {
                        row[column.FieldName] = gridView1.GetRowCellValue(selectedRowHandles[index], column);
                    }
                    dtDeleteUserRoles.Rows.Add(row);
                }
                #endregion   
                string sKetQua = BUS_HeThong.DeleteUserRoles(dtDeleteUserRoles, "btnUserRolesDelete");
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
        }

        private void btnUserRolesCreate_Click(object sender, EventArgs e)
        {
            string v_role_id = lkRole.EditValue.ToString();
            bool sKetQua = BUS_HeThong.CreateUserRoles(v_ad_user_id, v_role_id);
            if(sKetQua)
            {
                MessageBox.Show("Gán vai trò cho người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gán vai trò cho người dùng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmUserRoles()
        {
            InitializeComponent();
        }

        public frmUserRoles(string v_ad_user_id, DataTable dtProcess)
        {
            InitializeComponent();
            this.dtRole = BUS_HeThong.LoadRole();           
            this.v_ad_user_id = v_ad_user_id;
            this.dtProcess = dtProcess;
            utility.SearchProcess(this.Controls, dtProcess);
            this.dtUserRoles = BUS_HeThong.LoadUserRoles(v_ad_user_id);
        }
    }
}