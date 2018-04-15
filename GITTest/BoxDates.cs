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
    public partial class BoxDates : Form
    {
        public BoxDates()
        {
            InitializeComponent();
        }

        private void splitDates(string date)
        {
            //split the date down and assign it to varibales for later use
            string[] arrayDate = date.Split('/'); //split the original array at every " / "
            int year = Convert.ToInt32(arrayDate[2]); // Take the 3rd piece of data for the Year
            int month = Convert.ToInt32(arrayDate[1]); // Take the 3rd piece of data for the Month 
            int day = Convert.ToInt32(arrayDate[0]); // Take the 1st piece of data for the Day

            DateTime dateTime = new DateTime(year, month, day); //combine those pieces of data to send the correct format / date
            //console.log(dateTime) // Trace out the variable to check the correct format
            Console.WriteLine("Day of week: +" + dateTime.DayOfWeek);

            string dayOfWeek = dateTime.DayOfWeek.ToString();
            int dayOfYear = dateTime.DayOfYear;
            string monthName = dateTime.ToString("MMMM");
            int weekNumber = dayOfYear / 7;
            bool weekend = false;
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") weekend = true; // Capture whether its a weekend or not. - Is it either SAT or SUN
            string dbDate = dateTime.ToString("M/dd/yyyy");

            insertTimeDimension(dbDate, dayOfWeek, day, monthName, month, weekNumber, year, weekend, dayOfYear);

        }
    //function to insert the data into the database
    private void insertTimeDimension(string date, string dayName, int dayNumber, string monthName, int monthNumber, int weekNumber, int year, bool weekend, int dayOfYear)
        {
            //create a connection to the MDF file
            string connectionStringDestinaion = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestinaion))
            {
                //open the sqlConnection
                myConnection.Open();
                //the following code uses sqlcommand based on the sql connection
                SqlCommand command = new SqlCommand("SELECT id FROM Time WHERE date = @date", myConnection);

                //create a variable and assign it to false by default
                bool exists = false;

                //run the command and read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if there are rows it means date exists so change the exisists variables
                    if (reader.HasRows) exists = true;
                }

                if(exists == false)
                {
                    SqlCommand insertCommand = new SqlCommand(
                        "INSERT INTO Time (dayName, dayNumber, monthName, monthNumber, weekNumber, year, weekend, date, dayOfYear)" +
                    " VALUES ( @dayName, @dayNumber, @monthName, @monthNumber, @weekNumber, @year, @weekend, @date, @dayOfYear )", myConnection);

                    insertCommand.Parameters.Add(new SqlParameter("dayName", dayName));
                    insertCommand.Parameters.Add(new SqlParameter("dayNumber", dayNumber));
                    insertCommand.Parameters.Add(new SqlParameter("monthName", monthName));
                    insertCommand.Parameters.Add(new SqlParameter("monthNumber", monthName));
                    insertCommand.Parameters.Add(new SqlParameter("weekNumber", weekNumber));
                    insertCommand.Parameters.Add(new SqlParameter("year", year));
                    insertCommand.Parameters.Add(new SqlParameter("weekend", weekend));
                    insertCommand.Parameters.Add(new SqlParameter("date", date));
                    insertCommand.Parameters.Add(new SqlParameter("dayOfYear", dayOfYear));

                    //insert the line
                    int recordsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Records affected: " + recordsAffected);
                }


                command.Parameters.Add(new SqlParameter("date", date));
            }
        }

        private void btnGetDates_Click(object sender, EventArgs e)
        {
            //create new list to store the result in
            List<string> Dates = new List<string>();
            //clear the listbox
            lstBoxDates.Items.Clear();

            //create a database string
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
            //Bind the listbox to the list
            lstBoxDates.DataSource = DatesFormatted;

            //split the dates and insert and insert every date in the list
            foreach(string date in DatesFormatted)
            {
                splitDates(date);
            }

            splitDates(DatesFormatted[0]);
                        
            //these two do the same thing, its down to personal coding only use one of them
            string[] arrayDate = DatesFormatted[0].ToString().Split('/');
            Console.WriteLine("day: " + arrayDate[0] + " Month: " + arrayDate[1] + " Year: " + arrayDate[2]);

            string fullDate = DatesFormatted[0].ToString();
            string[] arrayDate1 = fullDate.Split('/');
            Console.WriteLine("day: " + arrayDate[0] + " Month: " + arrayDate[1] + " Year: " + arrayDate[2]);

            Console.WriteLine(Dates[0].ToString());
        }
    }
}
