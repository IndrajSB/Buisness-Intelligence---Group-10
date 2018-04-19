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
            this.SuspendLayout();
            // 
            // btnGetSales
            // 
            this.btnGetSales.Location = new System.Drawing.Point(761, 421);
            this.btnGetSales.Name = "btnGetSales";
            this.btnGetSales.Size = new System.Drawing.Size(75, 23);
            this.btnGetSales.TabIndex = 0;
            this.btnGetSales.Text = "Get Sales";
            this.btnGetSales.UseVisualStyleBackColor = true;
            this.btnGetSales.Click += new System.EventHandler(this.btnGetSales_Click);
            // 
            // lstSales
            // 
            this.lstSales.FormattingEnabled = true;
            this.lstSales.Location = new System.Drawing.Point(12, 12);
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(605, 381);
            this.lstSales.TabIndex = 1;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 456);
            this.Controls.Add(this.lstSales);
            this.Controls.Add(this.btnGetSales);
            this.Name = "frmSales";
            this.Text = "frmSales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetSales;
        private System.Windows.Forms.ListBox lstSales;
    }
}