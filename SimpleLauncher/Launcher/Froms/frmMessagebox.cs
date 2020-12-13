using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLauncher.Froms
{
    public partial class frmMessagebox : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmMessagebox()
        {
            InitializeComponent();
            this.Show();
        }
        public enum MessageBoxButon
        {
            OK=0,Yesno=1,YesnoCancel=2,finish = 3
        };

        public void Show(String Title, String Message, MessageBoxButon buton)
        {
            lblTitle.Text = Title;
            RichMessage.Text = Message;
            if(MessageBoxButon.OK==buton)
            {
                bttStarGame.Visible = true;
            }
            else if (MessageBoxButon.Yesno == buton)
            {

            }
            else if (MessageBoxButon.YesnoCancel == buton)
            {

            }
            else if (MessageBoxButon.finish == buton)
            {
                bttfinish.Visible = true;
            }
        }

        private void bttStarGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMessagebox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        void Destroy_Launcher()
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void bttfinish_Click(object sender, EventArgs e)
        {
            Destroy_Launcher();
        }
    }
}
