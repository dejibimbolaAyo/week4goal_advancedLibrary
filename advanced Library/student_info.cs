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
    public partial class student_info : Form
    {
        db mydb = new db();
       

        public student_info()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home_page home_page_page = new home_page();
            home_page_page.Show();
            this.Close();
        }

        private void button_student_info_Click(object sender, EventArgs e)
        {

            int stuid = Convert.ToInt32(textBoxStudentID.Text);
           HashSet<books> myhh= mydb.selectstudent(stuid);
            foreach(var k in myhh)
            {

                MessageBox.Show(k.dateborrowed);
            }

        }
           


    }

    public class db
    {
        MySqlCommand cmd;
        MySqlConnection myconnection;

        public void myconnect()
        {

            string connector = "Server=127.0.0.1;port=8080;Username=root;Password=root;Database=school_library";

            myconnection = new MySqlConnection(connector);

            try { 
            myconnection.Open();
            }
            catch(MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public HashSet<books> selectstudent(int studentid)
        {
          
          

            HashSet<books> myh = new HashSet<books> { };
            books myb = new books();

            try
            {

                string query = "SELECT * FROM borrowed_books WHERE student_ID="+studentid+"";


                string connector = "Server=127.0.0.1;port=8080;Uid=root;Pwd=root;Database=school_library";

                myconnection = new MySqlConnection(connector);

               
                myconnection.Open();

                cmd.CommandText = query;
                cmd.Connection = myconnection;
               
             

                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                       myb.id = (int)myreader["ID"];
                       myb.bookid = (int)myreader["book_ID"];
                       myb.studentid = (int)myreader["student_ID"];
                       myb.dateborrowed = myreader["date_borrowed"].ToString();
                       myb.datereturned = myreader["date_returned"].ToString();
                       myb.returnedtoggle = (int)myreader["returned_toggle"];


                    myh.Add(myb);
                }

               


            }
            catch(MySqlException ex)
        
            {
                MessageBox.Show(ex.Message); 
            }
            return myh;

        }
    }

    public class books
    {

      public  int id
        {
            get;
            set;
        }
        public int bookid
        {
            get;
            set;
        }
        public int studentid
        {
            get;
            set;
        }
        public string datereturned
        {
            get;
            set;
        }
        public string dateborrowed
        {
            get;
            set;
        }
        public int returnedtoggle {

            get;
            set;
        }

    }

}
