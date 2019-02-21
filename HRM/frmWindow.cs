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
    public partial class frmWindow : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        string v_ad_user_id, v_ad_org_id, v_ad_org_description;
        Utility utility = new Utility();
        DataTable dtWindow = new DataTable();
        DataTable dtProcess = new DataTable();

        private void frmWindow_Load(object sender, EventArgs e)
        {
            grdWindow.DataSource = dtWindow;
            repositoryItemCheckEdit1.ValueChecked = "Y";
            repositoryItemCheckEdit1.ValueUnchecked = "N";
        }

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
                            grdWindow.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            grdWindow.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            grdWindow.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            grdWindow.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            grdWindow.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            grdWindow.ExportToMht(exportFilePath);
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

        private void btnWindowUpdate_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                #region Method 03    
                int[] selectedRowHandles = gridView1.GetSelectedRows();
                DataTable dtUpdateWindow = new DataTable();
                foreach (GridColumn column in gridView1.Columns)
                {
                    dtUpdateWindow.Columns.Add(column.FieldName, column.ColumnType);
                }
                for (int index = 0; index < selectedRowHandles.Length; index++)
                {
                    DataRow row = dtUpdateWindow.NewRow();
                    foreach (GridColumn column in gridView1.Columns)
                    {
                        row[column.FieldName] = gridView1.GetRowCellValue(selectedRowHandles[index], column);
                    }
                    dtUpdateWindow.Rows.Add(row);
                }
                #endregion   
                string sKetQua = BUS_HeThong.UpdateWindow(dtUpdateWindow);
                if (string.IsNullOrEmpty(sKetQua))
                {
                    MessageBox.Show(this, "Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Những window sau cập nhật không thành công: " + sKetQua, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnWindowSave_Click(object sender, EventArgs e)
        {
            string v_name, v_description;
            v_name = txtName.Text;
            v_description = txtDescription.Text;

            if (string.IsNullOrEmpty(v_name) || string.IsNullOrEmpty(v_description))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin cần thiết!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BUS_HeThong.CreateWindow(v_name, v_description))
                {
                    MessageBox.Show("Tạo cửa sổ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tạo cửa sổ không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public frmWindow()
        {
            InitializeComponent();
        }
        public frmWindow(string ad_user_id, string ad_org_id, DataTable dtProcess)
        {
            InitializeComponent();
            this.v_ad_user_id = ad_user_id;
            this.v_ad_org_id = ad_org_id;
            this.dtProcess = dtProcess;
            dtWindow = BUS_HeThong.LoadWindow();
            utility.SearchProcess(this.Controls, dtProcess);
        }
    }
}