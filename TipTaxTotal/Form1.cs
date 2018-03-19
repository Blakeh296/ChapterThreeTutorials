using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipTaxTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // sets variables
            double textbox;
            double tip;
            double tax;
            double total;
            try
            {
                textbox = double.Parse(textBox1.Text);

                tip = textbox * 0.15;
                tax = textbox * 0.07;
                // total = everything combined
                total = textbox + tax + tip;

                outPutTip.Text = tip.ToString("c");
                outPutTax.Text = tax.ToString("c");
                outPutTotal.Text = total.ToString("c");
            }
            catch
            {
                MessageBox.Show("Error...");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // closes app
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clears all fields
            textBox1.Text = " ";
            outPutTip.Text = " ";
            outPutTax.Text = " ";
            outPutTotal.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
