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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            List<string> Products = new List<string>();
            //clear the listbox
            lstProduct.Items.Clear();
            //create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getProducts = new OleDbCommand("SELECT [Product ID], [Product Name] from Sheet1'", connection);

                reader = getProducts.ExecuteReader();
                while (reader.Read())
                {
                    Products.Add(reader[0].ToString());
                    Products.Add(reader[1].ToString());
                }
            }
            //create a new list for the formatted data
            List<string> ProductsFormatted = new List<string>();

            foreach (string product in Products)
            {
                //split the string on whitespace and remove anything thats blank
                var products = product.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);


                //grab the first item (we know this is the date) and add it to our new list
                ProductsFormatted.Add(products[0]);
            }

            //Blind the listbox to the list
            lstProduct.DataSource = ProductsFormatted;

            //listBoxDates.DataSource = Dates
        }
    }
}
