using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WordMetrics.Logic.Classes
{
    internal class SingleFindResult
    {

        public SingleFindResult() { }

        public int PageNumber { get; set; }

        public string FindResult { get; set; } = string.Empty;
    }
}
