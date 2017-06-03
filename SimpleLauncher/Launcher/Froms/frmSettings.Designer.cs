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
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(96, 32);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(350, 20);
            this.txtLocation.TabIndex = 6;
            // 
            // bttBrowse
            // 
            this.bttBrowse.Location = new System.Drawing.Point(452, 32);
            this.bttBrowse.Name = "bttBrowse";
            this.bttBrowse.Size = new System.Drawing.Size(182, 19);
            this.bttBrowse.TabIndex = 7;
            this.bttBrowse.Text = "Browse";
            this.bttBrowse.UseVisualStyleBackColor = true;
            this.bttBrowse.Click += new System.EventHandler(this.bttBrowse_Click);
            // 
            // lblGamelocation
            // 
            this.lblGamelocation.AutoSize = true;
            this.lblGamelocation.ForeColor = System.Drawing.Color.Black;
            this.lblGamelocation.Location = new System.Drawing.Point(12, 35);
            this.lblGamelocation.Name = "lblGamelocation";
            this.lblGamelocation.Size = new System.Drawing.Size(78, 13);
            this.lblGamelocation.TabIndex = 8;
            this.lblGamelocation.Text = "Game location:";
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(12, 105);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(171, 48);
            this.bttCancel.TabIndex = 9;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseVisualStyleBackColor = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // bttOk
            // 
            this.bttOk.Location = new System.Drawing.Point(452, 105);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(182, 48);
            this.bttOk.TabIndex = 10;
            this.bttOk.Text = "Ok";
            this.bttOk.UseVisualStyleBackColor = true;
            this.bttOk.Click += new System.EventHandler(this.bttOk_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 165);
            this.Controls.Add(this.bttOk);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.lblGamelocation);
            this.Controls.Add(this.bttBrowse);
            this.Controls.Add(this.txtLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(657, 204);
            this.MinimumSize = new System.Drawing.Size(657, 204);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button bttBrowse;
        private System.Windows.Forms.Label lblGamelocation;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttOk;
    }
}