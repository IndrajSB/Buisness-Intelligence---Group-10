﻿namespace GITTest
{
    partial class MainMenu
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
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnDates = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.lblSystem = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(241, 139);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(132, 54);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_ClickEvent);
            // 
            // btnDates
            // 
            this.btnDates.Location = new System.Drawing.Point(64, 139);
            this.btnDates.Name = "btnDates";
            this.btnDates.Size = new System.Drawing.Size(132, 54);
            this.btnDates.TabIndex = 1;
            this.btnDates.Text = "Dates";
            this.btnDates.UseVisualStyleBackColor = true;
            this.btnDates.Click += new System.EventHandler(this.btnDates_ClickEvent);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(241, 218);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(132, 54);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_ClickEvent);
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.Purple;
            this.lblSystem.Location = new System.Drawing.Point(135, 40);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(162, 32);
            this.lblSystem.TabIndex = 3;
            this.lblSystem.Text = "Main Menu";
            this.lblSystem.Click += new System.EventHandler(this.lblSystem_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(64, 218);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(132, 54);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 373);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnDates);
            this.Controls.Add(this.btnCustomers);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnDates;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Button btnSales;
    }
}