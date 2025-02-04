﻿using System;
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

        public IEnumerable<string> Findings { get; set; } = new List<string>();

    }
}