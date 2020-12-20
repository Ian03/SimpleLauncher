using System.Windows.Forms;
using SimpleLauncher.Properties;
using System.Linq;
using System;
using SimpleLauncher.Froms;
using System.IO;
using System.Drawing;
using SimpleLauncher.Class;

namespace SimpleLauncher
{
    public partial class frmSettings : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmSettings()
        {
            InitializeComponent();
            
            string root = @"C:\Project_n";

            txtLocation.Text = root;

            if (!Directory.Exists(root))
                Directory.CreateDirectory(root);

        }

        private void bttBrowse_Click(object sender, System.EventArgs e)
        {
           

            OpenFolderDialog folder = new OpenFolderDialog()
            {
                Title = "Selecione a pasta de destino",
               AutoUpgradeEnabled = true,
                CheckPathExists = true,
                InitialDirectory = @"C:\Project_n",
                Multiselect = true,
            RestoreDirectory = true
            };
            DialogResult result = folder.ShowDialog(IntPtr.Zero);
            if (result.Equals(DialogResult.OK))


                txtLocation.Text = folder.SelectedPath;

            /* Olde Code 
            I made the switch thanks to Alain Eus Rivera 
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtLocation.Text = fbd.SelectedPath;
                }

            }
            */
        }

        private void bttOk_Click(object sender, System.EventArgs e)
        {
            if (txtLocation.Text == "")
            {
                frmMessagebox messagebox = new frmMessagebox();
                messagebox.Show("Mensagem de Alerta", Color.FromArgb(255, 161, 0), Properties.Resources.Alert, "local de instalação vazio ", frmMessagebox.MessageBoxButon.OK);
            }
            else
            {
                if (Application.OpenForms.OfType<frmMain>().Any())
                {
                    Settings.Default.GameLocation = txtLocation.Text;
                    Settings.Default.Save();

                    this.Hide();
                }
                else
                {
                    Settings.Default.GameLocation = txtLocation.Text;
                    Settings.Default.Save();

                    frmMain Main = new frmMain();
                    Main.Show();
                    this.Hide();
                }
            }

        }

        private void bttclosed_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void bttGithub_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Ian03/SimpleLauncher");
        }

        private void frmSettings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bttMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
