using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ReadWordDocs.Logics;

namespace ReadWordDocs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void btnRead_Click(object sender, EventArgs e)
        {
            var isOk = !string.IsNullOrEmpty(txtFilefolder.Text);

            if (isOk)
            {
                string[] extensions = { ".doc", ".docx" };

                List<string> fileList = new List<string>();
                
                foreach (string file in  Directory.EnumerateFiles(txtFilefolder.Text, "*.*", SearchOption.AllDirectories)
                    .Where(s => extensions.Any(ext => ext == Path.GetExtension(s))))
                {
                    fileList.Add(file);                    
                };

                foreach (string file in fileList.OrderBy(filename => filename))
                {
                    isOk = ReadFile(file, txtStart.Text, txtStop.Text);
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private bool ReadFile(string file, string startStr, string stopString)
        {           
            object miss = System.Reflection.Missing.Value;
            object path = file;
            object readOnly = true;
            bool started = false;
            int[] TRUE_CODE = {9999999, -1};

            try
            {
                toolStripStatusLabel.Text = @"Text extraction process is running....";
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document docs = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
               
                StringBuilder totaltext = new StringBuilder();

                //Create a missing variable for missing value
                object missing = System.Reflection.Missing.Value;

                for (int i = 0; i < docs.Paragraphs.Count; i++)
                {
                    var line = docs.Paragraphs[i + 1].Range.Text;

                    if (!started && line.ToUpper().Contains(startStr.ToUpper()))
                        started = true;

                    if (stopString.ToUpper().Contains("$BOLD$"))
                    {
                        if (TRUE_CODE.Any( n => n == docs.Paragraphs[i + 1].Range.Bold)  && !line.ToUpper().Contains(startStr.ToUpper()))
                           started = false;
                    }
                    else if (line.ToUpper().Contains(stopString.ToUpper()))
                        started = false;

                    if (started)
                        totaltext.Append("\n " + line);                       
                }
               
                rtbText.Text = totaltext.ToString();

                //Create a new document
                Microsoft.Office.Interop.Word.Document newDoc = word.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                //adding text to document
                newDoc.Content.SetRange(0, 0);
                newDoc.Content.Text = totaltext.ToString() + Environment.NewLine;

                //Save the document
                object filename = string.Empty;
                string foldername = string.Empty;

                foldername = (!string.IsNullOrWhiteSpace(txtOutFilefolder.Text)) ? string.Format("{0}\\", txtOutFilefolder.Text) : string.Format("{0}\\", Path.GetFullPath(file));

                if (!Directory.Exists(foldername))
                    Directory.CreateDirectory(foldername);

                filename = string.Format("{0}out_{1}", foldername, Path.GetFileName(file));

                newDoc.SaveAs2(ref filename);
                newDoc.Save();
                //newDoc.Close(ref missing, ref missing, ref missing);
                newDoc.Close();
                word.Quit(ref missing, ref missing, ref missing);

                toolStripStatusLabel.Text = @"Text extraction process successfully completed. Please see the outout files in Output folder.";


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                toolStripStatusLabel.Text = string.Format("Text extraction process failed due to {0}.", ex.Message);
                
                return false;
            }            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            txtFilefolder.Text = GetSelectedFolder();
        }

        private void btnStartTextCount_Click(object sender, EventArgs e)
        {
            TextCounterLogic.TextCounter<CheckedListBox, RichTextBox>(txtInputFolderTextCount.Text, txtOutputFolderTextCount.Text, checkBoxDesiredTextList, richTextBoxResult, toolStripStatusLabel);
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            CheckBoxDesiredTextListLogic<CheckedListBox>.AddText(textDesiredText.Text, checkBoxDesiredTextList);
        }

        private void btnRemoveText_Click(object sender, EventArgs e)
        {
            CheckBoxDesiredTextListLogic<CheckedListBox>.RemoveText(checkBoxDesiredTextList);
        }

        private void btnBrowseTextCountSource_Click(object sender, EventArgs e)
        {
            txtInputFolderTextCount.Text = GetSelectedFolder();
        }
     
        private string GetSelectedFolder( )
        {
            string result = string.Empty;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                result = string.Format("{0}{1}", folderBrowserDialog1.SelectedPath, Path.DirectorySeparatorChar);
            }

            return result;
        }

        private void btnOutBrowse_Click(object sender, EventArgs e)
        {
            txtOutFilefolder.Text = GetSelectedFolder();
        }

        private void btnBrowseTextCountDest_Click(object sender, EventArgs e)
        {
            txtOutputFolderTextCount.Text = GetSelectedFolder();
        }

        private void btnLoadDesiredTextList_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog() ;
            fileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
          
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                CheckBoxDesiredTextListLogic<CheckedListBox>.AddTextFromFile(fileDialog.FileName, checkBoxDesiredTextList);
            }
        }
    }
}
