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
using DevExpress.XtraCharts;

namespace HRM
{
    public partial class frmAttReport : DevExpress.XtraEditors.XtraForm
    {
        string ad_user_id, ad_org_id, ad_org_description;
        Utility utility = new Utility();
        DataTable dtboPhan = new DataTable();
        DataTable dtProcess = new DataTable();
        DataTable dtCa = new DataTable();
        DataTable dtChart1 = new DataTable();
        DataTable dtChart2 = new DataTable();

        Series series1 = new Series("Tổng số người", ViewType.Bar);
        Series series2 = new Series("Số người vắng", ViewType.Bar);     
        Series series3 = new Series("Số người nghỉ việc", ViewType.Bar);
        Series series4 = new Series("Tỉ lệ người vắng(%)", ViewType.Line);

        Series seriesPie = new Series("seriesPie", ViewType.Pie3D);
        
        ChartTitle chartTitle1 = new ChartTitle();
        ChartTitle chartTitle2 = new ChartTitle();

        private void frmAttReport_Load(object sender, EventArgs e)
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
            //lkShift.EditValue = dtCa.Rows[0][0];

            lkShift.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            lkShift.Properties.DropDownRows = dtCa.Rows.Count;
            //lkInput.Properties.ReadOnly = true;  

            #endregion
        }
        public frmAttReport()
        {
            InitializeComponent();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            splashScreenManager5.ShowWaitForm();
            if(dateEdit.DateTime.Date > dateEdit1.DateTime.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(string.Compare(dateEdit.DateTime.ToString("MM"),dateEdit1.DateTime.ToString("MM"))!= 0)
                {
                    MessageBox.Show("Ngày bắt đầu và ngày kết thúc phải trong cùng một tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string maCa;
                    if (lkShift.EditValue == null)
                    {
                        maCa = "0";
                    }
                    else
                    {
                        maCa = lkShift.EditValue.ToString();
                    }
                    // Add a title to the chart (if necessary).       
                    chartControl1.Titles.Clear();
                    chartTitle1.Text = "BIỂU ĐỒ NHÂN SỰ\n(" + dateEdit.DateTime.ToString("dd/MM/yyyy") + " - " + dateEdit1.DateTime.ToString("dd/MM/yyyy") + ")";
                    chartTitle1.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                    chartControl1.Titles.Add(chartTitle1);

                    // Add a title to the chart (if necessary).
                    chartControl2.Titles.Clear();
                    chartTitle2.Text = "BIỂU ĐỒ TỈ LỆ NGƯỜI VẮNG\n(" + dateEdit.DateTime.ToString("dd/MM/yyyy") + " - " + dateEdit1.DateTime.ToString("dd/MM/yyyy") + ")";
                    chartTitle2.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                    chartControl2.Titles.Add(chartTitle2);

                    dtChart1 = BUS_ChamCong.ChartDiemDanh(dateEdit.DateTime.ToString("yyyy-MM-dd"), dateEdit1.DateTime.ToString("yyyy-MM-dd"), lkBoPhan.EditValue.ToString(), maCa);
                    dtChart2 = Utility.CopyChart(dtChart1, dateEdit.DateTime.ToString("dd"), dateEdit1.DateTime.ToString("dd"));
                    CreateChart(dtChart1, dtChart2);
                }              
            }
            splashScreenManager5.CloseWaitForm();   
        }
        private void Export_Click(object sender, EventArgs e)
        {
            string path1 = null, path2 = null;
            //Khởi tạo saveFiledialog
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image|*.png|All|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path1 = dialog.FileName.ToString();
                path2 = path1.Substring(0, path1.Length - 4) + RandomNumber() + ".png";
                if (chartControl1.IsPrintingAvailable && chartControl2.IsPrintingAvailable)
                {
                    chartControl1.ExportToImage(path1, System.Drawing.Imaging.ImageFormat.Png);
                    chartControl2.ExportToImage(path2, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }
        public frmAttReport(string ad_user_id, string ad_org_id, DataTable dtProcess)
        {
            InitializeComponent();
            dateEdit.DateTime = DateTime.Now;
            dateEdit1.DateTime = DateTime.Now;
            this.ad_user_id = ad_user_id;
            this.ad_org_id = ad_org_id;
            this.dtProcess = dtProcess;
            dtCa = BUS_Ca.LoadCaShift(DateTime.Now.Date, ad_org_id);
            dtboPhan = BUS_BoPhan.LoadBoPhan(ad_org_id);
            utility.SearchProcess(this.Controls, dtProcess);

            #region Chart control 1
            // Create an empty Bar series and add it to the chart.
            chartControl1.Series.Add(series1);
            series1.View.Color = Color.Green;

            chartControl1.Series.Add(series2);
            series2.View.Color = Color.DarkGoldenrod;
          
            chartControl1.Series.Add(series3);
            series3.View.Color = Color.Red;

            chartControl1.Series.Add(series4);
            series4.View.Color = Color.Red;

            //Show point view lable and customize it
            chartControl1.Series["Tổng số người"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            SideBySideBarSeriesLabel label1 = chartControl1.Series["Tổng số người"].Label as SideBySideBarSeriesLabel;
            if (label1 != null)
            {
                label1.Position = BarSeriesLabelPosition.Top;
            }

            chartControl1.Series["Số người vắng"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            SideBySideBarSeriesLabel label2 = chartControl1.Series["Số người vắng"].Label as SideBySideBarSeriesLabel;
            if (label2 != null)
            {
                label2.Position = BarSeriesLabelPosition.Top;
            }

            chartControl1.Series["Số người nghỉ việc"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            SideBySideBarSeriesLabel label3 = chartControl1.Series["Số người nghỉ việc"].Label as SideBySideBarSeriesLabel;
            if (label3 != null)
            {
                label3.Position = BarSeriesLabelPosition.Top;
            }

            chartControl1.Series["Tỉ lệ người vắng(%)"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            SideBySideBarSeriesLabel label4 = chartControl1.Series["Tỉ lệ người vắng(%)"].Label as SideBySideBarSeriesLabel;
            if (label4 != null)
            {
                label4.Position = BarSeriesLabelPosition.Top;
            }        

            // Cast Diagram to the XYDiagram type. 
            XYDiagram diagram = chartControl1.Diagram as XYDiagram;
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisY.Title.Text = "Số lượng người";
            diagram.AxisY.Title.Font = new Font("Times New Roman", 10, FontStyle.Regular);

            // Add a title to the chart (if necessary).           
            chartTitle1.Text = "BIỂU ĐỒ NHÂN SỰ\n(" + "01" + DateTime.Now.ToString("/MM/yyyy") + " - " + DateTime.Now.ToString("dd/MM/yyyy") + ")";
            chartTitle1.Font = new Font("Times New Roman",15,FontStyle.Bold);
            chartControl1.Titles.Add(chartTitle1);

            // Control legend & position
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chartControl1.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            chartControl1.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside;
            chartControl1.Legend.Direction = LegendDirection.LeftToRight;
            chartControl1.Legend.EquallySpacedItems = true;

            //Create secondary Y-Axis, and add them to the chart's diagram
            SecondaryAxisY myAxisY2 = new SecondaryAxisY("Y-Axis2");
            ((XYDiagram)chartControl1.Diagram).SecondaryAxesY.Add(myAxisY2);

            //Assign series4 to the created axis
            ((LineSeriesView)series4.View).AxisY = myAxisY2;

            //Customize the apperance of the secondary axis 
            myAxisY2.Title.Text = "Tỉ lệ người vắng(%)";
            myAxisY2.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            myAxisY2.Title.TextColor = Color.Red;
            myAxisY2.Title.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            myAxisY2.Label.TextColor = Color.Red;
            myAxisY2.Color = Color.Red;
            #endregion

            #region Chart control 2                
            // Add a title to the chart (if necessary).
            chartControl2.Titles.Clear();
            chartTitle2.Text = "BIỂU ĐỒ TỈ LỆ NGƯỜI VẮNG\n(" + "01" + DateTime.Now.ToString("/MM/yyyy") + " - " + DateTime.Now.ToString("dd/MM/yyyy") + ")";
            chartTitle2.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            chartControl2.Titles.Add(chartTitle2);         

            
            #endregion
            dtChart1 = BUS_ChamCong.ChartDiemDanh(DateTime.Now.ToString("yyyy-MM-") + "01", DateTime.Now.ToString("yyyy-MM-dd"), ad_org_id, "0");
            dtChart2 = Utility.CopyChart(dtChart1, "01", DateTime.Now.ToString("dd"));
            CreateChart(dtChart1, dtChart2);
        }
        private void CreateChart(DataTable dt, DataTable dt2)
        {
            #region Chart control 1  
            //Assign data source to series
            series1.DataSource = dt;
            series2.DataSource = dt;
            series3.DataSource = dt;
            series4.DataSource = dt;

            // Specify data members to bind the series.
            //series.ArgumentScaleType = ScaleType.Numerical;
            series1.ArgumentDataMember = "att_date";
            series1.ValueScaleType = ScaleType.Numerical;
            series1.ValueDataMembers.AddRange(new string[] { "total" });

            series2.ArgumentDataMember = "att_date";
            series2.ValueScaleType = ScaleType.Numerical;
            series2.ValueDataMembers.AddRange(new string[] { "absent" });

            series3.ArgumentDataMember = "att_date";
            series3.ValueScaleType = ScaleType.Numerical;
            series3.ValueDataMembers.AddRange(new string[] { "running_total" }); 

            series4.ArgumentDataMember = "att_date";
            series4.ValueScaleType = ScaleType.Numerical;
            series4.ValueDataMembers.AddRange(new string[] { "absent_rate" });
            #endregion

            #region Chart control 2
            chartControl2.Series.Clear();
            seriesPie.Points.Clear();
            seriesPie.Points.Add(new SeriesPoint("Nghỉ phát sinh( " + dt2.Rows[0]["A02"].ToString() +" )", Convert.ToInt64(dt2.Rows[0]["A02"])));
            seriesPie.Points.Add(new SeriesPoint("Nghỉ nửa ngày( " + dt2.Rows[0]["A03"].ToString() +" )", Convert.ToInt64(dt2.Rows[0]["A03"])));
            seriesPie.Points.Add(new SeriesPoint("Việc riêng không lương( " + dt2.Rows[0]["A04"].ToString() + " )", Convert.ToInt64(dt2.Rows[0]["A04"])));
            seriesPie.Points.Add(new SeriesPoint("Nghỉ thai sản( " + dt2.Rows[0]["A05"].ToString() + " )", Convert.ToInt64(dt2.Rows[0]["A05"])));
            seriesPie.Points.Add(new SeriesPoint("Nghỉ phép năm( " + dt2.Rows[0]["A06"].ToString() + " )", Convert.ToInt64(dt2.Rows[0]["A06"])));
            seriesPie.Points.Add(new SeriesPoint("Nghỉ đào tạo( " + dt2.Rows[0]["A09"].ToString() + " )", Convert.ToInt64(dt2.Rows[0]["A09"])));
            seriesPie.Points.Add(new SeriesPoint("Nghỉ công tác( " + dt2.Rows[0]["A10"].ToString() + " )", Convert.ToInt64(dt2.Rows[0]["A10"])));

            // Add the series to the chart.
            chartControl2.Series.Add(seriesPie);

            // Adjust the value numeric options of the series.
            seriesPie.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent;
            seriesPie.PointOptions.ValueNumericOptions.Precision = 0;

            // Adjust the view-type-specific options of the series.
            ((Pie3DSeriesView)seriesPie.View).Depth = 15;
            ((Pie3DSeriesView)seriesPie.View).ExplodedPoints.Add(seriesPie.Points[PointName(dt2)]);
            ((Pie3DSeriesView)seriesPie.View).ExplodedDistancePercentage = 30;

            //// Access the diagram's options.
            //((SimpleDiagram3D)chartControl2.Diagram).RotationType = RotationType.UseAngles;
            //((SimpleDiagram3D)chartControl2.Diagram).RotationAngleX = -35;

            // Cast Diagram to the SimpleDiagram3D type. 
            SimpleDiagram3D diagram3D = chartControl2.Diagram as SimpleDiagram3D;
            if (diagram3D != null)
            {
                diagram3D.RuntimeRotation = true;
                diagram3D.RuntimeZooming = true;
                diagram3D.ZoomingOptions.UseMouseWheel = true;
            }

            // Control legend & position
            chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chartControl2.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            chartControl2.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside;
            chartControl2.Legend.Direction = LegendDirection.LeftToRight;
            seriesPie.LegendPointOptions.PointView = PointView.Argument;
            
            //chartControl2.Legend.Direction = LegendDirection.LeftToRight;
            chartControl2.Legend.EquallySpacedItems = true;
            #endregion
        }
        private static string RandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 1000);
            return randomNumber.ToString();
        }
        private static int PointName(DataTable dt2)
        {
            int pointName = 0;
            Int64 max = Convert.ToInt64(dt2.Rows[0]["A02"]);
            if(max < Convert.ToInt64(dt2.Rows[0]["A03"]))
            {
                max = Convert.ToInt64(dt2.Rows[0]["A03"]);
                pointName = 1;
            }
            if (max < Convert.ToInt64(dt2.Rows[0]["A04"]))
            {
                max = Convert.ToInt64(dt2.Rows[0]["A04"]);
                pointName = 2;
            }
            if (max < Convert.ToInt64(dt2.Rows[0]["A05"]))
            {
                max = Convert.ToInt64(dt2.Rows[0]["A05"]);
                pointName = 3;
            }
            if (max < Convert.ToInt64(dt2.Rows[0]["A06"]))
            {
                max = Convert.ToInt64(dt2.Rows[0]["A06"]);
                pointName = 4;
            }
            if (max < Convert.ToInt64(dt2.Rows[0]["A09"]))
            {
                max = Convert.ToInt64(dt2.Rows[0]["A09"]);
                pointName = 5;
            }
            if (max < Convert.ToInt64(dt2.Rows[0]["A10"]))
            {
                max = Convert.ToInt64(dt2.Rows[0]["A10"]);
                pointName = 6;
            }
            return pointName;
        }
    }
}