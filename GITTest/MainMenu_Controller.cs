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
    //Trace output
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCustomers_ClickEvent(object sender, EventArgs e)
        {
            Customer Check = new Customer();
            Check.Show();
        }

        private void btnDates_ClickEvent(object sender, EventArgs e)
        {
            BoxDates Check = new BoxDates();
            Check.Show();
        }

        private void btnProduct_ClickEvent(object sender, EventArgs e)
        {
            Product Check = new Product();
            Check.Show();
        }

    }
}
