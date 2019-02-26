using System;
using System.Data;
using BUS;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;

namespace HRM
{
    public partial class frmProductAccessories : DevExpress.XtraEditors.XtraForm
    {
        string i_variable;
        DataTable dtUnit = new DataTable();
        DataTable dtWarehouse = new DataTable();
        DataTable dtCategory = new DataTable();
        public frmProductAccessories()
        {
            InitializeComponent();
        }
        public frmProductAccessories(string v_variable)
        {
            InitializeComponent();
            this.i_variable = v_variable;
            this.dtUnit = BUS_Warehouse.LoadUnit();
            this.dtWarehouse = BUS_Warehouse.LoadWarehouse();
            this.dtCategory = BUS_Warehouse.LoadCategory();
        }

        private void frmProductAccessories_Load(object sender, EventArgs e)
        {
            switch (i_variable)
            {
                case "unit":
                    {
                        this.Text = "Quản lý đơn vị tính";
                        gridControl1.DataSource = dtUnit;
                        break;
                    }
                case "category":
                    {
                        this.Text = "Quản lý nhóm vật tư";
                        gridControl1.DataSource = dtCategory;
                        break;
                    }
                case "warehouse":
                    {
                        this.Text = "Quản lý kho lưu trữ";
                        gridControl1.DataSource = dtWarehouse;
                        break;
                    }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            #region Method 02 - Xử lý bằng datatable
            DataTable dt = new DataTable();
            foreach (GridColumn column in gridView1.Columns)
            {
                dt.Columns.Add(column.FieldName, column.ColumnType);
            }
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = dt.NewRow();
                foreach (GridColumn column in gridView1.Columns)
                {
                    row[column.FieldName] = gridView1.GetRowCellValue(i, column);
                }
                dt.Rows.Add(row);
            }
            #endregion
            string sKetQua = BUS_Warehouse.UpdateAccessories(dt, i_variable);
            if (string.IsNullOrEmpty(sKetQua))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật các dòng phân ca có ngày nhỏ hơn ngày hiện tại\nHoặc các ngày sau đã được phân ca trước đó: " + sKetQua, "Cập nhật không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool sKetQua = BUS_Warehouse.CreateAccessories(txtName.Text, txtDescription.Text, i_variable);
            if (sKetQua)
            {
                MessageBox.Show("Khởi tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Khởi tạo không thành công!", "Cập nhật không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}