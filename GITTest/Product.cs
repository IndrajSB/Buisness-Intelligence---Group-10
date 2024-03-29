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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        
        private void insertProductDimension(string name, string category, string subcategory)
        {
            //creaete a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //open the SqlConnection
                myConnection.Open();
                //the following code uses an SqlCOmmand based on the SqlCOnnection
                SqlCommand command = new SqlCommand("SELECT id FROM Product WHERE name = @name", myConnection); //????????
                command.Parameters.Add(new SqlParameter("name", name));

                //create variable and assign it to false by default
                bool exists = false;

                //run the command and read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                    //if there are rows, it means the product exists so chnage the exists variabe
                    if (reader.HasRows) exists = true;
                }
                
                if (exists == false)
                {
                    SqlCommand insertCommand = new SqlCommand(
                        "INSERT INTO Product (category, subcategory, name) " +
                    "VALUES @category, @subcategory, @name ", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("category", category));
                    insertCommand.Parameters.Add(new SqlParameter("subcategory", subcategory));
                    insertCommand.Parameters.Add(new SqlParameter("name", name));

                    //insert the line
                    int recordsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Records affected: " + recordsAffected);
                }
            }
        }
        

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            //create new list to store the result in
            List<string> Products = new List<string>();
            //clear the list box
            lstProduct.Items.Clear();

            //create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getProduct = new OleDbCommand("SELECT [Product Name] from Sheet1 '", connection);

                reader = getProduct.ExecuteReader();
                while (reader.Read())
                {
                    Products.Add(reader[0].ToString());
                    //Products.Add(reader[1].ToString());
                }
            }
            //create a new list for the formatted data
            List<string> ProductsFormatted = new List<string>();

            foreach (string product in Products)
            {
                //split the string on whitespace and remove anything bank
                var products = product.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //grab the first item (we know this is the date) and add it to our new list
                ProductsFormatted.Add(products[0]);
            }
            //bind the listbox to the list
            lstProduct.DataSource = ProductsFormatted;            
        }

        private int GetProductId(string product)
        {
            //declare string
            string dbName = "";
            
            //creaete a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;
            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //open the SqlConnection
                myConnection.Open();
                //the following code uses an SqlCOmmand based on the SqlCOnnection
                SqlCommand command = new SqlCommand("SELECT id FROM Product WHERE name = @name", myConnection); //????????
                command.Parameters.Add(new SqlParameter("name", dbName));

                //create variable and assign it to false by default
                bool exists = false;

                //run the command and read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //int productId = 0;
                    //if there are rows, it means the product exists so chnage the exists variabe
                    if (reader.HasRows)
                    {
                        exists = true;
                        Console.WriteLine("Data exists!");
                    }                    
                }
                //if is doesnt exist
                if (exists == false)
                {

                }

            }
            return 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetProductId()
        {      
            return 0;
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void btnGetFromDestinationDb_Click(object sender, EventArgs e)
        {
            //create new list to store the indexed results in
            List<string> DestinationProducts = new List<string>();

            //create the database string
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStringDestination))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT category, subcategory, name from Product", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if there are rows, it means the date exists so chnage the exists variable
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DestinationProducts.Add(reader["category"].ToString() + ", " + reader["subcategory"].ToString() + ", " + reader["name"].ToString());

                            //DestinationProductsNamed.Add(reader["category"].ToString() + ", " + reader["subcategory"].ToString() + ", " + reader["name"].ToString());
                        }
                    }
                    else
                    {
                        DestinationProducts.Add("No Data present, ");
                        //DestinationProductsNamed.Add("No Data present");
                    }
                }
            }

            //bind the listbox to the list
            listBoxFromDbNamed.DataSource = DestinationProducts;
            //bind the listbox to the list
            //listBoxFromDbNamed.DataSource = DestinationProductsNamed;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            //create an empty list and add in the products
            List<string> productlist = new List<string>(new string[] { "Office Supplies", "Furniture", "Technology" });
            //the dictionary type is string
            Dictionary<string, int> salesCount = new Dictionary<string, int>();

            //create a connection to the MDF File
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            //run this code for once for each product in my list (3 times)
            foreach (string product in productlist)
            {
                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                {
                    //open my connection
                    myConnection.Open();
                    //the following code uses an SqlCommand based on the SqlConnection
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) AS ProductId FROM FactTable JOIN Product" +
                    "ON FactTable.ProductId = Product.Id WHERE Product.Id = @ProductId; ", myConnection); //double check this

                    command.Parameters.Add(new SqlParameter("category", product));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                salesCount.Add(product, char.Parse(reader["ProductId"].ToString()));
                            }
                        }
                        else
                        {
                            salesCount.Add(product, 0);
                        }
                    }

                }

            }
            chartProduct.DataSource = salesCount;
            chartProduct.Series[0].XValueMember = "Key";
            chartProduct.Series[0].YValueMembers = "Value";
            chartProduct.DataBind();
        }
    }
}
