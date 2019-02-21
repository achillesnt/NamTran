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
using DevExpress.XtraCharts;
using BUS;

namespace HRM
{
    public partial class frmQtyReport : DevExpress.XtraEditors.XtraForm
    {
        string ad_user_id, ad_org_id, ad_org_description;
        Utility utility = new Utility();
        DataTable dtboPhan = new DataTable();
        DataTable dtProcess = new DataTable();
        DataTable dtCa = new DataTable();
        DataTable dtChart1 = new DataTable();
        DataTable dtChart2 = new DataTable();

        Series series1 = new Series("Sản lượng mục tiêu", ViewType.Bar);
        Series series2 = new Series("Sản lượng thực tế", ViewType.Bar);
        Series series3 = new Series("Tỉ lệ đạt mục tiêu(%)", ViewType.Line);
        Series series4 = new Series("Sản lượng mục tiêu", ViewType.Bar);
        Series series5 = new Series("Sản lượng thực tế", ViewType.Bar);
        Series series6 = new Series("Tỉ lệ đạt mục tiêu(%)", ViewType.Line);

        ChartTitle chartTitle1 = new ChartTitle();

        private void frmQtyReport_Load(object sender, EventArgs e)
        {
            #region Xử lý lookupEdit
            lkBoPhanNgay.Properties.DataSource = dtboPhan;
            lkBoPhanNgay.Properties.DisplayMember = "description";
            lkBoPhanNgay.Properties.ValueMember = "id";
            lkBoPhanNgay.Properties.NullText = "Chọn bộ phận";
            lkBoPhanNgay.EditValue = dtboPhan.Rows[0][0];

            lkBoPhanNgay.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkBoPhanNgay.Properties.DropDownRows = dtboPhan.Rows.Count;
            //lkInput.Properties.ReadOnly = true  

            lkBoPhanTotal.Properties.DataSource = dtboPhan;
            lkBoPhanTotal.Properties.DisplayMember = "description";
            lkBoPhanTotal.Properties.ValueMember = "id";
            lkBoPhanTotal.Properties.NullText = "Chọn bộ phận";
            lkBoPhanTotal.EditValue = dtboPhan.Rows[0][0];

            lkBoPhanTotal.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkBoPhanTotal.Properties.DropDownRows = dtboPhan.Rows.Count;
            //lkInput.Properties.ReadOnly = true 
            #endregion
        }

        ChartTitle chartTitle2 = new ChartTitle();
        public frmQtyReport()
        {
            InitializeComponent();
        }

        private void searchNgay_Click(object sender, EventArgs e)
        {
            splashScreenManager5.ShowWaitForm();
            if (dateEdit.DateTime.Date != null)
            {
                // Add a title to the chart (if necessary).       
                chartControl1.Titles.Clear();
                chartTitle1.Text = "BIỂU ĐỒ SẢN LƯỢNG HẰNG NGÀY\n(" + dateEdit.DateTime.ToString("dd/MM/yyyy") + ")";
                chartTitle1.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                chartControl1.Titles.Add(chartTitle1);

                dtChart1 = BUS_SanXuat.ChartQtyDaily(dateEdit.DateTime.ToString("yyyy-MM-dd"),lkBoPhanNgay.EditValue.ToString());
                DateTime seletedDay = dateEdit.DateTime;
                DateTime previousSelectedDay = seletedDay.AddDays(-1);
                lblQtyNgay.Text = "Sản lượng ngày trước: " + BUS_SanXuat.ChartQtyTotal(previousSelectedDay.ToString("yyyy-MM-dd"), previousSelectedDay.ToString("yyyy-MM-dd"), lkBoPhanNgay.EditValue.ToString());             
                CreateChart1(dtChart1);                 
            }
            splashScreenManager5.CloseWaitForm();
        }

