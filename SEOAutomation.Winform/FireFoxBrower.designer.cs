namespace SEOAutomation.Winform
{
    partial class FireFoxBrower
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
            this.richtxtLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richtxtLog
            // 
            this.richtxtLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richtxtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtxtLog.Location = new System.Drawing.Point(0, 0);
            this.richtxtLog.Name = "richtxtLog";
            this.richtxtLog.ReadOnly = true;
            this.richtxtLog.Size = new System.Drawing.Size(595, 376);
            this.richtxtLog.TabIndex = 0;
            this.richtxtLog.Text = "";
            this.richtxtLog.DoubleClick += new System.EventHandler(this.richtxtLog_DoubleClick);
            // 
            // FireFoxBrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 376);
            this.ControlBox = false;
            this.Controls.Add(this.richtxtLog);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FireFoxBrower";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FireFoxDrive";
            this.Load += new System.EventHandler(this.FireFoxDrive_Load);
            this.DoubleClick += new System.EventHandler(this.FireFoxBrower_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtLog;
    }
}

