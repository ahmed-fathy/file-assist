using System.Text.RegularExpressions;

namespace FileLogAssist
{
    public partial class Form1 : Form
    {
        private SearchOption selectedSearchOption = SearchOption.AllDirectories;
        private List<string> directoryFiles;
        private List<string> filteredDirectoryFiles;

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateDirFiles()
        {
            directoryFiles = new List<string>();
            if (!Directory.Exists(DirectoryPathTextBox.Text))
            {
                ExtensionsRichTextBox.TextChanged -= new EventHandler(ExtensionsRichTextBox_TextChanged);
                ExtensionsRichTextBox.Text = "Path doesn't exist.";
                ExtensionsRichTextBox.TextChanged += new EventHandler(ExtensionsRichTextBox_TextChanged);
                FilesCountRichTextBox.Text = "0";
                return;
            }

            try
            {
                //Start Search
                directoryFiles = filteredDirectoryFiles = Directory.GetFiles(DirectoryPathTextBox.Text, "*.*", selectedSearchOption).ToList();

                //Add files extensions to list, without duplicates
                string separator = ",";
                string extensions = string.Join(separator, directoryFiles.Select(file => Path.GetExtension(file)).Distinct());

                //Set Extensions and Count
                ExtensionsRichTextBox.TextChanged -= new EventHandler(ExtensionsRichTextBox_TextChanged);
                ExtensionsRichTextBox.Text = extensions;
                ExtensionsRichTextBox.TextChanged += new EventHandler(ExtensionsRichTextBox_TextChanged);
                FilesCountRichTextBox.Text = directoryFiles.Distinct().Count().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }
        }

        private void ChoosePathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialog = new FolderBrowserDialog
            {
                Description = "Select directory"
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryPathTextBox.Text = Dialog.SelectedPath;  // Set Path
            }
        }

