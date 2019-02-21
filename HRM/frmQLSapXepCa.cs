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
using DTO;
using BUS;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System.Collections;
using System.Reflection;

namespace HRM
{
    public partial class frmQLSapXepCa : DevExpress.XtraEditors.XtraForm
    {
        int mode = 0;
        bool indicatorIcon = true;    
        string ad_org_id, ad_org_description;
        DataTable dtboPhan = new DataTable();
        DataTable dtNV = new DataTable();
        DataTable dtProcess = new DataTable();      
        Utility utility = new Utility();

        public frmQLSapXepCa()
        {
            InitializeComponent();
        }

        public frmQLSapXepCa(string ad_org_id, string ad_org_description, DataTable dtProcess)
        {
            InitializeComponent();
            this.ad_org_id = ad_org_id;
            this.ad_org_description = ad_org_description;
            this.dtProcess = dtProcess;
            utility.SearchProcess(this.Controls, dtProcess);
        }

        #region Xử lý treeview
        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {

            TreeNode childNode;

            foreach (DataRow dr in dtboPhan.Select("[RelationID]=" + parentId))
            {
                TreeNode t = new TreeNode();
                t.Text = dr["DescriptionVN"].ToString();
                t.Name = dr["ID"].ToString();
                t.Tag = dtboPhan.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    treeView.Nodes.Add(t);
                    childNode = t;
                }
                else
                {
                    parentNode.Nodes.Add(t);
                    childNode = t;
                }
                PopulateTreeView(Convert.ToInt32(dr["ID"].ToString()), childNode);
            }
        }

        private void frmQLSapXepCa_Load(object sender, EventArgs e)
        {
            dtboPhan = BUS_BoPhan.LoadNode(ad_org_id);
            TreeNode t = treeView.Nodes.Add(ad_org_description);
            t.Name = ad_org_id;
            treeView.SelectedNode = t;
            PopulateTreeView(Convert.ToInt16(ad_org_id), t);
            treeView.ExpandAll();

            dataSelect(ad_org_id);

        }

