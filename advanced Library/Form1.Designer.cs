namespace advanced_Library
{
    partial class home_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_page));
            this.button_enroll = new System.Windows.Forms.Button();
            this.button_lend_book = new System.Windows.Forms.Button();
            this.button_retrieve_book = new System.Windows.Forms.Button();
            this.button_check_book_availability = new System.Windows.Forms.Button();
            this.button_check_student_info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_enroll
            // 
            this.button_enroll.BackColor = System.Drawing.Color.Brown;
            this.button_enroll.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enroll.Location = new System.Drawing.Point(78, 548);
            this.button_enroll.Name = "button_enroll";
            this.button_enroll.Size = new System.Drawing.Size(217, 23);
            this.button_enroll.TabIndex = 0;
            this.button_enroll.Text = "Enroll Student";
            this.button_enroll.UseVisualStyleBackColor = false;
            this.button_enroll.Click += new System.EventHandler(this.button_enroll_Click);
            // 
            // button_lend_book
            // 
            this.button_lend_book.BackColor = System.Drawing.SystemColors.Info;
            this.button_lend_book.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.button_lend_book.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_lend_book.Location = new System.Drawing.Point(78, 577);
            this.button_lend_book.Name = "button_lend_book";
            this.button_lend_book.Size = new System.Drawing.Size(217, 23);
            this.button_lend_book.TabIndex = 1;
            this.button_lend_book.Text = "Lend Book";
            this.button_lend_book.UseVisualStyleBackColor = false;
            this.button_lend_book.Click += new System.EventHandler(this.button_lend_book_Click);
            // 
            // button_retrieve_book
            // 
            this.button_retrieve_book.BackColor = System.Drawing.Color.Silver;
            this.button_retrieve_book.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.button_retrieve_book.Location = new System.Drawing.Point(78, 606);
            this.button_retrieve_book.Name = "button_retrieve_book";
            this.button_retrieve_book.Size = new System.Drawing.Size(217, 23);
            this.button_retrieve_book.TabIndex = 2;
            this.button_retrieve_book.Text = "Retrieve Book";
            this.button_retrieve_book.UseVisualStyleBackColor = false;
            this.button_retrieve_book.Click += new System.EventHandler(this.button_retrieve_book_Click);
            // 
            // button_check_book_availability
            // 
            this.button_check_book_availability.BackColor = System.Drawing.Color.DimGray;
            this.button_check_book_availability.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.button_check_book_availability.Location = new System.Drawing.Point(78, 635);
            this.button_check_book_availability.Name = "button_check_book_availability";
            this.button_check_book_availability.Size = new System.Drawing.Size(217, 23);
            this.button_check_book_availability.TabIndex = 3;
            this.button_check_book_availability.Text = "Check Book Availability";
            this.button_check_book_availability.UseVisualStyleBackColor = false;
            this.button_check_book_availability.Click += new System.EventHandler(this.button_check_book_availability_Click);
            // 
            // button_check_student_info
            // 
            this.button_check_student_info.BackColor = System.Drawing.Color.Brown;
            this.button_check_student_info.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.button_check_student_info.Location = new System.Drawing.Point(78, 664);
            this.button_check_student_info.Name = "button_check_student_info";
            this.button_check_student_info.Size = new System.Drawing.Size(217, 23);
            this.button_check_student_info.TabIndex = 4;
            this.button_check_student_info.Text = "Student Info";
            this.button_check_student_info.UseVisualStyleBackColor = false;
            this.button_check_student_info.Click += new System.EventHandler(this.button_check_student_info_Click);
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(384, 717);
            this.Controls.Add(this.button_check_student_info);
            this.Controls.Add(this.button_check_book_availability);
            this.Controls.Add(this.button_retrieve_book);
            this.Controls.Add(this.button_lend_book);
            this.Controls.Add(this.button_enroll);
            this.DoubleBuffered = true;
            this.Name = "home_page";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_enroll;
        private System.Windows.Forms.Button button_lend_book;
        private System.Windows.Forms.Button button_retrieve_book;
        private System.Windows.Forms.Button button_check_book_availability;
        private System.Windows.Forms.Button button_check_student_info;
    }
}

