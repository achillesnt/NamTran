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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid;
using System.IO;

namespace HRM
{
    public partial class frmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        string v_ad_user_id, v_ad_org_id, v_ad_org_description;
        Utility utility = new Utility();
        DataTable dtboPhan = new DataTable();
        DataTable dtNguoiDung = new DataTable();
        DataTable dtProcess = new DataTable();

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            grdNguoiDung.DataSource = dtNguoiDung;
            repositoryItemCheckEdit1.ValueChecked = "Y";
            repositoryItemCheckEdit1.ValueUnchecked = "N";
            repositoryItemTextEdit1.UseSystemPasswordChar = true;

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
            #endregion
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                #region Method 03    
                int[] selectedRowHandles = gridView1.GetSelectedRows();
                DataTable dtUpdateUser = new DataTable();
                foreach (GridColumn column in gridView1.Columns)
                {
                    dtUpdateUser.Columns.Add(column.FieldName, column.ColumnType);
                }
                for (int index = 0; index < selectedRowHandles.Length; index++)
                {
                    DataRow row = dtUpdateUser.NewRow();
                    foreach (GridColumn column in gridView1.Columns)
                    {
                        row[column.FieldName] = gridView1.GetRowCellValue(selectedRowHandles[index], column);
                    }
                    dtUpdateUser.Rows.Add(row);
                }
                #endregion   
                string sKetQua = BUS_HeThong.UpdateUser(dtUpdateUser);
                if (string.IsNullOrEmpty(sKetQua))
                {
                    MessageBox.Show(this, "Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Những username sau cập nhật không thành công: " + sKetQua, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            string v_name, v_description, v_username, v_password, v_groupid, v_ad_org_id;
            v_name = txtName.Text;
            v_description = txtDescription.Text;
            v_username = txtUsername.Text;
            v_password = txtPassword.Text;
            v_groupid = txtGroup.Text;
            v_ad_org_id = lkBoPhan.EditValue.ToString();
            if (string.IsNullOrEmpty(v_name) || string.IsNullOrEmpty(v_description) || string.IsNullOrEmpty(v_username) || string.IsNullOrEmpty(v_password) || string.IsNullOrEmpty(v_groupid))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin cần thiết!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BUS_HeThong.CreateUser(v_name, v_description, v_username, v_password, v_groupid, v_ad_org_id))
                {
                    MessageBox.Show("Tạo người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tạo người dùng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void export_Click(object sender, EventArgs e)
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
                            grdNguoiDung.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            grdNguoiDung.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            grdNguoiDung.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            grdNguoiDung.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            grdNguoiDung.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            grdNguoiDung.ExportToMht(exportFilePath);
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            object variable = gridView1.GetRowCellValue(rowHandle, "ad_user_id");
            //MessageBox.Show(variable.Text);
            //DataTable dt = new DataTable();
            //dt = BUS_HeThong.LoadUserRoles(variable.ToString());

            //splashScreenManager1.ShowWaitForm();
            frmUserRoles userRoles = new frmUserRoles(variable.ToString(), dtProcess);
            foreach (System.Windows.Forms.Form _mdi_child in this.MdiChildren)
            {
                if (userRoles.Name == _mdi_child.Name)
                    _mdi_child.Close();
            }
            //inoutLine.MdiParent = this;
            userRoles.ShowDialog();
            //splashScreenManager1.CloseWaitForm();
        }

        public frmNguoiDung()
        {
            InitializeComponent();
        }

        public frmNguoiDung(string ad_user_id, string ad_org_id, DataTable dtProcess)
        {
            InitializeComponent();
            this.v_ad_user_id = ad_user_id;
            this.v_ad_org_id = ad_org_id;
            this.dtProcess = dtProcess;
            dtNguoiDung = BUS_HeThong.LoadAdUserFull(ad_org_id);
            dtboPhan = BUS_BoPhan.LoadBoPhan(ad_org_id);
            utility.SearchProcess(this.Controls, dtProcess);
        }
    }
}