        private void txtTimNV_TextChanged(object sender, EventArgs e)
        {
            dataSelect(ad_org_id);
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (gridViewNhanVien.SelectedRowsCount > 0)
            {
                #region Method 01 
                /*
                ArrayList rows = new ArrayList();
                // Add the selected rows to the list.
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    if (gridView1.GetSelectedRows()[i] >= 0)
                    {
                        rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
                    }                    
                }
                try
                {
                    textBox1.Text = "";
                    gridView1.BeginUpdate();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i] as DataRow;
                        textBox1.Text = row["DEPARTMENT"].ToString();
                    }
                }
                finally
                {
                    gridView1.EndUpdate();
                }     
                */
                #endregion

                #region Method 02
                
                List<DTO_NhanVien> lstNhanVien = new List<DTO_NhanVien>();
                DTO_NhanVien nhanvienDTO;
                // Add the selected rows to the list.
                for (int i = 0; i < gridViewNhanVien.SelectedRowsCount; i++)
                {
                    nhanvienDTO = new DTO_NhanVien();
                    if (gridViewNhanVien.GetSelectedRows()[i] >= 0)
                    {
                        nhanvienDTO.UserFullCode = gridViewNhanVien.GetRowCellValue(gridViewNhanVien.GetSelectedRows()[i], "staff_id_c").ToString();
                        nhanvienDTO.UserFullName = gridViewNhanVien.GetRowCellValue(gridViewNhanVien.GetSelectedRows()[i], "staff_name_c").ToString();
                        nhanvienDTO.TitleName = gridViewNhanVien.GetRowCellValue(gridViewNhanVien.GetSelectedRows()[i], "title_c").ToString();
                        nhanvienDTO.DescriptionVN = gridViewNhanVien.GetRowCellValue(gridViewNhanVien.GetSelectedRows()[i], "dept_name_c").ToString();
                        nhanvienDTO.UserHireDay = gridViewNhanVien.GetRowCellValue(gridViewNhanVien.GetSelectedRows()[i], "staff_hire_date_c").ToString();
                    }
                    lstNhanVien.Add(nhanvienDTO);
                }
                
                /*
                DataTable dtPhanCa = new DataTable();
                foreach (GridColumn column in gridViewNhanVien.Columns)
                {
                    dtPhanCa.Columns.Add(column.FieldName, column.ColumnType);
                }

                Int32[] selectedRowHandles = gridViewNhanVien.GetSelectedRows();
                DataRow row = dtPhanCa.NewRow();
                for (int i = 0; i< selectedRowHandles.Length; i++)
                {
                    int selectedRowHandle = selectedRowHandles[i];
                    if(selectedRowHandle >= 0)
                    {                       
                        row = gridViewNhanVien.GetDataRow(selectedRowHandle);
                        dtPhanCa.Rows.Add(row);
                    }
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
                */

                #endregion

                frmPhanCa phanCa = new frmPhanCa(lstNhanVien, ad_org_id);
                phanCa.FormClosed += new FormClosedEventHandler(PhanCa_FormClosed);
                phanCa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PhanCa_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            dataSelect(ad_org_id);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ad_org_id = treeView.SelectedNode.Name.ToString();
            dataSelect(ad_org_id);
        }
        #endregion

        private void grdNhanvien_Click(object sender, EventArgs e)
        {
            //string maNV = gridViewNhanVien.GetFocusedValue();
            grdPhanCa.DataSource = BUS_PhanCa.LoadBangPhanCa(label1.Text);
            GridViewLookupEdit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            #region Method 02 - Xử lý bằng datatable
            DataTable dt = new DataTable();
            foreach (GridColumn column in gridViewPhanCa.Columns)
            {
                dt.Columns.Add(column.FieldName, column.ColumnType);
            }
            for (int i = 0; i < gridViewPhanCa.DataRowCount; i++)
            {
                DataRow row = dt.NewRow();
                foreach (GridColumn column in gridViewPhanCa.Columns)
                {
                    row[column.FieldName] = gridViewPhanCa.GetRowCellValue(i, column);
                }
                dt.Rows.Add(row);
            }
            #endregion
            //string sKetQua = BUS_PhanCa.UpdatePhanCa(ToDataTable<DTO_PhanCa>(lstPhanCa));
            string sKetQua = BUS_PhanCa.UpdatePhanCa(dt);
            if (string.IsNullOrEmpty(sKetQua))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật các dòng phân ca có ngày nhỏ hơn ngày hiện tại\nHoặc các ngày sau đã được phân ca trước đó: " + sKetQua, "Cập nhật không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grdPhanCa.DataSource = BUS_PhanCa.LoadBangPhanCa(label1.Text);
                GridViewLookupEdit();
            }
            #region Xử lý bằng listview
            /*
            if (gridViewPhanCa.SelectedRowsCount > 0)
            {              
                /*
                List<DTO_PhanCa> lstPhanCa = new List<DTO_PhanCa>();
                DTO_PhanCa phancaDTO;
                // Add the selected rows to the list.
                for (int i = 0; i < gridViewPhanCa.SelectedRowsCount; i++)
                {
                    phancaDTO = new DTO_PhanCa();
                    if (gridViewPhanCa.GetSelectedRows()[i] >= 0)
                    {
                        phancaDTO.ID = gridViewPhanCa.GetRowCellValue(gridViewPhanCa.GetSelectedRows()[i], "ID").ToString();
                        phancaDTO.STAFFID = gridViewPhanCa.GetRowCellValue(gridViewPhanCa.GetSelectedRows()[i], "STAFFID").ToString();
                        phancaDTO.EffectiveDate = gridViewPhanCa.GetRowCellValue(gridViewPhanCa.GetSelectedRows()[i], "EffectiveDate").ToString();
                        phancaDTO.ShiftID = gridViewPhanCa.GetRowCellValue(gridViewPhanCa.GetSelectedRows()[i], "ShiftID").ToString();                    
                    }
                    lstPhanCa.Add(phancaDTO);
                }                                            
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu trước khi thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
            #endregion
        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public void dataSelect(string boPhan)
        {
            //string tinhTrang = "Đang làm việc";
            dtNV = BUS_NhanVien.LoadNhanVien(boPhan, mode);
            grdNhanvien.DataSource = dtNV;
            BindingDanhSachPhanCa();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridViewPhanCa.SelectedRowsCount > 0)
            {
                if (DialogResult.Yes != MessageBox.Show(this, "Bạn có chắc chắn muốn xóa?\nLưu ý: chỉ xóa được những dòng phân ca có ngày hiệu lực bằng hoặc lớn hơn ngày hiện tại.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return;
                }
                else
                {
                    string sID = "";
                    for (int i = 0; i < gridViewPhanCa.SelectedRowsCount; i++)
                    {
                        DateTime shift_arrange_effective = Convert.ToDateTime(gridViewPhanCa.GetRowCellValue(gridViewPhanCa.GetSelectedRows()[i], "shift_arrange_effective")).Date;
                        DateTime toDay = DateTime.Now.Date;
                        if(toDay < shift_arrange_effective)
                        {
                            if (i < gridViewPhanCa.SelectedRowsCount - 1)
                            {
                                sID += gridViewPhanCa.GetRowCellValue(gridViewPhanCa.GetSelectedRows()[i], "shift_arrange_id").ToString() + ",";
                            }
                            else
                            {
                                sID += gridViewPhanCa.GetRowCellValue(gridViewPhanCa.GetSelectedRows()[i], "shift_arrange_id").ToString();
                            }
                        }                    
                    }
                    if(!string.IsNullOrEmpty(sID))
                    {
                        int sKetQua = BUS_PhanCa.XoaPhanCa(sID);
                        if (sKetQua == 1)
                        {
                            MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            grdPhanCa.DataSource = BUS_PhanCa.LoadBangPhanCa(label1.Text);
                            GridViewLookupEdit();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }              
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng phân ca muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BindingDanhSachPhanCa()
        {
            if (grdNhanvien.MainView.RowCount > 0)
            {
                //string maNV = gridViewNhanVien.GetRowCellValue(gridViewNhanVien.GetSelectedRows()[0], "UserFullCode").ToString();
                label1.DataBindings.Clear();
                label1.DataBindings.Add("Text", grdNhanvien.DataSource, "staff_id_c");
                grdPhanCa.DataSource = BUS_PhanCa.LoadBangPhanCa(label1.Text);
                GridViewLookupEdit();
            }
            else
            {
                label1.Text = "";
            }
        }

        public void GridViewLookupEdit()
        {
            // Create an in-place LookupEdit control.
            //RepositoryItemLookUpEdit repositoryItemGridLookUpEdit1 = new RepositoryItemLookUpEdit();
            DataTable dtShift = BUS_Ca.LoadCa();
            repositoryItemLookUpEdit1.DataSource = dtShift;
            repositoryItemLookUpEdit1.ValueMember = "id";
            repositoryItemLookUpEdit1.DisplayMember = "name";

            
            // Enable the "best-fit" functionality mode in which columns have proportional widths and the popup window is resized to fit all the columns.
            repositoryItemGridLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            repositoryItemLookUpEdit1.DropDownRows = BUS_Ca.LoadCa().Rows.Count;

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
            

            gridViewPhanCa.Columns["shift_id"].ColumnEdit = repositoryItemLookUpEdit1;
            gridViewPhanCa.BestFitColumns();
        }
    }
}