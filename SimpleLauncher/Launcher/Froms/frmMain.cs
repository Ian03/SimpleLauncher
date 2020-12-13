using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Xml.Linq;
using SimpleLauncher.Properties;
using System.Diagnostics;
using SimpleLauncher.Froms;
using Ionic.Zip;
using System.ComponentModel;

namespace SimpleLauncher
{
    public partial class frmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public frmMain()
        {
            InitializeComponent();

            //Desabilitar botão start game
            bttStarGame.Enabled = false;


            //Checar vessão do launcher
            trmUpdateLauncher.Start();
           

        }

        private void bttStarGame_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Close();
                Directory.SetCurrentDirectory(Settings.Default.GameLocation);
                Process.Start("Project n.exe");
            }
            catch(Exception)
            {
                frmMessagebox messagebox = new frmMessagebox();
                messagebox.Show("Title: Updater", "Erro ao tentar encontrar executavel do jogo ", frmMessagebox.MessageBoxButon.OK);
            }
            
            
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
            try
            {

                string root = @"C:\Temp";
                string rootdownload = @"c:\Temp\update.zip";
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                XDocument doc = XDocument.Load(SimpleLauncher.ClsVariables.CheckxmlMaintenance);

                var VersionElement = doc.Descendants("Version");
                SimpleLauncher.ClsVariables.WebVersionxml = Convert.ToInt32(string.Concat(VersionElement.Nodes()));

                lblVersion.Text = "Version: " + Settings.Default.Version;

                if (Settings.Default.Version < SimpleLauncher.ClsVariables.WebVersionxml)
                {
                    //label
                    lblStatus1.Visible = true;
                    lblStatus2.Visible = true;
                    lblSpeed.Visible = true;
                    lblSize.Visible = true;
                    lblpercent.Visible = true;
                    //Barr
                    Statusbar.Visible = true;
                    StatusbarZip.Visible = true;

                    using (var client = new WebClient())
                    {
                        lblStatus.Text = "Status: " + "Updating...";

                        //Download here
                        WebClient wc = new WebClient();
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                        //  wc.DownloadFileAsync(new Uri(SimpleLauncher.ClsVariables.Downloadurl.Trim()), Settings.Default.GameLocation + "Update" + Path.GetExtension(SimpleLauncher.ClsVariables.Downloadurl));
                        wc.DownloadFileCompleted += DownloadCompleted;
                        wc.DownloadFileAsync(new Uri(SimpleLauncher.ClsVariables.Downloadurl.Trim()), rootdownload);

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
            catch (Exception exe)
            {
                    frmMessagebox messagebox = new frmMessagebox();
                    messagebox.Show("Title: Updater", exe.Message, frmMessagebox.MessageBoxButon.OK);
            }
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            // Pegar porcentagem do download e enviar para barra de progeso
            Statusbar.Value = e.ProgressPercentage;

            // Calculate download speed and output it to labelSpeed.             lblSpeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));
            lblSpeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

            // if (e.BytesReceived < 1024)
            //    lblSize.Text = string.Format("{0} / {1} KBs", Math.Round(e.BytesReceived / 1024f), Math.Round(e.TotalBytesToReceive / 1024f));
            // else
            //     lblSize.Text = string.Format("{0} / {1} MBs", (Math.Round((e.BytesReceived / 1024f) / 1024f)), Math.Round((e.TotalBytesToReceive / 1024f) / 1024f));

            lblSize.Text = string.Format("{0} MB's / {1} MB's", (e.BytesReceived / 1024d / 1024d).ToString("0.00"), (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));

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
                    break;
            }
        }

        void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            UnZipFile();
        }
        void UnZipFile()
        {
           string root = @"C:\Temp\update.zip";

           string TargetDirectory = Settings.Default.GameLocation;

            using (ZipFile zip = ZipFile.Read(root))
                {
                   // foreach (ZipEntry es in zip)
                   // {
                      // es.Extract(TargetDirectory, ExtractExistingFileAction.OverwriteSilently);  // overwrite == true
                        zip.ExtractProgress += zip_ExtractProgress;

                        zip.ExtractAll(TargetDirectory, ExtractExistingFileAction.OverwriteSilently);
                    
                  //  }
                }

        }
        
        void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            
            if (e.BytesTransferred > 0 && e.TotalBytesToTransfer > 0)
            {
                int progress = (int)Math.Floor((decimal)((e.BytesTransferred * 100) / e.TotalBytesToTransfer));
                StatusbarZip.Value = progress;
                lblpercent.Text = Convert.ToString(progress) + "%";
                lblpercent.Visible = true;
                lblStatus2.Text = "Patch: " + e.CurrentEntry.FileName;
                Application.DoEvents();
            }
            else if (e.EventType == ZipProgressEventType.Extracting_AfterExtractAll)
            {
                trmClean.Start();
                
            }
        }

        void CleanData()
        {
            string root = @"C:\Temp";

            if (Directory.Exists(root))
                Directory.Delete(root, true);

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
                lblSpeed.Visible = false;
                lblSize.Visible = false;
                lblpercent.Visible = false;
                LauncherTray.Visible = false;
            

        }

        private void trmCheckupdate_Tick(object sender, EventArgs e)
        {
            trmCheckupdate.Stop();
            CheckUpdate();
        }

        private void creditsMenu_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ian03");
        }

        private void trmCheckMaintenance_Tick(object sender, EventArgs e)
        {
            trmCheckMaintenance.Stop();
            CheckMaintenance();
        }

        void CheckMaintenance()
        {
            try
            {
                XDocument doc = XDocument.Load(ClsVariables.CheckxmlMaintenance);

                var VersionElement = doc.Descendants("Maintenance");
                ClsVariables.WebVersionxml = Convert.ToInt32(string.Concat(VersionElement.Nodes()));

                if (Settings.Default.LauncherUpdate < ClsVariables.WebVersionxml)
                {
                    WebClient wc = new WebClient();
                    string somestring = wc.DownloadString(ClsVariables.MaintenanceMessage);

                    // MetroFramework.MetroMessageBox.Show(this, "Mesage: " + "New version availible! " + "Current Version: " + SimpleLauncher.ClsVariables.LauncherVersion + " Online Version: " + SimpleLauncher.ClsVariables.WebVersionxml, "Title: Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMessagebox messagebox = new frmMessagebox();
                    messagebox.Show("Title: Updater", somestring.ToString(), frmMessagebox.MessageBoxButon.OK);


                    lblMaintenance.Visible = true;
                    lblMaintenance.Text = "Maintenance: On ";

                    System.Diagnostics.Process.Start(ClsVariables.MaintenanceWebsite);
                    using (var client = new WebClient())
                    {

                    }
                }
                else
                {
                    // Checar versão do jogo
                    trmCheckupdate.Start();
                }
            }
            catch (Exception)
            {
                frmMessagebox messagebox = new frmMessagebox();
                messagebox.Show("Title: Updater", "Erro ao tentar carregar versão do jogo na web ", frmMessagebox.MessageBoxButon.OK);
            }
        }

        void CheckNews()
        {
            try
            {

                WebClient wc = new WebClient();
                string somestring = wc.DownloadString(ClsVariables.Checknews);

                
                RichNews.Text = somestring.ToString();

       
            }
            catch (Exception)
            {

                frmMessagebox messagebox = new frmMessagebox();
                messagebox.Show("Title: Updater", "Erro ao tentar carregar novidades na web ", frmMessagebox.MessageBoxButon.OK);

            }
 
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
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

        private void bttclosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trmCheckNews_Tick(object sender, EventArgs e)
        {
            trmCheckNews.Stop();
            CheckNews();
        }

        private void trmUpdateLauncher_Tick(object sender, EventArgs e)
        {
            trmUpdateLauncher.Stop();
            CheckUpdateLauncher();
        }

        void CheckUpdateLauncher()
        {
            try
            {
                XDocument doc = XDocument.Load(ClsVariables.CheckxmlLauncher);

                var VersionElement = doc.Descendants("LauncherUpdate");
                ClsVariables.WebVersionLauncherxml = Convert.ToInt32(string.Concat(VersionElement.Nodes()));

                if (Settings.Default.LauncherUpdate < ClsVariables.WebVersionLauncherxml)
                {

                    frmMessagebox messagebox = new frmMessagebox();
                    messagebox.Show("Title: Updater", "Nova versão do launcher disponivel, seu launcher sera finalizado! ", frmMessagebox.MessageBoxButon.finish);

                    Properties.Settings.Default.Reset();

                }
                else
                {   //Checar versão do jogo
                    trmCheckMaintenance.Start();
                }
            }
            catch (Exception)
            {
                frmMessagebox messagebox = new frmMessagebox();
                messagebox.Show("Title: Updater", "Erro ao tentar carregar versão do launcher ", frmMessagebox.MessageBoxButon.OK);
            }
        }

        private void trmClean_Tick(object sender, EventArgs e)
        {
            CleanData();
        }

        private void RichNews_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }

  }

