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
using System.IO;
using BUS;
using DTO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Columns;

namespace HRM
{
    public partial class frmBaoCom : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        string ad_user_id, ad_org_id, ad_org_description;
        Utility utility = new Utility();
        DataTable dtboPhan = new DataTable();
        DataTable dtNV = new DataTable();
        DataTable dtProcess = new DataTable();
        DataTable dtCa = new DataTable();
        DataTable dtReportDiemDanh = new DataTable();
        int tong = 0;
        int suatMan = 0;
        int suatChay = 0;
        int khongAn = 0;
        public frmBaoCom()
        {
            InitializeComponent();
        }

        public frmBaoCom(string ad_user_id, string ad_org_id, DataTable dtProcess)
        {
            InitializeComponent();
            this.ad_user_id = ad_user_id;
            this.ad_org_id = ad_org_id;
            this.dtProcess = dtProcess;
            dtCa = BUS_Ca.LoadCaShift(DateTime.Now.Date, ad_org_id);
            dtboPhan = BUS_BoPhan.LoadBoPhan(ad_org_id);
            utility.SearchProcess(this.Controls, dtProcess);
        }

        private void frmBaoCom_Load(object sender, EventArgs e)
        {
            #region Xử lý lookupEdit
            lkBoPhan.Properties.DataSource = dtboPhan;
            lkBoPhan.Properties.DisplayMember = "description";
            lkBoPhan.Properties.ValueMember = "id";
            lkBoPhan.Properties.NullText = "Chọn bộ phận";
            lkBoPhan.EditValue = dtboPhan.Rows[0][0];

            lkBoPhan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkBoPhan.Properties.DropDownRows = dtboPhan.Rows.Count;
            //lkInput.Properties.ReadOnly = true;

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
            dateEdit.EditValue = DateTime.Now.Date;
            dateEdit1.EditValue = DateTime.Now.Date;
        }

        #region Xử lý stt gridview
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

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 10;
        }
        #endregion

        private void radioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup.SelectedIndex == 0)
            {
                lkShift.EditValue = dtCa.Rows[0][0];
                gridBaoCom.DataSource = null;
                groupBox3.Enabled = false;
                dateEdit.EditValue = DateTime.Now.Date;
                alertControl1.Show(this, "Các cột cho phép nhập", "-Số lượng nhân viên ăn chay.\n-Số lượng nhân viên không ăn.\n-Số lượng phần ăn cho khách.\n-Ghi chú.");
            }
            if (radioGroup.SelectedIndex == 1)
            {
                gridBaoCom.DataSource = null;
                dateEdit.EditValue = DateTime.Now.Date;
                dateEdit1.EditValue = DateTime.Now.Date;
                lkShift.EditValue = null;
                groupBox3.Enabled = true;
            }
            if (radioGroup.SelectedIndex == 2)
            {
                gridBaoCom.DataSource = null;
                dateEdit.EditValue = DateTime.Now.Date;
                dateEdit1.EditValue = DateTime.Now.Date;
                lkShift.EditValue = null;
                groupBox3.Enabled = false;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radioGroup.SelectedIndex == 0)
            {
                DataTable dt = new DataTable();
                foreach (GridColumn column in gridView1.Columns)
                {
                    dt.Columns.Add(column.FieldName, column.ColumnType);
                }
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    DataRow row = dt.NewRow();
                    foreach (GridColumn column in gridView1.Columns)
                    {
                        row[column.FieldName] = gridView1.GetRowCellValue(i, column);
                    }
                    dt.Rows.Add(row);
                }
                if(dt!= null && dt.Rows.Count >0)
                {
                    bool sKetQua = BUS_BaoCom.InsertMeal(dt, ad_user_id);
                    if (sKetQua)
                    {
                        MessageBox.Show("Báo cơm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.gridBaoCom.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Báo cơm không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Báo cơm không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại công việc = 'thực hiện báo cơm'", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            splashScreenManager3.ShowWaitForm();
            string fromDate = dateEdit.DateTime.Date.ToString("yyyy-MM-dd");
            string toDate = dateEdit1.DateTime.Date.ToString("yyyy-MM-dd");
            string boPhan = lkBoPhan.EditValue.ToString();
            string mode = radioGroup.EditValue.ToString();
            DataTable dtMeal = BUS_BaoCom.LoadMeal(fromDate, toDate, mode, boPhan, maCa);
            gridBaoCom.DataSource = dtMeal;
            splashScreenManager3.CloseWaitForm();
            
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "ACh" || e.Column.FieldName == "KhA")
            {
                tong = Convert.ToInt16(gridView1.GetFocusedRowCellValue(A00));
                suatChay = Convert.ToInt16(gridView1.GetFocusedRowCellValue(ACh));
                khongAn = Convert.ToInt16(gridView1.GetFocusedRowCellValue(KhA));
                suatMan = tong-suatChay-khongAn;
                //gridView1.SetFocusedRowCellValue(AMn, suatMan);
                gridView1.SetRowCellValue(e.RowHandle, "AMn", suatMan);
                //gridView1.SetFocusedRowCellValue(ACh, suatChay);
            }
        }

        private void alertControl1_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            e.AlertForm.OpacityLevel = 1;
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
                            gridBaoCom.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridBaoCom.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridBaoCom.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridBaoCom.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridBaoCom.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridBaoCom.ExportToMht(exportFilePath);
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