namespace PastebinScraperGUI
{
    partial class WebBrowserForm
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
            this.browser = new System.Windows.Forms.WebBrowser();
            this.txtCurrentUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 0);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.ScriptErrorsSuppressed = true;
            this.browser.Size = new System.Drawing.Size(800, 450);
            this.browser.TabIndex = 0;
            this.browser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.browser_Navigated);
            // 
            // txtCurrentUrl
            // 
            this.txtCurrentUrl.BackColor = System.Drawing.Color.White;
            this.txtCurrentUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCurrentUrl.Location = new System.Drawing.Point(0, 0);
            this.txtCurrentUrl.Name = "txtCurrentUrl";
            this.txtCurrentUrl.ReadOnly = true;
            this.txtCurrentUrl.Size = new System.Drawing.Size(800, 20);
            this.txtCurrentUrl.TabIndex = 1;
            // 
            // WebBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCurrentUrl);
            this.Controls.Add(this.browser);
            this.Name = "WebBrowserForm";
            this.ShowIcon = false;
            this.Text = "PastebinScraper Web Browser";
            this.Load += new System.EventHandler(this.WebBrowserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.TextBox txtCurrentUrl;
    }
}