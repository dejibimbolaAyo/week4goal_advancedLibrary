using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using advanced_Library;

namespace advanced_Library
{
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }

        private void button_check_book_availability_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkbook_available checkbook_available_page = new checkbook_available();
            checkbook_available_page.Show();
        }

        private void button_enroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            enroll_students enroll_students_page = new enroll_students();
            enroll_students_page.Show();
            
        }

        private void button_lend_book_Click(object sender, EventArgs e)
        {
            this.Hide();
            lend_books lend_books_page = new lend_books();
            lend_books_page.Show();
        }

        private void button_retrieve_book_Click(object sender, EventArgs e)
        {
            this.Hide();
            retrieve_books retrieve_books_page = new retrieve_books();
            retrieve_books_page.Show();
        }

        private void button_check_student_info_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_info student_info_page = new student_info();
            student_info_page.Show();
        }
    }
}
