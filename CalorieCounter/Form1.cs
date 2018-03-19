using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class F1CalorieCounter : Form
    {
        public F1CalorieCounter()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int ban;
            int current;
            int output;
            try
            {
                ban = 115;
                current = int.Parse(outPutLabel.Text);
                output = ban + current;
                outPutLabel.Text = output.ToString();
            }
            
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int appl;
            int current;
            int output;

            try
            {
                appl = 80;

                current = int.Parse(outPutLabel.Text);
                output = appl + current;
                outPutLabel.Text = output.ToString();
            }
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int oran;
            int current;
            int output;

            try
            {
                oran = 90;
                current = int.Parse(outPutLabel.Text);
                output = oran + current;
                outPutLabel.Text = output.ToString();
            }
            catch
            {
                MessageBox.Show("Unknown error occured");
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Var pair stores amount of calories for a pear
            int pear;
            // Var current first sees what the value is before it outputs it
            int current;
            // Var output will be final product
            int output;

            try
            {

            }
            catch
            {
                // Sets Var pear calorie count
                pear = 120;
                // current = output label total
                current = int.Parse(outPutLabel.Text);
                // output adds it to the value already present
                output = pear + current;
                // displays new total to the user
                outPutLabel.Text = output.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // resets counter
            outPutLabel.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // if you started from the main menu this will take you back.
            // otherwise closes the application
            this.Close();
        }
    }
}
