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
using advanced_Library;

namespace advanced_Library
{
    public partial class enroll_students : Form
    {
        public enroll_students()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string myConnectionString = "server=localhost;port=8080;database=library;uid=root;pwd=root;";
                MySqlConnection connection = new MySqlConnection(myConnectionString);
                MySqlCommand cmd;
                connection.Open();

                // MessageBox.Show("Data Submitted to Database \n Data waiting for Validation");



                try
                {

                    cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO students_info(firstName,lastName,middleName,dateOfBirth,phone,matNo,session,department,faculty,createdBy,createdOn) VALUES(@firstName,@lastName,@middleName,@dateOfBirth,@phone,@matNo,@session,@department,@faculty,@createdBy,@createdOn)";
                    cmd.Parameters.AddWithValue("@firstName", textBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", textBoxMiddleName.Text);
                    cmd.Parameters.AddWithValue("@middleName", textBoxMiddleName.Text);
                    cmd.Parameters.AddWithValue("@dateOfBirth", textBoxAge.Text);
                    cmd.Parameters.AddWithValue("@emailAddress", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@MatNo", textBoxMatNo.Text);
                    cmd.Parameters.AddWithValue("@session", textBoxSession.Text);
                    cmd.Parameters.AddWithValue("@department", textBoxDepartment.Text);
                    cmd.Parameters.AddWithValue("@faculty", textBoxFaculty.Text);
                    cmd.Parameters.AddWithValue("@createdBy", SystemInformation.UserName);
                    cmd.Parameters.AddWithValue("@createdOn", System.DateTime.Now);

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
        }
        public class stdFormInput
        {
            public string firstName;
            public string lastName;
            public string middleName;
            public string dateOfBirth;
            public string phone;
            public string matNo;
            public string emailAddress;
            public string session;
            public string department;
            public string faculty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            home_page home_page_page = new home_page();
            home_page_page.Show();
            this.Close();
        }
    }
}
   