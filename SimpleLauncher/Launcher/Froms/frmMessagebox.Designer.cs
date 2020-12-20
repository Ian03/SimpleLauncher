
namespace SimpleLauncher.Froms
{
    partial class frmMessagebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessagebox));
            this.panelcolor = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Boxicon = new System.Windows.Forms.PictureBox();
            this.lblok = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblfinish = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Boxicon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcolor
            // 
            this.panelcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panelcolor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelcolor.Location = new System.Drawing.Point(0, 0);
            this.panelcolor.Name = "panelcolor";
            this.panelcolor.Size = new System.Drawing.Size(10, 114);
            this.panelcolor.TabIndex = 17;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(113, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 30);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Simple Launcher";
            // 
            // Boxicon
            // 
            this.Boxicon.BackColor = System.Drawing.Color.Transparent;
            this.Boxicon.Location = new System.Drawing.Point(16, 12);
            this.Boxicon.Name = "Boxicon";
            this.Boxicon.Size = new System.Drawing.Size(91, 86);
            this.Boxicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Boxicon.TabIndex = 24;
            this.Boxicon.TabStop = false;
            // 
            // lblok
            // 
            this.lblok.AutoSize = true;
            this.lblok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblok.ForeColor = System.Drawing.Color.White;
            this.lblok.Location = new System.Drawing.Point(536, 9);
            this.lblok.Name = "lblok";
            this.lblok.Size = new System.Drawing.Size(20, 21);
            this.lblok.TabIndex = 25;
            this.lblok.Text = "X";
            this.lblok.Visible = false;
            this.lblok.Click += new System.EventHandler(this.lblok_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(115, 39);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(400, 59);
            this.lblMessage.TabIndex = 26;
            this.lblMessage.Text = "fsdfsdasdas\r\ndasdas\r\ndasdasdasdasd\r\ndasdasdas\r\n";
            // 
            // lblfinish
            // 
            this.lblfinish.AutoSize = true;
            this.lblfinish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinish.ForeColor = System.Drawing.Color.White;
            this.lblfinish.Location = new System.Drawing.Point(536, 12);
            this.lblfinish.Name = "lblfinish";
            this.lblfinish.Size = new System.Drawing.Size(20, 21);
            this.lblfinish.TabIndex = 27;
            this.lblfinish.Text = "X";
            this.lblfinish.Visible = false;
            this.lblfinish.Click += new System.EventHandler(this.lblfinish_Click);
            // 
            // frmMessagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(568, 114);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.Boxicon);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelcolor);
            this.Controls.Add(this.lblfinish);
            this.Controls.Add(this.lblok);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMessagebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessagebox";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMessagebox_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Boxicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelcolor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox Boxicon;
        private System.Windows.Forms.Label lblok;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblfinish;
    }
}