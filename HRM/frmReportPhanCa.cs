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
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Drawing;

namespace HRM
{
    public partial class frmReportPhanCa : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        string ad_org_id, ad_org_description;
        DataTable dtboPhan = new DataTable();
        DataTable dtNV = new DataTable();
        DataTable dtProcess = new DataTable();
        Utility utility = new Utility();
        public frmReportPhanCa()
        {
            InitializeComponent();
        }

        public frmReportPhanCa(string ad_org_id)
        {
            InitializeComponent();
            this.ad_org_id = ad_org_id;
        }

        private void frmKTPhanCa_Load(object sender, EventArgs e)
        {
            #region Xử lý lookupEdit
            dtboPhan = BUS_BoPhan.LoadBoPhan(ad_org_id);

            lkBoPhan.Properties.DataSource = dtboPhan;
            lkBoPhan.Properties.DisplayMember = "description";
            lkBoPhan.Properties.ValueMember = "id";
            lkBoPhan.Properties.NullText = "Chọn bộ phận";
            lkBoPhan.EditValue = dtboPhan.Rows[0][0];

            lkBoPhan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkBoPhan.Properties.DropDownRows = dtboPhan.Rows.Count;
            //lkInput.Properties.ReadOnly = true

            //List<DTO_Ca> lstCa = new List<DTO_Ca>();
            DataTable dtCa = BUS_Ca.LoadCa();


            lkShift.Properties.DataSource = dtCa;
            lkShift.Properties.DisplayMember = "name";
            lkShift.Properties.ValueMember = "id";
            lkShift.Properties.NullText = "Chọn ca làm việc";
            //lkShift.EditValue = dtCa.Rows[0][0];

            lkShift.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkShift.Properties.DropDownRows = dtCa.Rows.Count;
            //lkInput.Properties.ReadOnly = true;   
            #endregion

            radioGroup.SelectedIndex = 0;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            Reset.Enabled = false;
            dateEdit.EditValue = DateTime.Now.Date;
            dateEdit1.EditValue = DateTime.Now.Date;
            #region Redundance
            /*
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
            #endregion
            radioGroup.SelectedIndex = 0;

            int i = Convert.ToInt16(user_level_id);
            if (i > 1)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
            */
            #endregion
        }

        private void radioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup.SelectedIndex == 0)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                Reset.Enabled = false;
                //dateEdit.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                Reset.Enabled = true;
                //dateEdit.Enabled = false;
                //dateEdit.EditValue = DateTime.Now.Date;
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

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            lkShift.EditValue = null;
            lkBoPhan.EditValue = dtboPhan.Rows[0][0];
            dateEdit.EditValue = DateTime.Now.Date;
            dateEdit1.EditValue = DateTime.Now.Date;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string maCa;
            if (lkShift.EditValue != null)
            {
                maCa = lkShift.EditValue.ToString();
            }
            else
            {
                maCa = "0";
            }
            splashScreenManager4.ShowWaitForm();
            string fromDate = dateEdit.DateTime.Date.ToString("yyyy-MM-dd");
            string toDate = dateEdit1.DateTime.Date.ToString("yyyy-MM-dd");
            string boPhan = lkBoPhan.EditValue.ToString();
            string mode = radioGroup.EditValue.ToString();
            DataTable dtReportPhanCa = BUS_PhanCa.ReportPhanCa(fromDate, toDate, mode, boPhan, maCa);
            gridPhanCa.DataSource = dtReportPhanCa;
            splashScreenManager4.CloseWaitForm();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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
                            gridPhanCa.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridPhanCa.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridPhanCa.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridPhanCa.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridPhanCa.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridPhanCa.ExportToMht(exportFilePath);
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
