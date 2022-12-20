namespace FileLogAssist
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DirectoryPathTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseDirectoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ExtensionsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FilesCountRichTextBox = new System.Windows.Forms.RichTextBox();
            this.IncludeSubFolders = new System.Windows.Forms.CheckBox();
            this.GetReportButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgressBarLabel = new System.Windows.Forms.Label();
            this.RenameTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AutonumberLabel = new System.Windows.Forms.Label();
            this.NumberFormat = new System.Windows.Forms.NumericUpDown();
            this.FileSizeRTB = new System.Windows.Forms.RichTextBox();
            this.IgnoreFilesCheck = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.CollectiveDirectoryCheck = new System.Windows.Forms.RadioButton();
            this.SameDirectoryCheck = new System.Windows.Forms.RadioButton();
            this.SeperatorLabel = new System.Windows.Forms.Label();
            this.SeparatorRTB = new System.Windows.Forms.RichTextBox();
            this.WithLabel = new System.Windows.Forms.Label();
            this.ReplaceLabel = new System.Windows.Forms.Label();
            this.ReplaceWithRTB = new System.Windows.Forms.RichTextBox();
            this.ReplacePartCheck = new System.Windows.Forms.CheckBox();
            this.AddAutoNumCheck = new System.Windows.Forms.CheckBox();
            this.AddTextCheck = new System.Windows.Forms.CheckBox();
            this.EndRadioBtn = new System.Windows.Forms.RadioButton();
            this.StartRadioBtn = new System.Windows.Forms.RadioButton();
            this.ReplacePartRTB = new System.Windows.Forms.RichTextBox();
            this.StartRename = new System.Windows.Forms.Button();
            this.AddTextRTB = new System.Windows.Forms.RichTextBox();
            this.FindandReplaceTab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReplaceRegexCheck = new System.Windows.Forms.CheckBox();
            this.ReplaceWith = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReplaceMatchCase = new System.Windows.Forms.CheckBox();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.FindText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FindTextTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RegexCheck = new System.Windows.Forms.CheckBox();
            this.MatchCaseCheck = new System.Windows.Forms.CheckBox();
            this.StartSearchButton = new System.Windows.Forms.Button();
            this.SearchTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ReportTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.RenameTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberFormat)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.FindandReplaceTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.FindTextTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ReportTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DirectoryPathTextBox
            // 
            this.DirectoryPathTextBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DirectoryPathTextBox.Location = new System.Drawing.Point(118, 31);
            this.DirectoryPathTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DirectoryPathTextBox.Multiline = false;
            this.DirectoryPathTextBox.Name = "DirectoryPathTextBox";
            this.DirectoryPathTextBox.Size = new System.Drawing.Size(586, 37);
            this.DirectoryPathTextBox.TabIndex = 2;
            this.DirectoryPathTextBox.Text = "";
            this.DirectoryPathTextBox.TextChanged += new System.EventHandler(this.DirectoryPathTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory Path:";
            // 
            // ChooseDirectoryButton
            // 
            this.ChooseDirectoryButton.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseDirectoryButton.Location = new System.Drawing.Point(720, 28);
            this.ChooseDirectoryButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChooseDirectoryButton.Name = "ChooseDirectoryButton";
            this.ChooseDirectoryButton.Size = new System.Drawing.Size(114, 33);
            this.ChooseDirectoryButton.TabIndex = 1;
            this.ChooseDirectoryButton.Text = "Choose Path";
            this.ChooseDirectoryButton.UseVisualStyleBackColor = true;
            this.ChooseDirectoryButton.Click += new System.EventHandler(this.ChoosePathButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extensions:";
            // 
            // ExtensionsRichTextBox
            // 
            this.ExtensionsRichTextBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExtensionsRichTextBox.Location = new System.Drawing.Point(126, 42);
            this.ExtensionsRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExtensionsRichTextBox.Multiline = false;
            this.ExtensionsRichTextBox.Name = "ExtensionsRichTextBox";
            this.ExtensionsRichTextBox.Size = new System.Drawing.Size(563, 37);
            this.ExtensionsRichTextBox.TabIndex = 4;
            this.ExtensionsRichTextBox.Text = "";
            this.ExtensionsRichTextBox.TextChanged += new System.EventHandler(this.ExtensionsRichTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Files Count:";
            // 
            // FilesCountRichTextBox
            // 
            this.FilesCountRichTextBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilesCountRichTextBox.Location = new System.Drawing.Point(126, 101);
            this.FilesCountRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FilesCountRichTextBox.Multiline = false;
            this.FilesCountRichTextBox.Name = "FilesCountRichTextBox";
            this.FilesCountRichTextBox.Size = new System.Drawing.Size(114, 27);
            this.FilesCountRichTextBox.TabIndex = 6;
            this.FilesCountRichTextBox.Text = "";
            // 
            // IncludeSubFolders
            // 
            this.IncludeSubFolders.AutoSize = true;
            this.IncludeSubFolders.Checked = true;
            this.IncludeSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeSubFolders.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncludeSubFolders.Location = new System.Drawing.Point(722, 72);
            this.IncludeSubFolders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IncludeSubFolders.Name = "IncludeSubFolders";
            this.IncludeSubFolders.Size = new System.Drawing.Size(132, 20);
            this.IncludeSubFolders.TabIndex = 7;
            this.IncludeSubFolders.Text = "Include Subfolders";
            this.IncludeSubFolders.UseVisualStyleBackColor = true;
            this.IncludeSubFolders.CheckedChanged += new System.EventHandler(this.IncludeSubFolders_CheckedChanged);
            // 
            // GetReportButton
            // 
            this.GetReportButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetReportButton.Location = new System.Drawing.Point(356, 147);
            this.GetReportButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GetReportButton.Name = "GetReportButton";
            this.GetReportButton.Size = new System.Drawing.Size(132, 45);
            this.GetReportButton.TabIndex = 8;
            this.GetReportButton.Text = "Directory Report";
            this.GetReportButton.UseVisualStyleBackColor = true;
            this.GetReportButton.Click += new System.EventHandler(this.GetReportButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IncludeSubFolders);
            this.groupBox1.Controls.Add(this.ChooseDirectoryButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DirectoryPathTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(887, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Folder";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 450);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(889, 37);
            this.progressBar1.TabIndex = 6;
            // 
            // ProgressBarLabel
            // 
            this.ProgressBarLabel.AutoSize = true;
            this.ProgressBarLabel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgressBarLabel.Location = new System.Drawing.Point(19, 424);
            this.ProgressBarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProgressBarLabel.Name = "ProgressBarLabel";
            this.ProgressBarLabel.Size = new System.Drawing.Size(55, 15);
            this.ProgressBarLabel.TabIndex = 7;
            this.ProgressBarLabel.Text = "Progress";
            // 
            // RenameTab
            // 
            this.RenameTab.Controls.Add(this.label10);
            this.RenameTab.Controls.Add(this.groupBox6);
            this.RenameTab.Location = new System.Drawing.Point(4, 26);
            this.RenameTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RenameTab.Name = "RenameTab";
            this.RenameTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RenameTab.Size = new System.Drawing.Size(883, 272);
            this.RenameTab.TabIndex = 4;
            this.RenameTab.Text = "Rename Files";
            this.RenameTab.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(16, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Batch rename files with multiple options";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.AutonumberLabel);
            this.groupBox6.Controls.Add(this.NumberFormat);
            this.groupBox6.Controls.Add(this.FileSizeRTB);
            this.groupBox6.Controls.Add(this.IgnoreFilesCheck);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.SeperatorLabel);
            this.groupBox6.Controls.Add(this.SeparatorRTB);
            this.groupBox6.Controls.Add(this.WithLabel);
            this.groupBox6.Controls.Add(this.ReplaceLabel);
            this.groupBox6.Controls.Add(this.ReplaceWithRTB);
            this.groupBox6.Controls.Add(this.ReplacePartCheck);
            this.groupBox6.Controls.Add(this.AddAutoNumCheck);
            this.groupBox6.Controls.Add(this.AddTextCheck);
            this.groupBox6.Controls.Add(this.EndRadioBtn);
            this.groupBox6.Controls.Add(this.StartRadioBtn);
            this.groupBox6.Controls.Add(this.ReplacePartRTB);
            this.groupBox6.Controls.Add(this.StartRename);
            this.groupBox6.Controls.Add(this.AddTextRTB);
            this.groupBox6.Location = new System.Drawing.Point(9, 7);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(866, 230);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rename Files";
            // 
            // AutonumberLabel
            // 
            this.AutonumberLabel.AutoSize = true;
            this.AutonumberLabel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutonumberLabel.Location = new System.Drawing.Point(658, 69);
            this.AutonumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AutonumberLabel.Name = "AutonumberLabel";
            this.AutonumberLabel.Size = new System.Drawing.Size(84, 15);
            this.AutonumberLabel.TabIndex = 39;
            this.AutonumberLabel.Text = "001_Filename";
            // 
            // NumberFormat
            // 
            this.NumberFormat.Location = new System.Drawing.Point(657, 36);
            this.NumberFormat.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumberFormat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberFormat.Name = "NumberFormat";
            this.NumberFormat.Size = new System.Drawing.Size(50, 25);
            this.NumberFormat.TabIndex = 38;
            this.NumberFormat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumberFormat.ValueChanged += new System.EventHandler(this.NumberFormat_ValueChanged);
            // 
            // FileSizeRTB
            // 
            this.FileSizeRTB.Location = new System.Drawing.Point(278, 96);
            this.FileSizeRTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FileSizeRTB.Name = "FileSizeRTB";
            this.FileSizeRTB.Size = new System.Drawing.Size(66, 29);
            this.FileSizeRTB.TabIndex = 37;
            this.FileSizeRTB.Text = "25";
            // 
            // IgnoreFilesCheck
            // 
            this.IgnoreFilesCheck.AutoSize = true;
            this.IgnoreFilesCheck.Location = new System.Drawing.Point(19, 100);
            this.IgnoreFilesCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IgnoreFilesCheck.Name = "IgnoreFilesCheck";
            this.IgnoreFilesCheck.Size = new System.Drawing.Size(257, 21);
            this.IgnoreFilesCheck.TabIndex = 36;
            this.IgnoreFilesCheck.Text = "Ignore Files - Size (MB) Greater than:";
            this.IgnoreFilesCheck.UseVisualStyleBackColor = true;
            this.IgnoreFilesCheck.CheckedChanged += new System.EventHandler(this.IgnoreFilesCheck_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.CollectiveDirectoryCheck);
            this.groupBox7.Controls.Add(this.SameDirectoryCheck);
            this.groupBox7.Location = new System.Drawing.Point(7, 147);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(328, 67);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Output";
            // 
            // CollectiveDirectoryCheck
            // 
            this.CollectiveDirectoryCheck.AutoSize = true;
            this.CollectiveDirectoryCheck.Checked = true;
            this.CollectiveDirectoryCheck.Location = new System.Drawing.Point(21, 29);
            this.CollectiveDirectoryCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CollectiveDirectoryCheck.Name = "CollectiveDirectoryCheck";
            this.CollectiveDirectoryCheck.Size = new System.Drawing.Size(119, 21);
            this.CollectiveDirectoryCheck.TabIndex = 32;
            this.CollectiveDirectoryCheck.TabStop = true;
            this.CollectiveDirectoryCheck.Text = "New Directory";
            this.CollectiveDirectoryCheck.UseVisualStyleBackColor = true;
            // 
            // SameDirectoryCheck
            // 
            this.SameDirectoryCheck.AutoSize = true;
            this.SameDirectoryCheck.Location = new System.Drawing.Point(189, 29);
            this.SameDirectoryCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SameDirectoryCheck.Name = "SameDirectoryCheck";
            this.SameDirectoryCheck.Size = new System.Drawing.Size(123, 21);
            this.SameDirectoryCheck.TabIndex = 33;
            this.SameDirectoryCheck.Text = "Same Directory";
            this.SameDirectoryCheck.UseVisualStyleBackColor = true;
            // 
            // SeperatorLabel
            // 
            this.SeperatorLabel.AutoSize = true;
            this.SeperatorLabel.Location = new System.Drawing.Point(722, 38);
            this.SeperatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SeperatorLabel.Name = "SeperatorLabel";
            this.SeperatorLabel.Size = new System.Drawing.Size(73, 17);
            this.SeperatorLabel.TabIndex = 31;
            this.SeperatorLabel.Text = "Separator:";
            // 
            // SeparatorRTB
            // 
            this.SeparatorRTB.Location = new System.Drawing.Point(798, 33);
            this.SeparatorRTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SeparatorRTB.Name = "SeparatorRTB";
            this.SeparatorRTB.Size = new System.Drawing.Size(60, 29);
            this.SeparatorRTB.TabIndex = 30;
            this.SeparatorRTB.Text = "_";
            this.SeparatorRTB.TextChanged += new System.EventHandler(this.SeparatorRTB_TextChanged);
            // 
            // WithLabel
            // 
            this.WithLabel.AutoSize = true;
            this.WithLabel.Location = new System.Drawing.Point(673, 134);
            this.WithLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WithLabel.Name = "WithLabel";
            this.WithLabel.Size = new System.Drawing.Size(93, 17);
            this.WithLabel.TabIndex = 28;
            this.WithLabel.Text = "Replace with:";
            // 
            // ReplaceLabel
            // 
            this.ReplaceLabel.AutoSize = true;
            this.ReplaceLabel.Location = new System.Drawing.Point(514, 134);
            this.ReplaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReplaceLabel.Name = "ReplaceLabel";
            this.ReplaceLabel.Size = new System.Drawing.Size(70, 17);
            this.ReplaceLabel.TabIndex = 27;
            this.ReplaceLabel.Text = "Find Text:";
            // 
            // ReplaceWithRTB
            // 
            this.ReplaceWithRTB.Location = new System.Drawing.Point(770, 129);
            this.ReplaceWithRTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReplaceWithRTB.Name = "ReplaceWithRTB";
            this.ReplaceWithRTB.Size = new System.Drawing.Size(80, 29);
            this.ReplaceWithRTB.TabIndex = 24;
            this.ReplaceWithRTB.Text = "";
            // 
            // ReplacePartCheck
            // 
            this.ReplacePartCheck.AutoSize = true;
            this.ReplacePartCheck.Location = new System.Drawing.Point(509, 98);
            this.ReplacePartCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReplacePartCheck.Name = "ReplacePartCheck";
            this.ReplacePartCheck.Size = new System.Drawing.Size(185, 21);
            this.ReplacePartCheck.TabIndex = 22;
            this.ReplacePartCheck.Text = "Replace part of file name:";
            this.ReplacePartCheck.UseVisualStyleBackColor = true;
            this.ReplacePartCheck.CheckedChanged += new System.EventHandler(this.ReplacePartCheck_CheckedChanged);
            // 
            // AddAutoNumCheck
            // 
            this.AddAutoNumCheck.AutoSize = true;
            this.AddAutoNumCheck.Location = new System.Drawing.Point(511, 38);
            this.AddAutoNumCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddAutoNumCheck.Name = "AddAutoNumCheck";
            this.AddAutoNumCheck.Size = new System.Drawing.Size(143, 21);
            this.AddAutoNumCheck.TabIndex = 21;
            this.AddAutoNumCheck.Text = "Add Auto-number:";
            this.AddAutoNumCheck.UseVisualStyleBackColor = true;
            this.AddAutoNumCheck.CheckedChanged += new System.EventHandler(this.AddAutoNumCheck_CheckedChanged);
            // 
            // AddTextCheck
            // 
            this.AddTextCheck.AutoSize = true;
            this.AddTextCheck.Location = new System.Drawing.Point(16, 38);
            this.AddTextCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddTextCheck.Name = "AddTextCheck";
            this.AddTextCheck.Size = new System.Drawing.Size(86, 21);
            this.AddTextCheck.TabIndex = 20;
            this.AddTextCheck.Text = "Add Text:";
            this.AddTextCheck.UseVisualStyleBackColor = true;
            this.AddTextCheck.CheckedChanged += new System.EventHandler(this.AddTextCheck_CheckedChanged);
            // 
            // EndRadioBtn
            // 
            this.EndRadioBtn.AutoSize = true;
            this.EndRadioBtn.Location = new System.Drawing.Point(349, 35);
            this.EndRadioBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EndRadioBtn.Name = "EndRadioBtn";
            this.EndRadioBtn.Size = new System.Drawing.Size(51, 21);
            this.EndRadioBtn.TabIndex = 13;
            this.EndRadioBtn.Text = "End";
            this.EndRadioBtn.UseVisualStyleBackColor = true;
            // 
            // StartRadioBtn
            // 
            this.StartRadioBtn.AutoSize = true;
            this.StartRadioBtn.Checked = true;
            this.StartRadioBtn.Location = new System.Drawing.Point(264, 35);
            this.StartRadioBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartRadioBtn.Name = "StartRadioBtn";
            this.StartRadioBtn.Size = new System.Drawing.Size(61, 21);
            this.StartRadioBtn.TabIndex = 12;
            this.StartRadioBtn.TabStop = true;
            this.StartRadioBtn.Text = "Begin";
            this.StartRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ReplacePartRTB
            // 
            this.ReplacePartRTB.Location = new System.Drawing.Point(587, 129);
            this.ReplacePartRTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReplacePartRTB.Name = "ReplacePartRTB";
            this.ReplacePartRTB.Size = new System.Drawing.Size(80, 29);
            this.ReplacePartRTB.TabIndex = 2;
            this.ReplacePartRTB.Text = "";
            // 
            // StartRename
            // 
            this.StartRename.Location = new System.Drawing.Point(385, 177);
            this.StartRename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartRename.Name = "StartRename";
            this.StartRename.Size = new System.Drawing.Size(112, 32);
            this.StartRename.TabIndex = 2;
            this.StartRename.Text = "Rename";
            this.StartRename.UseVisualStyleBackColor = true;
            this.StartRename.Click += new System.EventHandler(this.StartRename_Click);
            // 
            // AddTextRTB
            // 
            this.AddTextRTB.Location = new System.Drawing.Point(117, 35);
            this.AddTextRTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddTextRTB.Name = "AddTextRTB";
            this.AddTextRTB.Size = new System.Drawing.Size(130, 29);
            this.AddTextRTB.TabIndex = 1;
            this.AddTextRTB.Text = "";
            // 
            // FindandReplaceTab
            // 
            this.FindandReplaceTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FindandReplaceTab.Controls.Add(this.label9);
            this.FindandReplaceTab.Controls.Add(this.groupBox3);
            this.FindandReplaceTab.Location = new System.Drawing.Point(4, 26);
            this.FindandReplaceTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FindandReplaceTab.Name = "FindandReplaceTab";
            this.FindandReplaceTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FindandReplaceTab.Size = new System.Drawing.Size(883, 272);
            this.FindandReplaceTab.TabIndex = 1;
            this.FindandReplaceTab.Text = "Find and Replace";
            this.FindandReplaceTab.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(16, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(356, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Generates CSV report for file path, name, and replacement count";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.ReplaceRegexCheck);
            this.groupBox3.Controls.Add(this.ReplaceWith);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ReplaceMatchCase);
            this.groupBox3.Controls.Add(this.ReplaceButton);
            this.groupBox3.Controls.Add(this.FindText);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(9, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(866, 217);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Replace text in files";
            // 
            // ReplaceRegexCheck
            // 
            this.ReplaceRegexCheck.AutoSize = true;
            this.ReplaceRegexCheck.Checked = true;
            this.ReplaceRegexCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReplaceRegexCheck.Location = new System.Drawing.Point(18, 159);
            this.ReplaceRegexCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReplaceRegexCheck.Name = "ReplaceRegexCheck";
            this.ReplaceRegexCheck.Size = new System.Drawing.Size(145, 21);
            this.ReplaceRegexCheck.TabIndex = 11;
            this.ReplaceRegexCheck.Text = "Regular expression";
            this.ReplaceRegexCheck.UseVisualStyleBackColor = true;
            this.ReplaceRegexCheck.CheckedChanged += new System.EventHandler(this.ReplaceRegexCheck_CheckedChanged);
            // 
            // ReplaceWith
            // 
            this.ReplaceWith.Location = new System.Drawing.Point(83, 91);
            this.ReplaceWith.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReplaceWith.Name = "ReplaceWith";
            this.ReplaceWith.Size = new System.Drawing.Size(686, 41);
            this.ReplaceWith.TabIndex = 2;
            this.ReplaceWith.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Replace:";
            // 
            // ReplaceMatchCase
            // 
            this.ReplaceMatchCase.AutoSize = true;
            this.ReplaceMatchCase.Checked = true;
            this.ReplaceMatchCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReplaceMatchCase.Location = new System.Drawing.Point(171, 160);
            this.ReplaceMatchCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReplaceMatchCase.Name = "ReplaceMatchCase";
            this.ReplaceMatchCase.Size = new System.Drawing.Size(96, 21);
            this.ReplaceMatchCase.TabIndex = 8;
            this.ReplaceMatchCase.Text = "Match case";
            this.ReplaceMatchCase.UseVisualStyleBackColor = true;
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(369, 156);
            this.ReplaceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(112, 32);
            this.ReplaceButton.TabIndex = 2;
            this.ReplaceButton.Text = "Replace";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // FindText
            // 
            this.FindText.Location = new System.Drawing.Point(83, 40);
            this.FindText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FindText.Name = "FindText";
            this.FindText.Size = new System.Drawing.Size(686, 41);
            this.FindText.TabIndex = 1;
            this.FindText.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Find:";
            // 
            // FindTextTab
            // 
            this.FindTextTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FindTextTab.Controls.Add(this.label8);
            this.FindTextTab.Controls.Add(this.groupBox2);
            this.FindTextTab.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindTextTab.Location = new System.Drawing.Point(4, 26);
            this.FindTextTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FindTextTab.Name = "FindTextTab";
            this.FindTextTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FindTextTab.Size = new System.Drawing.Size(883, 272);
            this.FindTextTab.TabIndex = 0;
            this.FindTextTab.Text = "Find text";
            this.FindTextTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(16, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Generates CSV report for file path, name, and matches count";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.RegexCheck);
            this.groupBox2.Controls.Add(this.MatchCaseCheck);
            this.groupBox2.Controls.Add(this.StartSearchButton);
            this.groupBox2.Controls.Add(this.SearchTextRichTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(9, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(866, 217);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find text in files";
            // 
            // RegexCheck
            // 
            this.RegexCheck.AutoSize = true;
            this.RegexCheck.Checked = true;
            this.RegexCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RegexCheck.Location = new System.Drawing.Point(18, 121);
            this.RegexCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RegexCheck.Name = "RegexCheck";
            this.RegexCheck.Size = new System.Drawing.Size(145, 21);
            this.RegexCheck.TabIndex = 9;
            this.RegexCheck.Text = "Regular expression";
            this.RegexCheck.UseVisualStyleBackColor = true;
            this.RegexCheck.CheckedChanged += new System.EventHandler(this.RegexCheck_CheckedChanged);
            // 
            // MatchCaseCheck
            // 
            this.MatchCaseCheck.AutoSize = true;
            this.MatchCaseCheck.Checked = true;
            this.MatchCaseCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MatchCaseCheck.Location = new System.Drawing.Point(18, 164);
            this.MatchCaseCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MatchCaseCheck.Name = "MatchCaseCheck";
            this.MatchCaseCheck.Size = new System.Drawing.Size(96, 21);
            this.MatchCaseCheck.TabIndex = 8;
            this.MatchCaseCheck.Text = "Match case";
            this.MatchCaseCheck.UseVisualStyleBackColor = true;
            // 
            // StartSearchButton
            // 
            this.StartSearchButton.Location = new System.Drawing.Point(369, 159);
            this.StartSearchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartSearchButton.Name = "StartSearchButton";
            this.StartSearchButton.Size = new System.Drawing.Size(111, 32);
            this.StartSearchButton.TabIndex = 2;
            this.StartSearchButton.Text = "Find";
            this.StartSearchButton.UseVisualStyleBackColor = true;
            this.StartSearchButton.Click += new System.EventHandler(this.StartSearchButton_Click);
            // 
            // SearchTextRichTextBox
            // 
            this.SearchTextRichTextBox.Location = new System.Drawing.Point(71, 43);
            this.SearchTextRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchTextRichTextBox.Name = "SearchTextRichTextBox";
            this.SearchTextRichTextBox.Size = new System.Drawing.Size(734, 51);
            this.SearchTextRichTextBox.TabIndex = 1;
            this.SearchTextRichTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Find:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ReportTab);
            this.tabControl1.Controls.Add(this.FindTextTab);
            this.tabControl1.Controls.Add(this.FindandReplaceTab);
            this.tabControl1.Controls.Add(this.RenameTab);
            this.tabControl1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(14, 119);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 302);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ReportTab
            // 
            this.ReportTab.Controls.Add(this.label7);
            this.ReportTab.Controls.Add(this.groupBox4);
            this.ReportTab.Location = new System.Drawing.Point(4, 26);
            this.ReportTab.Name = "ReportTab";
            this.ReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReportTab.Size = new System.Drawing.Size(883, 272);
            this.ReportTab.TabIndex = 5;
            this.ReportTab.Text = "Dir Files";
            this.ReportTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Generates CSV report for file path, name, extension, and size";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GetReportButton);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.ExtensionsRichTextBox);
            this.groupBox4.Controls.Add(this.FilesCountRichTextBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(9, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(866, 217);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Choose Files Extensions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(911, 496);
            this.Controls.Add(this.ProgressBarLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "File and Log Assist";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RenameTab.ResumeLayout(false);
            this.RenameTab.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberFormat)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.FindandReplaceTab.ResumeLayout(false);
            this.FindandReplaceTab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.FindTextTab.ResumeLayout(false);
            this.FindTextTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ReportTab.ResumeLayout(false);
            this.ReportTab.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox DirectoryPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChooseDirectoryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ExtensionsRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox FilesCountRichTextBox;
        private System.Windows.Forms.CheckBox IncludeSubFolders;
        private System.Windows.Forms.Button GetReportButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ProgressBarLabel;
        private TabPage RenameTab;
        private GroupBox groupBox6;
        private RichTextBox FileSizeRTB;
        private CheckBox IgnoreFilesCheck;
        private GroupBox groupBox7;
        private RadioButton CollectiveDirectoryCheck;
        private RadioButton SameDirectoryCheck;
        private Label SeperatorLabel;
        private RichTextBox SeparatorRTB;
        private Label WithLabel;
        private Label ReplaceLabel;
        private RichTextBox ReplaceWithRTB;
        private CheckBox ReplacePartCheck;
        private CheckBox AddAutoNumCheck;
        private CheckBox AddTextCheck;
        private RadioButton EndRadioBtn;
        private RadioButton StartRadioBtn;
        private RichTextBox ReplacePartRTB;
        private Button StartRename;
        private RichTextBox AddTextRTB;
        private TabPage FindandReplaceTab;
        private GroupBox groupBox3;
        private CheckBox ReplaceRegexCheck;
        private RichTextBox ReplaceWith;
        private Label label6;
        private CheckBox ReplaceMatchCase;
        private Button ReplaceButton;
        private RichTextBox FindText;
        private Label label5;
        private TabPage FindTextTab;
        private GroupBox groupBox2;
        private CheckBox RegexCheck;
        private CheckBox MatchCaseCheck;
        private Button StartSearchButton;
        private RichTextBox SearchTextRichTextBox;
        private Label label4;
        private TabControl tabControl1;
        private TabPage ReportTab;
        private GroupBox groupBox4;
        private NumericUpDown NumberFormat;
        private Label AutonumberLabel;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
    }
    }

