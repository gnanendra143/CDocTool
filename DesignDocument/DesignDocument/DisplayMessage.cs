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
            WordDocumentOperations wordDoc = new WordDocumentOperations();
            wordDoc.closeAllDocuments();
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
            object objMiss = System.Reflection.Missing.Value;
            object objEndOfDocFlag = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
            
            //Start Word and create a new document.
            _Application objApp;
            _Document objDoc;
            objApp = new Microsoft.Office.Interop.Word.Application();
            objApp.Visible = true;//opens new document

            objDoc = objApp.Documents.Add(ref objMiss, ref objMiss,
            ref objMiss, ref objMiss);
            ////Insert a paragraph at the end of the document.
            //Paragraph objPara2; //define paragraph object
            //object oRng = objDoc.Bookmarks.get_Item
            //            (ref objEndOfDocFlag).Range; //go to end of the page
            //objPara2 = objDoc.Content.Paragraphs.Add
            //            (ref oRng); //add paragraph at end of document
            //objPara2.Range.Text = "Test Table Caption"; //add some text in paragraph
            //objPara2.Format.SpaceAfter = 10; //define some style
            //objPara2.Range.InsertParagraphAfter(); //insert paragraph

            //Insert a 2 x 2 table, (table with 2 row and 2 column)
            Table objTab1; //create table object
            Range objWordRng = objDoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range; //go to end of document
            objTab1 = objDoc.Tables.Add(objWordRng, 2, 4, ref objMiss, ref objMiss); //add table object in word document
            objTab1.Range.ParagraphFormat.SpaceAfter = 6;
            int iRow, iCols;
            string strText = "hello";
            for (iRow = 1; iRow <= 2; iRow++)
                for (iCols = 1; iCols <= 4; iCols++)
                {
                    strText = "row:1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111" + iRow + "col:" + iCols;
                    objTab1.Cell(iRow, iCols).Range.Text = strText; //add some text to cell
                }
            objTab1.Borders.Enable = 1;
            objTab1.Rows[1].Range.Font.Bold = 1; //make first row of table bold
            objTab1.Rows[1].Range.Font.Size = 14;//make first row of size 14
            objTab1.Rows[1].Range.Font.Name = "Arial";
            //objTab1.AllowAutoFit = true;
            //objTab1.Columns[1].Width = objApp.InchesToPoints(3); //increase first column width
            //objTable.Borders.Shadow = true;
            //Add some text after table
            object missing = System.Reflection.Missing.Value;
            objTab1.Rows.Add(ref missing);
            objWordRng = objDoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            objWordRng.InsertParagraphAfter(); //put enter in document
            objWordRng.InsertAfter("THIS IS THE SIMPLE WORD DEMO : THANKS YOU.");
            object szPath = "test.docx";
            objDoc.SaveAs(ref szPath);
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(filePathTextBox.Text))
                {
                    string cellData = string.Empty;
                    object readFromPath = filePathTextBox.Text;
                    WordDocumentOperations wordDoc = new WordDocumentOperations();
                    Document doc = wordDoc.openDocument(readFromPath);
                    Table table = doc.Tables[1];
                    object missing = System.Reflection.Missing.Value;
                    table.Rows.Add(ref missing);
                        for (int iCols = 1; iCols <= table.Columns.Count; iCols++)
                        {
                            string strText = "gnananan" + table.Rows.Count + "col:" + iCols;
                            table.Cell(table.Rows.Count, iCols).Range.Text = strText; //add some text to cell
                        }
                    ////Processing all tables in the documents
                    //for (int iCounter = 1; iCounter <= doc.Tables.Count; iCounter++)
                    //{

                    //}
                    doc.Save();
                }
            }
            catch
            {

            }
        }
    }
}
