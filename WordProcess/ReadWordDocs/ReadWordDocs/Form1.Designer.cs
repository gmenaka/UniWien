namespace ReadWordDocs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlWordCount = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOutBrowse = new System.Windows.Forms.Button();
            this.txtOutFilefolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStop = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilefolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoadDesiredTextList = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemoveText = new System.Windows.Forms.Button();
            this.checkBoxDesiredTextList = new System.Windows.Forms.CheckedListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAddText = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textDesiredText = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.btnBrowseTextCountDest = new System.Windows.Forms.Button();
            this.txtOutputFolderTextCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBrowseTextCountSource = new System.Windows.Forms.Button();
            this.txtInputFolderTextCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnStartTextCount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tabControlWordCount.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDesiredText.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlWordCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 827);
            this.panel1.TabIndex = 0;
            // 
            // tabControlWordCount
            // 
            this.tabControlWordCount.Controls.Add(this.tabPage1);
            this.tabControlWordCount.Controls.Add(this.tabPage2);
            this.tabControlWordCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlWordCount.Location = new System.Drawing.Point(0, 0);
            this.tabControlWordCount.Name = "tabControlWordCount";
            this.tabControlWordCount.SelectedIndex = 0;
            this.tabControlWordCount.Size = new System.Drawing.Size(1349, 827);
            this.tabControlWordCount.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnOutBrowse);
            this.tabPage1.Controls.Add(this.txtOutFilefolder);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtStop);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.txtFilefolder);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnRead);
            this.tabPage1.Controls.Add(this.txtStart);
            this.tabPage1.Controls.Add(this.rtbText);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Navy;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1341, 799);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Paragraph Extract";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(10, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "Extract Desired Paragraphs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(714, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(479, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "*** For End Text, if you need to stop extract on Bold text line, then specify : $" +
    "bold$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(677, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "    (3).  press \"Start Reading File(s)\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(677, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "    (2).  Specify Start/End Text to be extract";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(677, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(609, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "** (1).  Please select the document folder which needs to be read (Program will r" +
    "ead all *.doc & *.docx files)";
            // 
            // btnOutBrowse
            // 
            this.btnOutBrowse.Location = new System.Drawing.Point(574, 145);
            this.btnOutBrowse.Name = "btnOutBrowse";
            this.btnOutBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnOutBrowse.TabIndex = 34;
            this.btnOutBrowse.Text = "Browse";
            this.btnOutBrowse.UseVisualStyleBackColor = true;
            this.btnOutBrowse.Click += new System.EventHandler(this.btnOutBrowse_Click);
            // 
            // txtOutFilefolder
            // 
            this.txtOutFilefolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutFilefolder.Location = new System.Drawing.Point(128, 145);
            this.txtOutFilefolder.Name = "txtOutFilefolder";
            this.txtOutFilefolder.Size = new System.Drawing.Size(440, 21);
            this.txtOutFilefolder.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Output Folder ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "End Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Start Text";
            // 
            // txtStop
            // 
            this.txtStop.Location = new System.Drawing.Point(128, 115);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(440, 21);
            this.txtStop.TabIndex = 29;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(574, 55);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 27;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilefolder
            // 
            this.txtFilefolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilefolder.Location = new System.Drawing.Point(128, 55);
            this.txtFilefolder.Name = "txtFilefolder";
            this.txtFilefolder.Size = new System.Drawing.Size(440, 21);
            this.txtFilefolder.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Read Folder ";
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(655, 145);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(151, 23);
            this.btnRead.TabIndex = 24;
            this.btnRead.Text = "Start Reading File(s)";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(128, 86);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(440, 21);
            this.txtStart.TabIndex = 28;
            // 
            // rtbText
            // 
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.Location = new System.Drawing.Point(-2, 207);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(1972, 495);
            this.rtbText.TabIndex = 23;
            this.rtbText.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLoadDesiredTextList);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnRemoveText);
            this.tabPage2.Controls.Add(this.checkBoxDesiredTextList);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.btnAddText);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.textDesiredText);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.richTextBoxResult);
            this.tabPage2.Controls.Add(this.btnBrowseTextCountDest);
            this.tabPage2.Controls.Add(this.txtOutputFolderTextCount);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnBrowseTextCountSource);
            this.tabPage2.Controls.Add(this.txtInputFolderTextCount);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnStartTextCount);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Navy;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1341, 799);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text Counter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoadDesiredTextList
            // 
            this.btnLoadDesiredTextList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDesiredTextList.Location = new System.Drawing.Point(758, 133);
            this.btnLoadDesiredTextList.Name = "btnLoadDesiredTextList";
            this.btnLoadDesiredTextList.Size = new System.Drawing.Size(208, 23);
            this.btnLoadDesiredTextList.TabIndex = 62;
            this.btnLoadDesiredTextList.Text = "Load desired Text(s) from  file (*.txt)";
            this.btnLoadDesiredTextList.UseVisualStyleBackColor = true;
            this.btnLoadDesiredTextList.Click += new System.EventHandler(this.btnLoadDesiredTextList_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 61;
            this.label10.Text = "Result";
            // 
            // btnRemoveText
            // 
            this.btnRemoveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveText.Location = new System.Drawing.Point(1112, 335);
            this.btnRemoveText.Name = "btnRemoveText";
            this.btnRemoveText.Size = new System.Drawing.Size(163, 27);
            this.btnRemoveText.TabIndex = 60;
            this.btnRemoveText.Text = "Remove Selected Text(s)";
            this.btnRemoveText.UseVisualStyleBackColor = true;
            this.btnRemoveText.Click += new System.EventHandler(this.btnRemoveText_Click);
            // 
            // checkBoxDesiredTextList
            // 
            this.checkBoxDesiredTextList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDesiredTextList.FormattingEnabled = true;
            this.checkBoxDesiredTextList.Location = new System.Drawing.Point(25, 214);
            this.checkBoxDesiredTextList.Name = "checkBoxDesiredTextList";
            this.checkBoxDesiredTextList.Size = new System.Drawing.Size(1068, 148);
            this.checkBoxDesiredTextList.TabIndex = 59;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(228, 17);
            this.label19.TabIndex = 58;
            this.label19.Text = "Type Desired Text to be count";
            // 
            // btnAddText
            // 
            this.btnAddText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddText.Location = new System.Drawing.Point(645, 131);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(95, 23);
            this.btnAddText.TabIndex = 57;
            this.btnAddText.Text = "Select Text";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(195, 17);
            this.label18.TabIndex = 56;
            this.label18.Text = "Desired Texts to be count";
            // 
            // textDesiredText
            // 
            this.textDesiredText.Location = new System.Drawing.Point(276, 136);
            this.textDesiredText.Name = "textDesiredText";
            this.textDesiredText.Size = new System.Drawing.Size(350, 20);
            this.textDesiredText.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(21, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 20);
            this.label14.TabIndex = 47;
            this.label14.Text = "Count desired Text(s) in files";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxResult.Location = new System.Drawing.Point(15, 469);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(1260, 201);
            this.richTextBoxResult.TabIndex = 46;
            this.richTextBoxResult.Text = "";
            // 
            // btnBrowseTextCountDest
            // 
            this.btnBrowseTextCountDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseTextCountDest.Location = new System.Drawing.Point(645, 90);
            this.btnBrowseTextCountDest.Name = "btnBrowseTextCountDest";
            this.btnBrowseTextCountDest.Size = new System.Drawing.Size(95, 23);
            this.btnBrowseTextCountDest.TabIndex = 45;
            this.btnBrowseTextCountDest.Text = "Browse";
            this.btnBrowseTextCountDest.UseVisualStyleBackColor = true;
            this.btnBrowseTextCountDest.Click += new System.EventHandler(this.btnBrowseTextCountDest_Click);
            // 
            // txtOutputFolderTextCount
            // 
            this.txtOutputFolderTextCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputFolderTextCount.Location = new System.Drawing.Point(276, 92);
            this.txtOutputFolderTextCount.Name = "txtOutputFolderTextCount";
            this.txtOutputFolderTextCount.Size = new System.Drawing.Size(350, 21);
            this.txtOutputFolderTextCount.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Output Folder ";
            // 
            // btnBrowseTextCountSource
            // 
            this.btnBrowseTextCountSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseTextCountSource.Location = new System.Drawing.Point(645, 55);
            this.btnBrowseTextCountSource.Name = "btnBrowseTextCountSource";
            this.btnBrowseTextCountSource.Size = new System.Drawing.Size(95, 23);
            this.btnBrowseTextCountSource.TabIndex = 38;
            this.btnBrowseTextCountSource.Text = "Browse";
            this.btnBrowseTextCountSource.UseVisualStyleBackColor = true;
            this.btnBrowseTextCountSource.Click += new System.EventHandler(this.btnBrowseTextCountSource_Click);
            // 
            // txtInputFolderTextCount
            // 
            this.txtInputFolderTextCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputFolderTextCount.Location = new System.Drawing.Point(276, 57);
            this.txtInputFolderTextCount.Name = "txtInputFolderTextCount";
            this.txtInputFolderTextCount.Size = new System.Drawing.Size(350, 21);
            this.txtInputFolderTextCount.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Read Folder ";
            // 
            // btnStartTextCount
            // 
            this.btnStartTextCount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnStartTextCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTextCount.Location = new System.Drawing.Point(25, 368);
            this.btnStartTextCount.Name = "btnStartTextCount";
            this.btnStartTextCount.Size = new System.Drawing.Size(151, 32);
            this.btnStartTextCount.TabIndex = 35;
            this.btnStartTextCount.Text = "Start Reading File(s)";
            this.btnStartTextCount.UseVisualStyleBackColor = false;
            this.btnStartTextCount.Click += new System.EventHandler(this.btnStartTextCount_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 727);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1349, 100);
            this.panel2.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 78);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1349, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1397, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.DefaultExt = "doc";
            this.dlgOpenFile.Filter = "Doc files|*.doc";
            this.dlgOpenFile.Title = "Open *.doc file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 827);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Word Extractor";
            this.panel1.ResumeLayout(false);
            this.tabControlWordCount.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDesiredText.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlWordCount;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOutBrowse;
        private System.Windows.Forms.TextBox txtOutFilefolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStop;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilefolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button btnBrowseTextCountDest;
        private System.Windows.Forms.TextBox txtOutputFolderTextCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBrowseTextCountSource;
        private System.Windows.Forms.TextBox txtInputFolderTextCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnStartTextCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit textDesiredText;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckedListBox checkBoxDesiredTextList;
        private System.Windows.Forms.Button btnRemoveText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoadDesiredTextList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;

    }
}

