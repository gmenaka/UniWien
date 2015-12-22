using System.IO;
using System.Windows.Forms;

namespace ReadWordDocs.Logics
{
    public class CheckBoxDesiredTextListLogic<T> 
            where T : CheckedListBox
    {
        public static void AddText(string desiredText, T listBox )
        {
            if (listBox == null)
                return;

            listBox.Items.Add(desiredText);
        }

        public static void AddTextFromFile(string fileNameFull, T listBox)
        {
            //Read the file to get the Desired Text List
            if (string.IsNullOrEmpty(fileNameFull) || listBox == null || !File.Exists(fileNameFull))
                return;

            foreach (var line in File.ReadAllLines(fileNameFull))
            {
                if (!string.IsNullOrEmpty(line))
                     AddText(line, listBox);
            }
        }


        public static void RemoveText(T listBox)
        {
            for (var i = listBox.CheckedIndices.Count - 1; i >= 0 ; i--)
            {
                listBox.Items.RemoveAt(listBox.CheckedIndices[i]);
            }
           
        }
    }
}
