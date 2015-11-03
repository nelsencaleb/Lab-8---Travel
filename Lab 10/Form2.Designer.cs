namespace Lab_10
{
    partial class Form2Map
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
            this.pictureBoxUnitestStatesRegions = new System.Windows.Forms.PictureBox();
            this.West = new System.Windows.Forms.CheckBox();
            this.MidWest = new System.Windows.Forms.CheckBox();
            this.SouthWest = new System.Windows.Forms.CheckBox();
            this.SouthEast = new System.Windows.Forms.CheckBox();
            this.NorthEast = new System.Windows.Forms.CheckBox();
            this.groupBoxCheckBoxPlacesToVisit = new System.Windows.Forms.GroupBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnitestStatesRegions)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUnitestStatesRegions
            // 
            this.pictureBoxUnitestStatesRegions.Image = global::Lab_10.Properties.Resources.regionsOfUsPic;
            this.pictureBoxUnitestStatesRegions.InitialImage = global::Lab_10.Properties.Resources.regionsOfUsPic;
            this.pictureBoxUnitestStatesRegions.Location = new System.Drawing.Point(-2, 12);
            this.pictureBoxUnitestStatesRegions.Name = "pictureBoxUnitestStatesRegions";
            this.pictureBoxUnitestStatesRegions.Size = new System.Drawing.Size(408, 309);
            this.pictureBoxUnitestStatesRegions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUnitestStatesRegions.TabIndex = 0;
            this.pictureBoxUnitestStatesRegions.TabStop = false;
            // 
            // West
            // 
            this.West.AutoSize = true;
            this.West.Location = new System.Drawing.Point(66, 116);
            this.West.Name = "West";
            this.West.Size = new System.Drawing.Size(15, 14);
            this.West.TabIndex = 1;
            this.West.UseVisualStyleBackColor = true;
            // 
            // MidWest
            // 
            this.MidWest.AutoSize = true;
            this.MidWest.Location = new System.Drawing.Point(225, 93);
            this.MidWest.Name = "MidWest";
            this.MidWest.Size = new System.Drawing.Size(15, 14);
            this.MidWest.TabIndex = 2;
            this.MidWest.UseVisualStyleBackColor = true;
            // 
            // SouthWest
            // 
            this.SouthWest.AutoSize = true;
            this.SouthWest.Location = new System.Drawing.Point(125, 198);
            this.SouthWest.Name = "SouthWest";
            this.SouthWest.Size = new System.Drawing.Size(15, 14);
            this.SouthWest.TabIndex = 3;
            this.SouthWest.UseVisualStyleBackColor = true;
            // 
            // SouthEast
            // 
            this.SouthEast.AutoSize = true;
            this.SouthEast.Location = new System.Drawing.Point(299, 176);
            this.SouthEast.Name = "SouthEast";
            this.SouthEast.Size = new System.Drawing.Size(15, 14);
            this.SouthEast.TabIndex = 4;
            this.SouthEast.UseVisualStyleBackColor = true;
            // 
            // NorthEast
            // 
            this.NorthEast.AutoSize = true;
            this.NorthEast.Location = new System.Drawing.Point(355, 89);
            this.NorthEast.Name = "NorthEast";
            this.NorthEast.Size = new System.Drawing.Size(15, 14);
            this.NorthEast.TabIndex = 5;
            this.NorthEast.UseVisualStyleBackColor = true;
            // 
            // groupBoxCheckBoxPlacesToVisit
            // 
            this.groupBoxCheckBoxPlacesToVisit.Location = new System.Drawing.Point(32, 72);
            this.groupBoxCheckBoxPlacesToVisit.Name = "groupBoxCheckBoxPlacesToVisit";
            this.groupBoxCheckBoxPlacesToVisit.Size = new System.Drawing.Size(359, 161);
            this.groupBoxCheckBoxPlacesToVisit.TabIndex = 6;
            this.groupBoxCheckBoxPlacesToVisit.TabStop = false;
            this.groupBoxCheckBoxPlacesToVisit.Text = "groupBox1";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(32, 343);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 7;
            this.buttonConfirm.Text = "&Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGoBack.Location = new System.Drawing.Point(295, 343);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 8;
            this.btnGoBack.Text = "Go &Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // Form2Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGoBack;
            this.ClientSize = new System.Drawing.Size(410, 389);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.NorthEast);
            this.Controls.Add(this.SouthEast);
            this.Controls.Add(this.SouthWest);
            this.Controls.Add(this.MidWest);
            this.Controls.Add(this.West);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.pictureBoxUnitestStatesRegions);
            this.Controls.Add(this.groupBoxCheckBoxPlacesToVisit);
            this.Enabled = false;
            this.Name = "Form2Map";
            this.Text = "Map ";
            this.Load += new System.EventHandler(this.Form2Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnitestStatesRegions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUnitestStatesRegions;
        private System.Windows.Forms.CheckBox West;
        private System.Windows.Forms.CheckBox MidWest;
        private System.Windows.Forms.CheckBox SouthWest;
        private System.Windows.Forms.CheckBox SouthEast;
        private System.Windows.Forms.CheckBox NorthEast;
        private System.Windows.Forms.GroupBox groupBoxCheckBoxPlacesToVisit;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button btnGoBack;
    }
}