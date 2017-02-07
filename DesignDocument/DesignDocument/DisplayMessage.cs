using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
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

                filePathTextBox.Text = BrowseDocument.getFilePath();//file path from textbox
                System.IO.Path.Combine(browseButton.Text);//check for valid path
                displayMessageButton.Show();//if valid path show display button
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);//Invalid path will raise an exception
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

        private void readTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!string.IsNullOrEmpty(filePathTextBox.Text))
                {
                    string cellData = string.Empty;
                    object readFromPath = filePathTextBox.Text;
                    WordDocumentOperations wordDoc = new WordDocumentOperations();
                    Document doc = wordDoc.openDocument(readFromPath);

                    //Processing all tables in the documents
                    for (int iCounter = 1; iCounter <= doc.Tables.Count; iCounter++)
                    {
                        foreach (Row aRow in doc.Tables[iCounter].Rows)
                        {
                            foreach (Cell aCell in aRow.Cells)
                            {
                                cellData = aCell.Range.Text;
                                MessageBox.Show(cellData);
                            }
                        }
                    }
                    doc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void DisplayMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            WordDocumentOperations wordDoc = new WordDocumentOperations();
            wordDoc.closeAllDocuments();
        }

        private void closeDocsButton_Click(object sender, EventArgs e)
        {
            WordDocumentOperations wordDoc = new WordDocumentOperations();
            wordDoc.closeDocument(filePathTextBox.Text);
        }

        private void createTableButton_Click(object sender, EventArgs e)
        {

        }
    }
}
