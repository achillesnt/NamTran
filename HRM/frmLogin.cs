using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace HRM
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly CheckForUpdate checkForUpdate = null;
        public delegate void ThoatActive();
        public ThoatActive thoatActive;

        public frmLogin()
        {
            InitializeComponent();
            //ConfigService.Init(new SimpleAppSettings(SimpleAppSettings.ConfigTypes.AppConfig));

            this.checkForUpdate = new CheckForUpdate(this);
            // start the check for update process
            this.checkForUpdate.OnCheckForUpdate();
        }

        private void pictureEdit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Dangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = BUS_HeThong.LoadAccount(txtUser.Text, txtPass.Text);
            if (dt.Rows.Count > 0)
            {
                frmMain frm = new frmMain(dt);
                frm.thoat = new frmMain.Thoat(thoat);
                frm.Show();
                Hide();
            }
            else
            {
                lbCanhbao.Visible = true;
                image_canhbao.Visible = true;
            }
        }

        public void thoat()
        {

            Show();
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            //Clipboard.SetText(ConfigService.Encrypt("WiseEyeOn"));
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // when the app is closing, this will stop the thread that checks for the
            // new version or downloads it
            this.checkForUpdate.StopThread();
        }

        // this method is called when the checkForUpdate finishes checking
        // for the new version. If this method returns true, our checkForUpdate
        // object will download the installer
        public bool OnCheckForUpdateFinished(DownloadedVersionInfo versionInfo)
        {
            if ((versionInfo.error) || (versionInfo.installerUrl.Length == 0) || (versionInfo.latestVersion == null))
            {
                MessageBox.Show(this, "Đã có lỗi xãy ra trong quá trình kiểm tra phiên bản mới", "Kiểm tra cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // compare the current version with the downloaded version number
            Version curVer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if (curVer.CompareTo(versionInfo.latestVersion) >= 0)
            {
                // no new version
                //MessageBox.Show(this, "No new version detected", "Check for updates", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            // new version found, ask the user if he wants to download the installer
            string str = String.Format("Đã có phiên bản mới của phần mềm!\nPhiên bản bạn đang dùng: {0}.\nPhiên bản mới nhất: {1}.", curVer, versionInfo.latestVersion);
            //return DialogResult.Yes == MessageBox.Show(this, str, "Kiểm tra cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return true;
        }

        // called after the checkForUpdate object downloaded the installer
        public void OnDownloadInstallerinished(DownloadInstallerInfo info)
        {
            if (info.error)
            {
                MessageBox.Show(this, "Đã có lỗi xãy ra trong quá trình tải phiên bản mới của phần mềm", "Kiểm tra cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*
            // ask the user if he want to start the installer
            if (DialogResult.Yes != MessageBox.Show(this, "Bạn có muốn cài đặt phiên bản mới không?", "Kiểm tra cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                // it not - remove the downloaded file
                try
                {
                    File.Delete(info.path);
                }
                catch { }
                return;
            }
            */
            // run the installer and exit the app
            try
            {
                //Process.Start(info.path);
                ProcessStart();
                //Process.Start(@"AutoUpdater\Updater.exe");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error while running the installer.", "Check for updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    File.Delete(info.path);
                }
                catch { }
                return;
            }
            return;
        }

        public void ProcessStart()
        {
            ProcessStartInfo startInfor = new ProcessStartInfo();
            startInfor.CreateNoWindow = false;
            startInfor.UseShellExecute = false;
            startInfor.FileName = "Updater.exe";
            //startInfor.WorkingDirectory = @"..\\AutoUpdater";
            startInfor.WindowStyle = ProcessWindowStyle.Hidden;
            try
            {
                /*
                using (Process exeProcess = Process.Start(startInfor))
                {
                    exeProcess.WaitForExit();
                }
                */
                Process.Start(startInfor);
            }
            catch (Exception exception)
            {
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfor = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfor.ProductVersion;
            label2.Text = "Version " + version;
        }

        private void pictureEdit4_EditValueChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            thoatActive();
        }
    }
}