using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMetrics.Logic.Classes
{
    internal class WordPageResult
    {
        public WordPageResult() { }

        public int PageNumber { get; set; } = 1;

        private IList<string> _findings = new List<string>();

        public IEnumerable<string> Findings { get { return _findings; } }
        public void AddFinding(string text)
        {
            _findings.Add(text);
        }



    }
}