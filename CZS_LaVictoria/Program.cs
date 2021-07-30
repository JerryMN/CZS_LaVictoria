using System;
using System.Threading;
using System.Windows.Forms;
using CZS_LaVictoria_Library;

namespace CZS_LaVictoria
{
    static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDgxMTM2QDMxMzkyZTMyMmUzMGZQRzdjU0lOdjZCRUxYcWE2K2JIUEl4aHFZN0lmRjBJUUJKTHhvUHBRNGc9");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-MX");

            GlobalConfig.InitializeSql();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
    }
}