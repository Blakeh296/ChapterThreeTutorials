using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPriceCalculator
{
    public partial class SalePriceCalculator : Form
    {
        public SalePriceCalculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;      // The item's original price
            decimal discountPercentage; // The discount percentage
            decimal discountAmount;     // The amount of the discount
            decimal salePrice;          // The item's sale price

            try
            {
                // Get the item's original price.
                originalPrice = decimal.Parse(originalPriceTextBox.Text);

                // Get the discount percentage.
                discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

                // Move the percentage's decimal point left two spaces.
                discountPercentage = discountPercentage / 100;

                // Calculate the amount of the discount
                discountAmount = originalPrice * discountPercentage;

                // Calculate the sale price
                salePrice = originalPrice - discountAmount;

                // Display the sale price
                salePriceLabel.Text = salePrice.ToString("c");
            }

            catch
            {
                MessageBox.Show("An unknown error orrured");
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
