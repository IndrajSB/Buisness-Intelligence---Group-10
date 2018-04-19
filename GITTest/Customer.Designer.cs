namespace GITTest
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetDestination = new System.Windows.Forms.Button();
            this.lstBoxFromDBCustomers = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.CustomerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(6, 293);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(100, 35);
            this.btnGetCustomer.TabIndex = 0;
            this.btnGetCustomer.Text = "Get Customer";
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click);
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.Location = new System.Drawing.Point(6, 6);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(281, 264);
            this.lstCustomer.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(926, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close Window";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 360);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnGetDestination);
            this.tabPage1.Controls.Add(this.lstBoxFromDBCustomers);
            this.tabPage1.Controls.Add(this.btnGetCustomer);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.lstCustomer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetDestination
            // 
            this.btnGetDestination.Location = new System.Drawing.Point(151, 293);
            this.btnGetDestination.Name = "btnGetDestination";
            this.btnGetDestination.Size = new System.Drawing.Size(136, 37);
            this.btnGetDestination.TabIndex = 4;
            this.btnGetDestination.Text = "Get from Destination Db";
            this.btnGetDestination.UseVisualStyleBackColor = true;
            this.btnGetDestination.Click += new System.EventHandler(this.btnGetDestination_Click);
            // 
            // lstBoxFromDBCustomers
            // 
            this.lstBoxFromDBCustomers.FormattingEnabled = true;
            this.lstBoxFromDBCustomers.Location = new System.Drawing.Point(293, 6);
            this.lstBoxFromDBCustomers.Name = "lstBoxFromDBCustomers";
            this.lstBoxFromDBCustomers.Size = new System.Drawing.Size(397, 264);
            this.lstBoxFromDBCustomers.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLoadData);
            this.tabPage2.Controls.Add(this.CustomerChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(6, 301);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(83, 27);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // CustomerChart
            // 
            chartArea4.Name = "ChartArea1";
            this.CustomerChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.CustomerChart.Legends.Add(legend4);
            this.CustomerChart.Location = new System.Drawing.Point(16, 6);
            this.CustomerChart.Name = "CustomerChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.CustomerChart.Series.Add(series4);
            this.CustomerChart.Size = new System.Drawing.Size(300, 300);
            this.CustomerChart.TabIndex = 0;
            this.CustomerChart.Text = "chart1";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(718, 387);
            this.Controls.Add(this.tabControl1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetCustomer;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataVisualization.Charting.Chart CustomerChart;
        private System.Windows.Forms.Button btnGetDestination;
        private System.Windows.Forms.ListBox lstBoxFromDBCustomers;
        private System.Windows.Forms.Button button1;
    }
}