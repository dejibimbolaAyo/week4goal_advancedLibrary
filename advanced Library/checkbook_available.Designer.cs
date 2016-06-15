namespace advanced_Library
{
    partial class checkbook_available
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
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.buttonCheckBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(60, 242);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(262, 20);
            this.textBoxBookTitle.TabIndex = 0;
            // 
            // buttonCheckBook
            // 
            this.buttonCheckBook.Location = new System.Drawing.Point(193, 269);
            this.buttonCheckBook.Name = "buttonCheckBook";
            this.buttonCheckBook.Size = new System.Drawing.Size(128, 23);
            this.buttonCheckBook.TabIndex = 1;
            this.buttonCheckBook.Text = "Check Book";
            this.buttonCheckBook.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Title";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbook_available
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCheckBook);
            this.Controls.Add(this.textBoxBookTitle);
            this.Name = "checkbook_available";
            this.Text = "Check Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.Button buttonCheckBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}