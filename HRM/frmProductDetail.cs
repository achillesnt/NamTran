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
using System.Data;
using BUS;

namespace HRM
{
    public partial class frmProductDetail : DevExpress.XtraEditors.XtraForm
    {
        string product_id, product_code, product_name, _price_id;
        Utility utility = new Utility();
        DataTable dtPrices = new DataTable();
        DataTable dtTransaction = new DataTable();

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            gridPrice.DataSource = dtPrices;
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            int rowHandle = gridView2.FocusedRowHandle;
            _price_id = gridView2.GetRowCellValue(rowHandle, "price_id").ToString();
            txtValue.Text = gridView2.GetRowCellValue(rowHandle, "value").ToString();
            txtCurrency.Text = gridView2.GetRowCellValue(rowHandle, "currency").ToString();
            DateTime _eff_date = Convert.ToDateTime(gridView2.GetRowCellValue(rowHandle, "effective_date"));
            txtNote.Text = gridView2.GetRowCellValue(rowHandle, "price_note").ToString();
            dateEdit.EditValue = _eff_date;
        }

        private void btnPriceNew_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValue.Text) && !string.IsNullOrEmpty(txtCurrency.Text))
            {
                bool sKetQua = false;
                sKetQua = BUS_Warehouse.CreatePrice(product_id, txtValue.Text, txtCurrency.Text, dateEdit.DateTime, txtNote.Text);
                if (sKetQua)
                {
                    MessageBox.Show("Tạo mới thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tạo mới không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Điền đầy đủ các thông tin cần thiết.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPriceSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValue.Text) && !string.IsNullOrEmpty(txtCurrency.Text))
            {
                string sKetQua = null;
                sKetQua = BUS_Warehouse.UpdatePrice(_price_id, txtValue.Text, txtCurrency.Text, dateEdit.DateTime, txtNote.Text);
                if (string.IsNullOrEmpty(sKetQua))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chọn dòng dữ liệu cần cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public frmProductDetail()
        {
            InitializeComponent();
        }
        public frmProductDetail(string _product_id, string _product_code, string _product_name, DataTable dtProcess)
        {
            InitializeComponent();
            this.product_id = _product_id;
            this.product_code = _product_code;
            this.product_name = _product_name;
            utility.SearchProcess(this.Controls, dtProcess);
            lblProductCode.Text = "Part Code: " + product_code;
            lblProductName.Text = "Part Name: " + product_name;
            this.dtPrices = BUS_Warehouse.LoadPriceByProduct(product_id);
        }
    }
}