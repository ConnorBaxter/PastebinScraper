using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PastebinScraperLib;

namespace PastebinScraperGUI
{
    public partial class ScraperForm : Form
    {
        private BingResult bingResult;

        private string searchTerm;
        private int startPage = -1;
        private int pageRangeFrom = -1;
        private int pageRangeTo = -1;

        private bool saveToJson;
        private string jsonFilePath;

        private WebBrowserForm wbForm;

        public ScraperForm()
        {
            InitializeComponent();
        }

        private void ScraperForm_Load(object sender, EventArgs e)
        {
            rbStartFrom.Checked = true;
            chkSaveToJson.Checked = false;
        }

        private void PerformSearch()
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please specify search term.");
                return;
            }

            Scraper scraper;

            if(pageRangeFrom != -1 && pageRangeTo != -1)
            {
                scraper = new Scraper(searchTerm, pageRangeFrom, pageRangeTo);
            }
            else if(startPage != -1)
            {
                scraper = new Scraper(searchTerm, startPage);
            }
            else
            {
                scraper = new Scraper(searchTerm);
            }

            scraper.Search();

            if (saveToJson)
            {
                if (!Directory.Exists(GetDirectoryFromFilename()))
                    Directory.CreateDirectory(GetDirectoryFromFilename());
                if(!File.Exists(jsonFilePath)) File.Create(jsonFilePath).Close();
                scraper.SaveToJson(jsonFilePath);
            }

            bingResult = scraper.BingResult;
            DisplayResult();
        }

        private void DisplayResult()
        {
            dgvResults.Rows.Clear();

            List<int> ids = new List<int>();
            List<string> titles = new List<string>();
            List<string> urls = new List<string>();

            if (bingResult != null)
            {
                int counter = 0;
                foreach (Result res in bingResult.SearchResults)
                {
                    ids.Add(counter);
                    titles.Add(res.Name);
                    urls.Add(res.Url);
                    counter++;
                }
            }
            else
            {
                return;
            }

            foreach (int id in ids)
            {
                dgvResults.Rows.Add(id, titles[id], urls[id]);
            }
        }

        private void OpenWebBrowser(string url)
        {
            if (wbForm != null)
            {
                wbForm.ChangePage(url);
            }
            else
            {
                wbForm = new WebBrowserForm(url);
                wbForm.Show();
            }

        }

        private string GetDirectoryFromFilename()
        {
            string filename = jsonFilePath;
            List<string> split = jsonFilePath.Split('/').ToList();

            split.RemoveAt(split.Count-1);
            string path = "";
            foreach (string s in split)
            {
                path += s + "/";
            }

            return path;
        }

        private void HandleRadioButtonChange(object sender, EventArgs e)
        {
            if (rbStartFrom.Checked)
            {
                rbPageRange.Checked = false;
                pnlStartFromPage.Enabled = true;
                pnlStartFromPage.BackColor = Color.FromArgb(32, 32, 32);
                pnlPageRange.Enabled = false;
                pnlPageRange.BackColor = Color.DimGray;
            }

            if (rbPageRange.Checked)
            {
                rbStartFrom.Checked = false;
                pnlStartFromPage.Enabled = false;
                pnlStartFromPage.BackColor = Color.DimGray;
                pnlPageRange.Enabled = true;
                pnlPageRange.BackColor = Color.FromArgb(32, 32, 32);
            }
        }
        private void JsonCheckboxChanged(object sender, EventArgs e)
        {
            if (chkSaveToJson.Checked)
            {
                saveToJson = true;
                pnlJsonSave.Enabled = true;
                pnlJsonSave.BackColor = Color.FromArgb(32, 32, 32);
            }
            else
            {
                saveToJson = false;
                pnlJsonSave.Enabled = false;
                pnlJsonSave.BackColor = Color.DimGray;
            }
        }
        private void txtStartPage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                startPage = int.Parse(txtStartPage.Text);
            }
            catch { startPage = -1; }
        }
        private void txtPageFrom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pageRangeFrom = int.Parse(txtPageFrom.Text);
            }
            catch { pageRangeFrom = -1; }
        }
        private void txtPageTo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pageRangeTo = int.Parse(txtPageTo.Text);
            }
            catch { pageRangeTo = -1; }
        }
        private void txtJsonFilename_TextChanged(object sender, EventArgs e)
        {
            if (txtJsonFilename.Text.Contains(":"))
            {
                jsonFilePath = txtJsonFilename.Text;
            }
            else
            {
                jsonFilePath = Environment.CurrentDirectory + "/Exports/" + txtJsonFilename.Text;
            }
        }
        private void txtSearchTerm_TextChanged(object sender, EventArgs e)
        {
            searchTerm = txtSearchTerm.Text;
        }
        private void txtSearchTerm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch();
            }
        }

        private void btnSaveOutput_Click(object sender, EventArgs e)
        {
            if (bingResult != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Select save location";
                sfd.CreatePrompt = true;
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "JSON Files|*.json|All Files|*.*";
                sfd.DefaultExt = ".json";
                sfd.FilterIndex = 0;
                sfd.InitialDirectory = Environment.CurrentDirectory + "/Exports/";
                sfd.RestoreDirectory = true;
                DialogResult dr = sfd.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    jsonFilePath = sfd.FileName;
                    using(StreamWriter sw = new StreamWriter(jsonFilePath))
                    {
                        sw.Write(JsonConvert.SerializeObject(bingResult, Formatting.Indented));
                    }
                }
            }
        }

        private void btnOpenWeb_Click(object sender, EventArgs e)
        {
            if (bingResult.Url != null)
            {
                OpenWebBrowser(bingResult.Url);
            }
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string url = dgvResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                OpenWebBrowser(url);
            }
        }

        private BingResult RootToResult(Root root)
        {
            int rCount, fCount;
            List<Result> rList = new List<Result>();
            string rUrl;

            rCount = root.SearchResultsCount;
            fCount = root.FetchedResultsCount;
            rUrl = root.Url;

            
            foreach (SearchResult sr in root.SearchResults)
            {
                Result tmp = new Result(sr.Name, sr.Url);
                rList.Add(tmp);
            }

            BingResult bRes = new BingResult(rCount, fCount, rList, rUrl);
            return bRes;
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Not yet implemented", "PastebinScraper", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Title = "Select JSON Location";
            ofd.Filter = "JSON Files|*.json|All Files|*.*";
            ofd.DefaultExt = ".json";
            ofd.FilterIndex = 0;
            ofd.InitialDirectory = Environment.CurrentDirectory + "/Exports/";
            ofd.RestoreDirectory = true;
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string p = ofd.FileName;

                object tempObj = JsonConvert.DeserializeObject(File.ReadAllText(p));

                Root tempRoot = (Root) tempObj;

                bingResult = RootToResult(tempRoot);
                DisplayResult();
            }
        }
    }
}
