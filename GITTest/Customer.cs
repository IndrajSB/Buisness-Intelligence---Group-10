﻿using System;
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
                OleDbCommand getCustomers = new OleDbCommand("SELECT [Customer Name], [City] from sheet1'", connection);
                reader = getCustomers.ExecuteReader();
                while (reader.Read())
                {
                    Customers.Add(reader[0].ToString());
                    Customers.Add(reader[1].ToString());
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
                lstCustomer.DataSource =
                   CustomersFormatted;

                //string[] arrayCustomer = CustomersFormatted[0].ToString().Split('/');
                //string category=Convert.ToString(arrayCustomer[1]);
                //string subcategory = Convert.ToString(arrayCustomer[2]);
                //string name = Convert.ToString(arrayCustomer[0]);
                ////in relation to the dateTime in the example...

                // string CustomerList = new (category, subcategory, name); 





                Console.WriteLine(Customers[0].ToString());

                //string fullCustomer = CustomersFormatted[0].ToString();
                //string[] arrayCustomer1 = fullCustomer.Split('/');
                //Console.WriteLine("name" + arrayCustomer1[0] + "category" + arrayCustomer1[1] + "subcategory" + arrayCustomer1[2]);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
