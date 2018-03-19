using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentenceBuilder
{
    public partial class F1SentenceBuilder : Form
    {
        
        public F1SentenceBuilder()
        {
            InitializeComponent();
        }

        private void F1SentenceBuilder_Load(object sender, EventArgs e)
        {

        }

        // all buttons set a variable equal to the label, then adds it to the existing total
        // of words
        private void btnLbl1_Click(object sender, EventArgs e)
        {
            string text;
            text = btnLbl1.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;

            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string text;
            text = label1.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string text;
            text = label2.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string text;
            text = label3.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string text;
            text = label4.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string text;
            text = label5.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string text;
            text = label6.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string text;
            text = label7.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string text;
            text = label8.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            string text;
            text = label9.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            string text;
            text = label10.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            string text;
            text = label11.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            string text;
            text = label12.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            string text;
            text = label13.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            string text;
            text = label14.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            string text;
            text = label15.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            string text;
            text = label23.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            string text;
            text = label16.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            string text;
            text = label17.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label22_Click(object sender, EventArgs e)
        {
            string text;
            text = label22.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            string text;
            text = label21.Text;
            outPutLabel.Text = outPutLabel.Text + " " + text;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            string text;
            text = " ";
            outPutLabel.Text = outPutLabel.Text + text;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            string text;
            text = ". ";
            outPutLabel.Text = outPutLabel.Text + text;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            string text;
            text = "! ";
            outPutLabel.Text = outPutLabel.Text + text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            outPutLabel.Text = " ";
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
