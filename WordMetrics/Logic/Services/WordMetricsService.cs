using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop;
using WordMetrics.Logic.Classes;
using Microsoft.Office.Interop.Word;
using System.Reflection;

namespace WordMetrics.Logic.Services
{
    internal static class WordMetricsService
    {

        public static IEnumerable<WordDistributionResult>? WordDistributions(string filePath, string[] words)
        {

            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));

            if (words == null || words.Length == 0) throw new ArgumentNullException(nameof(words));

            if (!File.Exists(filePath)) throw new FileNotFoundException(nameof(filePath));

            var result = new List<WordDistributionResult>();

            Microsoft.Office.Interop.Word.Application? wordApplication = null;
            try
            {

                wordApplication = new Microsoft.Office.Interop.Word.Application();
                wordApplication.Visible = false;

                Microsoft.Office.Interop.Word.Document? document = null;

                try
                {
                    document = wordApplication.Documents.Open(filePath, ReadOnly: true);

                    var lastPage = document.Range().GoTo(WdGoToItem.wdGoToPage, WdGoToDirection.wdGoToLast);
                    var numberOfPages = (int)lastPage.Information[WdInformation.wdActiveEndPageNumber];


                    foreach (string singleWord in words)
                    {
                        int currentPageNumber = 0;
                        WordDistributionResult thisWordResult = new WordDistributionResult() { Word = singleWord };
                        IList<WordPageResult> wordPages = new List<WordPageResult>();
                        IList<SingleFindResult> allFindings = new List<SingleFindResult>();

                        for (int i = 1; i <= numberOfPages; i++)
                        {
                            wordPages.Add(new WordPageResult() { PageNumber = i });
                        }

                        Microsoft.Office.Interop.Word.Range range = document.Content;

                        range.Find.Execute(singleWord);

                        while (range.Find.Found)
                        {
                            currentPageNumber = (int)range.Information[WdInformation.wdActiveEndPageNumber];
                            allFindings.Add(new SingleFindResult() { PageNumber = currentPageNumber, FindResult = range.Text });
                            range.Find.Execute(singleWord);
                        }

                        thisWordResult.AddPages(wordPages);
                        thisWordResult.AddAllFindings(allFindings);
                        result.Add(thisWordResult);

                    }
                }
                finally
                {
                    if (document != null)
                    {
                        document.Saved = true;
                    }
                    document?.Close();
                }
            }
            finally
            {
                wordApplication?.Quit(SaveChanges: false);
            }

            return Process(result);
        }

        private static IEnumerable<WordDistributionResult>? Process(IEnumerable<WordDistributionResult>? source)
        {
            if(source == null || !source.Any()) {  return source; }

            IEnumerable<WordDistributionResult>? result = source;

            foreach (WordDistributionResult resultItem in result) {
                resultItem.ProcessFindings();
            }

            return result;
        }

    }
}