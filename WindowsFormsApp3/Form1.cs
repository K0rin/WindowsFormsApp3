using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double classA = 0;
            double classB = 0;
            double classC = 0;
            string errorList="";
            try 
            {
                classA = double.Parse(textBox1.Text)*15;
                label10.Text = classA.ToString()+" $";
            } 
            catch 
            {
                if (textBox1.Text.Equals(""))
                {
                    errorList = "Class A has no value \n";
                }
                else 
                {
                    errorList = "Class A has wrong value \n";
                }               
            }
            try
            {
                classB = double.Parse(textBox2.Text) * 12;
                label11.Text = classB.ToString() + " $";
            }
            catch
            {
                if (textBox2.Text.Equals("")) 
                {
                    errorList = errorList + "Class B has no value \n";
                }
                else 
                {
                    errorList = errorList + "Class B has wrong value \n";
                }                   
            }
            try
            {
                classC = double.Parse(textBox3.Text) * 9;
                label12.Text = classC.ToString() + " $";
            }
            catch
            {
                if (textBox3.Text.Equals(""))
                {
                    errorList = errorList + "Class C has no value \n";
                }
                else
                {
                    errorList = errorList + "Class C has wrong value \n";
                }
            }
            if (errorList.Equals(""))
            {
                double summ = classA + classB + classC;
                label14.Text = summ.ToString()+" $";
            }
            else 
            {
                MessageBox.Show(errorList);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label14.Text = "";
        }
    }
}
