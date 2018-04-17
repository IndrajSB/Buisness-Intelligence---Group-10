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
            this.btnClose = new System.Windows.Forms.Button();
            this.lstBoxDatesFromDB = new System.Windows.Forms.ListBox();
            this.lstBoxDatesFromDBNamed = new System.Windows.Forms.ListBox();
            this.btnGetDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(172, 217);
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
            this.lstBoxDates.Location = new System.Drawing.Point(12, 12);
            this.lstBoxDates.Name = "lstBoxDates";
            this.lstBoxDates.Size = new System.Drawing.Size(260, 199);
            this.lstBoxDates.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 217);
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
            this.lstBoxDatesFromDB.Location = new System.Drawing.Point(296, 12);
            this.lstBoxDatesFromDB.Name = "lstBoxDatesFromDB";
            this.lstBoxDatesFromDB.Size = new System.Drawing.Size(260, 199);
            this.lstBoxDatesFromDB.TabIndex = 3;
            // 
            // lstBoxDatesFromDBNamed
            // 
            this.lstBoxDatesFromDBNamed.FormattingEnabled = true;
            this.lstBoxDatesFromDBNamed.Location = new System.Drawing.Point(579, 12);
            this.lstBoxDatesFromDBNamed.Name = "lstBoxDatesFromDBNamed";
            this.lstBoxDatesFromDBNamed.Size = new System.Drawing.Size(260, 199);
            this.lstBoxDatesFromDBNamed.TabIndex = 4;
            // 
            // btnGetDb
            // 
            this.btnGetDb.Location = new System.Drawing.Point(519, 217);
            this.btnGetDb.Name = "btnGetDb";
            this.btnGetDb.Size = new System.Drawing.Size(100, 35);
            this.btnGetDb.TabIndex = 5;
            this.btnGetDb.Text = "Get From Destination DB";
            this.btnGetDb.UseVisualStyleBackColor = true;
            this.btnGetDb.Click += new System.EventHandler(this.btnGetDb_Click);
            // 
            // BoxDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 374);
            this.Controls.Add(this.btnGetDb);
            this.Controls.Add(this.lstBoxDatesFromDBNamed);
            this.Controls.Add(this.lstBoxDatesFromDB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstBoxDates);
            this.Controls.Add(this.btnGetDates);
            this.Name = "BoxDates";
            this.Text = "BoxDates";
            this.Load += new System.EventHandler(this.BoxDates_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.ListBox lstBoxDates;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstBoxDatesFromDB;
        private System.Windows.Forms.ListBox lstBoxDatesFromDBNamed;
        private System.Windows.Forms.Button btnGetDb;
    }
}