using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITTest //name space
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
            string[] arrayDate = date.Split('/');
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);

            DateTime dateTime = new DateTime(year, month, day);

            string dayOfWeek = dateTime.DayOfWeek.ToString();
            int dayOfYear = dateTime.DayOfYear;
            string monthName = dateTime.ToString("MMMM");
            int weekNumber = dayOfYear / 7;
            bool Weekend = false;
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") Weekend = true;
        }

        private void insertTimeDimension()
        {
            //inserted commentss
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
