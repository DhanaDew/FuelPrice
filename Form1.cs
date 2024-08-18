using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelPrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void driverNametextBox_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void petrol92radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (petrol92radioButton.Checked) 
            {
                priceOfLitertextBox.Text = "420";
                
            }
        }

        private void petrol95radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (petrol95radioButton.Checked)
            {
                priceOfLitertextBox.Text = "440";
                
            }
        }

        private void dieselradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dieselradioButton.Checked)
            {
                priceOfLitertextBox.Text = "400";
               
            }
        }

        private void amountToPaytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void noOfLiterstextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrWhiteSpace(driverNametextBox.Text))
                {
                    MessageBox.Show("Driver Name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    driverNametextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(vehicalNotextBox.Text))
                {
                    MessageBox.Show("Vehical No. is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    vehicalNotextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(noOfLiterstextBox.Text))
                {
                    MessageBox.Show("How much You want!?", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    noOfLiterstextBox.Focus();
                    return;
                }
                if (decimal.TryParse(noOfLiterstextBox.Text, out decimal liters) && decimal.TryParse(priceOfLitertextBox.Text, out decimal priceperliter))
                {
                    decimal totalAmount = liters * priceperliter;
                    amountToPaytextBox.Text = totalAmount.ToString();
                }
                else
                {
                    amountToPaytextBox.Text = String.Empty;
                }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            driverNametextBox.Clear();
            vehicalNotextBox.Clear();
            noOfLiterstextBox.Clear();
            priceOfLitertextBox.Clear();
            amountToPaytextBox.Clear();

            petrol92radioButton.Checked = false;
            petrol95radioButton.Checked = false;
            dieselradioButton.Checked = false;

            driverNametextBox.Focus();
        }
    }
}
