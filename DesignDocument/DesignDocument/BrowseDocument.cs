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
            OpenFileDialog bDialog = new OpenFileDialog();
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                if (null != bDialog)
                {
                    bDialog.Dispose();
                    bDialog = null;
                }
            }
            return filePath;
        }
    }
}
