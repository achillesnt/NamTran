using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
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
using DTO;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Columns;

namespace HRM
{
    public partial class frmDieuChuyen : DevExpress.XtraEditors.XtraForm
    {
        List<DTO_NhanVien> lstNhanVien = new List<DTO_NhanVien>();
        string dtBoPhan;
        public frmDieuChuyen()
        {
            InitializeComponent();
        }

        public frmDieuChuyen(List<DTO_NhanVien> lstTemp, string boPhan)
        {
            InitializeComponent();
            this.lstNhanVien = lstTemp;
            this.dtBoPhan = boPhan;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDieuChuyen_Load(object sender, EventArgs e)
        {
            grdDieuchuyen.DataSource = lstNhanVien;

            #region Xử lý lookupEdit
            DataTable lstBoPhan = BUS_BoPhan.LoadBoPhan(dtBoPhan);

            lkBoPhan.Properties.DataSource = lstBoPhan;
            lkBoPhan.Properties.DisplayMember = "description";
            lkBoPhan.Properties.ValueMember = "id";
            lkBoPhan.Properties.NullText = "Chọn bộ phận";
            lkBoPhan.EditValue = lstBoPhan.Rows[0][0];

            lkBoPhan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkBoPhan.Properties.DropDownRows = lstBoPhan.Rows.Count;
            //lkInput.Properties.ReadOnly = true;
            #endregion
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            #region Method 02 - Xử lý bằng datatable
            DataTable dt = new DataTable();
            foreach (GridColumn column in gridView.VisibleColumns)
            {
                dt.Columns.Add(column.FieldName, column.ColumnType);
            }
            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                DataRow row = dt.NewRow();
                foreach (GridColumn column in gridView.VisibleColumns)
                {
                    row[column.FieldName] = gridView.GetRowCellValue(i, column);
                }
                dt.Rows.Add(row);
            }

            string maBoPhan = lkBoPhan.EditValue.ToString();

            int sKetQua = BUS_NhanVien.DieuChuyen(dt, maBoPhan);
            if (sKetQua == 0)
            {
                MessageBox.Show("Không thành công, vui lòng kiểm tra lại dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Điều chuyển thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            #endregion
        }
    }
}