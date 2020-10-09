using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using BaxLogger;
using Newtonsoft.Json;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace PastebinScraperLib
{
    public class Scraper
    {
        Logger logger = new Logger(false);

        private bool RangeSearch;
        private int Range;

        private string SearchTerm;
        private int Page;

        public BingResult BingResult;

        public Scraper()
        {
            logger.Log("No search term specified, prompting...", logger.STATUS_WARNING);
            SearchTerm = Interaction.InputBox("Enter search term: ", "PastebinScraper", "test");
            Page = int.Parse(Interaction.InputBox("Start search from page: ", "PastebinScraper", "1"));
        }

        public Scraper(string searchTerm)
        {
            SearchTerm = searchTerm;
            Page = 1;
        }

        public Scraper(string searchTerm, int page)
        {
            logger.Log($"Search term {{{searchTerm}}} set.", logger.STATUS_OKAY);
            SearchTerm = searchTerm;
            if (page == 1)
            {
                Page = 1;
            }
            else
            {
                Page = (page - 1) * 10;
            }
        }

        public Scraper(string searchTerm, int pageFrom, int pageTo)
        {
            logger.Log($"Search term {{{searchTerm}}} set.", logger.STATUS_OKAY);

            SearchTerm = searchTerm;

            if (pageFrom == 1) { pageFrom = 1; }
            else { pageFrom = (pageFrom - 1) * 10; }

            pageTo = (pageTo - 1) * 10;

            Page = pageFrom;

            RangeSearch = true;
            Range = (pageTo - pageFrom) / 10;
        }

        private string GetUrl()
        {
            string url = "";
            url += "https://www.bing.com/search?";
            url += "q=" + SearchTerm;
            url += "+site%3apastebin.com";
            url += "&first=" + Page;
            return url;
        }

        public void Search()
        {
            if (RangeSearch)
            {
                logger.Log("Starting range search...");

                List<BingResult> rangeResults = new List<BingResult>();
                for (int i = 0; i < Range; i++)
                {
                    Page = (i * 10);
                    Thread tRange = new Thread(SearchMethod);
                    tRange.SetApartmentState(ApartmentState.STA);
                    tRange.Start();
                    tRange.Join();
                    rangeResults.Add(BingResult);
                }

                BingResult = BingResult.ConsolidateResults(rangeResults, GetUrl());

                return;
            }

            logger.Log($"Search for {SearchTerm} has begun...", logger.STATUS_INFO);

            Thread t = new Thread(SearchMethod);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            t.Join();

            logger.Log("Search completed", logger.STATUS_OKAY);
        }


        private void SearchMethod()
        {
            int resCount = 0;
            int fetched = 0;
            List<Result> results = new List<Result>();

            string url = GetUrl();
            logger.Log("Url: " + url, logger.STATUS_INFO);
            logger.Log("Start From: " + Page + "\n", logger.STATUS_INFO);
            HtmlWeb web = new HtmlWeb();

            HtmlDocument document = web.LoadFromBrowser(url, o =>
            {
                WebBrowser webBrowser = (WebBrowser) o;
                return !string.IsNullOrEmpty(webBrowser.Document.GetElementById("b_results").InnerHtml);
            });

            var allResults = new List<HtmlNode>();
            try
            {
                allResults = document.DocumentNode.SelectNodes("//ol/li/h2").ToList();
            }
            catch (Exception e)
            {
                allResults = new List<HtmlNode> {HtmlNode.CreateNode("<h2>No results</h2>")};
            }

            List<string> resultsList = new List<string>();
            foreach (var listItem in allResults)
            {
                resultsList.Add(listItem.InnerHtml);
            }

            foreach (string res in resultsList)
            {
                if (res == "No results")
                {
                    Result r = new Result("No results", "No results");
                    results.Add(r);
                    continue;
                }

                string resName = res.Substring(res.IndexOf('>') + 1);
                resName = resName.Replace(" - Pastebin.com", "");
                resName = resName.Split('<')[0];

                string resUrl = res.Substring(res.IndexOf('=') + 2);
                resUrl = resUrl.Split('"')[0];

                Result result = new Result(resName, resUrl);
                results.Add(result);
            }

            var possibleResCount = document.DocumentNode.SelectNodes("//div/span").ToList();
            foreach (var poss in possibleResCount)
            {
                if (poss.InnerText.Contains(" results"))
                {
                    string asText = poss.InnerText;
                    asText = asText.Replace(" results", "");
                    asText = asText.Replace(",", "");

                    if (asText.Contains("of"))
                    {
                        asText = asText.Split(' ')[2];
                    }

                    resCount = int.Parse(asText);
                }
            }

            fetched = results.Count;

            BingResult bingResult = new BingResult(resCount, fetched, results, GetUrl());
            BingResult = bingResult;
        }

        public void SaveToJson(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                string data = JsonConvert.SerializeObject(BingResult, Formatting.Indented);
                sw.Write(data);
            }
        }
    }
}
