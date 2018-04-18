namespace GITTest
{
    partial class BoxDates
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGetDates = new System.Windows.Forms.Button();
            this.lstBoxDates = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstBoxDatesFromDB = new System.Windows.Forms.ListBox();
            this.lstBoxDatesFromDBNamed = new System.Windows.Forms.ListBox();
            this.btnGetDb = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DatesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(169, 247);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(100, 35);
            this.btnGetDates.TabIndex = 0;
            this.btnGetDates.Text = "GetDates";
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.btnGetDates_Click);
            // 
            // lstBoxDates
            // 
            this.lstBoxDates.FormattingEnabled = true;
            this.lstBoxDates.Location = new System.Drawing.Point(9, 42);
            this.lstBoxDates.Name = "lstBoxDates";
            this.lstBoxDates.Size = new System.Drawing.Size(260, 199);
            this.lstBoxDates.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(9, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close Window";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstBoxDatesFromDB
            // 
            this.lstBoxDatesFromDB.FormattingEnabled = true;
            this.lstBoxDatesFromDB.Location = new System.Drawing.Point(293, 42);
            this.lstBoxDatesFromDB.Name = "lstBoxDatesFromDB";
            this.lstBoxDatesFromDB.Size = new System.Drawing.Size(260, 199);
            this.lstBoxDatesFromDB.TabIndex = 3;
            // 
            // lstBoxDatesFromDBNamed
            // 
            this.lstBoxDatesFromDBNamed.FormattingEnabled = true;
            this.lstBoxDatesFromDBNamed.Location = new System.Drawing.Point(576, 42);
            this.lstBoxDatesFromDBNamed.Name = "lstBoxDatesFromDBNamed";
            this.lstBoxDatesFromDBNamed.Size = new System.Drawing.Size(260, 199);
            this.lstBoxDatesFromDBNamed.TabIndex = 4;
            // 
            // btnGetDb
            // 
            this.btnGetDb.Location = new System.Drawing.Point(516, 247);
            this.btnGetDb.Name = "btnGetDb";
            this.btnGetDb.Size = new System.Drawing.Size(100, 35);
            this.btnGetDb.TabIndex = 5;
            this.btnGetDb.Text = "Get From Destination DB";
            this.btnGetDb.UseVisualStyleBackColor = true;
            this.btnGetDb.Click += new System.EventHandler(this.btnGetDb_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 382);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstBoxDatesFromDB);
            this.tabPage1.Controls.Add(this.btnGetDb);
            this.tabPage1.Controls.Add(this.btnGetDates);
            this.tabPage1.Controls.Add(this.lstBoxDatesFromDBNamed);
            this.tabPage1.Controls.Add(this.lstBoxDates);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(18, 19);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DatesChart);
            this.tabPage2.Controls.Add(this.btnLoadData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // DatesChart
            // 
            chartArea1.Name = "ChartArea1";
            this.DatesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DatesChart.Legends.Add(legend1);
            this.DatesChart.Location = new System.Drawing.Point(157, 19);
            this.DatesChart.Name = "DatesChart";
            this.DatesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.DatesChart.Series.Add(series1);
            this.DatesChart.Size = new System.Drawing.Size(300, 300);
            this.DatesChart.TabIndex = 1;
            this.DatesChart.Text = "chart1";
            // 
            // BoxDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 396);
            this.Controls.Add(this.tabControl1);
            this.Name = "BoxDates";
            this.Text = "BoxDates";
            this.Load += new System.EventHandler(this.BoxDates_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatesChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.ListBox lstBoxDates;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstBoxDatesFromDB;
        private System.Windows.Forms.ListBox lstBoxDatesFromDBNamed;
        private System.Windows.Forms.Button btnGetDb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart DatesChart;
        private System.Windows.Forms.Button btnLoadData;
    }
}