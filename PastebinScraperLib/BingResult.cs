using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastebinScraperLib
{
    public class BingResult
    {
        public int SearchResultsCount;
        public int FetchedResultsCount;
        public List<Result> SearchResults;
        public string Url;

        public BingResult(int resCount, int fetched, List<Result> results, string url)
        {
            SearchResultsCount = resCount;
            FetchedResultsCount = fetched;
            SearchResults = results;
            Url = url;
        }

        public BingResult ConsolidateResults(List<BingResult> results, string url)
        {
            List<Result> res = new List<Result>();

            foreach (BingResult r in results)
            {
                res.AddRange(r.SearchResults);
            }

            BingResult newResult = new BingResult(results[0].SearchResultsCount, res.Count, res, url);
            return newResult;
        }

        private string getSearchResultsAsTextFormat()
        {
            string data = "";
            foreach (Result r in SearchResults)
            {
                data += $"{r.Name}: {r.Url}\n";
            }
            return data;
        }

        public override string ToString()
        {
            return $"  Total Results: {SearchResultsCount}\n" +
                   $"Fetched Results: {FetchedResultsCount}\n" +
                   getSearchResultsAsTextFormat();

        }

        public string ToShortString()
        {
            return $"  Total Results: {SearchResultsCount}\n" +
                   $"Fetched Results: {FetchedResultsCount}";
        }

        public List<string>[] GetAsListStringArray()
        {
            List<string> leftCol = new List<string>();
            List<string> rightCol = new List<string>();

            foreach (Result res in SearchResults)
            {
                leftCol.Add(res.Name);
                rightCol.Add(res.Url);
            }

            return new[] { leftCol, rightCol };
        }
    }

    public class Result
    {
        public string Name;
        public string Url;

        public Result(string name, string url)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Untitled";
            }

            Name = name;
            Url = url;
        }
    }
}
