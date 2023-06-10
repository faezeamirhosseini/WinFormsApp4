using System.Runtime.ExceptionServices;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double first_num;
        string operation;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != "")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }

        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != "")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != "")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != "")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != "")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != "")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != "")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != "")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != "")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "0";

        }

        private void add_Click(object sender, EventArgs e)
        {
            first_num = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "+";


        }

        private void sub_Click(object sender, EventArgs e)
        {
            first_num = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "-";

        }

        private void mul_Click(object sender, EventArgs e)
        {
            first_num = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "x";

        }

        private void div_Click(object sender, EventArgs e)
        {
            first_num = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "/";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double second_num = Convert.ToDouble(textBox1.Text);    
            double result;
            if(operation == "+")
            {
                result = first_num + second_num;
                textBox1.Text = Convert.ToString(result);
                first_num = result;
            }
            if (operation == "-")
            {
                result = first_num - second_num;
                textBox1.Text = Convert.ToString(result);
                first_num = result;
            }
            if(operation == "x")
            {
                result = second_num * first_num;
                textBox1.Text= Convert.ToString(result);
                first_num = result;
            }
            if(operation == "/")
            {
                if (second_num == 0)
                {
                    textBox1.Text = "Cannot divide ";

                }
                else 
                { 
                result = second_num / first_num;
                textBox1.Text = Convert.ToString(result);
                first_num = result;
                }
            }

        }
    }
}