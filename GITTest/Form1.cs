﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDates_Click(object sender, EventArgs e)
        {

            List<string> Dates = new List<string>();
            //clear the listbox
            listBoxDates.Items.Clear();
            //create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getDates = new OleDbCommand("SELECT [Order Date], [Ship Date] from Sheet1'", connection);

                reader = getDates.ExecuteReader();
                while (reader.Read())
                {
                    Dates.Add(reader[0].ToString());
                    Dates.Add(reader[1].ToString());
                }
            }
            //create a new list for the formatted data
            List<string> DatesFormatted = new List<string>();

            foreach (string date in Dates)
            {
                //split the string on whitespace and remove anything thats blank
                var dates = date.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            
                //grab the first item (we know this is the date) and add it to our new list
                DatesFormatted.Add(dates[0]);
            }

            //Blind the listbox to the list
            listBoxDates.DataSource = DatesFormatted;

            //listBoxDates.DataSource = Dates


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }



