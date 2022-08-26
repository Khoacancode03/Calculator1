using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class calculator : Form
    {
        bool check;
        string operand;
        string previousData;

        public calculator()
        {
            InitializeComponent();
        }

        //Display numbers
        private void button1_Click(object sender, EventArgs e)
        {
            if (check)
                tbDisplay1.Clear();
            tbDisplay1.Text = tbDisplay1.Text + "1";
            check = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (check)
                tbDisplay1.Clear();
            tbDisplay1.Text = tbDisplay1.Text + "2";
            check = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (check)
                tbDisplay1.Clear();
            tbDisplay1.Text = tbDisplay1.Text + "3";
            check = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (check)
                tbDisplay1.Clear();
            tbDisplay1.Text = tbDisplay1.Text + "4";
            check = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (check)
                tbDisplay1.Clear();
            tbDisplay1.Text = tbDisplay1.Text + "5";
            check = false;
        }
        private void button6_Click_1(object sender, EventArgs e)

        {
            if (check)
                tbDisplay1.Clear();
            tbDisplay1.Text = tbDisplay1.Text + "6";
            check = false;
        }


        private void button7_Click_1(object sender, EventArgs e)

        {
            if (check)
                tbDisplay1.Clear();
            tbDisplay1.Text = tbDisplay1.Text + "7";
            check = false;
        }
        private void button8_Click_1(object sender, EventArgs e)


        {
            if (check)
                tbDisplay1.Clear();
            tbDisplay1.Text = tbDisplay1.Text + "8";
            check = false;
        }

        private void button9_Click_1(object sender, EventArgs e)

        {
            if (check)
                tbDisplay1.Clear();
            tbDisplay1.Text = tbDisplay1.Text + "9";
            check = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (check)
                tbDisplay1.Clear();
            tbDisplay1.Text = tbDisplay1.Text + "0";
            check = false;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (check)
                tbDisplay1.Clear();
            tbDisplay1.Text = tbDisplay1.Text + ".";
            check = false;
        }


        //Operand
        private void btnPlus_Click(object sender, EventArgs e)
        {
                previousData = tbDisplay1.Text;
                check = true;
                operand = "+";
                tbDisplay2.Text = Convert.ToString(Convert.ToDouble(previousData)) + "+";
   

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            previousData = tbDisplay1.Text;
            check = true;
            operand = "*";
            tbDisplay2.Text = Convert.ToString(Convert.ToDouble(previousData)) + "*";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            previousData = tbDisplay1.Text;
            check = true;
            tbDisplay2.Text = Convert.ToString(Convert.ToDouble(previousData)) + "-";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            previousData = tbDisplay1.Text;
            check = true;
            operand = "/";
            tbDisplay2.Text = Convert.ToString(Convert.ToDouble(previousData)) + "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            previousData = tbDisplay1.Text;
            check = true;
            operand = "reverse";
            tbDisplay2.Text = "1/"+(Convert.ToString(Convert.ToDouble(previousData)));
            tbDisplay1.Text = Convert.ToString(1/ Convert.ToDouble(previousData));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            previousData = tbDisplay1.Text;
            check = true;
            tbDisplay2.Text = (Convert.ToString(Convert.ToDouble(previousData)))+ "*" +Convert.ToString(Convert.ToDouble(previousData));
            tbDisplay1.Text = Convert.ToString(Convert.ToDouble(previousData) * Convert.ToDouble(previousData));
        }


        private void button24_Click(object sender, EventArgs e)
        {
            previousData = tbDisplay1.Text;
            check = true;
            tbDisplay2.Text = "sqr" + ((Convert.ToString(Convert.ToDouble(previousData))));
            tbDisplay1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(previousData)));

        }


        //Calculating
        double x, y;


        private void btnEqual_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(previousData);
            y = Convert.ToDouble(tbDisplay1.Text);
            if (operand == "+")
            {
                tbDisplay2.Text += Convert.ToString(y);
                tbDisplay1.Text = Convert.ToString(x + y);
            }
            if (operand == "-")
            {
                tbDisplay2.Text += Convert.ToString(y);
                tbDisplay1.Text = Convert.ToString(x - y);
            }
            if (operand == "*")
            {
                tbDisplay2.Text += Convert.ToString(y);
                tbDisplay1.Text = Convert.ToString(x * y);
            }
            if (operand == "/")
            {
                tbDisplay2.Text += Convert.ToString(y);
                if (y != 0)
                tbDisplay1.Text = Convert.ToString(x / y);
                else 
                    tbDisplay1.Text = "Cannot Divide by Zero";
            }
        }

        

        //Delete
        private void btnC_Click(object sender, EventArgs e)
        {
            tbDisplay1.Clear();
            tbDisplay2.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbDisplay2.Clear();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbDisplay1.Clear();
        }

        


        //Button +/- and %

        private void button14_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbDisplay1.Text);
            if (a > 0)
                tbDisplay1.Text = "-" + tbDisplay1.Text;
            else
            {   
                tbDisplay1.Text = Convert.ToString(-a);

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tbDisplay1.Text = Convert.ToString(Convert.ToDouble(tbDisplay1.Text) / 100);

        }





    }
}
