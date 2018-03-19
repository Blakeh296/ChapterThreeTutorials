using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileCosts
{
    public partial class F1AutomobileCosts : Form
    {
        public F1AutomobileCosts()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double lp;
            double i;
            double gas;
            double oil;
            double tires;
            double maint;
            double total;
            double annual;

            try
            {

                // Hold number values entered into textBoxes
                lp = double.Parse(textBox1.Text);
                i = double.Parse(textBox2.Text);
                gas = double.Parse(textBox3.Text);
                oil = double.Parse(textBox4.Text);
                tires = double.Parse(textBox5.Text);
                maint = double.Parse(textBox6.Text);

                // Total var adds them all up
                total = lp + i + gas + oil + tires + maint;

                // Annual Var takes the total  and * by how many months in a year
                annual = total * 12;

                // Display variablas from texboxes to output Labels
                outPutLabelMonthly.Text = total.ToString("c");

                // Display variablas from texboxes to output Labels
                outPutLabelAnnual.Text = annual.ToString("c");
            }
            catch
            {
                MessageBox.Show("Error occured..");
            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Sets all generated fields to nothing
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            outPutLabelAnnual.Text = " ";
            outPutLabelMonthly.Text = " ";
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            // if you started from the main menu this will take you back.
            // otherwise closes the application
            this.Close();
        }
    }
}
