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
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;

namespace HRM
{
    public partial class frmDiemDanh : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        string ad_user_id, ad_org_id, ad_org_description;
        Utility utility = new Utility();
        DataTable dtboPhan = new DataTable();
        DataTable dtNV = new DataTable();
        DataTable dtProcess = new DataTable();
        DataTable dtCa = new DataTable();
        DataTable dtReportDiemDanh = new DataTable();
        public frmDiemDanh()
        {
            InitializeComponent();
        }

        public frmDiemDanh(string ad_user_id, string ad_org_id, DataTable dtProcess)
        {
            InitializeComponent();
            this.ad_user_id = ad_user_id;
            this.ad_org_id = ad_org_id;
            this.dtProcess = dtProcess;
            dtCa = BUS_Ca.LoadCaShift(DateTime.Now.Date, ad_org_id);
            dtboPhan = BUS_BoPhan.LoadBoPhan(ad_org_id);
            utility.SearchProcess(this.Controls, dtProcess);
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
                            gridDiemDanh.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridDiemDanh.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridDiemDanh.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridDiemDanh.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridDiemDanh.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridDiemDanh.ExportToMht(exportFilePath);
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
            string fromDate = dateEdit.DateTime.Date.ToString("yyyy-MM-dd");
            string toDate = dateEdit1.DateTime.Date.ToString("yyyy-MM-dd");
            string boPhan = lkBoPhan.EditValue.ToString();
            string mode = radioGroup.EditValue.ToString();
            splashScreenManager5.ShowWaitForm();
            dtReportDiemDanh = BUS_ChamCong.ReportDiemDanh(fromDate, toDate, mode, boPhan, maCa);
            gridDiemDanh.DataSource = dtReportDiemDanh;
            GridViewLookupEdit();
            splashScreenManager5.CloseWaitForm();
        }
        #region Gridview No.
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
        #endregion

