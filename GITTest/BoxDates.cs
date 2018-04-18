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
                command.Parameters.Add(new SqlParameter("date", date));
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
                    insertCommand.Parameters.Add(new SqlParameter("monthNumber", monthNumber));
                    insertCommand.Parameters.Add(new SqlParameter("weekNumber", weekNumber));
                    insertCommand.Parameters.Add(new SqlParameter("year", year));
                    insertCommand.Parameters.Add(new SqlParameter("weekend", weekend));
                    insertCommand.Parameters.Add(new SqlParameter("date", date));
                    insertCommand.Parameters.Add(new SqlParameter("dayOfYear", dayOfYear));


                    //insert the line
                    int recordsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Records affected: " + recordsAffected);
                }


                command.Parameters.Add(new SqlParameter("@date", date));
            }
        }


        private int GetDateId (string date)
        {
            string[] arrayDate = date.Split('/'); 
            int year = Convert.ToInt32(arrayDate[2]); 
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);

            DateTime dateTime = new DateTime(year, month, day);

            string dbDate = dateTime.ToString("M/dd/yyyy");
            string connectonStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;
            using (SqlConnection myConnection = new SqlConnection(connectonStringDestination))
            {
                myConnection.Open();
                SqlCommand command = new SqlCommand("SELECT id FROM Time WHERE dat = @date", myConnection);
                command.Parameters.Add(new SqlParameter("date", dbDate));

                bool exists = false;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        exists = true;
                        Console.WriteLine("Data exists!");

                    }
                }
                if (exists == false)
                {

                }
            }
            return 0;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetDb_Click(object sender, EventArgs e)
        {
            List<string> Destinationdates = new List<string>();
            //create a new list to store the named results in
            List<string> DestinationDatesNamed = new List<string>();

            //create the database string
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using(SqlConnection connection = new SqlConnection(connectionStringDestination))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT dayName, dayNumber, monthName, monthNumber,weekNumber,year, weekend," + "date, dayOfYear from Time", connection);



                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows){
                        while (reader.Read())
                        {
                            Destinationdates.Add(reader[0].ToString()+ "," +reader[1].ToString()+","+reader[2].ToString()+"."+
                                reader[3].ToString()+","+reader[4].ToString()+","+reader[5].ToString()+","+reader[6].ToString()+
                                ","+reader[7].ToString()+","+reader[8].ToString());

                            DestinationDatesNamed.Add(reader["dayName"].ToString() + "," + reader["dayNumber"].ToString() + "," +
                                reader["MonthName"].ToString() + "," + reader["monthNumber"].ToString() + "," + reader["weekNumber"].ToString() +
                                "," + reader["Year"].ToString() + "," + reader["weekend"].ToString() + "," + reader["date"].ToString() + "," +
                                reader["dayOfYear"].ToString());
                        }
                    }
                    else
                    {
                        Destinationdates.Add("No Data is present.");
                        DestinationDatesNamed.Add("No Data is present.");
                    }
                }

            }
            lstBoxDatesFromDB.DataSource = Destinationdates;
            lstBoxDatesFromDBNamed.DataSource = DestinationDatesNamed;
        }

        private void BoxDates_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            List<string> dateList = new List<string>(new string[] { "03/01/2014", "04/01/2014", "05/01/2014", "06/01/2014", "07/01/2014", "09/01/2014", "10/01/2014" });

            Dictionary<string, int> salesCount = new Dictionary<string, int>();


            //Create a connection to the mdf File 
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            foreach (string date in dateList)
            {
                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                {
                    myConnection.Open();

                    SqlCommand command = new SqlCommand("SELECT COUNT(*) AS SalesNumber FROM FactTable JOIN Time " + "ON FactTable.timeId = Time.id WHERE Time.date = @date; ", myConnection);

                    command.Parameters.Add(new SqlParameter("date", date));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                salesCount.Add(date, Int32.Parse(reader["SalesNumber"].ToString()));
                            }
                        }

                        else

                        {
                            salesCount.Add(date, 0);
                        }
                    }
                }

            }

            DatesChart.DataSource = salesCount;
            DatesChart.Series[0].XValueMember = "Key";
            DatesChart.Series[0].YValueMembers = "Value";
            DatesChart.DataBind();
          
        }

        private void DatesChart_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
