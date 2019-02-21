using System;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid;
using DTO;
using BUS;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace HRM
{
    public partial class frmNhSanLuong : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        string ad_user_id, ad_org_id, ad_org_description, sochungtu;
        Utility utility = new Utility();
        DataTable dtboPhan = new DataTable();
        DataTable dtProcess = new DataTable();

        DataTable dtInout = new DataTable();
        DataTable dtTypename = new DataTable();
        DataTable dtPartname = new DataTable();
        DataTable typePart = new DataTable();
        DataTable dtRecentTypePart = new DataTable();
        DataTable dtDocument = new DataTable();
        public frmNhSanLuong()
        {
            InitializeComponent();
        }

        public frmNhSanLuong(string ad_user_id, string ad_org_id, DataTable dtProcess)
        {
            InitializeComponent();
            dateEdit1.EditValue = DateTime.Now.Date;
            dateEdit2.EditValue = DateTime.Now.Date;
            this.ad_user_id = ad_user_id;
            this.ad_org_id = ad_org_id;
            this.dtProcess = dtProcess;
            dtboPhan = BUS_BoPhan.LoadBoPhan(ad_org_id);
            utility.SearchProcess(this.Controls, dtProcess);

            dtInout = BUS_SanXuat.GetInout(ad_org_id, dateEdit1.DateTime.Date.ToString("yyyy-MM-dd"), dateEdit2.DateTime.Date.ToString("yyyy-MM-dd"));
            dtTypename = BUS_SanXuat.LoadTypename();
            dtPartname = BUS_SanXuat.LoadPartname();
            dtRecentTypePart = BUS_SanXuat.LoadRecentTypePart(ad_org_id);
            dtDocument = BUS_SanXuat.LoadDocumenttype();
        }
        #region Hiển thị cột thứ tự gridview
        private void gridView_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 10;
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
        private void frmNhSanLuong_Load(object sender, EventArgs e)
        {           
            txtDate.Text = DateTime.Now.ToShortDateString();
            #region Xử lý lookupEdit

            lkTypename.Properties.DataSource = dtTypename;
            lkTypename.Properties.DisplayMember = "typename";
            lkTypename.Properties.ValueMember = "typecode";
            //lkTypename.EditValue = dtTypename.Rows[0]["typecode"];
                  
            if (dtRecentTypePart != null && dtRecentTypePart.Rows.Count > 0)
            {
                lkTypename.EditValue = dtRecentTypePart.Rows[0][4].ToString();
            }
            else
            {
                lkTypename.EditValue = dtTypename.Rows[0]["typecode"];
            }

            //string typeCode = dtRecentTypePart.Rows[0][4].ToString();
            //XuLyLookupPartName(typeCode);

            lkTypename.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkTypename.Properties.DropDownRows = dtTypename.Rows.Count;
            //lkInput.Properties.ReadOnly = true;


            lkDocumenttype.Properties.DataSource = dtDocument;
            lkDocumenttype.Properties.DisplayMember = "document_type";
            lkDocumenttype.Properties.ValueMember = "documentcode";
            lkDocumenttype.Properties.NullText = "Chọn loại chứng từ";
            lkDocumenttype.EditValue = dtDocument.Rows[0]["documentcode"];

            lkDocumenttype.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkDocumenttype.Properties.DropDownRows = dtDocument.Rows.Count;
            //lkInput.Properties.ReadOnly = true;
            #endregion

            grdInout.DataSource = dtInout;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string documentstatus = "D01";
            string typeName = lkTypename.EditValue.ToString();
            string partCode = lkPartname.EditValue.ToString();
            string documentType = lkDocumenttype.EditValue.ToString();
            if (!string.IsNullOrEmpty(typeName) && !string.IsNullOrEmpty(documentType))
            {
                bool flag = BUS_SanXuat.InputInout(ad_org_id, typeName, partCode, documentType, documentstatus);
                if (!flag)
                {
                    MessageBox.Show("Dữ liệu đã tồn tại.\n Vui lòng loại bỏ dữ liệu đã có trước khi tạo mới.", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtInout = BUS_SanXuat.GetInout(ad_org_id, dateEdit1.DateTime.Date.ToString("yyyy-MM-dd"), dateEdit2.DateTime.Date.ToString("yyyy-MM-dd"));
                    grdInout.DataSource = dtInout;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn typename & loại chứng từ!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gridView.GetSelectedRows();
            if(selectedRows.Length > 0)
            {
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        sochungtu = gridView.GetRowCellValue(rowHandle, documentno).ToString();
                        bool flag = BUS_SanXuat.RemoveInout(sochungtu);
                        if (!flag)
                        {
                            MessageBox.Show("Reomve không thành công.", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dtInout = BUS_SanXuat.GetInout(ad_org_id, dateEdit1.DateTime.Date.ToString("yyyy-MM-dd"), dateEdit2.DateTime.Date.ToString("yyyy-MM-dd"));
                            grdInout.DataSource = dtInout;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần remove!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lkTypename_EditValueChanged(object sender, EventArgs e)
        {
            string typeCode = lkTypename.EditValue.ToString();
            XuLyLookupPartName(typeCode);      
        }
        private void XuLyLookupPartName(string typeCode)
        {           
            typePart = Utility.CopyDatatable(dtPartname, typeCode);
            #region Xử lý lookupEdit
            lkPartname.Properties.DataSource = typePart;
            lkPartname.Properties.DisplayMember = "partname";
            lkPartname.Properties.ValueMember = "partcode";
            lkPartname.Properties.NullText = "Chọn partname";
            lkPartname.EditValue = typePart.Rows[0]["partcode"];

            lkPartname.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkPartname.Properties.DropDownRows = typePart.Rows.Count;
            //lkInput.Properties.ReadOnly = true;
            #endregion
        }

        private void search_Click(object sender, EventArgs e)
        {
            dtInout = BUS_SanXuat.GetInout(ad_org_id, dateEdit1.DateTime.Date.ToString("yyyy-MM-dd"), dateEdit2.DateTime.Date.ToString("yyyy-MM-dd"));
            grdInout.DataSource = dtInout;
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if(gridView.RowCount > 0)
            {
                int rowHandle = gridView.FocusedRowHandle;
                object variable = gridView.GetRowCellValue(rowHandle, "documentno");
                DataTable dt = new DataTable();
                dt = BUS_SanXuat.GetInoutbydocumentno(variable.ToString());
                //splashScreenManager1.ShowWaitForm();
                frmInoutLine inoutLine = new frmInoutLine(dt, dtProcess);
                foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
                {
                    if (inoutLine.Name == _mdi_child.Name)
                        _mdi_child.Close();
                }
                //inoutLine.MdiParent = this;
                inoutLine.ShowDialog();
                //splashScreenManager1.CloseWaitForm();
            }
        }

        private void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string inputType = View.GetRowCellDisplayText(e.RowHandle, View.Columns["document_type_description"]);
                if (inputType == "Nhập đầu vào")
                {
                    e.Appearance.BackColor = Color.SkyBlue;
                    e.Appearance.BackColor2 = Color.White;
                    e.HighPriority = true;
                }
            }
            
        }

        private void btnExport_Click(object sender, EventArgs e)
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
                            grdInout.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            grdInout.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            grdInout.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            grdInout.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            grdInout.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            grdInout.ExportToMht(exportFilePath);
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


        
    }
}