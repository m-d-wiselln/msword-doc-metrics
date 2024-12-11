using System.Windows.Forms;
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
            IEnumerable<WordDistributionResult>? wordDistributions = WordMetricsService.WordDistributions(this.FilePath.Text, this.WordList.Lines);
            if (wordDistributions != null && wordDistributions.Any()) {
                


            }
        }
    }
}
