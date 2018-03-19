using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nameFormatter
{
    public partial class nameformatter : Form
    {
        public nameformatter()
        {
            InitializeComponent();
        }



        



        
        

        private void fNameFormatter_Load(object sender, EventArgs e)
        {

        }


        
            

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear all fields
            outPutLabel.Text = " ";
            textBox1fn.Text = " ";
            textBox2mn.Text = " ";
            textBox3ln.Text = " ";
            tbpt.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // if you started from the main menu this will take you back.
            // otherwise closes the application
            this.Close();
        }

        
        private void btnFormat_Click(object sender, EventArgs e)
        {
            string name;
            try
            {
                // Names are CONCATENATED in various orders based on which radio button is selected
                if (radioButton1.Checked)
                {

                    name = tbpt.Text + " " + textBox1fn.Text + " " + textBox2mn.Text + " " + textBox3ln.Text;

                    outPutLabel.Text = name.ToString();
                }

                else if (radioButton2.Checked)
                {

                    name = textBox1fn.Text + " " + textBox2mn.Text + " " + textBox3ln.Text;

                    outPutLabel.Text = name;
                }
                else if (radioButton3.Checked)
                {

                    name = textBox1fn.Text + " " + textBox3ln.Text;

                    outPutLabel.Text = name;
                }

                else if (radioButton4.Checked)
                {

                    name = textBox3ln.Text + ", " + textBox1fn.Text + " " + textBox2mn.Text + ", " + tbpt.Text;
                    outPutLabel.Text = name;
                }

                else if (radioButton5.Checked)
                {

                    name = textBox3ln.Text + ", " + textBox1fn.Text + " " + textBox2mn.Text;
                    outPutLabel.Text = name;
                }

                else if (radioButton6.Checked)
                {

                    name = textBox3ln.Text + ", " + textBox1fn.Text;
                    outPutLabel.Text = name;
                }
            }
            catch
            {
                MessageBox.Show("Oops..");
            }

        }
    
    }

       
}
