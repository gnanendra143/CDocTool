namespace DesignDocument
{
    partial class DisplayMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayMessageButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.readTableButton = new System.Windows.Forms.Button();
            this.createTableButton = new System.Windows.Forms.Button();
            this.closeDocsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayMessageButton
            // 
            this.displayMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayMessageButton.Location = new System.Drawing.Point(111, 154);
            this.displayMessageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayMessageButton.Name = "displayMessageButton";
            this.displayMessageButton.Size = new System.Drawing.Size(171, 45);
            this.displayMessageButton.TabIndex = 0;
            this.displayMessageButton.Text = "Display Message";
            this.displayMessageButton.UseVisualStyleBackColor = true;
            this.displayMessageButton.Click += new System.EventHandler(this.displayMessageButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(12, 65);
            this.filePathTextBox.Multiline = true;
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(294, 30);
            this.filePathTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Location = new System.Drawing.Point(312, 62);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(102, 33);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // readTableButton
            // 
            this.readTableButton.Location = new System.Drawing.Point(111, 295);
            this.readTableButton.Name = "readTableButton";
            this.readTableButton.Size = new System.Drawing.Size(171, 40);
            this.readTableButton.TabIndex = 4;
            this.readTableButton.Text = "Read Table";
            this.readTableButton.UseVisualStyleBackColor = true;
            this.readTableButton.Click += new System.EventHandler(this.readTableButton_Click);
            // 
            // createTableButton
            // 
            this.createTableButton.Location = new System.Drawing.Point(111, 220);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(171, 42);
            this.createTableButton.TabIndex = 3;
            this.createTableButton.Text = "Create Table";
            this.createTableButton.UseVisualStyleBackColor = true;
            this.createTableButton.Click += new System.EventHandler(this.createTableButton_Click);
            // 
            // closeDocsButton
            // 
            this.closeDocsButton.Location = new System.Drawing.Point(70, 13);
            this.closeDocsButton.Name = "closeDocsButton";
            this.closeDocsButton.Size = new System.Drawing.Size(212, 36);
            this.closeDocsButton.TabIndex = 5;
            this.closeDocsButton.Text = "Close Document";
            this.closeDocsButton.UseVisualStyleBackColor = true;
            this.closeDocsButton.Click += new System.EventHandler(this.closeDocsButton_Click);
            // 
            // DisplayMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 482);
            this.Controls.Add(this.closeDocsButton);
            this.Controls.Add(this.readTableButton);
            this.Controls.Add(this.createTableButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.displayMessageButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayMessage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayMessage_FormClosing);
            this.Load += new System.EventHandler(this.DisplayMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayMessageButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button readTableButton;
        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Button closeDocsButton;
    }
}