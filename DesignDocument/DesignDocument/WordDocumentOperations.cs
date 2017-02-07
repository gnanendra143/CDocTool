using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DesignDocument
{
    public class WordDocumentOperations
    {
        //return the open document object
        public Document openDocument(object readFromPath)
        {
            try
            {
                Application application = new Application();
                Document doc = application.Documents.Open(ref readFromPath);
                return doc;
            }
            catch
            {
                throw;
            }
        }

        //reads  and returns all the paragraphs in the file
        public List<string> readParagraphs(Document doc)
        {
            string read = string.Empty;
            List<string> data = new List<string>();
            //foreach (Paragraphs paragraph in doc.Paragraphs)
            //{
            //    Style paragraphStyle = paragraph.get_Style() as Style;
            //}
            //loop through all paragraphs
            for (int i = 0; i < doc.Paragraphs.Count; i++)
            {
                string temp = doc.Paragraphs[i + 1].Range.Text.Trim();
                if (temp != string.Empty)
                {
                    data.Add(temp);//add paragraph to list
                    System.Windows.Forms.MessageBox.Show(data[i]);
                }
            }
            return data;
        }

        //closes the file
        public bool closeDocument(string pathName)
        {
            try
            {
                Application app = (Application)Marshal.GetActiveObject("Word.Application");
                if (app == null)
                {
                    return true;
                }

                foreach (Document document in app.Documents)
                {
                    if (document.FullName.ToLower() == pathName.ToLower())
                    {
                        document.Close();
                        return true;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        //closes all opened documents
        public bool closeAllDocuments()
        {
            try
            {
                Application app = (Application)Marshal.GetActiveObject("Word.Application");
                if (app == null)
                {
                    return true;
                }

                foreach (Document document in app.Documents)
                {
                    document.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
