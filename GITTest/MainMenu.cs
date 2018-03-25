using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITTest
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customer Check = new Customer();
            Check.Show();
        }

        private void btnDates_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product Check = new Product();
            Check.Show();
        }
    }
}