        public frmQtyReport(string ad_user_id, string ad_org_id, DataTable dtProcess)
        {
            InitializeComponent();
            dateEdit.DateTime = DateTime.Now;
            dateEdit1.DateTime = DateTime.Now;
            this.ad_user_id = ad_user_id;
            this.ad_org_id = ad_org_id;
            this.dtProcess = dtProcess;
            dtboPhan = BUS_BoPhan.LoadBoPhan(ad_org_id);
            utility.SearchProcess(this.Controls, dtProcess);

            dateEdit.DateTime = DateTime.Now;
            dateEdit1.DateTime = DateTime.Now;
            dateEdit2.DateTime = DateTime.Now;

            #region Chart control 1
            // Create an empty Bar series and add it to the chart.
            chartControl1.Series.Add(series1);
            series1.View.Color = Color.Green;

            chartControl1.Series.Add(series2);
            series2.View.Color = Color.DarkGoldenrod;

            chartControl1.Series.Add(series3);
            series3.View.Color = Color.Red;

            //Show point view lable and customize it
            chartControl1.Series["Sản lượng mục tiêu"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            SideBySideBarSeriesLabel label1 = chartControl1.Series["Sản lượng mục tiêu"].Label as SideBySideBarSeriesLabel;
            if (label1 != null)
            {
                label1.Position = BarSeriesLabelPosition.Top;
            }

            chartControl1.Series["Sản lượng thực tế"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            SideBySideBarSeriesLabel label2 = chartControl1.Series["Sản lượng thực tế"].Label as SideBySideBarSeriesLabel;
            if (label2 != null)
            {
                label2.Position = BarSeriesLabelPosition.Top;
            }

            chartControl1.Series["Tỉ lệ đạt mục tiêu(%)"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            SideBySideBarSeriesLabel label3 = chartControl1.Series["Tỉ lệ đạt mục tiêu(%)"].Label as SideBySideBarSeriesLabel;
            if (label3 != null)
            {
                label3.Position = BarSeriesLabelPosition.Top;
            }

            // Cast Diagram to the XYDiagram type. 
            XYDiagram diagram = chartControl1.Diagram as XYDiagram;
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisY.Title.Text = "Sản lượng (k)";
            diagram.AxisY.Title.Font = new Font("Times New Roman", 10, FontStyle.Regular);

            // Add a title to the chart (if necessary).           
            chartTitle1.Text = "BIỂU ĐỒ SẢN LƯỢNG HẰNG NGÀY\n(" + DateTime.Now.ToString("dd/MM/yyyy") + ")";
            chartTitle1.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            chartControl1.Titles.Add(chartTitle1);

            // Control legend & position
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chartControl1.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            chartControl1.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside;
            chartControl1.Legend.Direction = LegendDirection.LeftToRight;
            chartControl1.Legend.EquallySpacedItems = true;

            //Create secondary Y-Axis, and add them to the chart's diagram
            SecondaryAxisY myAxisY = new SecondaryAxisY("Y-Axis");
            ((XYDiagram)chartControl1.Diagram).SecondaryAxesY.Add(myAxisY);

            //Assign series3 to the created axis
            ((LineSeriesView)series3.View).AxisY = myAxisY;

            //Customize the apperance of the secondary axis 
            myAxisY.Title.Text = "Tỉ lệ đạt mục tiêu(%)";
            myAxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            myAxisY.Title.TextColor = Color.Red;
            myAxisY.Title.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            myAxisY.Label.TextColor = Color.Red;
            myAxisY.Color = Color.Red;
            #endregion

            #region Chart control 2
            // Create an empty Bar series and add it to the chart.
            chartControl2.Series.Add(series4);
            series4.View.Color = Color.Green;

            chartControl2.Series.Add(series5);
            series5.View.Color = Color.DarkGoldenrod;

            chartControl2.Series.Add(series6);
            series6.View.Color = Color.Red;

            //Show point view lable and customize it
            chartControl2.Series["Sản lượng mục tiêu"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            SideBySideBarSeriesLabel label4 = chartControl2.Series["Sản lượng mục tiêu"].Label as SideBySideBarSeriesLabel;
            if (label4 != null)
            {
                label4.Position = BarSeriesLabelPosition.Top;
            }

            chartControl2.Series["Sản lượng thực tế"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            SideBySideBarSeriesLabel label5 = chartControl2.Series["Sản lượng thực tế"].Label as SideBySideBarSeriesLabel;
            if (label5 != null)
            {
                label5.Position = BarSeriesLabelPosition.Top;
            }

            //chartControl2.Series["Tỉ lệ đạt mục tiêu(%)"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            //SideBySideBarSeriesLabel label6 = chartControl2.Series["Tỉ lệ đạt mục tiêu(%)"].Label as SideBySideBarSeriesLabel;
            //if (label6 != null)
            //{
            //    label6.Position = BarSeriesLabelPosition.Top;
            //}

            // Cast Diagram to the XYDiagram type. 
            XYDiagram diagram2 = chartControl2.Diagram as XYDiagram;
            diagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram2.AxisY.Title.Text = "Sản lượng (k)";
            diagram2.AxisY.Title.Font = new Font("Times New Roman", 10, FontStyle.Regular);

            // Add a title to the chart (if necessary).           
            chartTitle2.Text = "BIỂU ĐỒ SẢN LƯỢNG HẰNG THÁNG\n(" + "01/" + DateTime.Now.ToString("MM/yyyy") + " - " + DateTime.Now.ToString("dd/MM/yyyy") + ")";
            chartTitle2.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            chartControl2.Titles.Add(chartTitle2);

            // Control legend & position
            chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chartControl2.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            chartControl2.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside;
            chartControl2.Legend.Direction = LegendDirection.LeftToRight;
            chartControl2.Legend.EquallySpacedItems = true;

            //Create secondary Y-Axis, and add them to the chart's diagram
            SecondaryAxisY myAxisY2 = new SecondaryAxisY("Y-Axis2");
            ((XYDiagram)chartControl2.Diagram).SecondaryAxesY.Add(myAxisY2);

            //Assign series3 to the created axis
            ((LineSeriesView)series6.View).AxisY = myAxisY2;

            //Customize the apperance of the secondary axis 
            myAxisY2.Title.Text = "Tỉ lệ đạt mục tiêu(%)";
            myAxisY2.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            myAxisY2.Title.TextColor = Color.Red;
            myAxisY2.Title.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            myAxisY2.Label.TextColor = Color.Red;
            myAxisY2.Color = Color.Red;
            #endregion

            dtChart1 = BUS_SanXuat.ChartQtyDaily(DateTime.Now.ToString("yyyy-MM-dd"), ad_org_id);
            DateTime today = DateTime.Today;
            DateTime yesterday = today.AddDays(-1);
            lblQtyNgay.Text = "Sản lượng ngày trước (k): " + BUS_SanXuat.ChartQtyTotal(yesterday.ToString("yyyy-MM-dd"), yesterday.ToString("yyyy-MM-dd"), ad_org_id);
            CreateChart1(dtChart1);

            dtChart2 = BUS_SanXuat.ChartQtyMonthly(DateTime.Now.ToString("yyyy-MM-") + "01", DateTime.Now.ToString("yyyy-MM-dd"), ad_org_id);
            DateTime currentMonth = DateTime.Today;
            DateTime lastMonth = currentMonth.AddMonths(-1);
            lblQtyMonth.Text = "Sản lượng tháng trước (k): " + BUS_SanXuat.ChartQtyTotal(lastMonth.ToString("yyyy-MM-") + "01", lastMonth.ToString("yyyy-MM-") + "31", ad_org_id);
            CreateChart2(dtChart2);
        }

        private void searchTotal_Click(object sender, EventArgs e)
        {
            splashScreenManager5.ShowWaitForm();
            if (dateEdit1.DateTime.Date > dateEdit2.DateTime.Date)
            {
                MessageBox.Show("Ngày bắt đàu không được lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Add a title to the chart (if necessary).  
                chartControl2.Titles.Clear();
                chartTitle2.Text = "BIỂU ĐỒ SẢN LƯỢNG HẰNG THÁNG\n(" + dateEdit1.DateTime.ToString("dd/MM/yyyy") + " - " + dateEdit2.DateTime.ToString("dd/MM/yyyy") + ")";
                chartTitle2.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                chartControl2.Titles.Add(chartTitle2);

                dtChart2 = BUS_SanXuat.ChartQtyMonthly(dateEdit1.DateTime.ToString("yyyy-MM-dd"), dateEdit2.DateTime.ToString("yyyy-MM-dd"), lkBoPhanTotal.EditValue.ToString());
                DateTime selectedMonth1 = dateEdit1.DateTime;
                DateTime previousSelectedMonth1 = selectedMonth1.AddMonths(-1);
                DateTime selectedMonth2 = dateEdit2.DateTime;
                DateTime previousSelectedMonth2 = selectedMonth2.AddMonths(-1);
                lblQtyMonth.Text = "Sản lượng tháng trước: " + BUS_SanXuat.ChartQtyTotal(previousSelectedMonth1.ToString("yyyy-MM-dd"), previousSelectedMonth2.ToString("yyyy-MM-dd"), lkBoPhanTotal.EditValue.ToString());
                CreateChart2(dtChart2);
            }
            splashScreenManager5.CloseWaitForm();
        }

        private void exportNgay_Click(object sender, EventArgs e)
        {
            string path1 = null;
            //Khởi tạo saveFiledialog
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image|*.png|All|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path1 = dialog.FileName.ToString();
                if (chartControl1.IsPrintingAvailable)
                {
                    chartControl1.ExportToImage(path1, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private void exportTotal_Click(object sender, EventArgs e)
        {
            string path1 = null;
            //Khởi tạo saveFiledialog
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image|*.png|All|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path1 = dialog.FileName.ToString();
                if (chartControl2.IsPrintingAvailable)
                {
                    chartControl2.ExportToImage(path1, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private void CreateChart1(DataTable dt)
        {
            #region Chart control 1  
            //Assign data source to series
            series1.DataSource = dt;
            series2.DataSource = dt;
            series3.DataSource = dt;

            // Specify data members to bind the series.
            //series.ArgumentScaleType = ScaleType.Numerical;
            series1.ArgumentDataMember = "inputname";
            series1.ValueScaleType = ScaleType.Numerical;
            series1.ValueDataMembers.AddRange(new string[] { "output_target" });

            series2.ArgumentDataMember = "inputname";
            series2.ValueScaleType = ScaleType.Numerical;
            series2.ValueDataMembers.AddRange(new string[] { "output_actual" });

            series3.ArgumentDataMember = "inputname";
            series3.ValueScaleType = ScaleType.Numerical;
            series3.ValueDataMembers.AddRange(new string[] { "qty_rate" });
            #endregion
        }

        private void CreateChart2(DataTable dt2)
        {
            #region Chart control 2 
            //Assign data source to series
            series4.DataSource = dt2;
            series5.DataSource = dt2;
            series6.DataSource = dt2;

            // Specify data members to bind the series.
            //series.ArgumentScaleType = ScaleType.Numerical;
            series4.ArgumentDataMember = "documentdate";
            series4.ValueScaleType = ScaleType.Numerical;
            series4.ValueDataMembers.AddRange(new string[] { "output_target" });

            series5.ArgumentDataMember = "documentdate";
            series5.ValueScaleType = ScaleType.Numerical;
            series5.ValueDataMembers.AddRange(new string[] { "output_actual" });

            series6.ArgumentDataMember = "documentdate";
            series6.ValueScaleType = ScaleType.Numerical;
            series6.ValueDataMembers.AddRange(new string[] { "qty_rate" });
            #endregion
        }
    }
}