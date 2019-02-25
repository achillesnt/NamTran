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
    public partial class frmProductEdit : DevExpress.XtraEditors.XtraForm
    {
        string product_id, product_name, isActive;
        object unit_id, category_id, warehouse_id;
        DataTable dtProductEdit = new DataTable();
        DataTable dtUnit = new DataTable();
        DataTable dtCategory = new DataTable();
        DataTable dtWarehouse = new DataTable();
        public frmProductEdit()
        {
            InitializeComponent();
        }
        public frmProductEdit(DataTable dt)
        {
            InitializeComponent();
            this.dtProductEdit = dt;
            this.dtUnit = BUS_Warehouse.LoadUnit();
            this.dtCategory = BUS_Warehouse.LoadCategory();
            this.dtWarehouse = BUS_Warehouse.LoadWarehouse();
            this.product_id = dtProductEdit.Rows[0]["product_id"].ToString();
            this.unit_id = dtProductEdit.Rows[0]["unit_id"];
            this.category_id = dtProductEdit.Rows[0]["category_id"];
            this.warehouse_id = dtProductEdit.Rows[0]["warehouse_id"];
            this.isActive = dtProductEdit.Rows[0]["isactive"].ToString();
            txtMaVT.Text = dtProductEdit.Rows[0]["product_code"].ToString();
            product_name = dtProductEdit.Rows[0]["product_name"].ToString();
            txtTenTA.Text = product_name.Substring(0, product_name.LastIndexOf(" / "));
            txtTenTV.Text = product_name.Substring(product_name.LastIndexOf(" / ") + 3);
            txtMoTa.Text = dtProductEdit.Rows[0]["product_description"].ToString();
            txtViTri.Text = dtProductEdit.Rows[0]["location"].ToString();
            txtGhiChu.Text = dtProductEdit.Rows[0]["product_note"].ToString();
            txtTonKho.Text = dtProductEdit.Rows[0]["minimum"].ToString();
        }
        private void btnProductEditSave_Click(object sender, EventArgs e)
        {
            unit_id = lkeDonVi.EditValue;
            warehouse_id = lkeKho.EditValue;
            category_id = lkeNhomVT.EditValue;
            if(checkEdit.Checked == true)
            {
                isActive = "Y";
            }
            else
            {
                isActive = "N";
            }
            product_name = txtTenTA.Text + " / " + txtTenTV.Text;
            string sKetQua = BUS_Warehouse.UpdateProduct(unit_id, category_id, warehouse_id, product_name, txtMoTa.Text, txtGhiChu.Text, txtTonKho.Text, isActive, txtViTri.Text, product_id);
            if(string.IsNullOrEmpty(sKetQua))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmProductEdit_Load(object sender, EventArgs e)
        {
            #region Xử lý lookupEdit
            lkeDonVi.Properties.DataSource = dtUnit;
            lkeDonVi.Properties.DisplayMember = "name";
            lkeDonVi.Properties.ValueMember = "id";
            lkeDonVi.Properties.NullText = "Chọn đơn vị";
            lkeDonVi.EditValue = unit_id;

            lkeDonVi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkeDonVi.Properties.DropDownRows = dtUnit.Rows.Count;
            //lkInput.Properties.ReadOnly = true;

            lkeKho.Properties.DataSource = dtWarehouse;
            lkeKho.Properties.DisplayMember = "name";
            lkeKho.Properties.ValueMember = "id";
            lkeKho.Properties.NullText = "Chọn lô kho";
            lkeKho.EditValue = warehouse_id;

            lkeKho.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkeKho.Properties.DropDownRows = dtWarehouse.Rows.Count;
            //lkInput.Properties.ReadOnly = true;

            lkeNhomVT.Properties.DataSource = dtCategory;
            lkeNhomVT.Properties.DisplayMember = "name";
            lkeNhomVT.Properties.ValueMember = "id";
            lkeNhomVT.Properties.NullText = "Chọn nhóm vật tư";
            lkeNhomVT.EditValue = category_id;

            lkeNhomVT.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkeNhomVT.Properties.DropDownRows = dtCategory.Rows.Count;
            //lkInput.Properties.ReadOnly = true;
            #endregion

            if(string.Compare(isActive, "Y") == 0)
            {
                checkEdit.CheckState = CheckState.Checked;
            }
            else
            {
                checkEdit.CheckState = CheckState.Unchecked;
            }
        }       

        private void btnProductClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}