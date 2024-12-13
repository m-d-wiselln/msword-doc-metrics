using System.Windows.Forms;
using System.Linq;
using WordMetrics.Logic.Classes;
using WordMetrics.Logic.Services;

namespace WordMetrics
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new();
            fileDialog.Filter = "Word Docs (*.docx)|*.docx|Macro-Enabled Word Docs (*.docm)|*.docm";
            fileDialog.Title = "Select Document To Analyze";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.FilePath.Text = fileDialog.FileName;
            }
        }

        private void AnalyzeDocument_Click(object sender, EventArgs e)
        {

            WordResults.Visible = false;
            WordResults.Nodes.Clear();

            AnalyzeDocument.Enabled = false;
            IEnumerable<WordDistributionResult>? wordDistributions = WordMetricsService.WordDistributions(this.FilePath.Text, this.WordList.Lines);
            if (wordDistributions?.Count() > 0) {

                foreach (WordDistributionResult result in wordDistributions) {

                    TreeNode wordNode = new TreeNode() { Text = string.Format("{0} (Total Results: {1:#,##0})", result.Word, result.FindingCount) };

                    if (result.Pages != null && result.Pages.Any())
                    {
                        foreach (WordPageResult page in result.Pages)
                        {
                            string pageNodeText = $"Page {page.PageNumber}";

                            if(page.Findings != null && page.Findings.Any())  { pageNodeText += string.Format(" (Count: {0:#,##0})", page.Findings.Count()); }

                            TreeNode pageNode = new TreeNode() { Text = pageNodeText };
                            wordNode.Nodes.Add(pageNode);

                            if(page.Findings != null && page.Findings.Any())
                            {
                                foreach (string finding in page.Findings)
                                {
                                    pageNode.Nodes.Add(new TreeNode() { Text = finding });
                                }
                            }

                        }

                    }

                    WordResults.Nodes.Add(wordNode);    

                }

                WordResults.Visible = true;

            }

            AnalyzeDocument.Enabled = true;
        }
    }
}
