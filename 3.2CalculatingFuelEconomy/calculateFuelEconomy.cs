using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateFuelEconomy
{
    public partial class calculateFuelEconomy : Form
    {
        public calculateFuelEconomy()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;       // To hold miles driven
            double gallons;     // To hold gallons used
            double mpg;         // To hold MPG
// Error handling start
            try
                {
                    // Get the miles driven and assign it to the miles variable
                    miles = double.Parse(milesTextBox.Text);

                    // Get the gallons used and assigne it to the gallons variable
                    gallons = double.Parse(gallonsTextBox.Text);

                    // Calculate MPG
                    mpg = miles / gallons;

                    // Display the MPG in the mgpLabel
                    mpgLabel.Text = mpg.ToString();
                }

             catch
                {
                    MessageBox.Show("An unknown error orrcured");
                }   
// End of error handling
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        
    }
}
