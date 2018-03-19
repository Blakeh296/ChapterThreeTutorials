using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceTraveled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            // if you started from the main menu this will take you back.
            // otherwise closes the application
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear all fields
            textBox1.Text = " ";
            outPutDistanceTraveled.Text = " ";
        }

        private void btnFiveHr_Click(object sender, EventArgs e)
        {
          int  speed;
            int time;
            int distance;

            try
            {
                // speed = user input
                speed = int.Parse(textBox1.Text);
                // time is set per box
                time = 5;
                // distance = speed * time
                distance = speed * time;

                outPutDistanceTraveled.Text = distance.ToString() + " Miles";
            }
            catch
            {
                MessageBox.Show("error occured..");
            }

            
        }

        private void btnEightHrs_Click(object sender, EventArgs e)
        {
            int speed;
            int time;
            int distance;

            try
            {
                speed = int.Parse(textBox1.Text);
                time = 8;
                distance = speed * time;

                outPutDistanceTraveled.Text = distance.ToString() + " Miles";
            }
            catch
            {
                MessageBox.Show("error occured..");
            }
        }

        private void btnTwelveHrs_Click(object sender, EventArgs e)
        {
            int speed;
            int time;
            int distance;

            try
            {
                speed = int.Parse(textBox1.Text);
                time = 12;
                distance = speed * time;

                outPutDistanceTraveled.Text = distance.ToString() + " Miles";
            }
            catch
            {

                MessageBox.Show("error..");
                
            }
            
        }
    }
}
