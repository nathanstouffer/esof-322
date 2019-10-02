using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DesignPatternFinder
{
    public partial class DesignPatternFinderForm : Form
    {
        private readonly DesignPatternFinder finder;
        private Size previousSize;

        public DesignPatternFinderForm()
        {
            InitializeComponent();
            previousSize = Size;

            finder = new DesignPatternFinder();

            // Fill the filter ComboBox
            patternFilterComboBox.Items.Add("All");
            foreach (PatternDefinition pattern in finder.PatternDefinitions)
            {
                patternFilterComboBox.Items.Add(pattern);
            }
            patternFilterComboBox.SelectedIndex = 0;
        }

        private void directoryPickerButton_Click(object sender, EventArgs e)
        {
            string previousPath = folderBrowserDialog.SelectedPath;
            folderBrowserDialog.ShowDialog();
            if (!String.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
            {
                if (!previousPath.Equals(folderBrowserDialog.SelectedPath)) // New search
                {
                    resultsListBox.Items.Clear();
                    startDirectoryTextBox.Text = folderBrowserDialog.SelectedPath;
                    findButton.Enabled = true;
                    patternFilterComboBox.SelectedIndex = 0;
                }
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // Disable Controls
            directoryPickerButton.Enabled = false;
            searchFileContentCheckBox.Enabled = false;
            findButton.Enabled = false;

            string sourcePath = startDirectoryTextBox.Text.Trim();

            finder.StartDirectory = new DirectoryInfo(sourcePath);
            finder.SearchFileContent = searchFileContentCheckBox.Checked;
            finder.Start();

            if (patternFilterComboBox.SelectedIndex != 0)
            {
                PatternDefinition pattern = (PatternDefinition) patternFilterComboBox.SelectedItem;
                finder.Filter(pattern);
            }

            WriteResultsToListBox();

            // Enable Controls
            directoryPickerButton.Enabled = true;
            searchFileContentCheckBox.Enabled = true;
            findButton.Enabled = true;
            patternFilterComboBox.Enabled = true;
        }

        private void WriteResultsToListBox()
        {
            resultsListBox.Items.Clear();

            resultsListBox.Items.Add("Found " + finder.Results.Count + " files that possibly contain design patterns.");
            resultsListBox.Items.Add("");

            foreach (PatternFinderResult result in finder.Results)
            {
                string temp = result.File.FullName.Replace(finder.StartDirectory.FullName, string.Empty);
                resultsListBox.Items.Add(temp);
                resultsListBox.Items.Add("Possible patterns: " + result.PossiblePatterns);
                resultsListBox.Items.Add("");
            }
        }

        private void resultsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string pathToFile = (string) resultsListBox.SelectedItem;
            if (pathToFile.EndsWith(".java") ||
                pathToFile.EndsWith(".cs") ||
                pathToFile.EndsWith(".vb") ||
                pathToFile.EndsWith(".php"))
            {
                string fileToOpen = startDirectoryTextBox.Text + pathToFile;
                Process.Start(fileToOpen);
            }
        }

        private void searchFileContentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (searchFileContentCheckBox.CheckState == CheckState.Checked)
            {
                MessageBox.Show(
                    "Searching in the content of files might take some time,\ndepending on the file size and the number of files.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void patternFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultsListBox.Items.Count == 0) // Nothing to filter
            {
                return;
            }
            if (patternFilterComboBox.SelectedIndex == 0) // Reset filter
            {
                finder.ResetFilter();
            }
            else // Do filter
            {
                PatternDefinition pattern = (PatternDefinition) patternFilterComboBox.SelectedItem;
                finder.Filter(pattern);
            }
            WriteResultsToListBox();
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileInfo fileToWriteTo = new FileInfo(Path.Combine(desktopFolder, "DesignPatternFinder Results.txt"));
            finder.Results.WriteToFile(fileToWriteTo);
            resultsListBox.Items.Add("Saved result to file: " + fileToWriteTo.FullName);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog(this);
        }

        #region Resizing Support Methods

        private void FinderForm_ResizeBegin(object sender, EventArgs e)
        {
            previousSize = Size;
        }

        private void FinderForm_SizeChanged(object sender, EventArgs e)
        {
            previousSize = Size;
        }

        private void FinderForm_Resize(object sender, EventArgs e)
        {
            int widthDifference = Size.Width - previousSize.Width;
            int heightDifference = Size.Height - previousSize.Height;

            MoveControl(directoryPickerButton, widthDifference, 0);
            MoveControl(searchFileContentCheckBox, widthDifference, 0);
            MoveControl(findButton, widthDifference, 0);
            MoveControl(aboutButton, widthDifference, heightDifference);
            MoveControl(patternFilterComboBox, widthDifference, 0);

            MoveControl(helpLabel, 0, heightDifference);
            MoveControl(saveToFileButton, widthDifference, heightDifference);
        }

        private static void MoveControl(Control control, int x, int y)
        {
            control.Location = new Point(control.Location.X + x, control.Location.Y + y);
        }

        #endregion
    }
}