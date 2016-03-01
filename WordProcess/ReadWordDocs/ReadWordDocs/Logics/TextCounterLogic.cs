using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadWordDocs.Logics
{
    public class TextCounterLogic
    {
        public static void TextCounter<T, T1>(string sourcefolder, string destinationfolder, T textList, T1 resultControl, ToolStripStatusLabel statusBar) 
                where T : CheckedListBox
                where T1 : RichTextBox
        {
            if (string.IsNullOrEmpty(sourcefolder) || string.IsNullOrEmpty(destinationfolder) || textList == null ||
                textList.Items.Count < 1)
            {
                statusBar.Text = @"Incomplete input values. Please check and try again.";
                return;
            }
            statusBar.Text = @"Text count process is running....";

            try
            {
                // Get the file List
                var fileList = GetfileList(sourcefolder);
                if (fileList == null || fileList.Count == 0)
                {
                    statusBar.Text = @"There is no *.docx. files in the ""Read Folder""";
                    return;
                }

                // Read Files and count words
                List<string> serachStringList = new List<string>();

                foreach (var item in textList.Items)
                {
                    serachStringList.Add(item.ToString());
                }

                var result = GetTextCounts(fileList, serachStringList);

                //Write result to ShowDialog
                if (result == null)
                    return;

                WriteResult<RichTextBox, Dictionary<string, Dictionary<string, int>>>(resultControl, destinationfolder, result);

                WriteResult2SummaryFile<Dictionary<string, Dictionary<string, int>>>( destinationfolder, result);
            }
            catch (Exception ex)
            {
                statusBar.Text = string.Format("Text count process failed due to : {0}", ex.Message);
            }

            statusBar.Text = @"Text count process is successfully completed.";
        }

        internal static void WriteResult2SummaryFile<T1>(string destinationfolder, T1 results)
            where T1 : Dictionary<string, Dictionary<string, int>>
        {
            if (string.IsNullOrEmpty(destinationfolder) || results == null)
                return;

            var sbTextCountSummary = new StringBuilder();

            // File Header         
            var textHeader = "FileName";

            foreach (var result in results)
            {
                var textCounts = result.Value;
                foreach (var textCount in textCounts)
                {
                    textHeader = string.Format("{0}; {1} ", textHeader, textCount.Key);
                }
                break;
            }
            
            sbTextCountSummary.AppendLine(textHeader);

            // File Body
            foreach (var result in results)
            {
                var textCounts = result.Value;
                textHeader = string.Format("{0}", result.Key);

                foreach (var textCount in textCounts)
                {
                    textHeader = string.Format("{0}; {1}", textHeader, textCount.Value);                   
                }
                
                sbTextCountSummary.AppendLine(textHeader);
            }
            

            // Write Summary File 
            try
            {
                StreamWriter sw = new StreamWriter(string.Format("{0}\\Summary.csv", destinationfolder));
                sw.WriteLine(sbTextCountSummary.ToString());
                sw.Close();
                GC.Collect();                
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Failure in writing to Summary File ({0})", ex.Message));
            }
            
        }


        internal static void WriteResult<T, T1>(T control, string destinationfolder, T1 results)
            where T : RichTextBox
            where T1 : Dictionary<string, Dictionary<string, int>>
        {
            if (string.IsNullOrEmpty(destinationfolder) || control == null || results == null)
                    return ;

            // display Results Summary --> on RichTextBox
            StringBuilder showText = new StringBuilder();
            List<string> filecontents = new List<string>();

            foreach (var result in results)
            {
                var textCounts = result.Value;
                showText.Append("\n" + result.Key + " --> " + "\n");

                foreach (var textCount in textCounts)
                {
                    showText.AppendFormat("\t{0} = {1} \n", textCount.Key, textCount.Value);
                    filecontents.Add(textCount.Key + " = " + textCount.Value + "\n");
                }

                WriteResultToFiles(filecontents, destinationfolder, result.Key);
                filecontents.Clear();
            }

            control.Text = showText.ToString();
        }

        internal static void WriteResultToFiles(IEnumerable<string> fileContents , string destinationfolder, string fileNameFull )
        {
            if (string.IsNullOrEmpty(destinationfolder) || fileContents == null || string.IsNullOrEmpty(fileNameFull))
                return;

            try
            {
                if (!Directory.Exists(destinationfolder))
                    Directory.CreateDirectory(destinationfolder);

                var fileName = string.Format("{0}{1}_{2}.txt", destinationfolder, Path.GetFileName(fileNameFull), DateTime.Now.ToString("yyyyMMddHHmmss"));
                File.WriteAllLines(fileName, fileContents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }

        internal static Dictionary<string, Dictionary<string, int>> GetTextCounts(List<string> fileList, List<string> serachstringList)
        {
            var textCountForAllFiles = new Dictionary<string, Dictionary<string, int>>();

            //Read the file to string
            foreach (var file in fileList.OrderBy(fileName => fileName))
            {
                var textCountForOnefile = new Dictionary<string, int>();
                object miss = System.Reflection.Missing.Value;
                object path = file;
                object readOnly = true;

                try
                {
                    Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                    Microsoft.Office.Interop.Word.Document doc = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);

                    Microsoft.Office.Interop.Word.Range range = doc.Content;
                    range.Find.Forward = true;
                   
                    foreach (var searchText in serachstringList)
                    {
                        range.Find.Text = searchText;
                        var textCount = 0;

                        range.Find.Execute(
                            ref miss, ref miss, ref miss, ref miss, ref miss,
                            ref miss, ref miss, ref miss, ref miss, ref miss,
                            ref miss, ref miss, ref miss, ref miss, ref miss);

                        while (range.Find.Found)
                        {
                            textCount++;

                            range.Find.Execute(
                                ref miss, ref miss, ref miss, ref miss, ref miss,
                                ref miss, ref miss, ref miss, ref miss, ref miss,
                                ref miss, ref miss, ref miss, ref miss, ref miss);
                        }
                        
                        textCountForOnefile.Add(searchText, textCount);
                        range = doc.Content;
                    }

                    word.Quit(ref miss, ref miss, ref miss);
                    word = null;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error");
                }

                textCountForAllFiles.Add(file, textCountForOnefile);
            }

            return textCountForAllFiles;
        }


        internal static List<string> GetfileList(string sourcefolder)
        {
            string[] extensions = { ".doc", ".docx" };

            List<string> fileList = new List<string>();

            foreach (string file in Directory.EnumerateFiles(sourcefolder, "*.*", SearchOption.AllDirectories)
                .Where(s => extensions.Any(ext => ext == Path.GetExtension(s))))
            {
                fileList.Add(file);
            }


            return fileList;
        }
    }
}
