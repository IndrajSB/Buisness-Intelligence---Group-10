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
                OleDbCommand getSale = new OleDbCommand("SELECT [Product ID], [Quantity], [Sales] from Sheet1 '", connection);

                reader = getSale.ExecuteReader();
                while (reader.Read())
                {
                    Sales.Add(reader[0].ToString());
                    //Products.Add(reader[1].ToString());
                }
            }
            //create a new list for the formatted data
            List<string> ProductsFormatted = new List<string>();

            foreach (string Sale in Sales)
            {
                //split the string on whitespace and remove anything bank
                var products = Sale.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //grab the first item (we know this is the date) and add it to our new list
                ProductsFormatted.Add(products[0]);
            }
            //bind the listbox to the list
            lstSales.DataSource = ProductsFormatted;
        }
    }
        }
   

