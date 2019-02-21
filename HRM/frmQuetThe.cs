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

namespace HRM
{
    public partial class frmQuetThe : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        DataTable dtBoPhan = new DataTable();
        DataTable dtProcess = new DataTable();
        string ad_org_id, ad_org_description;
        Utility utility = new Utility();

        public frmQuetThe()
        {
            InitializeComponent();
        }

        public frmQuetThe(string ad_org_id)
        {
            InitializeComponent();
            this.ad_org_id = ad_org_id;
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            dtpFromDay.Format = DateTimePickerFormat.Custom;
            dtpFromDay.CustomFormat = "yyyy-MM-dd";
            dtpToDay.Format = DateTimePickerFormat.Custom;
            dtpToDay.CustomFormat = "yyyy-MM-dd";

            dtpFromTime.Format = DateTimePickerFormat.Time;
            dtpFromTime.ShowUpDown = true;
            dtpToTime.Format = DateTimePickerFormat.Time;
            dtpToTime.ShowUpDown = true;

            #region Xử lý lookupEdit
            dtBoPhan = BUS_BoPhan.LoadBoPhan(ad_org_id);

            lkBoPhan.Properties.DataSource = dtBoPhan;
            lkBoPhan.Properties.DisplayMember = "description";
            lkBoPhan.Properties.ValueMember = "id";
            lkBoPhan.Properties.NullText = "Chọn bộ phận";
            lkBoPhan.EditValue = dtBoPhan.Rows[0][0];
  

            lkBoPhan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkBoPhan.Properties.DropDownRows = dtBoPhan.Rows.Count;
            //lkInput.Properties.ReadOnly = true;
            #endregion

        }

        #region Xử lý STT gridview
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 10;
        }

        #endregion

        private void btnSua_Click(object sender, EventArgs e)
        {           
            splashScreenManager1.ShowWaitForm();
            string fromDate = dtpFromDay.Text + " " + dtpFromTime.Text;
            string toDate = dtpToDay.Text + " " + dtpToTime.Text;
            DataTable dtAttrecord = BUS_ChamCong.LoadAttrecord(fromDate, toDate, txtTimNV.Text, lkBoPhan.EditValue.ToString());
            grdChamCong.DataSource = dtAttrecord;
            splashScreenManager1.CloseWaitForm();            
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
                            grdChamCong.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            grdChamCong.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            grdChamCong.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            grdChamCong.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            grdChamCong.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            grdChamCong.ExportToMht(exportFilePath);
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