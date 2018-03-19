using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._4TestAverageApplication
{
    public partial class TestAverageApplication : Form
    {
        public TestAverageApplication()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double test1;   // Hold test score #1
            double test2;   // Hold test score #2
            double test3;   // Hold test score #3
            double average; // Hold the average test score

            try
            {
                // Get the three test scores
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // Calculate the average test score
                average = (test1 + test2 + test3) / 3.0;

                // Display the average score, with the output rounded to 1 decimal point
                averageLabel.Text = average.ToString("n1");
            }

            catch (Exception Ex)
            {
                // default error message 
                MessageBox.Show(Ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //  Clear the input and output controls
            test1TextBox.Text = " ";
            test2TextBox.Text = " ";
            test3TextBox.Text = " ";
            averageLabel.Text = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