        private void radioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup.SelectedIndex == 0)
            {
                lkBoPhan.EditValue = dtboPhan.Rows[0][0];
                //string hour = DateTime.Now.Hour.ToString();
                //string filter = string.Format("[checkin] <= '{0}'", hour);
                //dtCa.DefaultView.RowFilter = filter;
                lkShift.Properties.DataSource = dtCa;
                lkShift.EditValue = dtCa.Rows[0][0];
                groupBox3.Enabled = false;
                alertControl1.Show(this, "Lưu ý", "Chọn bộ phận & ca làm việc cho chính xác.");
                gridDiemDanh.DataSource = null;
            }
            if (radioGroup.SelectedIndex == 1)
            {
                groupBox3.Enabled = true;
                dateEdit.EditValue = DateTime.Now.Date;
                dateEdit1.EditValue = DateTime.Now.Date;
                lkShift.EditValue = null;
                lkBoPhan.EditValue = dtboPhan.Rows[0][0];
                gridDiemDanh.DataSource = null;
            }
            if (radioGroup.SelectedIndex == 2)
            {
                groupBox3.Enabled = false;
                dateEdit.EditValue = DateTime.Now.Date;
                dateEdit1.EditValue = DateTime.Now.Date;
                lkShift.EditValue = null;
                lkBoPhan.EditValue = dtboPhan.Rows[0][0];
                gridDiemDanh.DataSource = null;
            }

        }

        private void frmDiemDanh_Load(object sender, EventArgs e)
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
            //lkInput.Properties.ReadOnly = true

            //string hourMinute;
            //hourMinute = DateTime.Now.ToString("HH:mm");
            //lkShift.Properties.DataSource = dtCa.Select("[checkin]<=" + hourMinute);
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
            groupBox3.Enabled = false;
            dateEdit1.EditValue = DateTime.Now.Date;
            dateEdit.EditValue = DateTime.Now.Date;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(radioGroup.SelectedIndex == 1)
            {
                if (DialogResult.Yes != MessageBox.Show(this, "Bạn có chắc chắn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return;
                }
                else
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
                    if(dt!=null && dt.Rows.Count > 0)
                    {
                        bool sKetQua = BUS_ChamCong.UpdateAttCount(dt, ad_user_id);
                        if (sKetQua)
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string maCa = lkShift.EditValue.ToString();
                            string attDate = dateEdit.DateTime.Date.ToString("yyyy-MM-dd");
                            string boPhan = lkBoPhan.EditValue.ToString();
                            string tinhTrang = radioGroup.EditValue.ToString();
                            DataTable dtCheckin = BUS_ChamCong.LoadCheckin(attDate, tinhTrang, boPhan, maCa);
                            gridDiemDanh.DataSource = dtCheckin;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công!", "Không thành công.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng lựa chọn loại công việc = 'xem danh sách đã điểm danh'!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alertControl1_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            e.AlertForm.Opacity = 1;
        }

        private void btnAddCountDelete_Click(object sender, EventArgs e)
        {
            if (radioGroup.SelectedIndex == 1)
            {
                if (DialogResult.Yes != MessageBox.Show(this, "Bạn có chắc chắn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return;
                }
                else
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
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        bool sKetQua = BUS_ChamCong.DeleteAttCount(dt, ad_user_id);
                        if (sKetQua)
                        {
                            MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //string maCa = lkShift.EditValue.ToString();
                            //string attDate = dateEdit.DateTime.Date.ToString("yyyy-MM-dd");
                            //string boPhan = lkBoPhan.EditValue.ToString();
                            //string tinhTrang = radioGroup.EditValue.ToString();
                            //DataTable dtCheckin = BUS_ChamCong.LoadCheckin(attDate, tinhTrang, boPhan, maCa);
                            gridDiemDanh.DataSource = null;
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Không thành công.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng lựa chọn loại công việc = 'xem danh sách đã điểm danh'!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(radioGroup.SelectedIndex == 0)
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
                if (dt != null && dt.Rows.Count > 0)
                {
                    bool sKetQua = BUS_ChamCong.InsertAttCount(ad_user_id, dt);
                    if (sKetQua)
                    {
                        MessageBox.Show("Điểm danh thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.gridDiemDanh.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Điểm danh không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Điểm danh không thành công!", "Không thành công.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại công việc = 'thực hiện điểm danh'!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void GridViewLookupEdit()
        {
            #region Ghi chú
            // Create an in-place LookupEdit control.
            //RepositoryItemLookUpEdit repositoryItemGridLookUpEdit1 = new RepositoryItemLookUpEdit();
            DataTable dtAbsent = BUS_ChamCong.LoadAbsent();
            repositoryItemLookUpEdit1.DataSource = dtAbsent;
            repositoryItemLookUpEdit1.ValueMember = "id";
            repositoryItemLookUpEdit1.DisplayMember = "description";
            repositoryItemLookUpEdit1.NullText = "Chọn lý do vắng";


            // Enable the "best-fit" functionality mode in which columns have proportional widths and the popup window is resized to fit all the columns.
            repositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            repositoryItemLookUpEdit1.DropDownRows = dtAbsent.Rows.Count;

            // Enable the automatic completion feature. In this mode, when the dropdown is closed, 
            // the text in the edit box is automatically completed if it matches a DisplayMember field value of one of dropdown rows. 
            repositoryItemLookUpEdit1.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            // Specify the column against which an incremental search is performed in SearchMode.AutoComplete and SearchMode.OnlyInPopup modes
            repositoryItemLookUpEdit1.AutoSearchColumnIndex = 1;

            // Optionally hide the Description column in the dropdown.
            repositoryItemLookUpEdit1.PopulateColumns();
            repositoryItemLookUpEdit1.Columns["id"].Visible = false;

            // Assign the in-place LookupEdit control to the grid's CategoryID column.
            // Note that the data types of the "ID" and "CategoryID" fields match.
            repositoryItemDateEdit1.NullText = string.Empty;
            repositoryItemDateEdit2.NullText = string.Empty;

            gridView1.Columns["att_reason"].ColumnEdit = repositoryItemLookUpEdit1;
            //gridView1.Columns["created"].ColumnEdit = repositoryItemDateEdit1;
            //gridView1.Columns["updated"].ColumnEdit = repositoryItemDateEdit2;
            gridView1.BestFitColumns();
            #endregion
        }
    }
}