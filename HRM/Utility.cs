using DevExpress.XtraBars;
using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Security.Cryptography;
using Renci.SshNet;

namespace HRM
{
    public class Utility
    {
        //Find baritem of ribbon control
        public void SearchWindow(DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl, DataTable dt)
        {
            foreach (var item in ribbonControl.Items)
            {
                if (item.GetType() == typeof(BarButtonItem))
                {
                    BarButtonItem barItem = (BarButtonItem)item;
                    if (barItem.Name.Contains("bar"))
                    {
                        barItem.Enabled = false;
                    }
                }
            }

            foreach (var item in ribbonControl.Items)
            {
                if (item.GetType() == typeof(BarButtonItem))
                {
                    BarButtonItem barItem = (BarButtonItem)item;
                    if (barItem.Name.Contains("bar"))
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string ad_window_name = dt.Rows[i]["ad_window_name"].ToString();
                            string ad_window_access_isactive = dt.Rows[i]["ad_window_access_isactive"].ToString();
                            if (string.Compare(barItem.Name.ToString(), ad_window_name) == 0 && string.Compare(ad_window_access_isactive, "Y") == 0)
                            {
                                barItem.Enabled = true;
                            }
                        }
                    }
                }
            }
        }
        //Find windown form control
        public void SearchProcess(Control.ControlCollection owner, DataTable dt)
        {
            foreach (Control c in owner)
            {

                if (c.Name.Contains("btn"))
                {
                    c.Enabled = false;
                }
                if (c.HasChildren)
                {
                    SearchProcess(c.Controls, dt);
                }
            }


            foreach (Control c in owner)
            {
                if (c.Name.Contains("btn"))
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string ad_process_name = dt.Rows[i]["ad_process_name"].ToString();
                        string ad_process_access_isactive = dt.Rows[i]["ad_process_access_isactive"].ToString();
                        if (string.Compare(c.Name.ToString(), ad_process_name) == 0 && string.Compare(ad_process_access_isactive, "Y") == 0)
                        {
                            c.Enabled = true;
                        }
                    }
                }
                if (c.HasChildren)
                {
                    SearchProcess(c.Controls, dt);
                }
            }
        }
        public static string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }
        public static string CreateMD5Hash(string input)
        {
            // Step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public static string GetHardDrive()
        {
            string s = null;
            ManagementObjectSearcher moSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                //HardDrive hd = new HardDrive();  // User Defined Class
                //hd.Model = wmi_HD["Model"].ToString();  //Model Number
                //hd.Type = wmi_HD["InterfaceType"].ToString();  //Interface Type
                s = wmi_HD["SerialNumber"].ToString(); //Serial Number
                //hardDriveDetails.Add(hd);
            }
            return s;
        }
        public static string GetMotherBoardSerial()
        {
            string s = null;
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
            foreach (ManagementObject getserial in MOS.Get())
            {
                s = getserial["SerialNumber"].ToString();
            }
            return s;
        }
        public static bool ConnectServer()
        {
            bool sKetQua = false;
            SshClient client = new SshClient("10.191.0.12", 4774, "tuongtai", "LiLoM0903@!");
            client.ConnectionInfo.Timeout = TimeSpan.FromSeconds(120);
            try
            {
                client.Connect();
                if (client.IsConnected)
                {
                    sKetQua = true;
                }
                else
                {
                    sKetQua = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please checking your connection or contact to IT for help","Disconnected",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sKetQua;
        }
        public static DataTable CopyDatatable(DataTable dtSource, string typeCode)
        {
            DataRow[] rowsToCopy;
            DataTable dtTarget = new DataTable();
            string sQuery = string.Format("typecode = '{0}'", typeCode);
            dtTarget = dtSource.Clone();
            rowsToCopy = dtSource.Select(sQuery);
            foreach (DataRow temp in rowsToCopy)
            {
                dtTarget.ImportRow(temp);
            }
            return dtTarget;
        }
        public static DataTable CopyChart(DataTable dtSource, string date)
        {
            DataRow[] rowsToCopy;
            DataTable dtTarget = new DataTable();
            string sQuery = string.Format("att_date = '{0}'", date);
            dtTarget = dtSource.Clone();
            rowsToCopy = dtSource.Select(sQuery);
            foreach (DataRow temp in rowsToCopy)
            {
                dtTarget.ImportRow(temp);
            }
            return dtTarget;
        }
        public static DataTable CopyChart(DataTable dtSource, string fromDate, string toDate)
        {
            DataRow[] rowsToCopy;
            Int32 A02 = 0, A03 = 0, A04 = 0, A05 = 0, A06 = 0, A09 = 0, A10 = 0;
            DataTable dtTarget = new DataTable();
            string sQuery = string.Format("att_date >= '{0}' AND att_date <= '{1}'", fromDate, toDate);
            dtTarget = dtSource.Clone();
            rowsToCopy = dtSource.Select(sQuery);           
            foreach (DataRow temp in rowsToCopy)
            {
                A02 += Convert.ToInt32(temp[4]);
                A03 += Convert.ToInt32(temp[5]);
                A04 += Convert.ToInt32(temp[6]);
                A05 += Convert.ToInt32(temp[7]);
                A06 += Convert.ToInt32(temp[8]);
                A09 += Convert.ToInt32(temp[9]);
                A10 += Convert.ToInt32(temp[10]);
            }

            DataRow dr = dtTarget.NewRow();
            dr[0] = dtSource.Rows[0][0];
            dr[1] = dtSource.Rows[0][1];
            dr[2] = dtSource.Rows[0][2];
            dr[3] = dtSource.Rows[0][3];
            dr[4] = A02;
            dr[5] = A03;
            dr[6] = A04;
            dr[7] = A05;
            dr[8] = A06;
            dr[9] = A09;
            dr[10] = A10;
            dtTarget.Rows.Add(dr);
            return dtTarget;
        }
        public static DataTable CopyProductByName(DataTable dtSource, string productName)
        {
            DataRow[] rowsToCopy;
            DataTable dtTarget = new DataTable();
            string sQuery = string.Format("product_name LIKE '%" + productName + "%'");
            dtTarget = dtSource.Clone();
            rowsToCopy = dtSource.Select(sQuery);
            foreach (DataRow temp in rowsToCopy)
            {
                dtTarget.ImportRow(temp);
            }
            return dtTarget;
        }
    }
}
