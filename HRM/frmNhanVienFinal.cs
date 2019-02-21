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
using System.IO;
using DevExpress.XtraGrid.Columns;

namespace HRM
{
    public partial class frmNhanVienFinal : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        DataTable dtNV = new DataTable();
        DataTable dtProcess = new DataTable();
        int mode = 1;
        string ad_org_id, ad_org_description, ad_org_id_root;
        bool indicatorIcon = true;
        Utility utility = new Utility();
        public frmNhanVienFinal()
        {
            InitializeComponent();
        }

        public frmNhanVienFinal(string ad_org_id, string ad_org_description, DataTable dtProcess)
        {
            InitializeComponent();
            this.ad_org_id = ad_org_id;
            this.ad_org_id_root = ad_org_id;
            this.ad_org_description = ad_org_description;
            this.dtProcess = dtProcess;         
            utility.SearchProcess(this.Controls, dtProcess);
        }

        private void frmNhanVienFinal_Load(object sender, EventArgs e)
        {
            lblHoten.Left = (tableLayoutPanel1.Width - lblHoten.Width) / 2;
            //Gọi nghiệp vụ load tình trạng từ class BUL

            dt = BUS_BoPhan.LoadNode(ad_org_id);
            TreeNode t = treeView.Nodes.Add(ad_org_description);
            t.Name = ad_org_id;
            treeView.SelectedNode = t;
            PopulateTreeView(Convert.ToInt16(ad_org_id), t);
            treeView.ExpandAll();

            dataSelect(ad_org_id);           
        }

        #region Xử lý hiển thị
        public void clearNhanVien()
        {
            lblHoten.Text = "";
            txtManv.Text = "";
            txtBophan.Text = "";
            txtChucvu.Text = "";
            txtHokhau.Text = "";
            txtCMND.Text = "";
            txtNgaysinh.Text = "";
            txtDienthoai.Text = "";
            //txtTinhtrang.Text = "";
            txtNgaynghisinh.Text = "";
            txtNgaythongbao.Text = "";
            txtNgaynghiviec.Text = "";
        }

        public void BindingNhanVien()
        {
            if (grdNhanvien.MainView.RowCount > 0)
            {
                lblHoten.DataBindings.Clear();
                lblHoten.DataBindings.Add("Text", grdNhanvien.DataSource, "staff_name");
                //lblHoten.Left = (this.ClientSize.Width - lblHoten.Width - grpHinh.Width) / 2;

                txtManv.DataBindings.Clear();
                txtManv.DataBindings.Add("Text", grdNhanvien.DataSource, "staff_id");

                txtBophan.DataBindings.Clear();
                txtBophan.DataBindings.Add("Text", grdNhanvien.DataSource, "dept_name");

                txtChucvu.DataBindings.Clear();
                txtChucvu.DataBindings.Add("Text", grdNhanvien.DataSource, "title");

                txtHokhau.DataBindings.Clear();
                txtHokhau.DataBindings.Add("Text", grdNhanvien.DataSource, "address");

                txtCMND.DataBindings.Clear();
                txtCMND.DataBindings.Add("Text", grdNhanvien.DataSource, "idcard");

                txtNgaysinh.DataBindings.Clear();
                txtNgaysinh.DataBindings.Add("Text", grdNhanvien.DataSource, "birthday");

                txtDienthoai.DataBindings.Clear();
                txtDienthoai.DataBindings.Add("Text", grdNhanvien.DataSource, "mobilephone");

                txtQuequan.DataBindings.Clear();
                txtQuequan.DataBindings.Add("Text", grdNhanvien.DataSource, "country");

                txtNgaynghisinh.DataBindings.Clear();
                txtNgaynghisinh.DataBindings.Add("Text", grdNhanvien.DataSource, "baby_date");

                txtNgaythongbao.DataBindings.Clear();
                txtNgaythongbao.DataBindings.Add("Text", grdNhanvien.DataSource, "inform_date");

                txtNgaynghiviec.DataBindings.Clear();
                txtNgaynghiviec.DataBindings.Add("Text", grdNhanvien.DataSource, "terminal_date");

            }
            else
                clearNhanVien();
        }

