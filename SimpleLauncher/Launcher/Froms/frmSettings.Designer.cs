namespace SimpleLauncher
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.bttBrowse = new System.Windows.Forms.Button();
            this.lblGamelocation = new System.Windows.Forms.Label();
            this.bttOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttGithub = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttMinize = new System.Windows.Forms.Button();
            this.bttclosed = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(100, 107);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(601, 20);
            this.txtLocation.TabIndex = 6;
            // 
            // bttBrowse
            // 
            this.bttBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(166)))));
            this.bttBrowse.FlatAppearance.BorderSize = 0;
            this.bttBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttBrowse.ForeColor = System.Drawing.Color.White;
            this.bttBrowse.Location = new System.Drawing.Point(100, 364);
            this.bttBrowse.Name = "bttBrowse";
            this.bttBrowse.Size = new System.Drawing.Size(182, 62);
            this.bttBrowse.TabIndex = 7;
            this.bttBrowse.Text = "Escolher pasta";
            this.bttBrowse.UseVisualStyleBackColor = false;
            this.bttBrowse.Click += new System.EventHandler(this.bttBrowse_Click);
            // 
            // lblGamelocation
            // 
            this.lblGamelocation.AutoSize = true;
            this.lblGamelocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamelocation.ForeColor = System.Drawing.Color.White;
            this.lblGamelocation.Location = new System.Drawing.Point(101, 83);
            this.lblGamelocation.Name = "lblGamelocation";
            this.lblGamelocation.Size = new System.Drawing.Size(155, 21);
            this.lblGamelocation.TabIndex = 8;
            this.lblGamelocation.Text = "Local de instalação";
            // 
            // bttOk
            // 
            this.bttOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(166)))));
            this.bttOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttOk.FlatAppearance.BorderSize = 0;
            this.bttOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttOk.ForeColor = System.Drawing.Color.White;
            this.bttOk.Location = new System.Drawing.Point(519, 361);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(182, 62);
            this.bttOk.TabIndex = 10;
            this.bttOk.Text = "Ok";
            this.bttOk.UseVisualStyleBackColor = false;
            this.bttOk.Click += new System.EventHandler(this.bttOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 23);
            this.panel1.TabIndex = 16;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.bttGithub);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 429);
            this.panel2.TabIndex = 20;
            // 
            // bttGithub
            // 
            this.bttGithub.BackgroundImage = global::SimpleLauncher.Properties.Resources.GitHub_Mark;
            this.bttGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttGithub.FlatAppearance.BorderSize = 0;
            this.bttGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGithub.ForeColor = System.Drawing.Color.White;
            this.bttGithub.Location = new System.Drawing.Point(12, 371);
            this.bttGithub.Name = "bttGithub";
            this.bttGithub.Size = new System.Drawing.Size(62, 55);
            this.bttGithub.TabIndex = 15;
            this.bttGithub.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttGithub.UseVisualStyleBackColor = true;
            this.bttGithub.Click += new System.EventHandler(this.bttGithub_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleLauncher.Properties.Resources.CloundImg;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Simple Launcher";
            // 
            // bttMinize
            // 
            this.bttMinize.FlatAppearance.BorderSize = 0;
            this.bttMinize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMinize.Image = global::SimpleLauncher.Properties.Resources.inside;
            this.bttMinize.Location = new System.Drawing.Point(631, 0);
            this.bttMinize.Name = "bttMinize";
            this.bttMinize.Size = new System.Drawing.Size(33, 38);
            this.bttMinize.TabIndex = 23;
            this.bttMinize.UseVisualStyleBackColor = true;
            this.bttMinize.Click += new System.EventHandler(this.bttMinize_Click);
            // 
            // bttclosed
            // 
            this.bttclosed.FlatAppearance.BorderSize = 0;
            this.bttclosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttclosed.Image = global::SimpleLauncher.Properties.Resources.logout;
            this.bttclosed.Location = new System.Drawing.Point(670, 0);
            this.bttclosed.Name = "bttclosed";
            this.bttclosed.Size = new System.Drawing.Size(31, 38);
            this.bttclosed.TabIndex = 22;
            this.bttclosed.UseVisualStyleBackColor = true;
            this.bttclosed.Click += new System.EventHandler(this.bttclosed_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(713, 452);
            this.Controls.Add(this.bttMinize);
            this.Controls.Add(this.bttclosed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttOk);
            this.Controls.Add(this.lblGamelocation);
            this.Controls.Add(this.bttBrowse);
            this.Controls.Add(this.txtLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(713, 452);
            this.MinimumSize = new System.Drawing.Size(657, 204);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings launcher";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSettings_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button bttBrowse;
        private System.Windows.Forms.Label lblGamelocation;
        private System.Windows.Forms.Button bttOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttGithub;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttMinize;
        private System.Windows.Forms.Button bttclosed;
    }
}