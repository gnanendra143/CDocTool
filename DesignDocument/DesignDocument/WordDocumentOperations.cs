using Microsoft.Office.Interop.Word;
using System.Collections.Generic;

namespace DesignDocument
{
    public class WordDocumentOperations
    {
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

        public List<string> readParagraphs(Document doc)
        {
            string read = string.Empty;
            List<string> data = new List<string>();
            //foreach (Paragraphs paragraph in doc.Paragraphs)
            //{
            //    Style paragraphStyle = paragraph.get_Style() as Style;
            //}
            for (int i = 0; i < doc.Paragraphs.Count; i++)
            {
                string temp = doc.Paragraphs[i + 1].Range.Text.Trim();
                if (temp != string.Empty)
                {
                    data.Add(temp);
                    System.Windows.Forms.MessageBox.Show(data[i]);
                }
            }
            return data;
        }
    }
}
