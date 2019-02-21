using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid;
using DTO;
using BUS;
using System.IO;
using System.Data;

namespace HRM
{
    public partial class frmQLSanLuong : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        string deptID;
        DataTable dt = new DataTable();
        public frmQLSanLuong()
        {
            InitializeComponent();          
        }

        public frmQLSanLuong(string tmpDeptID)
        {
            InitializeComponent();
            dtpStart.EditValue = DateTime.Now.Date;
            dtpEnd.EditValue = DateTime.Now.Date;
            deptID = tmpDeptID;
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

        private void frmQLSanLuong_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BUS_SanXuat.GetTargetActualLine(deptID, dtpStart.DateTime.Date.ToString("yyyy-MM-dd"), dtpEnd.DateTime.Date.ToString("yyyy-MM-dd"));
            grdTargetActualLine.DataSource = dt;


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            dt = BUS_SanXuat.GetTargetActualLine(deptID, dtpStart.DateTime.Date.ToString("yyyy-MM-dd"), dtpEnd.DateTime.Date.ToString("yyyy-MM-dd"));
            grdTargetActualLine.DataSource = dt;
            splashScreenManager2.CloseWaitForm();
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
                            grdTargetActualLine.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            grdTargetActualLine.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            grdTargetActualLine.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            grdTargetActualLine.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            grdTargetActualLine.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            grdTargetActualLine.ExportToMht(exportFilePath);
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