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
using System.Drawing;
using SimpleLauncher.Class;

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

        String BoxMessage;
        String BoxMessageDesc;

        public frmMain()
        {
            InitializeComponent();

            //Desabilitar botão start game
            bttStarGame.Enabled = false;
            //
            trmCheckMaintenance.Start();

            try
            {
                /*
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData("url");
                MemoryStream ms = new MemoryStream(bytes);
                Image img = Image.FromStream(ms);

                */

                var request01 = WebRequest.Create(Classvariables.Slider01);

                using (var response = request01.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    BoxImagens.Image = Bitmap.FromStream(stream);

                    BoxMessage = "Sobre o projeto";
                    BoxMessageDesc = "Neo town vem sendo desenvolvido por mais de 2 anos só agora depois da correção de alguns bugs e " + "\r\n"
    + "teste de alguns sistemas internos me senti à-vontade de publicar ele, e começar os teste online";
                }


            }
            catch (Exception)
            {
                BoxImagens.Image = Resources.erronetwork;
                BoxMessage = "erro 404";
                BoxMessageDesc = "pagina não encontrada ou erro de conexão!";
            }


        }



        private void bttStarGame_Click(object sender, EventArgs e)
        {
            // NOTE: FileDownloader is IDisposable!
            //FileDownloader fileDownloader = new FileDownloader();

            // This callback is triggered for DownloadFileAsync only
           // fileDownloader.DownloadProgressChanged += (sender, e) => Console.WriteLine("Progress changed " + e.BytesReceived + " " + e.TotalBytesToReceive);

            //fileDownloader.DownloadProgressChanged += (sender2, e2) => Console.WriteLine(e2.ProgressPercentage.ToString());
            // This callback is triggered for both DownloadFile and DownloadFileAsync
            // fileDownloader.DownloadFileCompleted += (sender, e) => Console.WriteLine("Download completed");
           
            //fileDownloader.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);

            //fileDownloader.DownloadFileAsync("https://drive.google.com/file/d/10vgMBi4UuR_cHWJ4juKWusmHsbd5z5b6/view?usp=sharing", @"C:\Project_n\Resorces\Project n.zip");


            
            try
            {
                this.Close();
                Directory.SetCurrentDirectory(Settings.Default.GameLocation);
                Process.Start("Project n.exe");
            }
            catch(Exception)
            {
                frmMessagebox messagebox = new frmMessagebox();
                messagebox.Show("Mensagem de Erro", Color.FromArgb(255, 0, 0), Properties.Resources.Erro, "Erro ao tentar encontrar executável do jogo ", frmMessagebox.MessageBoxButon.OK);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                LauncherTray.Visible = true;
                LauncherTray.Text = "Simple Launcher";
                ShowBalloon("Launcher", "Your application in tray icon", (ToolTipIcon)IconTip.info);
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
                XDocument doc = XDocument.Load(Classvariables.maintenanceurl);

                var VersionElement = doc.Descendants("Version");
                Classvariables.webversionurl = Convert.ToInt32(string.Concat(VersionElement.Nodes()));

                lblVersion.Text = "Version: " + Settings.Default.Version;

                if (Settings.Default.Version < Classvariables.webversionurl)
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
                        wc.DownloadFileCompleted += DownloadCompleted;
                        wc.DownloadFileAsync(new Uri(Classvariables.Downloadurl.Trim()), rootdownload);

                    }
                }
                else
                {
                    lblStatus.Text = "Status: " + "No updates availible!";
                    ShowBalloon("Launcher", "No updates availible!", (ToolTipIcon)IconTip.none);

                    bttStarGame.Enabled = true;
                }
            }
            catch (Exception exe)
            {
                    frmMessagebox messagebox = new frmMessagebox();
                   messagebox.Show("Mensagem de Erro", Color.FromArgb(255, 0, 0), Properties.Resources.Erro, exe.Message, frmMessagebox.MessageBoxButon.OK);
            }
        }

        public enum IconTip
        {
            //Tool Enum
            [Description("None")]
            none = 0,
            [Description("Information")]
            info = 1,
            [Description("Erro")]
            erro = 2,
            [Description("Warning")]
            warning = 3
        };



    public static void ShowBalloon(string title, string body, ToolTipIcon IconTip)
        {
            //XDocument doc = XDocument.Load(SimpleLauncher.ClsVariables.CheckxmlMaintenance);
           // ToolTipIcon Tipodeiconess = ToolTipIcon;

            // Show with icon
            NotifyIcon ni = new NotifyIcon() { Visible = true, Icon = Properties.Resources.icon };

            // Timeout is deprecated since Vista
            ni.ShowBalloonTip(0, title, body, IconTip);

            // Dispose on event
            ni.BalloonTipClosed += (sender, e) => ni.Dispose();
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
            try
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
            catch (Exception)
            {
                frmMessagebox messagebox = new frmMessagebox();
                messagebox.Show("Mensagem de Erro", Color.FromArgb(255, 0, 0), Properties.Resources.Erro, "Versão web insponivel", frmMessagebox.MessageBoxButon.OK);
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
                ShowBalloon("Launcher", "Update was successfull!", (ToolTipIcon)IconTip.info);
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
                XDocument doc = XDocument.Load(Classvariables.maintenanceurl);

                var VersionElement = doc.Descendants("Maintenance");
                Classvariables.webversionurl = Convert.ToInt32(string.Concat(VersionElement.Nodes()));

                if (Settings.Default.LauncherUpdate < Classvariables.webversionurl)
                {
                    WebClient wc = new WebClient();
                    string somestring = wc.DownloadString(Classvariables.maintenancemessageurl);

                    // MetroFramework.MetroMessageBox.Show(this, "Mesage: " + "New version availible! " + "Current Version: " + SimpleLauncher.ClsVariables.LauncherVersion + " Online Version: " + SimpleLauncher.ClsVariables.WebVersionxml, "Title: Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMessagebox messagebox = new frmMessagebox();
                    messagebox.Show("Mensagem de alerta", Color.FromArgb(255, 162, 0), Resources.Alert, somestring.ToString(), frmMessagebox.MessageBoxButon.OK);


                    lblMaintenance.Visible = true;
                    lblMaintenance.Text = "Maintenance: On ";

                    System.Diagnostics.Process.Start(Classvariables.Websiteurl);
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
                messagebox.Show("Mensagem de Erro", Color.FromArgb(255, 0, 0), Properties.Resources.Erro, "Erro ao tentar carregar versão do jogo na web ", frmMessagebox.MessageBoxButon.OK);
            }
        }

        void CheckNews()
        {
            try
            {

                WebClient wc = new WebClient();
                string somestring = wc.DownloadString(Classvariables.Newsurl);

                
                RichNews.Text = somestring.ToString();



            }
            catch (Exception)
            {

                frmMessagebox messagebox = new frmMessagebox();
                messagebox.Show("Mensagem de Erro", Color.FromArgb(255, 0, 0), Properties.Resources.Erro, "Erro ao tentar carregar novidades do jogo na web ", frmMessagebox.MessageBoxButon.OK);

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



        private void trmClean_Tick(object sender, EventArgs e)
        {
            CleanData();
            trmClean.Stop();
        }

        private void RichNews_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }


        private void BoxImagens_Paint(object sender, PaintEventArgs e)
        {
           
            Graphics g = e.Graphics;
            int RectangleWidht = 180;

            Color captionBgColor = Color.FromArgb(150, 0, 0, 0);
            g.FillRectangle(new SolidBrush(captionBgColor), new Rectangle(0, RectangleWidht, BoxImagens.Size.Width, 50));

            using (Font myFont = new Font("Segoe UI", 12))
            {
                e.Graphics.DrawString(BoxMessage, myFont, Brushes.White, new Point(2, RectangleWidht));
            }

            using (Font myFont2 = new Font("Segoe UI", 8.5f))
            {
                e.Graphics.DrawString(BoxMessageDesc, myFont2, Brushes.White, new Point(2, RectangleWidht + 20));
            }


        }
        private bool flag;
        private void lblNext_Click(object sender, EventArgs e)
        {

            try
            {
                var request02 = WebRequest.Create(Classvariables.Slider02);

                using (var response02 = request02.GetResponse())
                using (var stream02 = response02.GetResponseStream())
                {

                    if (flag)
                    {
                        BoxImagens.Image = Bitmap.FromStream(stream02);
                        BoxMessage = "Fonte da vida eterna";
                        BoxMessageDesc = "Sistema que usa o sistema de aura para cura";

                    }
                    else
                    {
                        var request03 = WebRequest.Create(Classvariables.Slider03);

                        using (var response03 = request03.GetResponse())
                        using (var stream03 = response03.GetResponseStream())
                        {

                            BoxImagens.Image = Bitmap.FromStream(stream03);
                            BoxMessage = "Habilidades";
                            BoxMessageDesc = "Esse sistema consiste equilibrio no grid do jogo fazendo com que jogador sempre tenha que montar " + "\r\n"
                                + "suas habilidades antes de enfrentar quest especificas";
                        }
                    }

                    flag = !flag;

                }
            }
            catch (Exception)
            {
                BoxImagens.Image = Resources.erronetwork;
                BoxMessage = "erro 404";
                BoxMessageDesc = "pagina não encontrada ou erro de conexão!";
            }

        }
    }

  }

