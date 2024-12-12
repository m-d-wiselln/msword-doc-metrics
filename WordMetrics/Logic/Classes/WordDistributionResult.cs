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

        private IEnumerable<SingleFindResult>? _allFindings = null;

        private IEnumerable<WordPageResult>? _pages = null;
        public void AddAllFindings(IEnumerable<SingleFindResult> allFindings) { _allFindings = allFindings; }
        public void AddPages(IEnumerable<WordPageResult> allPages) { _pages = allPages; }   

    }
}