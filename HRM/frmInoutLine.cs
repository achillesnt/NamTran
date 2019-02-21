using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DTO;
using DevExpress.XtraGrid;
using BUS;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace HRM
{
    public partial class frmInoutLine : DevExpress.XtraEditors.XtraForm
    {             
        bool indicatorIcon = true;
        string ad_user_id, ad_org_id, ad_org_description, m_inout_id, ngaytao, document_type_code, documentStatus, _inoutline_id;
        Utility utility = new Utility();
        DataTable dtProcess = new DataTable();

        DataTable dtInout = new DataTable();
        DataTable dtInoutLine = new DataTable();
        DataTable dtInput = new DataTable();
        DataTable dtAttendance = new DataTable();
        public frmInoutLine()
        {
            InitializeComponent();
        }
        public frmInoutLine(DataTable dtInout, DataTable dtProcess)
        {
            InitializeComponent();
            this.dtInout = dtInout;
            this.dtProcess = dtProcess;

            m_inout_id = dtInout.Rows[0][0].ToString();
            ad_org_id = dtInout.Rows[0][2].ToString();
            document_type_code = dtInout.Rows[0][6].ToString();
            txtDocumentno.Text = dtInout.Rows[0][1].ToString();
            txtDeptname.Text = dtInout.Rows[0][3].ToString();
            documentStatus = dtInout.Rows[0][12].ToString();
            txtDocumentstatus.Text = documentStatus;
            txtDocumenttype.Text = dtInout.Rows[0][9].ToString();
            txtInouttime.Text = dtInout.Rows[0][10].ToString();
            txtTypename.Text = dtInout.Rows[0][5].ToString();
            txtPartname.Text = dtInout.Rows[0][7].ToString();
            dtInput = BUS_SanXuat.LoadInputPeriod(ad_org_id);
            
            utility.SearchProcess(this.Controls, dtProcess);

        }

        #region Gridview indicator
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.Compare(documentStatus, "Đã đóng") == 0)
            {
                MessageBox.Show(this, "Chứng từ đã đóng, không thể thêm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string headCount = txtHeadcount.Text;
                string outPut = txtOutput.Text;
                if (!string.IsNullOrEmpty(headCount) && !string.IsNullOrEmpty(outPut))
                {
                    bool flag = BUS_SanXuat.InputLine(m_inout_id, lkInput.EditValue.ToString(), txtHeadcount.Text, txtOutput.Text,txtNote.Text);
                    if (!flag)
                    {
                        MessageBox.Show("Dữ liệu đã tồn tại.\n Vui lòng loại bỏ dữ liệu đã có trước khi tạo mới.", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dtInoutLine = BUS_SanXuat.GetInoutLine(m_inout_id);
                        grdInoutLine.DataSource = dtInoutLine;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập các dữ liệu cần thiết!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtHeadcount.Text = "";
            txtOutput.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.Compare(documentStatus, "Đã đóng") == 0)
            {
                MessageBox.Show(this, "Chứng từ đã đóng, không thể xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int[] selectedRows = gridView.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        _inoutline_id = gridView.GetRowCellValue(rowHandle, m_inoutline_id).ToString();
                        bool flag = BUS_SanXuat.RemoveLine(_inoutline_id);
                        if (!flag)
                        {
                            MessageBox.Show("Reomve không thành công.", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dtInoutLine = BUS_SanXuat.GetInoutLine(m_inout_id);
                            grdInoutLine.DataSource = dtInoutLine;
                        }
                    }
                }
            }
        }

        private void gridView_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 10;
        }

        private void frmInoutLine_Load(object sender, EventArgs e)
        {

            if (string.Compare(document_type_code, "ITG") == 0)
            {
                lkInputProcess(false);
            }
            else
            {
                lkInputProcess(false);
            }


            dtInoutLine = BUS_SanXuat.GetInoutLine(m_inout_id);
            grdInoutLine.DataSource = dtInoutLine;

            groupControl3.Text = "Headcount ngày " + DateTime.Now.Date.ToString("dd/MM/yyyy");
            dtAttendance = BUS_BaoCom.LoadAttendance(ad_org_id);
            txtTotal.Text = dtAttendance.Rows[0][1].ToString();
            txtAttendance.Text = dtAttendance.Rows[0][2].ToString();
            txtAbsent.Text = dtAttendance.Rows[0][3].ToString();
        }

        private void lkInputProcess(bool flag)
        {
            string hour = DateTime.Now.Hour.ToString();
            if (flag)
            {
                dtInput.DefaultView.RowFilter = string.Format("[from] <= '{0}'", hour);
            }
            lkInput.Properties.DataSource = dtInput;
            lkInput.Properties.DisplayMember = "inputname";
            lkInput.Properties.ValueMember = "inputcode";
            lkInput.Properties.NullText = "Chọn lượt nhập";
            lkInput.EditValue = dtInput.Rows[0][0];

            lkInput.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkInput.Properties.DropDownRows = dtInput.Rows.Count;
            //lkInput.Properties.ReadOnly = true;
        }
    }
}