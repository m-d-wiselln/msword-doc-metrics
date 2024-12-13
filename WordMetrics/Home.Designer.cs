namespace WordMetrics
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FilePath = new TextBox();
            label1 = new Label();
            SelectFile = new Button();
            WordList = new TextBox();
            label2 = new Label();
            AnalyzeDocument = new Button();
            AnalyzeProgress = new ProgressBar();
            WordResults = new TreeView();
            SuspendLayout();
            // 
            // FilePath
            // 
            FilePath.Enabled = false;
            FilePath.Location = new Point(93, 48);
            FilePath.Name = "FilePath";
            FilePath.ReadOnly = true;
            FilePath.Size = new Size(594, 27);
            FilePath.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 51);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Select File:";
            // 
            // SelectFile
            // 
            SelectFile.Location = new Point(693, 47);
            SelectFile.Name = "SelectFile";
            SelectFile.Size = new Size(95, 28);
            SelectFile.TabIndex = 2;
            SelectFile.Text = "Browse...";
            SelectFile.UseVisualStyleBackColor = true;
            SelectFile.Click += SelectFile_Click;
            // 
            // WordList
            // 
            WordList.Location = new Point(93, 81);
            WordList.Multiline = true;
            WordList.Name = "WordList";
            WordList.Size = new Size(324, 120);
            WordList.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 84);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Word(s):";
            // 
            // AnalyzeDocument
            // 
            AnalyzeDocument.Location = new Point(694, 172);
            AnalyzeDocument.Name = "AnalyzeDocument";
            AnalyzeDocument.Size = new Size(94, 29);
            AnalyzeDocument.TabIndex = 6;
            AnalyzeDocument.Text = "Analyze";
            AnalyzeDocument.UseVisualStyleBackColor = true;
            AnalyzeDocument.Click += AnalyzeDocument_Click;
            // 
            // AnalyzeProgress
            // 
            AnalyzeProgress.Location = new Point(423, 173);
            AnalyzeProgress.Name = "AnalyzeProgress";
            AnalyzeProgress.Size = new Size(264, 27);
            AnalyzeProgress.TabIndex = 7;
            // 
            // WordResults
            // 
            WordResults.Location = new Point(8, 207);
            WordResults.Name = "WordResults";
            WordResults.Size = new Size(780, 293);
            WordResults.TabIndex = 8;
            WordResults.Visible = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(WordResults);
            Controls.Add(AnalyzeProgress);
            Controls.Add(AnalyzeDocument);
            Controls.Add(label2);
            Controls.Add(WordList);
            Controls.Add(SelectFile);
            Controls.Add(label1);
            Controls.Add(FilePath);
            Name = "Home";
            Text = "Word Metrics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FilePath;
        private Label label1;
        private Button SelectFile;
        private TextBox WordList;
        private Label label2;
        private Button AnalyzeDocument;
        private ProgressBar AnalyzeProgress;
        private TreeView WordResults;
    }
}
