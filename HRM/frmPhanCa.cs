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
using DTO;
using BUS;
using DevExpress.XtraGrid.Columns;

namespace HRM
{
    public partial class frmPhanCa : DevExpress.XtraEditors.XtraForm
    {
        List<DTO_NhanVien> lstNhanVien = new List<DTO_NhanVien>();
        DataTable dt;
        string dtBoPhan;
        public frmPhanCa()
        {
            InitializeComponent();
        }

        public frmPhanCa(List<DTO_NhanVien> tmpNhanVien, string boPhan)
        {
            InitializeComponent();
            this.lstNhanVien = tmpNhanVien;
            this.dtBoPhan = boPhan;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhanCa_Load(object sender, EventArgs e)
        {
            dtpNgayHieuLuc.Format = DateTimePickerFormat.Custom;
            dtpNgayHieuLuc.CustomFormat = "yyyy-MM-dd";

            gridControl1.DataSource = lstNhanVien;


            //List<DTO_Ca> lstCa = new List<DTO_Ca>();
            DataTable dtCa = BUS_Ca.LoadCa();


            lkShift.Properties.DataSource = dtCa;
            lkShift.Properties.DisplayMember = "name";
            lkShift.Properties.ValueMember = "id";
            lkShift.Properties.NullText = "Chọn ca làm việc";
            lkShift.EditValue = dtCa.Rows[0][0];

            lkShift.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkShift.Properties.DropDownRows = dtCa.Rows.Count;
            //lkInput.Properties.ReadOnly = true;        

        }

        private void btnThucThi_Click(object sender, EventArgs e)
        {
            #region Method 02 - Xử lý bằng datatable
            DataTable dt = new DataTable();
            foreach (GridColumn column in gridView1.VisibleColumns)
            {
                dt.Columns.Add(column.FieldName, column.ColumnType);
            }
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = dt.NewRow();
                foreach (GridColumn column in gridView1.VisibleColumns)
                {
                    row[column.FieldName] = gridView1.GetRowCellValue(i, column);
                }
                dt.Rows.Add(row);
            }
            #endregion
            string sKetQua = BUS_PhanCa.PhanCa(dt, dtpNgayHieuLuc.Text, lkShift.EditValue.ToString());
            if (string.IsNullOrEmpty(sKetQua))
            {
                MessageBox.Show("Phân ca thành công." + sKetQua, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Ngày hiệu lực: " + dtpNgayHieuLuc.Text + "\nCác nhân viên sau đã được phân ca trước đó, bao gồm: "+ sKetQua, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}