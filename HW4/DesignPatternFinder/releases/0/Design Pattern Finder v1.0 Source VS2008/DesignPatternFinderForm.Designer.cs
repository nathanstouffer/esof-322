namespace DesignPatternFinder
{
    partial class DesignPatternFinderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignPatternFinderForm));
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.startDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.directoryPickerButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.searchFileContentCheckBox = new System.Windows.Forms.CheckBox();
            this.patternFilterComboBox = new System.Windows.Forms.ComboBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.helpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultsListBox
            // 
            this.resultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(12, 40);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(662, 355);
            this.resultsListBox.TabIndex = 0;
            this.resultsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resultsListBox_MouseDoubleClick);
            // 
            // startDirectoryTextBox
            // 
            this.startDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.startDirectoryTextBox.Enabled = false;
            this.startDirectoryTextBox.Location = new System.Drawing.Point(12, 12);
            this.startDirectoryTextBox.Name = "startDirectoryTextBox";
            this.startDirectoryTextBox.Size = new System.Drawing.Size(289, 22);
            this.startDirectoryTextBox.TabIndex = 1;
            // 
            // directoryPickerButton
            // 
            this.directoryPickerButton.Location = new System.Drawing.Point(307, 12);
            this.directoryPickerButton.Name = "directoryPickerButton";
            this.directoryPickerButton.Size = new System.Drawing.Size(31, 22);
            this.directoryPickerButton.TabIndex = 2;
            this.directoryPickerButton.Text = "...";
            this.directoryPickerButton.UseVisualStyleBackColor = true;
            this.directoryPickerButton.Click += new System.EventHandler(this.directoryPickerButton_Click);
            // 
            // findButton
            // 
            this.findButton.Enabled = false;
            this.findButton.Location = new System.Drawing.Point(626, 12);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(49, 22);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select the folder that contains the source files.";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // searchFileContentCheckBox
            // 
            this.searchFileContentCheckBox.AutoSize = true;
            this.searchFileContentCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.searchFileContentCheckBox.Location = new System.Drawing.Point(344, 14);
            this.searchFileContentCheckBox.Name = "searchFileContentCheckBox";
            this.searchFileContentCheckBox.Size = new System.Drawing.Size(139, 17);
            this.searchFileContentCheckBox.TabIndex = 4;
            this.searchFileContentCheckBox.Text = "Search in File Content";
            this.searchFileContentCheckBox.UseVisualStyleBackColor = true;
            this.searchFileContentCheckBox.CheckedChanged += new System.EventHandler(this.searchFileContentCheckBox_CheckedChanged);
            // 
            // patternFilterComboBox
            // 
            this.patternFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patternFilterComboBox.FormattingEnabled = true;
            this.patternFilterComboBox.Location = new System.Drawing.Point(489, 13);
            this.patternFilterComboBox.Name = "patternFilterComboBox";
            this.patternFilterComboBox.Size = new System.Drawing.Size(131, 21);
            this.patternFilterComboBox.TabIndex = 5;
            this.patternFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.patternFilterComboBox_SelectedIndexChanged);
            // 
            // aboutButton
            // 
            this.aboutButton.Image = global::DesignPatternFinder.Properties.Resources.About;
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.aboutButton.Location = new System.Drawing.Point(601, 401);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(73, 22);
            this.aboutButton.TabIndex = 6;
            this.aboutButton.Text = "     About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Location = new System.Drawing.Point(487, 401);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(108, 22);
            this.saveToFileButton.TabIndex = 7;
            this.saveToFileButton.Text = "Save to Desktop";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(12, 403);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(376, 13);
            this.helpLabel.TabIndex = 8;
            this.helpLabel.Text = "Double click on a file name to open the file in the default editor/viewer.";
            // 
            // DesignPatternFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 433);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.patternFilterComboBox);
            this.Controls.Add(this.searchFileContentCheckBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.directoryPickerButton);
            this.Controls.Add(this.startDirectoryTextBox);
            this.Controls.Add(this.resultsListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(694, 460);
            this.Name = "DesignPatternFinderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Design Pattern Finder v1.0";
            this.ResizeBegin += new System.EventHandler(this.FinderForm_ResizeBegin);
            this.SizeChanged += new System.EventHandler(this.FinderForm_SizeChanged);
            this.Resize += new System.EventHandler(this.FinderForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.TextBox startDirectoryTextBox;
        private System.Windows.Forms.Button directoryPickerButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox searchFileContentCheckBox;
        private System.Windows.Forms.ComboBox patternFilterComboBox;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.Label helpLabel;
    }
}