        private void DirectoryPathTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDirFiles();
        }

        private void ExtensionsRichTextBox_TextChanged(object sender, EventArgs e)
        {
            filteredDirectoryFiles = directoryFiles.Where(file => ExtensionsRichTextBox.Text.Split(",").Contains(Path.GetExtension(file))).ToList();
            FilesCountRichTextBox.Text = filteredDirectoryFiles.Distinct().Count().ToString();
        }

        private void IncludeSubFolders_CheckedChanged(object sender, EventArgs e)
        {
            // Subfolders
            if (IncludeSubFolders.Checked)
                selectedSearchOption = SearchOption.AllDirectories; //Include Subfolders
            else
                selectedSearchOption = SearchOption.TopDirectoryOnly; //Include Current Folder only

            UpdateDirFiles();
        }

        private void StartSearchButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(DirectoryPathTextBox.Text))
            {
                MessageBox.Show("Please insert a valid path.");
                return;
            }
            if (SearchTextRichTextBox.Text == "")
            {
                MessageBox.Show("Please insert search text.");
                return;
            }

            //output file
            string reportFile = Directory.GetCurrentDirectory() + @"\Report_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".csv";
            if (File.Exists(reportFile))
            {
                File.Delete(reportFile);
            }

            if (ExtensionsRichTextBox.Text.Contains("doc") || ExtensionsRichTextBox.Text.Contains("pdf"))
            {
                MessageBox.Show("Search in Word/PDF file is not supported.");
            }

            progressBar1.Value = 0;
            progressBar1.Maximum = filteredDirectoryFiles.Count();

            //csv
            try
            {
                using (var writer = new StreamWriter(reportFile))
                {
                    string csvHeader = "File Path,File Name,Results Found";
                    writer.WriteLine(csvHeader);

                    foreach (string filePath in filteredDirectoryFiles)
                    {
                        ProgressBarLabel.Text = "Processing file: " + filePath;
                        progressBar1.Value += 1;

                        int searchCount;
                        string fileContents;
                        using (var reader = new StreamReader(filePath))
                        {
                            fileContents = reader.ReadToEnd();
                        }

                        if (RegexCheck.Checked)
                        {
                            RegexOptions regexOptions = new RegexOptions();

                            if (!MatchCaseCheck.Checked)
                                regexOptions = RegexOptions.IgnoreCase;

                            MatchCollection MatchSearchText = Regex.Matches(fileContents, SearchTextRichTextBox.Text, regexOptions);
                            searchCount = MatchSearchText.Count;
                        }
                        else
                        {
                            searchCount = CountStringOccurrences(fileContents, SearchTextRichTextBox.Text);
                        }

                        writer.WriteLine(string.Join(",", Path.GetDirectoryName(filePath), Path.GetFileName(filePath), searchCount));
                    }
                }
                ProgressBarLabel.Text = "Finished. Report created successfully at " + reportFile;
                progressBar1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static int CountStringOccurrences(string text, string pattern)
        {
            // Loop through all instances of the string 'text'.
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }

        private void GetReportButton_Click(object sender, EventArgs e)
        {
            string reportFile = Directory.GetCurrentDirectory() + @"\Report_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".csv";
            if (File.Exists(reportFile))
            {
                File.Delete(reportFile);
            }

            progressBar1.Value = 0;
            progressBar1.Maximum = filteredDirectoryFiles.Count();

            try
            {
                using (var writer = new StreamWriter(reportFile))
                {
                    string csvHeader = "File Path,File Name,File Extension,File Size (bytes),File Size (KB),File Size (MB)";
                    writer.WriteLine(csvHeader);

                    foreach (string filePath in filteredDirectoryFiles)
                    {
                        ProgressBarLabel.Text = "Processing file: " + filePath;
                        progressBar1.Value += 1;

                        string fileDirPath = Path.GetDirectoryName(filePath);
                        string fileName = Path.GetFileName(filePath);
                        long fileSizeBytes = new FileInfo(filePath).Length;
                        long fileSizeKB = fileSizeBytes / 1024;
                        long fileSizeMB = fileSizeKB / 1024;
                        string fileExtension = Path.GetExtension(filePath).Replace(".", "");

                        writer.WriteLine(string.Join(",", fileDirPath, fileName, fileExtension, fileSizeBytes, fileSizeKB, fileSizeMB));
                    }
                }
                ProgressBarLabel.Text = "Finished. Report created successfully at " + reportFile;
                progressBar1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RegexCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (RegexCheck.Checked)
            {
                MatchCaseCheck.Enabled = true;
                MatchCaseCheck.Checked = true;
            }
            else
            {
                MatchCaseCheck.Enabled = false;
                MatchCaseCheck.Checked = true;
            }
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            if (FindText.Text == "")
            {
                MessageBox.Show("Please insert search text.");
                return;
            }
            //test regex
            if (ReplaceRegexCheck.Checked)
            {
                try
                {
                    string TestRegex = "";
                    TestRegex = Regex.Replace(TestRegex, FindText.Text, ReplaceWith.Text, RegexOptions.Compiled);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Regular Expression\r\n" + ex.ToString());
                    return;
                }
            }

            string reportFile = Directory.GetCurrentDirectory() + @"\Report_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".csv";
            if (File.Exists(reportFile))
            {
                File.Delete(reportFile);
            }

            if (ExtensionsRichTextBox.Text.Contains("doc") || ExtensionsRichTextBox.Text.Contains("pdf"))
            {
                MessageBox.Show("Replacing in Word/PDF file is not supported.");
            }

            progressBar1.Value = 0;
            progressBar1.Maximum = filteredDirectoryFiles.Count();

            try
            {
                using (var reportWriter = new StreamWriter(reportFile))
                {
                    string csvHeader = "File Path,File Name,Replacement counts";
                    reportWriter.WriteLine(csvHeader);

                    foreach (string filePath in filteredDirectoryFiles)
                    {
                        ProgressBarLabel.Text = "Processing file: " + filePath;
                        progressBar1.Value += 1;

                        int searchCount;
                        string fileContents;
                        using (var reader = new StreamReader(filePath))
                        {
                            fileContents = reader.ReadToEnd();
                        }

                        //replace
                        if (RegexCheck.Checked)
                        {
                            RegexOptions regexOptions = new RegexOptions();

                            if (!ReplaceMatchCase.Checked)
                                regexOptions = RegexOptions.IgnoreCase;

                            MatchCollection MatchSearchText = Regex.Matches(fileContents, FindText.Text, regexOptions);
                            fileContents = Regex.Replace(fileContents, FindText.Text, ReplaceWith.Text, regexOptions);
                            searchCount = MatchSearchText.Count;
                        }
                        else
                        {
                            searchCount = CountStringOccurrences(fileContents, SearchTextRichTextBox.Text);
                            fileContents = fileContents.Replace(FindText.Text, ReplaceWith.Text);
                        }

                        //save file
                        if (searchCount > 0)
                        {
                            using (var fileWriter = new StreamWriter(filePath))
                            { fileWriter.Write(fileContents); }
                        }

                        //report
                        reportWriter.WriteLine(string.Join(",", Path.GetDirectoryName(filePath), Path.GetFileName(filePath), searchCount));
                    }
                }
                ProgressBarLabel.Text = "Finished. Report created successfully at " + reportFile;
                progressBar1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ReplaceRegexCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ReplaceRegexCheck.Checked)
            {
                ReplaceMatchCase.Enabled = true;
                ReplaceMatchCase.Checked = true;
            }
            else
            {
                ReplaceMatchCase.Enabled = false;
                ReplaceMatchCase.Checked = true;
            }
        }

        private void StartRename_Click(object sender, EventArgs e)
        {
            if (!(AddTextCheck.Checked) && !(AddAutoNumCheck.Checked) && !(ReplacePartCheck.Checked))
            {
                MessageBox.Show("Please select rename option.");
                return;
            }

            string RenameFolderPath = "";
            if (CollectiveDirectoryCheck.Checked)
            {
                RenameFolderPath = DirectoryPathTextBox.Text + @"\Renamed Files\";
                if (Directory.Exists(RenameFolderPath))
                {
                    Directory.Delete(RenameFolderPath, true);
                }
                Directory.CreateDirectory(RenameFolderPath);
            }

            if (ReplacePartCheck.Checked == true && ReplacePartRTB.Text == "")
            {
                MessageBox.Show("Please insert text to Replace.");
                return;
            }

            int FileCounter = 0;

            progressBar1.Value = 0;
            progressBar1.Maximum = filteredDirectoryFiles.Count();

            foreach (var file in filteredDirectoryFiles)
            {
                ProgressBarLabel.Text = "Renaming File: " + file;
                progressBar1.Value += 1;
                try
                {
                    if (SameDirectoryCheck.Checked)
                    {
                        RenameFolderPath = Path.GetDirectoryName(file) + @"\";
                    }

                    if (IgnoreFilesCheck.Checked)
                    {
                        float fileSizeMax = float.Parse(FileSizeRTB.Text) * 1024 * 1024;
                        if ((new FileInfo(file)).Length > fileSizeMax)
                        {
                            continue;
                        }
                    }

                    string fileName = Path.GetFileName(file);
                    //Renaming options
                    if (AddTextCheck.Checked)
                    {
                        if (StartRadioBtn.Checked)
                        {
                            fileName = AddTextRTB.Text + fileName;
                        }
                        else
                        {
                            fileName = fileName + AddTextRTB.Text;
                        }
                    }

                    if (AddAutoNumCheck.Checked)
                    {
                        fileName = string.Format("{0:D" + NumberFormat.Value + "}", FileCounter) + SeparatorRTB.Text + fileName;
                    }

                    if (ReplacePartCheck.Checked)
                    {
                        fileName = fileName.Replace(ReplacePartRTB.Text, ReplaceWithRTB.Text);
                    }

                    File.Copy(file, RenameFolderPath + fileName);
                }
                catch (Exception myex)
                {
                    MessageBox.Show("Error. " + myex.Message.ToString());
                }

                FileCounter += 1;
            }

            progressBar1.Value = 0;
            ProgressBarLabel.Text = "Finished." + " Files Renamed: " + FileCounter;
        }

        public void ToggleButtonsCheckChanged()
        {
            bool toggle_AddTextCheck = AddTextCheck.Checked;
            AddTextRTB.Visible = toggle_AddTextCheck;
            StartRadioBtn.Visible = toggle_AddTextCheck;
            EndRadioBtn.Visible = toggle_AddTextCheck;

            bool toggle_AddAutoNumCheck = AddAutoNumCheck.Checked;
            NumberFormat.Visible = toggle_AddAutoNumCheck;
            SeparatorRTB.Visible = toggle_AddAutoNumCheck;
            SeperatorLabel.Visible = toggle_AddAutoNumCheck;
            AutonumberLabel.Visible = toggle_AddAutoNumCheck;

            bool toggle_ReplacePartCheck = ReplacePartCheck.Checked;
            ReplacePartRTB.Visible = toggle_ReplacePartCheck;
            ReplaceWithRTB.Visible = toggle_ReplacePartCheck;
            ReplaceLabel.Visible = toggle_ReplacePartCheck;
            WithLabel.Visible = toggle_ReplacePartCheck;

            bool toggle_IgnoreFilesCheck = IgnoreFilesCheck.Checked;
            FileSizeRTB.Visible = toggle_IgnoreFilesCheck;
        }

        private void AddTextCheck_CheckedChanged(object sender, EventArgs e)
        {
            ToggleButtonsCheckChanged();
        }

        private void AddAutoNumCheck_CheckedChanged(object sender, EventArgs e)
        {
            ToggleButtonsCheckChanged();
        }

        private void ReplacePartCheck_CheckedChanged(object sender, EventArgs e)
        {
            ToggleButtonsCheckChanged();
        }

        private void ReplaceExtCheck_CheckedChanged(object sender, EventArgs e)
        {
            ToggleButtonsCheckChanged();
        }

        private void IgnoreFilesCheck_CheckedChanged(object sender, EventArgs e)
        {
            ToggleButtonsCheckChanged();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "RenameTab")
            {
                AddTextCheck.Checked = true;
                AddAutoNumCheck.Checked = true;
            }
        }

        private void NumberFormat_ValueChanged(object sender, EventArgs e)
        {
            AutonumberLabel.Text = string.Format("{0:D" + NumberFormat.Value + "}", 1) + SeparatorRTB.Text + "Filename";
        }

        private void SeparatorRTB_TextChanged(object sender, EventArgs e)
        {
            AutonumberLabel.Text = string.Format("{0:D" + NumberFormat.Value + "}", 1) + SeparatorRTB.Text + "Filename";
        }
    }
}