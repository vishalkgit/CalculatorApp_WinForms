using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnsText.Enabled = false;
            AnsText.BorderStyle = BorderStyle.FixedSingle;

        }

        private void Addition_Click(object sender, EventArgs e)
        {
            double a, b;
            bool isNum1valid = double.TryParse(TxtBox1.Text, out a);
            bool isnum2valid = double.TryParse(TxtBox2.Text, out b);

            if(isNum1valid && isnum2valid)
            {
                double ans = a + b;
                AnsText.Text = ans.ToString();
                
            }
            else
            {

                
                MessageBox.Show("please enter valid numbers");
                TxtBox1.Clear();
                TxtBox2.Clear();

            }
           

        }

        private void TxtBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TxtBox1.Clear();
            TxtBox2.Clear();
            AnsText.Clear();
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            double a, b;
            bool isNum1Valid = double.TryParse(TxtBox1.Text, out a);
            bool isNum2Valid = double.TryParse(TxtBox2.Text, out b);

            if(isNum1Valid && isNum2Valid)
            {
                double ans = a - b;
                AnsText.Text = ans.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Number");
            }
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            double a, b;
            bool isNum1valid = double.TryParse(TxtBox1.Text, out a);
            bool isNum2Valid = double.TryParse(TxtBox2.Text, out b);

            if(isNum1valid && isNum2Valid)
            {
                double ans = a * b;
                AnsText.Text = ans.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Numbers");
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            double a, b;
            bool isNum1valid = double.TryParse(TxtBox1.Text, out a);
            bool isNum2Valid = double.TryParse(TxtBox2.Text, out b);

            if (b == 0)
            {
                MessageBox.Show("cant divide by zero");
                TxtBox2.Clear();
               AnsText.Clear();
                
            }
            else if (isNum1valid && isNum2Valid)
            {
                double ans = a / b;
                AnsText.Text = ans.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting application");
            Application.Exit();
        }
    }
}
