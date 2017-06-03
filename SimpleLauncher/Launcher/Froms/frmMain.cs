using System;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Linq;
using SimpleLauncher.Properties;

namespace SimpleLauncher
{
    public partial class frmMain : Form
    {
        int totalFiles;
        int filesExtracted;

        public frmMain()
        {
            InitializeComponent();

            //Desabilitar botão start game
            bttStarGame.Enabled = false;

            // Checar versão do jogo
            trmCheckupdate.Start();
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Pegar porcentagem do download e enviar para barra de progeso
            Statusbar.Value = e.ProgressPercentage;

            switch (Statusbar.Value)
            {
                case 1:
                    lblStatus.Text = "Status: " + " Start download.";
                    break;
                case 25:
                    lblStatus.Text = "Status: " + " Download working..";
                    break;
                case 65:
                    lblStatus.Text = "Status: " + " Download working...";
                    break;
                case 85:
                    lblStatus.Text = "Status: " + " Finishing download";
                    break;
                case 100:
                    lblStatus.Text = "Status: " + " Complete download!";
                    lblStatus.Text = "Status: " + " Extracting and configuring files";
                    UnZipFile();
                    break;
            }
        }

        void UnZipFile()
        {
            using (ZipFile zip = new ZipFile(SimpleLauncher.ClsVariables.FileExistingZip))
            {
                totalFiles = zip.Count;
                filesExtracted = 0;
                zip.ExtractProgress += zip_ExtractProgress;
                zip.ExtractAll(SimpleLauncher.ClsVariables.FolderGame, ExtractExistingFileAction.OverwriteSilently);
            }
        }

        void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
           
            
            if (e.TotalBytesToTransfer > 0)
            {
                StatusbarZip.Value = Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer);
            }
            
            if (e.EventType == ZipProgressEventType.Extracting_AfterExtractAll)
            {
                lblStatus.Text = "Status: " + " Extract complete config files wait!";
                trmDel.Start();
            }
        }

        private void trmDel_Tick(object sender, EventArgs e)
        {
            File.Delete(SimpleLauncher.ClsVariables.FileExistingZip);
            lblStatus.Text = "Status: " + " Full configuration!";
            LauncherTray.Visible = true;
            LauncherTray.BalloonTipText = "Update was successfull!";
            LauncherTray.ShowBalloonTip(1000);
            bttStarGame.Enabled = true;
            Settings.Default.Version = Settings.Default.Version + 1;
            Settings.Default.Save();
            Statusbar.Visible = false;
            lblStatus1.Visible = false;
            lblStatus2.Visible = false;
            StatusbarZip.Visible = false;
            trmDel.Stop();
            LauncherTray.Visible = false;
        }

        private void bttStarGame_Click(object sender, EventArgs e)
        {
           
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                LauncherTray.Visible = true;
                LauncherTray.BalloonTipText = "Your application in tray icon";
                LauncherTray.BalloonTipIcon = ToolTipIcon.Info;
                LauncherTray.ShowBalloonTip(1000);
                this.Hide();
                e.Cancel = true;
            }
        }

        private void Launcher_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            LauncherTray.Visible = false;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            LauncherTray.Visible = false;
        }

        void Destroy_Launcher()
        {
            Application.Exit();
            Environment.Exit(0);
            LauncherTray.Visible = false;
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Destroy_Launcher();
        }

        private void LauncherTray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LauncherContextmenu.Visible = true;
            }
        }

        void CheckUpdate()
        {
            XDocument doc = XDocument.Load(SimpleLauncher.ClsVariables.CheckxmlUrl);

            var VersionElement = doc.Descendants("Version");
            SimpleLauncher.ClsVariables.WebVersionxml = Convert.ToInt32(string.Concat(VersionElement.Nodes()));

            lblVersion.Text = "Version: " + SimpleLauncher.ClsVariables.LauncherVersion;

            if (SimpleLauncher.ClsVariables.LauncherVersion < SimpleLauncher.ClsVariables.WebVersionxml)
            {
               // MetroFramework.MetroMessageBox.Show(this, "Mesage: " + "New version availible! " + "Current Version: " + SimpleLauncher.ClsVariables.LauncherVersion + " Online Version: " + SimpleLauncher.ClsVariables.WebVersionxml, "Title: Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Mesage: " + "New version availible! " + "Current Version: " + SimpleLauncher.ClsVariables.LauncherVersion + " Online Version: " + SimpleLauncher.ClsVariables.WebVersionxml, "Title: Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //label
                lblStatus1.Visible = true;
                lblStatus2.Visible = true;
                //Barr
                Statusbar.Visible = true;
                StatusbarZip.Visible = true;

                using (var client = new WebClient())
                {
                    lblStatus.Text = "Status: " + "Updating...";
                    Console.WriteLine("Updating...");

                    //Download here
                    WebClient wc = new WebClient();
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                    wc.DownloadFileAsync(new Uri(SimpleLauncher.ClsVariables.Downloadurl.Trim()), SimpleLauncher.ClsVariables.FolderGame + "Update" + Path.GetExtension(SimpleLauncher.ClsVariables.Downloadurl));
                }
            }
            else
            {
                lblStatus.Text = "Status: " + "No updates availible!";
                LauncherTray.Visible = true;
                LauncherTray.BalloonTipText = "No updates availible!";
                LauncherTray.ShowBalloonTip(1000);
                LauncherTray.Visible = false;

                bttStarGame.Enabled = true;
            }
        }

        private void trmCheckupdate_Tick(object sender, EventArgs e)
        {
            trmCheckupdate.Stop();
            CheckUpdate();
        }

        private void creditsMenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Ian03");
        }
    }

  }

