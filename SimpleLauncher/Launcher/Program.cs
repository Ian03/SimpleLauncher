using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleLauncher.Properties;
using System.IO;

namespace SimpleLauncher
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

            if (!isStillRunning())
            {
                if (string.IsNullOrEmpty(Settings.Default.GameLocation) || !Directory.Exists(Settings.Default.GameLocation))
                {

                    Application.Run(new frmSettings());
                }
                else
                {
                    Application.Run(new frmMain());
                }
            }
            else
            {
                MessageBox.Show("Processo anterior ainda em execução.",
                   "Aplicativo interrompido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Application.Exit();
            }

         }

        //***Uses WMI Query
        static bool isStillRunning()
        {
            string processName = System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName;
            System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher();
            mos.Query.QueryString = @"SELECT * FROM Win32_Process WHERE Name = '" + processName + @"'";
            if (mos.Get().Count > 1)
            {
                return true;
            }
            else
                return false;
        }

    }
}
