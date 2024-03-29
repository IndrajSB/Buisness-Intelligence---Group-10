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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void btnGetSales_Click(object sender, EventArgs e)
        {
            //create new list to store the result in
            List<string> Sales = new List<string>();
            //clear the list box
            lstSales.Items.Clear();

            //create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getSale = new OleDbCommand("SELECT [Product ID], [Sales], [Profit], [Discount] from Sheet1 '", connection);

                reader = getSale.ExecuteReader();
                while (reader.Read())
                {
                    Sales.Add(reader[0].ToString());
                    Sales.Add(reader[1].ToString());
                    Sales.Add(reader[2].ToString());
                    Sales.Add(reader[3].ToString());

                }
            }
            //create a new list for the formatted data
            List<string>SalesFormatted = new List<string>();

            foreach (string Sale in Sales)
            {
                //split the string on whitespace and remove anything bank
                var sales = Sale.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //grab the first item (we know this is the date) and add it to our new list
                SalesFormatted.Add(sales[0]);
            }
            //bind the listbox to the list
            lstSales.DataSource = SalesFormatted;
        }

        private void btnGetfromDestinationDb_Click(object sender, EventArgs e)
        {
            //create new list to store the indexed results in
            List<string> DestinationSales = new List<string>();

            //create the database string
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStringDestination))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT  Sales, Profit, Discount from Sales", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if there are rows, it means the date exists so chnage the exists variable
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DestinationSales.Add(reader["Sales"].ToString() + ", " + reader["Profit"].ToString() + ", " + reader["Discount"].ToString());

                        }
                    }
                    else
                    {
                        DestinationSales.Add("No Data present, ");
                        //DestinationProductsNamed.Add("No Data present");
                    }
                }
            }

            //bind the listbox to the list
            listBoxFromDbNamed.DataSource = DestinationSales;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
   

