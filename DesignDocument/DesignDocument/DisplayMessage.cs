using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignDocument
{
    public partial class DisplayMessage : Form
    {
        public DisplayMessage()
        {
            InitializeComponent();
        }

        private void DisplayMessage_Load(object sender, EventArgs e)
        {
            displayMessageButton.Hide();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                filePathTextBox.Text = BrowseDocument.getFilePath();
                System.IO.Path.Combine(browseButton.Text);
                displayMessageButton.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void displayMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(filePathTextBox.Text))
                {
                    object readFromPath = filePathTextBox.Text;
                    WordDocumentOperations wordDoc = new WordDocumentOperations();
                    Document doc = wordDoc.openDocument(readFromPath);
                    List<string> list = wordDoc.readParagraphs(doc);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n"+ex.StackTrace);
            }
        }
    }
}
