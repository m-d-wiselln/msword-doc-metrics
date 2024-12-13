using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMetrics.Logic.Classes
{
    internal class WordDistributionResult
    {
        public WordDistributionResult() { }
        public string Word { get; set; } = string.Empty;
        public IEnumerable<WordPageResult>? Pages { get {  return _pages; } }

        public int FindingCount { get
            {
                if (_allFindings == null || !_allFindings.Any()) { return 0; }
                return _allFindings.Count();
            }
        }

        private IEnumerable<SingleFindResult>? _allFindings = null;

        private IEnumerable<WordPageResult>? _pages = null;
        public void AddAllFindings(IEnumerable<SingleFindResult> allFindings) { _allFindings = allFindings; }
        public void AddPages(IEnumerable<WordPageResult> allPages) { _pages = allPages; }

        public void ProcessFindings()
        {

            if (_pages == null || !_pages.Any()) { return; }

            if (_allFindings == null || !_allFindings.Any()) { return; }

            foreach (WordPageResult page in _pages)
            {

                IEnumerable<SingleFindResult> findResults = (from findings in _allFindings where findings.PageNumber == page.PageNumber select findings).ToList();

                if (findResults.Any())
                {

                    foreach (SingleFindResult result in findResults)
                    {
                        page.AddFinding(result.FindResult);
                    }

                }


            }

        }
    }
}