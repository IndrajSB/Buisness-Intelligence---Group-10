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

        private void insertCustomerDimension(string name, string country, string city, string state, string postalCode, string region, string reference)
        {
            //The following creates a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //This code opens the SQLConnection
                myConnection.Open();
                
                //This pull information on the SQLCommand from the SQLConnection
                SqlCommand command = new SqlCommand("SELECT Id FROM Customer WHERE name = @name", myConnection);
                command.Parameters.Add(new SqlParameter("name", name));
               
                //Creating a default boolean to show false
                bool exists = false;

                //This code run the command and read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    //if there are rows, it means the customer exists so chnage the exists variabe
                    if (reader.HasRows) exists = true;
                }

                if (exists == false)
                {
                    SqlCommand insertCommand = new SqlCommand(
                        "INSERT INTO Customer ( id, name, country, city, state, postalCode, region, reference) " +
                    "VALUES @id, @name, @country, @city, @state, @postalCode, @region, @reference ", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("name", name));
                    insertCommand.Parameters.Add(new SqlParameter("country", country));
                    insertCommand.Parameters.Add(new SqlParameter("city", city));
                    insertCommand.Parameters.Add(new SqlParameter("state", state));
                    insertCommand.Parameters.Add(new SqlParameter("postalCode", postalCode));
                    insertCommand.Parameters.Add(new SqlParameter("region", region));
                    insertCommand.Parameters.Add(new SqlParameter("reference", reference));

                    //insert the line
                    int recordsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Records affected: " + recordsAffected);
                }
            }
        }


        private void btnGetCustomer_Click(object sender, EventArgs e)
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
            List<string> CustomersFormatted = new List<string>();

            foreach (string customer in Customer)
            {

                var customers = customer.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                CustomersFormatted.Add(customers[0]);
            }

            //Bind the listbox
            lstCustomer.DataSource = CustomersFormatted;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
        private int GetCustomerId(string Customer)
        {
            //create the to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //open the Sqlconnection
                myConnection.Open();
               
                SqlCommand command = new SqlCommand("SELECT Id FROM Customer WHERE customername = @customername", myConnection); //????????
                command.Parameters.Add(new SqlParameter("customername", Customer));

                //Run the Command
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int customerId = 0;
                  
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            customerId = Convert.ToInt32(reader["Id"].ToString());
                        }
                    }

                    return customerId;
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            List<string> customerList = new List<string>(new string[] { "DP-13000", "PO-19195" });

            Dictionary<string, int> salesCount = new Dictionary<string, int>();

            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            foreach (string customer in customerList)
            {
                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                {
                    myConnection.Open();

                    SqlCommand command = new SqlCommand("SELECT COUNT(*) AS customerId FROM FactTable JOIN Customer" +
                    "ON FactTable.customerId = Customer.Id WHERE Customer.Id = @customerid; ", myConnection);

                    command.Parameters.Add(new SqlParameter("Customer", customer));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                salesCount.Add(customer, char.Parse(reader["customerId"].ToString()));
                            }
                        }
                        else
                        {
                            salesCount.Add(customer, 0);
                        }
                    }

                }

            }
            CustomerChart.DataSource = salesCount;
            CustomerChart.Series[0].XValueMember = "Key";
            CustomerChart.Series[0].YValueMembers = "Value";
            CustomerChart.DataBind();
        }

        private void btnGetDestination_Click(object sender, EventArgs e)
        {
            //Create the new list to store Indexed results
            List<string> DestinationCustomers = new List<string>();
            
            //Create the Database String
            string connectionStringForDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            //The database connection to the String
            using (SqlConnection connection = new SqlConnection(connectionStringForDestination))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT id, name, city, country, state, postalCode, region from Customer", connection);



                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //Add Rows
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DestinationCustomers.Add(reader[0].ToString() + "," + reader[1].ToString() + "," + reader[2].ToString() + "." +
                                reader[3].ToString() + "," + reader[4].ToString() + "," + reader[5].ToString() + "," + reader[6].ToString());
                        }
                    }

                    else
                    {
                        DestinationCustomers.Add("No Data Present");
                    }
                }
            }
            //Bind the list box to the data
            lstBoxFromDBCustomers.DataSource = DestinationCustomers;


        }
    }
}              

