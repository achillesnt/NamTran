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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using System.IO;
using DevExpress.XtraGrid.Columns;

namespace HRM
{
    public partial class frmProductList : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        string v_ad_user_id, v_ad_org_id, v_ad_org_description;
        Utility utility = new Utility();
        DataTable dtProductList = new DataTable();
        DataTable dtProcess = new DataTable();

        private void frmProductList_Load(object sender, EventArgs e)
        {
            grdProductList.DataSource = dtProductList;
            BindingData();
        }

        #region Xử lý STT gridview
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 10;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            {
                try
                {
                    GridView view = (GridView)sender;
                    if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                    {
                        string sText = (e.RowHandle + 1).ToString();
                        Graphics gr = e.Info.Graphics;
                        gr.PageUnit = GraphicsUnit.Pixel;
                        GridView gridView = ((GridView)sender);
                        SizeF size = gr.MeasureString(sText, e.Info.Appearance.Font);
                        int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                        if (gridView.IndicatorWidth < nNewSize)
                        {
                            gridView.IndicatorWidth = nNewSize;
                        }

                        e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        e.Info.DisplayText = sText;
                    }
                    if (!indicatorIcon)
                        e.Info.ImageIndex = -1;

                    if (e.RowHandle == GridControl.InvalidRowHandle)
                    {
                        Graphics gr = e.Info.Graphics;
                        gr.PageUnit = GraphicsUnit.Pixel;
                        GridView gridView = ((GridView)sender);
                        SizeF size = gr.MeasureString("STT", e.Info.Appearance.Font);
                        int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                        if (gridView.IndicatorWidth < nNewSize)
                        {
                            gridView.IndicatorWidth = nNewSize;
                        }

                        e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        e.Info.DisplayText = "STT";
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        #endregion

        public frmProductList()
        {
            InitializeComponent();
        }       
        public frmProductList(string ad_user_id, string ad_org_id, DataTable dtProcess)
        {
            InitializeComponent();
            this.v_ad_user_id = ad_user_id;
            this.v_ad_org_id = ad_org_id;
            this.dtProcess = dtProcess;
            dtProductList = BUS_Warehouse.LoadProductList(DateTime.Now.ToString("yyyy-MM-dd"));
            utility.SearchProcess(this.Controls, dtProcess);
        }

        private void txtTrangThai_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(txtTrangThai.Text, "Y") == 0)
            {
                checkEdit.CheckState = CheckState.Checked;
            }
            else
            {
                checkEdit.CheckState = CheckState.Unchecked;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            /*
            if(string.IsNullOrEmpty(txtTimKiem.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dtSearch = new DataTable();
                dtSearch = Utility.CopyProductByName(dtProductList, txtTimKiem.Text);
                grdProductList.DataSource = dtSearch;
            }
            */
            DataTable dtSearch = new DataTable();
            dtSearch = Utility.CopyProductByName(dtProductList, txtTimKiem.Text);
            grdProductList.DataSource = dtSearch;
            BindingData();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            grdProductList.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            grdProductList.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            grdProductList.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            grdProductList.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            grdProductList.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            grdProductList.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnProductListEdit_Click(object sender, EventArgs e)
        {
            DataTable dtProductEdit = new DataTable();
            if (gridView1.SelectedRowsCount > 0)
            {
                #region Method 03    
                int[] selectedRowHandles = gridView1.GetSelectedRows();               
                foreach (GridColumn column in gridView1.Columns)
                {
                    dtProductEdit.Columns.Add(column.FieldName, column.ColumnType);
                }
                for (int index = 0; index < selectedRowHandles.Length; index++)
                {
                    DataRow row = dtProductEdit.NewRow();
                    foreach (GridColumn column in gridView1.Columns)
                    {
                        row[column.FieldName] = gridView1.GetRowCellValue(selectedRowHandles[index], column);
                    }
                    dtProductEdit.Rows.Add(row);
                }
                #endregion                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(dtProductEdit !=null && dtProductEdit.Rows.Count > 0)
            {
                frmProductEdit productEdit = new frmProductEdit(dtProductEdit);
                productEdit.FormClosed += new FormClosedEventHandler(ProductEdit_FormClosed);
                productEdit.ShowDialog();
            }
        }

        private void ProductEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtProductList = BUS_Warehouse.LoadProductList(DateTime.Now.ToString("yyyy-MM-dd"));
            grdProductList.DataSource = dtProductList;
            BindingData();
        }

        private void grdProductList_Click(object sender, EventArgs e)
        {
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            int rowHandle = gridView1.FocusedRowHandle;
            object _product_id = gridView1.GetRowCellValue(rowHandle, "product_id");
            object _product_code = gridView1.GetRowCellValue(rowHandle, "product_code");
            object _product_name = gridView1.GetRowCellValue(rowHandle, "product_name");

            frmProductDetail productDetail = new frmProductDetail(_product_id.ToString(), _product_code.ToString(), _product_name.ToString(), dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (productDetail.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            productDetail.ShowDialog();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnProductListAdd_Click(object sender, EventArgs e)
        {
            frmCreateProduct createProduct = new frmCreateProduct();
            createProduct.FormClosed += new FormClosedEventHandler(CreateProduct_FormClosed);
            createProduct.ShowDialog();
        }

        private void CreateProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtProductList = BUS_Warehouse.LoadProductList(DateTime.Now.ToString("yyyy-MM-dd"));
            grdProductList.DataSource = dtProductList;
            BindingData();
        }

        #region Xử lý hiển thị
        public void clearData()
        {
            txtMaVT.Text = "";
            txtTenVT.Text = "";
            txtMoTa.Text = "";
            txtNhomVT.Text = "";
            txtGhiChu.Text = "";
            txtDonVi.Text = "";
            txtViTri.Text = "";
            txtLoKho.Text = "";
            txtTonKho.Text = "";
            txtTrangThai.Text = "";          
        }

        public void BindingData()
        {
            if (grdProductList.MainView.RowCount > 0)
            {
                txtMaVT.DataBindings.Clear();
                txtMaVT.DataBindings.Add("Text", grdProductList.DataSource, "product_code");

                txtTenVT.DataBindings.Clear();
                txtTenVT.DataBindings.Add("Text", grdProductList.DataSource, "product_name");

                txtMoTa.DataBindings.Clear();
                txtMoTa.DataBindings.Add("Text", grdProductList.DataSource, "product_description");

                txtNhomVT.DataBindings.Clear();
                txtNhomVT.DataBindings.Add("Text", grdProductList.DataSource, "category_name");

                txtGhiChu.DataBindings.Clear();
                txtGhiChu.DataBindings.Add("Text", grdProductList.DataSource, "product_note");

                txtDonVi.DataBindings.Clear();
                txtDonVi.DataBindings.Add("Text", grdProductList.DataSource, "unit_name");

                txtViTri.DataBindings.Clear();
                txtViTri.DataBindings.Add("Text", grdProductList.DataSource, "location");

                txtLoKho.DataBindings.Clear();
                txtLoKho.DataBindings.Add("Text", grdProductList.DataSource, "warehouse_name");

                txtTonKho.DataBindings.Clear();
                txtTonKho.DataBindings.Add("Text", grdProductList.DataSource, "minimum");

                txtTrangThai.DataBindings.Clear();
                txtTrangThai.DataBindings.Add("Text", grdProductList.DataSource, "isactive");              
            }
            else
                clearData();
        }

        #endregion
    }
}