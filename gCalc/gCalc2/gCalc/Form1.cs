using System;
using System.Windows.Forms;

namespace gCalc
{
    public partial class Form1 : Form
    {
        string input = string.Empty;//declaration of empty string for storing user input
        string operand1 = string.Empty;//declaration of empty string for storing first operand
        string operand2 = string.Empty;//declaration of empty string for storing second operand
        char operation;//char for storing operation
        double result = 0.0;//calculated result

        public Form1()//default constructor made when class is to be instantiated to initialize the instance of the class(objtect)
        {
            InitializeComponent();//calls partial class in order to initialize components
        }

        private void Form1_Load(object sender, EventArgs e)//does not return anything(void)
        {

        }

        private void button17_Click(object sender, EventArgs e)//does not return anything(void)
        {
            this.textBox1.Text = string.Empty;//when button_17 is clicked the textbox is cleared or has empty string
            input = string.Empty;//the input variable is assigned an empty string

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//does not return anything(void)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            input += "0";//append zero to the input
            this.textBox1.Text += input;//append the value of input(now zero) to the textbox1
        }

        private void button2_Click(object sender, EventArgs e)
        {

            input += "2";
            this.textBox1.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            input += "1";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            input += "3";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            input += "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            input += "5";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            input += "6";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            input += "8";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            input += "9";
            this.textBox1.Text += input;
        }

        private void button15_Click(object sender, EventArgs e)//multiplication
        {
            operand1 = input;//operand1 takes the value of our input after taking above values(zero,one...)
            operation = '*';//operation assumes value of our button15(star)
            this.textBox1.Text += operation;//append the valu of our operation onto textBox1
            input = string.Empty;//clear the input of any value by assigning an empty string to enable it to be used to store other values
        }

        private void button16_Click(object sender, EventArgs e)//division
        {
            operand1 = input;
            operation = '/';
            this.textBox1.Text += operation;
            input = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)//subtraction
        {
            operand1 = input;
            operation = '-';
            this.textBox1.Text += operation;
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)//addition
        {
            operand1 = input;
            operation = '+';
            this.textBox1.Text += operation;
            input = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)//equals
        {
            operand2 = input;//assigning input to the second operand
            double num1, num2;
            double.TryParse(operand1, out num1);//trying to change value of operand1 which is a string into a double.The output is assigned to num1
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;//calculation using doubles
                textBox1.Text = result.ToString();//conversion of double into string and appending it to textBox1
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)//making sure if num2 is not equal to zero (we do not divide by zero)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Cannot divide by Zero!";//if num2 is equal to zero
                }

            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";//appending decimal to values in textBox1
            input = textBox1.Text;//taking values in textBox1 and assigning the to input

        }
    }

}
