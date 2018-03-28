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

namespace GITTest
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            List<string> Customer = new List<string>();
            //clear the listbox
            lstCustomer.Items.Clear();

            //create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand Customers = new OleDbCommand("SELECT [Customer ID], [Customer Name], [Country], [City], [State], [Postal Code], [Region]  from Sheet1'", connection);

                reader = Customers.ExecuteReader();
                while (reader.Read())
                {
                    string CustomerID = reader[0].ToString();
                    Customer.Add(CustomerID);
                    string CustomerName = reader[1].ToString();
                    Customer.Add(CustomerName);
                    string Country = reader[2].ToString();
                    Customer.Add(Country);
                    string City = reader[3].ToString();
                    Customer.Add(City);
                    string State = reader[4].ToString();
                    Customer.Add(State);
                    string PostalCode = reader[5].ToString();
                    Customer.Add(PostalCode);
                    string Region = reader[6].ToString();
                    Customer.Add(Region);

                }
            }
            //create a new list for the formatted data
            List<string> CustomerFormatted = new List<string>();

            foreach (string customers in Customer)
            {
                //split the string on whitespace and remove anything thats blank
                var customer = customers.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //grab the first item (we know this is the date) and add it to our new list
                CustomerFormatted.Add(customer[0]);
            }

            //Blind the listbox to the list
            lstCustomer.DataSource = CustomerFormatted;

            //listBoxDates.DataSource = Dates;

        }
    }
}
