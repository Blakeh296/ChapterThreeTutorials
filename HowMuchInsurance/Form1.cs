using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowMuchInsurance
{
    public partial class F1howMuchInsurance : Form
    {
        public F1howMuchInsurance()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double replacecost;
                double output;

                // var = textbox
                replacecost = double.Parse(textBox1.Text);

                // Multiplied by recommended insurrance ammount
                output = replacecost * 0.80;

                outPutLabel.Text = output.ToString("c");
            }

            catch
            {
                MessageBox.Show("A unknown ERROR occured..");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear all fields
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
