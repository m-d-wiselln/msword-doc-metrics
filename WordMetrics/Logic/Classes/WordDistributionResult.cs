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

        public IEnumerable<WordPageResult>? Pages { get; set; } = null;

    }
}