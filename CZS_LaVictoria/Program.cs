using System;
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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDYyNTk5QDMxMzkyZTMxMmUzMFhYN3AzeWEwdVlZVUtvdDh6cjdMRXJQdlYxNTdaRko5NGsraFZMYVZ6M0U9");

            GlobalConfig.InitializeSql();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
    }
}