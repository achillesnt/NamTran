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
    public partial class frmRole : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        string v_ad_role_id;
        Utility utility = new Utility();
        DataTable dtRole = new DataTable();
        DataTable dtWindowAccess = new DataTable();
        DataTable dtProcessAccess = new DataTable();
        DataTable dtUserRoles = new DataTable();
        DataTable dtProcess = new DataTable();
        public frmRole()
        {
            InitializeComponent();
        }

        public frmRole(DataTable dtProcess)
        {
            InitializeComponent();
            this.dtProcess = dtProcess;
            utility.SearchProcess(this.Controls, dtProcess);
            this.dtRole = BUS_HeThong.LoadRoleFull();
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            grdRole.DataSource = dtRole;
            repositoryItemCheckEdit1.ValueChecked = "Y";
            repositoryItemCheckEdit1.ValueUnchecked = "N";
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            object _role_id = gridView1.GetRowCellValue(rowHandle, "ad_role_id");
            object _description = gridView1.GetRowCellValue(rowHandle, "description");

            frmRoleDetail roleDetail = new frmRoleDetail(_role_id.ToString(), _description.ToString(), dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (roleDetail.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            //inoutLine.MdiParent = this;
            roleDetail.ShowDialog();
            //splashScreenManager1.CloseWaitForm();
        }      

        private void btnRoleUpdate_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                #region Method 03    
                int[] selectedRowHandles = gridView1.GetSelectedRows();
                DataTable dtUpdateRole = new DataTable();
                foreach (GridColumn column in gridView1.Columns)
                {
                    dtUpdateRole.Columns.Add(column.FieldName, column.ColumnType);
                }
                for (int index = 0; index < selectedRowHandles.Length; index++)
                {
                    DataRow row = dtUpdateRole.NewRow();
                    foreach (GridColumn column in gridView1.Columns)
                    {
                        row[column.FieldName] = gridView1.GetRowCellValue(selectedRowHandles[index], column);
                    }
                    dtUpdateRole.Rows.Add(row);
                }
                #endregion   
                string sKetQua = BUS_HeThong.UpdateRole(dtUpdateRole);
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

        private void btnRoleDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                #region Method 03    
                int[] selectedRowHandles = gridView1.GetSelectedRows();
                DataTable dtDeleteRoles = new DataTable();
                foreach (GridColumn column in gridView1.Columns)
                {
                    dtDeleteRoles.Columns.Add(column.FieldName, column.ColumnType);
                }
                for (int index = 0; index < selectedRowHandles.Length; index++)
                {
                    DataRow row = dtDeleteRoles.NewRow();
                    foreach (GridColumn column in gridView1.Columns)
                    {
                        row[column.FieldName] = gridView1.GetRowCellValue(selectedRowHandles[index], column);
                    }
                    dtDeleteRoles.Rows.Add(row);
                }
                #endregion   
                string sKetQua = BUS_HeThong.DeleteRoles(dtDeleteRoles);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin cần thiết!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BUS_HeThong.CreateRole(txtName.Text, txtDescription.Text))
                {
                    MessageBox.Show("Tạo vai trò thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tạo vai trò không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}