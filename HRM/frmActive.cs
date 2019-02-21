using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class frmActive : Form
    {
        string key = null, code = null;
        string path = AppDomain.CurrentDomain.BaseDirectory + @"ActiveCode.txt";
        public frmActive()
        {
            InitializeComponent();
            key = Utility.CreateMD5Hash(Utility.GetHardDrive() + Utility.GetMACAddress() + Utility.GetMotherBoardSerial() + "LiLoM");
            code = Utility.CreateMD5Hash(key + "HelioTuongVictoria");
            txtKey.Enabled = false;
            txtKey.Text = key;
            #region Verify by Active code
            /*
            if (File.Exists(path) || Utility.ConnectServer())
            {
                String last = File.ReadLines(path).Last();
                if (string.Compare(code, last) == 0)
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = false;
                    frmLogin login = new frmLogin();
                    login.thoatActive = new frmLogin.ThoatActive(thoatActive);
                    login.Show();                    
                }
                else
                {
                    label4.Visible = true;
                    label4.Text = "Vui lòng active phần mềm trước khi sử dụng.";
                }
            }
            else
            {
                label4.Visible = true;
                label4.Text = "Vui lòng active phần mềm trước khi sử dụng.";
            }
            */
            #endregion
            #region Verify by online
            
            if (Utility.ConnectServer())
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                frmLogin login = new frmLogin();
                login.thoatActive = new frmLogin.ThoatActive(thoatActive);
                login.Show();
            }
            else
            {
                label4.Visible = true;
                label4.Text = "Vui lòng active phần mềm trước khi sử dụng.";
            }
            
            #endregion
            //frmLogin login = new frmLogin();
            //login.thoatActive = new frmLogin.ThoatActive(thoatActive);
            //login.Show();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtKey.Text);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (string.Compare(code, txtActiveCode.Text) == 0)
            {
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(txtActiveCode.Text);
                    }
                }
                else
                {
                    File.AppendAllText(path, txtActiveCode.Text + Environment.NewLine);
                }

                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                frmLogin login = new frmLogin();
                login.thoatActive = new frmLogin.ThoatActive(thoatActive);
                login.Show();
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
            else
            {
                label4.Visible = true;
                label4.Text = "Active code không hợp lệ.";
            }
        }

        public void thoatActive()
        {
            this.Close();
        }
    }
}
