namespace SimpleLauncher
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.trmDel = new System.Windows.Forms.Timer(this.components);
            this.trmCheckupdate = new System.Windows.Forms.Timer(this.components);
            this.bttStarGame = new System.Windows.Forms.Button();
            this.Statusbar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.StatusbarZip = new System.Windows.Forms.ProgressBar();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.LauncherTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.LauncherContextmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.trmCheckMaintenance = new System.Windows.Forms.Timer(this.components);
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttGithub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttMinize = new System.Windows.Forms.Button();
            this.bttclosed = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RichNews = new System.Windows.Forms.RichTextBox();
            this.trmCheckNews = new System.Windows.Forms.Timer(this.components);
            this.LauncherContextmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // trmDel
            // 
            this.trmDel.Interval = 2000;
            this.trmDel.Tick += new System.EventHandler(this.trmDel_Tick);
            // 
            // trmCheckupdate
            // 
            this.trmCheckupdate.Interval = 1000;
            this.trmCheckupdate.Tick += new System.EventHandler(this.trmCheckupdate_Tick);
            // 
            // bttStarGame
            // 
            this.bttStarGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(166)))));
            this.bttStarGame.FlatAppearance.BorderSize = 0;
            this.bttStarGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttStarGame.ForeColor = System.Drawing.Color.White;
            this.bttStarGame.Location = new System.Drawing.Point(665, 350);
            this.bttStarGame.Name = "bttStarGame";
            this.bttStarGame.Size = new System.Drawing.Size(165, 85);
            this.bttStarGame.TabIndex = 2;
            this.bttStarGame.Text = "Start Game";
            this.bttStarGame.UseVisualStyleBackColor = false;
            this.bttStarGame.Click += new System.EventHandler(this.bttStarGame_Click);
            // 
            // Statusbar
            // 
            this.Statusbar.Location = new System.Drawing.Point(151, 350);
            this.Statusbar.Name = "Statusbar";
            this.Statusbar.Size = new System.Drawing.Size(505, 30);
            this.Statusbar.TabIndex = 7;
            this.Statusbar.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(3, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(778, 5);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 13);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "Version :0";
            // 
            // StatusbarZip
            // 
            this.StatusbarZip.Location = new System.Drawing.Point(151, 405);
            this.StatusbarZip.Name = "StatusbarZip";
            this.StatusbarZip.Size = new System.Drawing.Size(505, 30);
            this.StatusbarZip.TabIndex = 11;
            this.StatusbarZip.Visible = false;
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus1.ForeColor = System.Drawing.Color.White;
            this.lblStatus1.Location = new System.Drawing.Point(148, 334);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(64, 13);
            this.lblStatus1.TabIndex = 12;
            this.lblStatus1.Text = "Download:";
            this.lblStatus1.Visible = false;
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus2.ForeColor = System.Drawing.Color.White;
            this.lblStatus2.Location = new System.Drawing.Point(151, 389);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(39, 13);
            this.lblStatus2.TabIndex = 13;
            this.lblStatus2.Text = "Patch:";
            this.lblStatus2.Visible = false;
            // 
            // LauncherTray
            // 
            this.LauncherTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.LauncherTray.ContextMenuStrip = this.LauncherContextmenu;
            this.LauncherTray.Icon = ((System.Drawing.Icon)(resources.GetObject("LauncherTray.Icon")));
            this.LauncherTray.Text = "Launcher in tray icon";
            this.LauncherTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LauncherTray_MouseClick);
            this.LauncherTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDoubleClick);
            // 
            // LauncherContextmenu
            // 
            this.LauncherContextmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playGameMenu,
            this.optionsMenu,
            this.creditsMenu,
            this.toolStripSeparator2,
            this.exitMenu});
            this.LauncherContextmenu.Name = "LauncherContextmenu";
            this.LauncherContextmenu.Size = new System.Drawing.Size(130, 98);
            // 
            // playGameMenu
            // 
            this.playGameMenu.Name = "playGameMenu";
            this.playGameMenu.Size = new System.Drawing.Size(129, 22);
            this.playGameMenu.Text = "Play game";
            // 
            // optionsMenu
            // 
            this.optionsMenu.Name = "optionsMenu";
            this.optionsMenu.Size = new System.Drawing.Size(129, 22);
            this.optionsMenu.Text = "Settings";
            // 
            // creditsMenu
            // 
            this.creditsMenu.Name = "creditsMenu";
            this.creditsMenu.Size = new System.Drawing.Size(129, 22);
            this.creditsMenu.Text = "Credits";
            this.creditsMenu.Click += new System.EventHandler(this.creditsMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(129, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // trmCheckMaintenance
            // 
            this.trmCheckMaintenance.Interval = 1000;
            this.trmCheckMaintenance.Tick += new System.EventHandler(this.trmCheckMaintenance_Tick);
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenance.ForeColor = System.Drawing.Color.White;
            this.lblMaintenance.Location = new System.Drawing.Point(368, 3);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(96, 13);
            this.lblMaintenance.TabIndex = 14;
            this.lblMaintenance.Text = "Maintenance: On";
            this.lblMaintenance.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblMaintenance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 23);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.bttGithub);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 446);
            this.panel2.TabIndex = 16;
            // 
            // bttGithub
            // 
            this.bttGithub.BackgroundImage = global::SimpleLauncher.Properties.Resources.GitHub_Mark;
            this.bttGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttGithub.FlatAppearance.BorderSize = 0;
            this.bttGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGithub.ForeColor = System.Drawing.Color.White;
            this.bttGithub.Location = new System.Drawing.Point(12, 385);
            this.bttGithub.Name = "bttGithub";
            this.bttGithub.Size = new System.Drawing.Size(62, 55);
            this.bttGithub.TabIndex = 15;
            this.bttGithub.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttGithub.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Simple Launcher";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleLauncher.Properties.Resources.CloundImg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // bttMinize
            // 
            this.bttMinize.FlatAppearance.BorderSize = 0;
            this.bttMinize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMinize.Image = global::SimpleLauncher.Properties.Resources.inside;
            this.bttMinize.Location = new System.Drawing.Point(702, 12);
            this.bttMinize.Name = "bttMinize";
            this.bttMinize.Size = new System.Drawing.Size(61, 59);
            this.bttMinize.TabIndex = 18;
            this.bttMinize.UseVisualStyleBackColor = true;
            this.bttMinize.Click += new System.EventHandler(this.bttMinize_Click);
            // 
            // bttclosed
            // 
            this.bttclosed.FlatAppearance.BorderSize = 0;
            this.bttclosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttclosed.Image = global::SimpleLauncher.Properties.Resources.logout;
            this.bttclosed.Location = new System.Drawing.Point(769, 12);
            this.bttclosed.Name = "bttclosed";
            this.bttclosed.Size = new System.Drawing.Size(61, 59);
            this.bttclosed.TabIndex = 17;
            this.bttclosed.UseVisualStyleBackColor = true;
            this.bttclosed.Click += new System.EventHandler(this.bttclosed_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.RichNews);
            this.panel3.Location = new System.Drawing.Point(154, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 243);
            this.panel3.TabIndex = 19;
            // 
            // RichNews
            // 
            this.RichNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.RichNews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichNews.ForeColor = System.Drawing.Color.White;
            this.RichNews.Location = new System.Drawing.Point(3, 3);
            this.RichNews.Name = "RichNews";
            this.RichNews.Size = new System.Drawing.Size(253, 237);
            this.RichNews.TabIndex = 0;
            this.RichNews.Text = "Hi teste";
            // 
            // trmCheckNews
            // 
            this.trmCheckNews.Enabled = true;
            this.trmCheckNews.Interval = 1000;
            this.trmCheckNews.Tick += new System.EventHandler(this.trmCheckNews_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(842, 469);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bttMinize);
            this.Controls.Add(this.bttclosed);
            this.Controls.Add(this.Statusbar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.lblStatus1);
            this.Controls.Add(this.StatusbarZip);
            this.Controls.Add(this.bttStarGame);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(701, 402);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.LauncherContextmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer trmDel;
        private System.Windows.Forms.Timer trmCheckupdate;
        private System.Windows.Forms.Button bttStarGame;
        private System.Windows.Forms.ProgressBar Statusbar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ProgressBar StatusbarZip;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.NotifyIcon LauncherTray;
        private System.Windows.Forms.ContextMenuStrip LauncherContextmenu;
        private System.Windows.Forms.ToolStripMenuItem playGameMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsMenu;
        private System.Windows.Forms.ToolStripMenuItem creditsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.Timer trmCheckMaintenance;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttGithub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttclosed;
        private System.Windows.Forms.Button bttMinize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox RichNews;
        private System.Windows.Forms.Timer trmCheckNews;
    }
}

