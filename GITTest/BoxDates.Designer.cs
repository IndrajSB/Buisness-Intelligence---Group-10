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
            this.btnGetDates = new System.Windows.Forms.Button();
            this.lstBoxDates = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(12, 226); // Position the button on the page / stage.
            this.btnGetDates.Name = "btnGetDates"; // Add an instance name / ID to the button, so that we can target it in the future if required.
            this.btnGetDates.Size = new System.Drawing.Size(75, 23); // Define the size of the get date button.
            this.btnGetDates.TabIndex = 0; // Set the tabbing order, to ensure the user journey remains consistent and falls down the page correctly.
            this.btnGetDates.Text = "GetDates"; // Add the title of the button.
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.btnGetDates_Click); // Assign a click handler to detect this button being clicked, so we can fire the function.
            // 
            // lstBoxDates
            // 
            this.lstBoxDates.FormattingEnabled = true;
            this.lstBoxDates.Location = new System.Drawing.Point(12, 12);
            this.lstBoxDates.Name = "lstBoxDates";
            this.lstBoxDates.Size = new System.Drawing.Size(260, 199);
            this.lstBoxDates.TabIndex = 1;
            // 
            // BoxDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstBoxDates);
            this.Controls.Add(this.btnGetDates);
            this.Name = "BoxDates";
            this.Text = "BoxDates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.ListBox lstBoxDates;
    }
}