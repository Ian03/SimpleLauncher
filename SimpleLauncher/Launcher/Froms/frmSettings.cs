using System.Windows.Forms;
using SimpleLauncher.Properties;
using System.Linq;
using System;

namespace SimpleLauncher
{
    public partial class frmSettings : Form
    {

        public frmSettings()
        {
            InitializeComponent();

            txtLocation.Text = Settings.Default.GameLocation;
        }

        private void bttBrowse_Click(object sender, System.EventArgs e)
        {

            OpenFolderDialog folder = new OpenFolderDialog()
            {
                Title = "Select destination folder",
                AutoUpgradeEnabled = true,
                CheckPathExists = true,
                InitialDirectory =
                Environment.GetFolderPath
                (Environment.SpecialFolder.DesktopDirectory),
                Multiselect = true,
                RestoreDirectory = true
            };
            DialogResult result = folder.ShowDialog(IntPtr.Zero);
            if (result.Equals(DialogResult.OK))
                MessageBox.Show(folder.SelectedPath + " Paths:" + folder.SelectedPaths.Length);
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

                   MessageBox.Show("Mesage: Location game empty", "Title: Config folder", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
    }
}
