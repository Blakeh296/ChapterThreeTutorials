using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieCalories
{
    public partial class F1CookieCalories : Form
    {
        public F1CookieCalories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // used to store user input
            int cookie;
            // stores calories per cookie
            int calories;

            try
            {
                // cookie = user input
                cookie = int.Parse(textBox1.Text);
                // times number of calories per cookie
                calories = cookie * 75;

                // display calories consumed to user
                outPutLabel.Text = calories.ToString() + " Calories";
            }
            catch
            {
                MessageBox.Show("error occured..");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // if you started from the main menu this will take you back.
            // otherwise closes the application
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // resets all fields
            textBox1.Text = " ";
            outPutLabel.Text = " ";
        }
    }
}
