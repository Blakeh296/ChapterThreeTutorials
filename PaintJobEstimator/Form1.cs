using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintJobEstimator
{
    public partial class F1PaintJobEstimator : Form
    {
        public F1PaintJobEstimator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double oneGallon;
            double GOP;
            double laborhours;
            double laborcharges;
            double COP;
            double total;

            try
            {
                // one gallon covers 115 feet
                oneGallon = 115;
                // gallons of paint needed
                GOP = double.Parse(textBox1.Text) * 0.05;
                laborhours = GOP * 8;
                laborcharges = laborhours * 20;
                //cost of paint
                COP = double.Parse(textBox2.Text) * GOP;
                total = laborcharges + COP;

                // out put various variables to the user
                outPutGallons.Text = GOP.ToString();
                outPutLaborhours.Text = laborhours.ToString();
                outPutLaborCharges.Text = laborcharges.ToString("c");
                outPutCostofPaint.Text = COP.ToString("c");
                outPutTotal.Text = total.ToString("c");
            }
            catch
            {
                MessageBox.Show("Error occured..");
            }
            


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear all fields
            textBox1.Text = " ";
            textBox2.Text = " ";
            outPutGallons.Text = " ";
            outPutLaborhours.Text = " ";
            outPutLaborCharges.Text = " ";
            outPutCostofPaint.Text = " ";
            outPutTotal.Text = " ";
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
