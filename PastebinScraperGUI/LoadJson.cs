using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastebinScraperGUI
{
    public class SearchResult
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Root
    {
        public int SearchResultsCount { get; set; }
        public int FetchedResultsCount { get; set; }
        public List<SearchResult> SearchResults { get; set; }
        public string Url { get; set; }
    }
}
