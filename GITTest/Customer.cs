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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            List<string> Customers = new List<string>();
            //clear the listbox
            lstCustomer.Items.Clear();
            //create database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getCustomers = new OleDbCommand("SELECT [Customer ID], [Customer Name], Country, City, State, Region, [Postal Code]  from sheet1'", connection);

                reader = getCustomers.ExecuteReader();
                while (reader.Read())
                {
                    Customers.Add(reader[0].ToString());
                    Customers.Add(reader[1].ToString());
                    Customers.Add(reader[2].ToString());
                    Customers.Add(reader[3].ToString());
                    Customers.Add(reader[4].ToString());
                    Customers.Add(reader[5].ToString());
                    Customers.Add(reader[6].ToString());
                }

                List<string> CustomersFormatted = new List<string>();
                foreach (string customer in Customers)
                {
                    //split the string on whitespace and remove anythng thats blank.
                    var customers = customer.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    //grab the first item and add it to the list
                    CustomersFormatted.Add(customers[0]);
                }

                   //bind the listbox to the list
                lstCustomer.DataSource = CustomersFormatted;


                //string[] arrayCustomer = CustomersFormatted[0].ToString().Split('/');
                //string customerId = Convert.ToString(arrayCustomer[0]);
                //string customername = Convert.ToString(arrayCustomer[1]);
                //string city = Convert.ToString(arrayCustomer[2]);

                //String CustList = new String(customerId, customername, city);
                //Console.WriteLine( );

                //string fullCustomer = CustomersFormatted[0].ToString();
                //string[] arrayCustomer1 = fullCustomer.Split('/');
                //Console.WriteLine("customerId:" + arrayCustomer1[0] + "customername:" + arrayCustomer1[1] + "city:" + arrayCustomer1[2]);

                //split the dates and insert and insert every date in the list
                foreach (string customer in CustomersFormatted)
                {
                   splitCustomers(customer);
                }
                  splitCustomers(CustomersFormatted[0]);
            }
        }


        private void splitCustomers(string customer)
        {
            //string[] arrayCustomer = CustomersFormatted[0].ToString().Split('/');
            //string customerId = arrayCustomer[0];
            //string customername = arrayCustomer[1];
            //string city = arrayCustomer[2];

            //String CustList = new String(customerId, customername, city);
            
            //string Customer = 


        }
                    

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

       
        }
}
