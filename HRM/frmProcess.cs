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
using DevExpress.XtraGrid.Columns;
using BUS;

namespace HRM
{
    public partial class frmProcess : DevExpress.XtraEditors.XtraForm
    {
        bool indicatorIcon = true;
        string v_ad_user_id, v_ad_org_id, v_ad_org_description;
        Utility utility = new Utility();
        DataTable dtProcessF = new DataTable();
        DataTable dtProcess = new DataTable();

        private void btnProcessUpdate_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                #region Method 03    
                int[] selectedRowHandles = gridView1.GetSelectedRows();
                DataTable dtUpdateProcess = new DataTable();
                foreach (GridColumn column in gridView1.Columns)
                {
                    dtUpdateProcess.Columns.Add(column.FieldName, column.ColumnType);
                }
                for (int index = 0; index < selectedRowHandles.Length; index++)
                {
                    DataRow row = dtUpdateProcess.NewRow();
                    foreach (GridColumn column in gridView1.Columns)
                    {
                        row[column.FieldName] = gridView1.GetRowCellValue(selectedRowHandles[index], column);
                    }
                    dtUpdateProcess.Rows.Add(row);
                }
                #endregion   
                string sKetQua = BUS_HeThong.UpdateProcess(dtUpdateProcess);
                if (string.IsNullOrEmpty(sKetQua))
                {
                    MessageBox.Show(this, "Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Những process sau cập nhật không thành công: " + sKetQua, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                            grdProcess.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            grdProcess.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            grdProcess.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            grdProcess.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            grdProcess.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            grdProcess.ExportToMht(exportFilePath);
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

        public frmProcess()
        {
            InitializeComponent();
        }
        public frmProcess(string ad_user_id, string ad_org_id, DataTable dtProcess)
        {
            InitializeComponent();
            this.v_ad_user_id = ad_user_id;
            this.v_ad_org_id = ad_org_id;
            this.dtProcess = dtProcess;
            dtProcessF = BUS_HeThong.LoadProcess();
            utility.SearchProcess(this.Controls, dtProcess);
        }

        private void frmProcess_Load(object sender, EventArgs e)
        {
            grdProcess.DataSource = dtProcessF;
            repositoryItemCheckEdit1.ValueChecked = "Y";
            repositoryItemCheckEdit1.ValueUnchecked = "N";
        }
    }
}