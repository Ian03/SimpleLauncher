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
            this.LauncherContextmenu.SuspendLayout();
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
            this.bttStarGame.Location = new System.Drawing.Point(8, 330);
            this.bttStarGame.Name = "bttStarGame";
            this.bttStarGame.Size = new System.Drawing.Size(123, 40);
            this.bttStarGame.TabIndex = 2;
            this.bttStarGame.Text = "Start Game";
            this.bttStarGame.UseVisualStyleBackColor = true;
            this.bttStarGame.Click += new System.EventHandler(this.bttStarGame_Click);
            // 
            // Statusbar
            // 
            this.Statusbar.Location = new System.Drawing.Point(207, 330);
            this.Statusbar.Name = "Statusbar";
            this.Statusbar.Size = new System.Drawing.Size(471, 14);
            this.Statusbar.TabIndex = 7;
            this.Statusbar.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(5, 382);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(621, 382);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 13);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "Version :0";
            // 
            // StatusbarZip
            // 
            this.StatusbarZip.Location = new System.Drawing.Point(207, 356);
            this.StatusbarZip.Name = "StatusbarZip";
            this.StatusbarZip.Size = new System.Drawing.Size(471, 14);
            this.StatusbarZip.TabIndex = 11;
            this.StatusbarZip.Visible = false;
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.ForeColor = System.Drawing.Color.Black;
            this.lblStatus1.Location = new System.Drawing.Point(137, 330);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(64, 13);
            this.lblStatus1.TabIndex = 12;
            this.lblStatus1.Text = "Download:";
            this.lblStatus1.Visible = false;
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.ForeColor = System.Drawing.Color.Black;
            this.lblStatus2.Location = new System.Drawing.Point(137, 357);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(38, 13);
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
            this.lblMaintenance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenance.Location = new System.Drawing.Point(200, 9);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(233, 40);
            this.lblMaintenance.TabIndex = 14;
            this.lblMaintenance.Text = "Maintenance: On";
            this.lblMaintenance.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 402);
            this.Controls.Add(this.lblMaintenance);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.lblStatus1);
            this.Controls.Add(this.StatusbarZip);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.Statusbar);
            this.Controls.Add(this.bttStarGame);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(701, 402);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.LauncherContextmenu.ResumeLayout(false);
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
    }
}