        #endregion

        public void dataSelect(string boPhan)
        {
            dtNV = BUS_NhanVien.LoadNhanVien(boPhan, mode);
            grdNhanvien.DataSource = dtNV;
            BindingNhanVien();
        }

        #region Xử lý treeview
        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {

            TreeNode childNode;

            foreach (DataRow dr in dt.Select("[RelationID]=" + parentId))
            {
                TreeNode t = new TreeNode();
                t.Text = dr["DescriptionVN"].ToString();
                t.Name = dr["ID"].ToString();
                t.Tag = dt.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    treeView.Nodes.Add(t);
                    childNode = t;
                }
                else
                {
                    parentNode.Nodes.Add(t);
                    childNode = t;
                }
                PopulateTreeView(Convert.ToInt32(dr["ID"].ToString()), childNode);
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ad_org_id = treeView.SelectedNode.Name.ToString();
            dataSelect(ad_org_id);
        }
        #endregion

        private void suaNhanVien()
        {
            if (grdNhanvien.MainView.RowCount > 0)
            {
                frmSuaNhanVien suaNV = new frmSuaNhanVien(txtManv.Text, ad_org_id_root);
                suaNV.FormClosed += new FormClosedEventHandler(SuaNV_FormClosed);
                suaNV.ShowDialog();
            }
        }

        private void SuaNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            dataSelect(ad_org_id);

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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            suaNhanVien();
        }

        private void btnExport_Click_1(object sender, EventArgs e)
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
                            grdNhanvien.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            grdNhanvien.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            grdNhanvien.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            grdNhanvien.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            grdNhanvien.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            grdNhanvien.ExportToMht(exportFilePath);
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
        private void btnMove_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                #region Method 01 
                /*
                ArrayList rows = new ArrayList();
                // Add the selected rows to the list.
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    if (gridView1.GetSelectedRows()[i] >= 0)
                    {
                        rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
                    }                    
                }
                try
                {
                    textBox1.Text = "";
                    gridView1.BeginUpdate();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i] as DataRow;
                        textBox1.Text = row["DEPARTMENT"].ToString();
                    }
                }
                finally
                {
                    gridView1.EndUpdate();
                }     
                */
                #endregion

                #region Method 02

                List<DTO_NhanVien> lstNhanVien = new List<DTO_NhanVien>();
                DTO_NhanVien nhanvienDTO;
                // Add the selected rows to the list.
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    nhanvienDTO = new DTO_NhanVien();
                    if (gridView1.GetSelectedRows()[i] >= 0)
                    {
                        nhanvienDTO.UserFullCode = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "staff_id").ToString();
                        nhanvienDTO.UserFullName = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "staff_name").ToString();
                        nhanvienDTO.TitleName = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "title").ToString();
                        nhanvienDTO.DescriptionVN = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "dept_name").ToString();
                        nhanvienDTO.UserHireDay = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "staff_hire_date").ToString();
                    }
                    lstNhanVien.Add(nhanvienDTO);
                }

                #endregion

                #region Method 03
                /*
                DataTable dtDieuChuyen = new DataTable();
                foreach (GridColumn column in gridView1.VisibleColumns)
                {
                    dtDieuChuyen.Columns.Add(column.FieldName, column.ColumnType);
                }
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    DataRow row = dtDieuChuyen.NewRow();
                    foreach (GridColumn column in gridView1.VisibleColumns)
                    {
                        row[column.FieldName] = gridView1.GetRowCellValue(i, column);
                    }
                    dtDieuChuyen.Rows.Add(row);
                }
                */
                #endregion

                frmDieuChuyen dieuchuyen = new frmDieuChuyen(lstNhanVien, ad_org_id_root);
                dieuchuyen.FormClosed += new FormClosedEventHandler(Dieuchuyen_FormClosed);
                dieuchuyen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Dieuchuyen_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            dataSelect(ad_org_id);
        }
    }
}