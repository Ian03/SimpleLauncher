
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttStarGame = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bttfinish = new System.Windows.Forms.Button();
            this.RichMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(166)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 23);
            this.panel1.TabIndex = 17;
            // 
            // bttStarGame
            // 
            this.bttStarGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(166)))));
            this.bttStarGame.FlatAppearance.BorderSize = 0;
            this.bttStarGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttStarGame.ForeColor = System.Drawing.Color.White;
            this.bttStarGame.Location = new System.Drawing.Point(339, 156);
            this.bttStarGame.Name = "bttStarGame";
            this.bttStarGame.Size = new System.Drawing.Size(165, 41);
            this.bttStarGame.TabIndex = 16;
            this.bttStarGame.Text = "Ok";
            this.bttStarGame.UseVisualStyleBackColor = false;
            this.bttStarGame.Visible = false;
            this.bttStarGame.Click += new System.EventHandler(this.bttStarGame_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 21);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Simple Launcher";
            // 
            // bttfinish
            // 
            this.bttfinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(166)))));
            this.bttfinish.FlatAppearance.BorderSize = 0;
            this.bttfinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttfinish.ForeColor = System.Drawing.Color.White;
            this.bttfinish.Location = new System.Drawing.Point(168, 156);
            this.bttfinish.Name = "bttfinish";
            this.bttfinish.Size = new System.Drawing.Size(165, 41);
            this.bttfinish.TabIndex = 22;
            this.bttfinish.Text = "Ok";
            this.bttfinish.UseVisualStyleBackColor = false;
            this.bttfinish.Visible = false;
            this.bttfinish.Click += new System.EventHandler(this.bttfinish_Click);
            // 
            // RichMessage
            // 
            this.RichMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.RichMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichMessage.ForeColor = System.Drawing.Color.White;
            this.RichMessage.Location = new System.Drawing.Point(42, 33);
            this.RichMessage.Name = "RichMessage";
            this.RichMessage.Size = new System.Drawing.Size(462, 117);
            this.RichMessage.TabIndex = 11;
            this.RichMessage.Text = "";
            // 
            // frmMessagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(516, 226);
            this.Controls.Add(this.RichMessage);
            this.Controls.Add(this.bttfinish);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.bttStarGame);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessagebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessagebox";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMessagebox_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttStarGame;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button bttfinish;
        private System.Windows.Forms.RichTextBox RichMessage;
    }
}