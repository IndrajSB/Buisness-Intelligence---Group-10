namespace GITTest
{
    partial class frmSales
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
            this.btnGetSales = new System.Windows.Forms.Button();
            this.lstSales = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.listBoxFromDbNamed = new System.Windows.Forms.ListBox();
            this.btnGetfromDestinationDb = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetSales
            // 
            this.btnGetSales.Location = new System.Drawing.Point(6, 305);
            this.btnGetSales.Name = "btnGetSales";
            this.btnGetSales.Size = new System.Drawing.Size(92, 32);
            this.btnGetSales.TabIndex = 0;
            this.btnGetSales.Text = "Get Sales";
            this.btnGetSales.UseVisualStyleBackColor = true;
            this.btnGetSales.Click += new System.EventHandler(this.btnGetSales_Click);
            // 
            // lstSales
            // 
            this.lstSales.FormattingEnabled = true;
            this.lstSales.Location = new System.Drawing.Point(6, 6);
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(299, 264);
            this.lstSales.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 369);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.listBoxFromDbNamed);
            this.tabPage1.Controls.Add(this.btnGetSales);
            this.tabPage1.Controls.Add(this.btnGetfromDestinationDb);
            this.tabPage1.Controls.Add(this.lstSales);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(658, 305);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listBoxFromDbNamed
            // 
            this.listBoxFromDbNamed.FormattingEnabled = true;
            this.listBoxFromDbNamed.Location = new System.Drawing.Point(311, 6);
            this.listBoxFromDbNamed.Name = "listBoxFromDbNamed";
            this.listBoxFromDbNamed.Size = new System.Drawing.Size(438, 264);
            this.listBoxFromDbNamed.TabIndex = 3;
            // 
            // btnGetfromDestinationDb
            // 
            this.btnGetfromDestinationDb.Location = new System.Drawing.Point(168, 305);
            this.btnGetfromDestinationDb.Name = "btnGetfromDestinationDb";
            this.btnGetfromDestinationDb.Size = new System.Drawing.Size(137, 32);
            this.btnGetfromDestinationDb.TabIndex = 2;
            this.btnGetfromDestinationDb.Text = "Get from Destination Db";
            this.btnGetfromDestinationDb.UseVisualStyleBackColor = true;
            this.btnGetfromDestinationDb.Click += new System.EventHandler(this.btnGetfromDestinationDb_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(775, 388);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmSales";
            this.Text = "frmSales";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetSales;
        private System.Windows.Forms.ListBox lstSales;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGetfromDestinationDb;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxFromDbNamed;
        private System.Windows.Forms.Button btnClose;
    }
}