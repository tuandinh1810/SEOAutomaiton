namespace SEOAutomation.Winform
{
    partial class BrowerGecko
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
            this.geckoBrower = new Gecko.GeckoWebBrowser();
            this.SuspendLayout();
            // 
            // geckoBrower
            // 
            this.geckoBrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoBrower.Location = new System.Drawing.Point(0, 0);
            this.geckoBrower.Name = "geckoBrower";
            this.geckoBrower.Size = new System.Drawing.Size(829, 450);
            this.geckoBrower.TabIndex = 0;
            this.geckoBrower.UseHttpActivityObserver = false;
            this.geckoBrower.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.geckoBrower_DocumentCompleted);
            // 
            // BrowerGecko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.geckoBrower);
            this.Name = "BrowerGecko";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brower";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Brower_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gecko.GeckoWebBrowser geckoBrower;
    }
}