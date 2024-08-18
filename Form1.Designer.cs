namespace FuelPrice
{
    partial class Form1
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
            this.driverName = new System.Windows.Forms.Label();
            this.vehicalNo = new System.Windows.Forms.Label();
            this.noOfLiters = new System.Windows.Forms.Label();
            this.driverNametextBox = new System.Windows.Forms.TextBox();
            this.vehicalNotextBox = new System.Windows.Forms.TextBox();
            this.noOfLiterstextBox = new System.Windows.Forms.TextBox();
            this.fualTypeDetailsgroupBox = new System.Windows.Forms.GroupBox();
            this.dieselradioButton = new System.Windows.Forms.RadioButton();
            this.petrol95radioButton = new System.Windows.Forms.RadioButton();
            this.petrol92radioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.priceOfLitertextBox = new System.Windows.Forms.TextBox();
            this.amountToPaytextBox = new System.Windows.Forms.TextBox();
            this.fualTypeDetailsgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // driverName
            // 
            this.driverName.AutoSize = true;
            this.driverName.Location = new System.Drawing.Point(59, 46);
            this.driverName.Name = "driverName";
            this.driverName.Size = new System.Drawing.Size(69, 13);
            this.driverName.TabIndex = 0;
            this.driverName.Text = "Driver Name:";
            this.driverName.Click += new System.EventHandler(this.driverNametextBox_Click);
            // 
            // vehicalNo
            // 
            this.vehicalNo.AutoSize = true;
            this.vehicalNo.Location = new System.Drawing.Point(59, 90);
            this.vehicalNo.Name = "vehicalNo";
            this.vehicalNo.Size = new System.Drawing.Size(62, 13);
            this.vehicalNo.TabIndex = 1;
            this.vehicalNo.Text = "Vehical No:";
            // 
            // noOfLiters
            // 
            this.noOfLiters.AutoSize = true;
            this.noOfLiters.Location = new System.Drawing.Point(59, 140);
            this.noOfLiters.Name = "noOfLiters";
            this.noOfLiters.Size = new System.Drawing.Size(122, 13);
            this.noOfLiters.TabIndex = 2;
            this.noOfLiters.Text = "No of Liters of Required:";
            // 
            // driverNametextBox
            // 
            this.driverNametextBox.Location = new System.Drawing.Point(223, 39);
            this.driverNametextBox.Name = "driverNametextBox";
            this.driverNametextBox.Size = new System.Drawing.Size(252, 20);
            this.driverNametextBox.TabIndex = 0;
            // 
            // vehicalNotextBox
            // 
            this.vehicalNotextBox.Location = new System.Drawing.Point(223, 87);
            this.vehicalNotextBox.Name = "vehicalNotextBox";
            this.vehicalNotextBox.Size = new System.Drawing.Size(153, 20);
            this.vehicalNotextBox.TabIndex = 1;
            this.vehicalNotextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // noOfLiterstextBox
            // 
            this.noOfLiterstextBox.Location = new System.Drawing.Point(223, 137);
            this.noOfLiterstextBox.Name = "noOfLiterstextBox";
            this.noOfLiterstextBox.Size = new System.Drawing.Size(153, 20);
            this.noOfLiterstextBox.TabIndex = 2;
            this.noOfLiterstextBox.TextChanged += new System.EventHandler(this.noOfLiterstextBox_TextChanged);
            // 
            // fualTypeDetailsgroupBox
            // 
            this.fualTypeDetailsgroupBox.Controls.Add(this.dieselradioButton);
            this.fualTypeDetailsgroupBox.Controls.Add(this.petrol95radioButton);
            this.fualTypeDetailsgroupBox.Controls.Add(this.petrol92radioButton);
            this.fualTypeDetailsgroupBox.Controls.Add(this.label1);
            this.fualTypeDetailsgroupBox.Location = new System.Drawing.Point(64, 193);
            this.fualTypeDetailsgroupBox.Name = "fualTypeDetailsgroupBox";
            this.fualTypeDetailsgroupBox.Size = new System.Drawing.Size(411, 129);
            this.fualTypeDetailsgroupBox.TabIndex = 6;
            this.fualTypeDetailsgroupBox.TabStop = false;
            this.fualTypeDetailsgroupBox.Text = "Fual Type Details";
            // 
            // dieselradioButton
            // 
            this.dieselradioButton.AutoSize = true;
            this.dieselradioButton.Location = new System.Drawing.Point(227, 106);
            this.dieselradioButton.Name = "dieselradioButton";
            this.dieselradioButton.Size = new System.Drawing.Size(54, 17);
            this.dieselradioButton.TabIndex = 2;
            this.dieselradioButton.TabStop = true;
            this.dieselradioButton.Text = "Diesel";
            this.dieselradioButton.UseVisualStyleBackColor = true;
            this.dieselradioButton.CheckedChanged += new System.EventHandler(this.dieselradioButton_CheckedChanged);
            // 
            // petrol95radioButton
            // 
            this.petrol95radioButton.AutoSize = true;
            this.petrol95radioButton.Location = new System.Drawing.Point(227, 63);
            this.petrol95radioButton.Name = "petrol95radioButton";
            this.petrol95radioButton.Size = new System.Drawing.Size(67, 17);
            this.petrol95radioButton.TabIndex = 1;
            this.petrol95radioButton.TabStop = true;
            this.petrol95radioButton.Text = "Petrol 95";
            this.petrol95radioButton.UseVisualStyleBackColor = true;
            this.petrol95radioButton.CheckedChanged += new System.EventHandler(this.petrol95radioButton_CheckedChanged);
            // 
            // petrol92radioButton
            // 
            this.petrol92radioButton.AutoSize = true;
            this.petrol92radioButton.Location = new System.Drawing.Point(227, 19);
            this.petrol92radioButton.Name = "petrol92radioButton";
            this.petrol92radioButton.Size = new System.Drawing.Size(67, 17);
            this.petrol92radioButton.TabIndex = 0;
            this.petrol92radioButton.TabStop = true;
            this.petrol92radioButton.Text = "Petrol 92";
            this.petrol92radioButton.UseVisualStyleBackColor = true;
            this.petrol92radioButton.CheckedChanged += new System.EventHandler(this.petrol92radioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Fual Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price of a Liter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount to Pay";
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(283, 450);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 3;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(400, 450);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 4;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // priceOfLitertextBox
            // 
            this.priceOfLitertextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.priceOfLitertextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceOfLitertextBox.Location = new System.Drawing.Point(223, 347);
            this.priceOfLitertextBox.Name = "priceOfLitertextBox";
            this.priceOfLitertextBox.ReadOnly = true;
            this.priceOfLitertextBox.Size = new System.Drawing.Size(100, 13);
            this.priceOfLitertextBox.TabIndex = 11;
            // 
            // amountToPaytextBox
            // 
            this.amountToPaytextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.amountToPaytextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountToPaytextBox.Location = new System.Drawing.Point(223, 400);
            this.amountToPaytextBox.Name = "amountToPaytextBox";
            this.amountToPaytextBox.ReadOnly = true;
            this.amountToPaytextBox.Size = new System.Drawing.Size(100, 13);
            this.amountToPaytextBox.TabIndex = 12;
            this.amountToPaytextBox.TextChanged += new System.EventHandler(this.amountToPaytextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 496);
            this.Controls.Add(this.amountToPaytextBox);
            this.Controls.Add(this.priceOfLitertextBox);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fualTypeDetailsgroupBox);
            this.Controls.Add(this.noOfLiterstextBox);
            this.Controls.Add(this.vehicalNotextBox);
            this.Controls.Add(this.driverNametextBox);
            this.Controls.Add(this.noOfLiters);
            this.Controls.Add(this.vehicalNo);
            this.Controls.Add(this.driverName);
            this.Name = "Form1";
            this.Text = "Fual Allocation";
            this.fualTypeDetailsgroupBox.ResumeLayout(false);
            this.fualTypeDetailsgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label driverName;
        private System.Windows.Forms.Label vehicalNo;
        private System.Windows.Forms.Label noOfLiters;
        private System.Windows.Forms.TextBox driverNametextBox;
        private System.Windows.Forms.TextBox vehicalNotextBox;
        private System.Windows.Forms.TextBox noOfLiterstextBox;
        private System.Windows.Forms.GroupBox fualTypeDetailsgroupBox;
        private System.Windows.Forms.RadioButton dieselradioButton;
        private System.Windows.Forms.RadioButton petrol95radioButton;
        private System.Windows.Forms.RadioButton petrol92radioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.TextBox priceOfLitertextBox;
        private System.Windows.Forms.TextBox amountToPaytextBox;
    }
}

