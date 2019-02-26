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

namespace HRM
{
    public partial class frmCreateProduct : DevExpress.XtraEditors.XtraForm
    {
        string product_id, product_name, isActive, unit_id, category_id, warehouse_id;

        private void btnProductCreateSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaVT.Text) && (!string.IsNullOrEmpty(txtTenTV.Text) || !string.IsNullOrEmpty(txtTenTA.Text)))
            {
                bool sKetQua = false;
                sKetQua = BUS_Warehouse.CreateProduct(txtMaVT.Text, txtTenTA.Text + " / " + txtTenTV.Text, txtGhiChu.Text, txtMoTa.Text, txtTonKho.Text, txtViTri.Text, lkeNhomVT.EditValue.ToString(), lkeDonVi.EditValue.ToString(), lkeKho.EditValue.ToString());
                if(sKetQua)
                {
                    MessageBox.Show("Tạo mới vật tư thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ các thông tin cần thiết", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnProductCreateClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            frmProductAccessories productAcc = new frmProductAccessories("category");
            productAcc.ShowDialog();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            frmProductAccessories productAcc = new frmProductAccessories("warehouse");
            productAcc.ShowDialog();
        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            frmProductAccessories productAcc = new frmProductAccessories("unit");
            productAcc.ShowDialog();
        }

        DataTable dtUnit = new DataTable();
        DataTable dtCategory = new DataTable();
        DataTable dtWarehouse = new DataTable();

        private void frmCreateProduct_Load(object sender, EventArgs e)
        {
            #region Xử lý lookupEdit
            lkeDonVi.Properties.DataSource = dtUnit;
            lkeDonVi.Properties.DisplayMember = "name";
            lkeDonVi.Properties.ValueMember = "id";
            lkeDonVi.Properties.NullText = "Chọn đơn vị";
            lkeDonVi.EditValue = dtUnit.Rows[0][0];

            lkeDonVi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkeDonVi.Properties.DropDownRows = dtUnit.Rows.Count;
            //lkInput.Properties.ReadOnly = true;

            lkeKho.Properties.DataSource = dtWarehouse;
            lkeKho.Properties.DisplayMember = "name";
            lkeKho.Properties.ValueMember = "id";
            lkeKho.Properties.NullText = "Chọn lô kho";
            lkeKho.EditValue = dtWarehouse.Rows[0][0];

            lkeKho.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkeKho.Properties.DropDownRows = dtWarehouse.Rows.Count;
            //lkInput.Properties.ReadOnly = true;

            lkeNhomVT.Properties.DataSource = dtCategory;
            lkeNhomVT.Properties.DisplayMember = "name";
            lkeNhomVT.Properties.ValueMember = "id";
            lkeNhomVT.Properties.NullText = "Chọn nhóm vật tư";
            lkeNhomVT.EditValue = dtCategory.Rows[0][0];

            lkeNhomVT.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkeNhomVT.Properties.DropDownRows = dtCategory.Rows.Count;
            //lkInput.Properties.ReadOnly = true;
            #endregion
            checkEdit.CheckState = CheckState.Checked;
        }

        public frmCreateProduct()
        {
            InitializeComponent();
            this.dtUnit = BUS_Warehouse.LoadUnit();
            this.dtCategory = BUS_Warehouse.LoadCategory();
            this.dtWarehouse = BUS_Warehouse.LoadWarehouse();
        }
    }
}