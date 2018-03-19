using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesTaxandTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double salesTax;
            double countyTax;
            double totalOfSale;

            try
            {
                // multiply the variables by the various required amounts
                salesTax = double.Parse(tbPurchaseAmount.Text) * 0.04;
                countyTax = double.Parse(tbPurchaseAmount.Text) * 0.02;

                // adds everything together
                totalOfSale = double.Parse(tbPurchaseAmount.Text) + salesTax + countyTax;

                // outputs variables in the form of money "c"
                salesTaxlLabel.Text = salesTax.ToString("C");
                countyTaxLabel.Text = countyTax.ToString("C");
                totalLabel.Text = totalOfSale.ToString("C");
            }
            catch
            {
                MessageBox.Show("error occured..");
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear all fields
            salesTaxlLabel.Text = " ";
            countyTaxLabel.Text = " ";
            totalLabel.Text = " ";
            tbPurchaseAmount.Text = " ";
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            // if you started from the main menu this will take you back.
            // otherwise closes the application
            this.Close();
        }

        private void countyTaxLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
