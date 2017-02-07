using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignDocument
{
    public static class BrowseDocument
    {
        public static string getFilePath()
        {
            string filePath = string.Empty;
            OpenFileDialog bDialog = new OpenFileDialog();
            try
            {
                bDialog.Title = "Open Word File";
                bDialog.Filter = "Doc Files|*.doc;*.docx";
                bDialog.InitialDirectory = @"C:\Documents\";
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
