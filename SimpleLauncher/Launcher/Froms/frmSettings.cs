using System.Windows.Forms;
using SimpleLauncher.Properties;
using System.Linq;

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
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtLocation.Text = fbd.SelectedPath;
                }

            }
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

        private void bttCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
