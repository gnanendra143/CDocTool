using System;
using System.Windows.Forms;

namespace DesignDocument
{
    public static class BrowseDocument
    {
        //returns the selected file path
        public static string getFilePath()
        {
            string filePath = string.Empty;
            using (OpenFileDialog bDialog = new OpenFileDialog())
            {
                bDialog.Title = "Open Word File";
                bDialog.Filter = "Doc Files|*.doc;*.docx";//specifying which documents to load
                bDialog.InitialDirectory = @"C:\Documents\";//specifying directory
                                                            //when clicked ok get theselected file name
                if (bDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = bDialog.FileName.ToString();
                }
            }
            return filePath;
        }
    }
}
