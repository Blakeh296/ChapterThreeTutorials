using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                nameFormatter.nameformatter var = new nameFormatter.nameformatter();
                var.Show();
            }
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TipTaxTotal.Form1 var = new TipTaxTotal.Form1();
                var.Show();
            }
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DistanceTraveled.Form1 var = new DistanceTraveled.Form1();
                var.Show();
            }
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                salesTaxandTotal.Form1 var = new salesTaxandTotal.Form1();
                var.Show();
            }
            catch
            {
                MessageBox.Show("Unknown error occured");
            }
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                CelsiusandFahrenheitConverter.Form1 var = new CelsiusandFahrenheitConverter.Form1();
                var.Show();
            }
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                BodyMassIndex.Form1 var = new BodyMassIndex.Form1();
                var.Show();
            }
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                SentenceBuilder.F1SentenceBuilder var = new SentenceBuilder.F1SentenceBuilder();
                var.Show();
            }
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                HowMuchInsurance.F1howMuchInsurance var = new HowMuchInsurance.F1howMuchInsurance();
                var.Show();
            }
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                CookieCalories.F1CookieCalories var = new CookieCalories.F1CookieCalories();
                var.Show();
            }
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                CalorieCounter.F1CalorieCounter var = new CalorieCounter.F1CalorieCounter();
                var.Show();
            }
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                AutomobileCosts.F1AutomobileCosts var = new AutomobileCosts.F1AutomobileCosts();
                var.Show();
            }
            catch
            {
                MessageBox.Show("Unknown error occured");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                PaintJobEstimator.F1PaintJobEstimator var = new PaintJobEstimator.F1PaintJobEstimator();
                var.Show();
            }
            catch
            {
                MessageBox.Show("Unknown error occured..");
            }
        }
    }
}
