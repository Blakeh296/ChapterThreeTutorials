using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight;
            double height;
            double height2;
            double bmi;

            try
            {
                // weight and height are saved into Variables from the textBoxes
                weight = double.Parse(textBox1.Text);
                height = double.Parse(textBox2.Text);

                // Var height Squared is made multiplying height and weight
                height2 = height * height;

                // Bmi var formulates final output
                bmi = weight * 703 / height2;

                // your BMI is displayed to the user
                outPutLabel.Text = bmi.ToString("0.00");
            }
            
            catch
            {
                MessageBox.Show("Unknown error, make sure to use numbers..");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // resets all fields
            outPutLabel.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            // if you started from the main menu this will take you back.
            // otherwise closes the application
            this.Close();
        }
    }
}
