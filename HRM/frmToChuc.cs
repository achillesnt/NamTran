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
using DevExpress.XtraGrid.Columns;

namespace HRM
{
    public partial class frmToChuc : DevExpress.XtraEditors.XtraForm
    {
        string ad_org_id, ad_org_description;
        DataTable dt = new DataTable();
        DataTable dtProcess = new DataTable();
        string maBoPhan = "1";
        public string deptID, relationID, levelID, tinhTrang;
        bool indicatorIcon = true;
        Utility utility = new Utility();
        public frmToChuc()
        {
            InitializeComponent();
        }

        public frmToChuc(string ad_org_id, string ad_org_description, DataTable dtProcess)
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

            foreach (DataRow dr in dt.Select("[RelationID]=" + parentId))
            {
                TreeNode t = new TreeNode();
                t.Text = dr["DescriptionVN"].ToString();
                t.Name = dr["ID"].ToString();
                t.Tag = dt.Rows.IndexOf(dr);
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

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int id = Convert.ToInt16(treeView.SelectedNode.Name);
            DataRow[] result = dt.Select("[ID]=" + id);
            foreach(DataRow row in result)
            {
                deptID = row[0].ToString();
                relationID = row[2].ToString();
                levelID = (Convert.ToInt16(row[3].ToString()) + 1).ToString();
                tinhTrang = "1";

                //Binding data to tab Thông tin
                txtTTMaBP.Text = row[4].ToString();
                txtTTTenTA.Text = row[1].ToString();
                txtTTTenTV.Text = row[7].ToString();

                //Binding data to tab sửa thông tin
                txtSuaMaBP.Text = row[4].ToString();
                txtSuaTenTA.Text = row[1].ToString();
                txtSuaTenTV.Text = row[7].ToString();

            }
            
            //dataSelect();
        }

        #endregion

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tinhTrang = "0";
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = BUS_BoPhan.UpdateBoPhan(deptID, txtSuaMaBP.Text, txtSuaTenTA.Text, txtSuaTenTV.Text, tinhTrang);
                if (i == 1)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmToChuc_Load(object sender, EventArgs e)
        {
            #region Load treeview
            dt = BUS_BoPhan.LoadNode(ad_org_id);
            TreeNode t = treeView.Nodes.Add(ad_org_description);
            t.Name = ad_org_id;
            PopulateTreeView(Convert.ToInt16(ad_org_id), t);
            treeView.ExpandAll();
            #endregion
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int i = BUS_BoPhan.InsertBoPhan(txtThemMaBP.Text, txtThemTenTA.Text, txtThemTenTV.Text, tinhTrang, deptID, levelID);
            if (i == 1)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bộ phận đã tồn tại!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int i = BUS_BoPhan.UpdateBoPhan(deptID, txtSuaMaBP.Text, txtSuaTenTA.Text, txtSuaTenTV.Text, tinhTrang);
            if(i==1)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}