using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastebinScraperGUI
{
    public partial class WebBrowserForm : Form
    {
        private string Url;

        public WebBrowserForm(string url)
        {
            InitializeComponent();

            Url = url;
        }

        public void ChangePage(string newUrl)
        {
            Url = newUrl;
            reloadWebbrowser();
        }

        private void reloadWebbrowser()
        {
            if (browser != null)
            {
                browser.Url = new Uri(Url, UriKind.Absolute);
            }
        }

        private void WebBrowserForm_Load(object sender, EventArgs e)
        {
            browser.Url = new Uri(Url);
        }

        private void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtCurrentUrl.Text = browser.Url.ToString();
        }
    }
}
