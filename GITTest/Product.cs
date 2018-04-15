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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            List<string> Products = new List<string>();
            //clear the listbox
            lstProducts.Items.Clear();
            //create database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getProducts = new OleDbCommand("SELECT [Product Name], [Category] from sheet1'", connection);
                reader = getProducts.ExecuteReader();
                while (reader.Read())
                {
                    Products.Add(reader[0].ToString());
                    Products.Add(reader[1].ToString());
                }
                List<string> ProductsFormatted = new List<string>();
                foreach (string product in Products)
                {
                    //split the string on whitespace and remove anythng thats blank.
                    var products = product.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    //grab the first item and add it to the list
                    ProductsFormatted.Add(products[0]);

                }
                //bind the listbox to the list
                lstProducts.DataSource =
                    ProductsFormatted;
            }
        }
    }
}
