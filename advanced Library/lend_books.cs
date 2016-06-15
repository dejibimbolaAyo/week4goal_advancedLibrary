using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace advanced_Library
{
    public partial class lend_books : Form
    {
        public lend_books()
        {
            InitializeComponent();
        }

        private void buttonLend_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=localhost;port=8080;database=school_library;uid=root;pwd=root;";
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand cmd;
            connection.Open();

            // MessageBox.Show("Data Submitted to Database \n Data waiting for Validation");



            try
            {

                cmd = connection.CreateCommand();
                cmd.CommandText =
                cmd.CommandText = "UPDATE `book_info` SET `book_Available` = b'1' WHERE `book_info`.`book_ID` =; " +textBoxBookID_Lend;
               // cmd.CommandText = "INSERT INTO students_info(firstName,lastName,middleName,age,phone,email,matno,department,faculty,session,createdBy,createdOn) VALUES(@firstName,@lastName,@middleName,@dateOfBirth,@phone,@matNo,@session,@department,@faculty,@createdBy,@createdOn)";
                cmd.Parameters.AddWithValue("@firstName", textBoxBookID_Lend.Text);


                cmd.ExecuteNonQuery();
                this.Close();

            }


            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home_page home_page_page = new home_page();
            home_page_page.Show();
            this.Close();
        }
    }
}
