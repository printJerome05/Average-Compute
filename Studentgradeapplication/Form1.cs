using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentgradeapplication
{
    public partial class Form1 : Form
    {
        double num1, num2, num3, num4, num5, average;
        string name;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)


        {
            name = Convert.ToString(textBox6.Text);

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            num3 = Convert.ToDouble(textBox3.Text);
            num4 = Convert.ToDouble(textBox4.Text);
            num5 = Convert.ToDouble(textBox5.Text);

           

            


            average = (num1 + num2 + num3 + num4 + num5) / 5;

          

            

          

            if (average > 75)
            {
                label9.Text = ("The Student Passed.");

                label11.Text = ("The general average of "+ name.ToString() +" is " + System.Math.Round(average, 2));

                
            }
            else if (average < 75)
            {
                label9.Text = ("The Student Failed.");

                label11.Text = ("The general average of " + name.ToString() + " is " + System.Math.Round(average, 2));


            }



        }

       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
