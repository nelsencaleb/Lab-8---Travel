namespace Lab_10
{
    partial class Main
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
            this.btnMap = new System.Windows.Forms.Button();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.listBoxTripDatesOrData = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnterDates = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMap
            // 
            this.btnMap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMap.Location = new System.Drawing.Point(122, 43);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(75, 23);
            this.btnMap.TabIndex = 0;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(38, 177);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDeparture.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pick your route";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(492, 291);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departure Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Return Date";
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(292, 177);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReturnDate.TabIndex = 6;
            // 
            // listBoxTripDatesOrData
            // 
            this.listBoxTripDatesOrData.FormattingEnabled = true;
            this.listBoxTripDatesOrData.Location = new System.Drawing.Point(168, 206);
            this.listBoxTripDatesOrData.Name = "listBoxTripDatesOrData";
            this.listBoxTripDatesOrData.Size = new System.Drawing.Size(305, 95);
            this.listBoxTripDatesOrData.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Planned Trip Dates:";
            // 
            // btnEnterDates
            // 
            this.btnEnterDates.Location = new System.Drawing.Point(508, 177);
            this.btnEnterDates.Name = "btnEnterDates";
            this.btnEnterDates.Size = new System.Drawing.Size(75, 108);
            this.btnEnterDates.TabIndex = 9;
            this.btnEnterDates.Text = "Enter Dates";
            this.btnEnterDates.UseVisualStyleBackColor = true;
            this.btnEnterDates.Click += new System.EventHandler(this.btnEnterDates_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "&Esc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnEnterDates;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(595, 313);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnterDates);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxTripDatesOrData);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDeparture);
            this.Controls.Add(this.btnMap);
            this.Name = "Main";
            this.Text = "Travel App";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.ListBox listBoxTripDatesOrData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnterDates;
        private System.Windows.Forms.Button btnExit;

    }
}

