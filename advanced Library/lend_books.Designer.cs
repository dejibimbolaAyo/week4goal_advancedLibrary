namespace advanced_Library
{
    partial class lend_books
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
            this.buttonLend = new System.Windows.Forms.Button();
            this.textBoxBookID_Lend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLend
            // 
            this.buttonLend.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLend.Location = new System.Drawing.Point(251, 478);
            this.buttonLend.Name = "buttonLend";
            this.buttonLend.Size = new System.Drawing.Size(75, 23);
            this.buttonLend.TabIndex = 0;
            this.buttonLend.Text = "Lend";
            this.buttonLend.UseVisualStyleBackColor = false;
            this.buttonLend.Click += new System.EventHandler(this.buttonLend_Click);
            // 
            // textBoxBookID_Lend
            // 
            this.textBoxBookID_Lend.Location = new System.Drawing.Point(98, 381);
            this.textBoxBookID_Lend.Name = "textBoxBookID_Lend";
            this.textBoxBookID_Lend.Size = new System.Drawing.Size(228, 20);
            this.textBoxBookID_Lend.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book ID";
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
            // lend_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBookID_Lend);
            this.Controls.Add(this.buttonLend);
            this.Name = "lend_books";
            this.Text = "Lend Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLend;
        private System.Windows.Forms.TextBox textBoxBookID_Lend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}