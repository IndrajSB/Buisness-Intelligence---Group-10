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
            //creaete a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //open the SqlConnection
                myConnection.Open();
                //the following code uses an SqlCOmmand based on the SqlCOnnection
                SqlCommand command = new SqlCommand("SELECT id FROM Product WHERE productid = @productid", myConnection); //????????
                command.Parameters.Add(new SqlParameter("productid", product));

                //create variable and assign it to false by default
             
                //run the command and read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int productId = 0;
                    //if there are rows, it means the product exists so chnage the exists variabe
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            productId = Convert.ToInt32(reader["Id"].ToString());
                        }
                    }

                    return productId;
                }

                //if is doesnt exist
              

            }
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
    }
}
