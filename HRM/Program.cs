using System;
using SimpleControls;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace HRM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ConfigService.Init(new SimpleAppSettings(SimpleAppSettings.ConfigTypes.AppConfig));
            Properties.Settings.Default.Reset();

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new frmActive());
        }
    }
}
