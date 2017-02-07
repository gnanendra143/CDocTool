namespace DesignDocument
{
    partial class Form1
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
            this.createTableButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.readTableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTableButton
            // 
            this.createTableButton.Location = new System.Drawing.Point(180, 36);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(159, 42);
            this.createTableButton.TabIndex = 0;
            this.createTableButton.Text = "Create Table";
            this.createTableButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // readTableButton
            // 
            this.readTableButton.Location = new System.Drawing.Point(180, 111);
            this.readTableButton.Name = "readTableButton";
            this.readTableButton.Size = new System.Drawing.Size(159, 40);
            this.readTableButton.TabIndex = 2;
            this.readTableButton.Text = "Read Table";
            this.readTableButton.UseVisualStyleBackColor = true;
            this.readTableButton.Click += new System.EventHandler(this.readTableButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 562);
            this.Controls.Add(this.readTableButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createTableButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button readTableButton;
    }
}

