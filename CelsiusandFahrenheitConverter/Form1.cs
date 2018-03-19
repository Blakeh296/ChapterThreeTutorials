using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsiusandFahrenheitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCeltoFahr_Click(object sender, EventArgs e)
        {
            // use a var for each 

            // will be input temp
            int cel;

            // will be conversion math
            int convertToFahr;

            try
            {
                // cell = user input text
                cel = int.Parse(textBox1.Text);

                // take that text value and do some math with converttoFahr
                convertToFahr = 9 / 5 * cel + 32;

                outPutLabel.Text = convertToFahr.ToString();
            }
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
            
        }

        private void btnFahrtoCel_Click(object sender, EventArgs e)
        {
            // will be input temp
            int fahr;
            // var for conversion math
            int convertToCel;

            try
            {
                // set fahr = to the user input
                fahr = int.Parse(textBox1.Text);
                // do conversion math with fahr variable with vonverttocell
                convertToCel = 9 / 5 * (fahr - 32);

                // output conversion to the user
                outPutLabel.Text = convertToCel.ToString();
            }
            catch
            {
                MessageBox.Show("error occured..");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // reset all
            textBox1.Text = " ";
            outPutLabel.Text = " ";
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            // if you started from the main menu this will take you back.
            // otherwise closes the application
            this.Close();
        }
    }
}
