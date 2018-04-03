using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitDates(string date)
        {
            //split the date down and assign it to variables for later use
            string[] arrayDate = date.Split('/');
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);


            DateTime dateTime = new DateTime(year, month, day);
            Console.WriteLine("Day of week: " + dateTime.DayOfWeek);


            string dayOfWeek = dateTime.DayOfWeek.ToString();
            int dayOfYear = dateTime.DayOfYear;
            string monthName = dateTime.ToString("MMMM");
            int weekNumber = dayOfYear / 7;
            bool Weekend = false;
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") Weekend = true;
        }

        private void insertTimeDimension()
        {
            //create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //open the SqlConnection
                myConnection.Open();
                //the following code uses an SqlCommand based on the SqlConnection
                SqlCommand command = new SqlCommand("SELECT id FROM Time WHERE date = @date", myConnection);
            }
        }


        private void btnGetDates_Click(object sender, EventArgs e)
        {

            List<string> Dates = new List<string>();
            //clear the listbox
            listBoxDates.Items.Clear();
            //create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getDates = new OleDbCommand("SELECT [Order Date], [Ship Date] from Sheet1'", connection);

                reader = getDates.ExecuteReader();
                while (reader.Read())
                {
                    Dates.Add(reader[0].ToString());
                    Dates.Add(reader[1].ToString());
                }
            }
            //create a new list for the formatted data
            List<string> DatesFormatted = new List<string>();

            foreach (string date in Dates)
            {
                //split the string on whitespace and remove anything thats blank
                var dates = date.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            
                //grab the first item (we know this is the date) and add it to our new list
                DatesFormatted.Add(dates[0]);
            }

            //Blind the listbox to the list
            listBoxDates.DataSource = DatesFormatted;

            splitDates(DatesFormatted[0]);
            

            //These two do the same thing, its down to personal coding style! only use one of them
            string[] arrayDate = DatesFormatted[0].ToString().Split('/');
            Console.WriteLine("day: " + arrayDate[0] + " Month: " + arrayDate[1] + " Year: " + arrayDate[2]);

            string fullDate = DatesFormatted[0].ToString();
            string[] arrayDate1 = fullDate.Split('/');
            Console.WriteLine("day: " + arrayDate[0] + " Month: " + arrayDate[1] + " Year: " + arrayDate[2]);
                


        }
        private int GetDatetID(string date)
        {
            string[] arrayDate = date.Split('/');
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);
            DateTime dateTime = new DateTime(year, month, day);
            string dbDate = dateTime.ToString("M/dd/yyyy");

            //create a connection to the MDF File
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;
            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //open the connection
                myConnection.Open();
                //the following code uses
                SqlCommand command = new SqlCommand("SELECT id FROM Time WHERE date =@date", myConnection);
                command.Parameters.Add(new SqlParameter("date", dbDate));

                //create a variable
                bool exists = false;
                //run the command
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        exists = true;
                        Console.WriteLine("Data exists");
                    }


                }
                if (exists == false)
                {

                }
            }
            return  0;

        }
        //
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }



