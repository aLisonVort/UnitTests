using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{

    public partial class CalculatorForm : Form

    {

        string input = string.Empty;

        string operand1 = string.Empty;

        string operand2 = string.Empty;

        char operation;

        double result = 0.0;

        public CalculatorForm(bool initialaze=false)

        {
            if(initialaze)
                InitializeComponent();

        }

        public string AddOperation(string operand1, string operand2)
        {
            double num1, num2;
            num1 = ParseString(operand1);
            num2 = ParseString(operand2);
            return (num1 + num2).ToString();
        }
        public string MinusOperation(string operand1, string operand2)
        {
            double num1, num2;
            num1 = ParseString(operand1);
            num2 = ParseString(operand2);
            return (num1 - num2).ToString();
        }
        public string DivideOperation(string operand1, string operand2)
        {
            double num1, num2;
            num1 = ParseString(operand1);
            num2 = ParseString(operand2);
            var res = num1 / num2;
            return res.ToString();
        }
        public string MultiplyOperation(string operand1, string operand2)
        {
            double num1, num2;
            num1 = ParseString(operand1);
            num2 = ParseString(operand2);
            return (num1 * num2).ToString();
        }

        public double ParseString(string str)
        {
            double num1;
            double.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out num1);
            return num1;
        }


        private void One_Click(object sender, EventArgs e)

        {

            this.textBox1.Text = "";

            input += "1";

            this.textBox1.Text += input;

        }

        private void Two_Click(object sender, EventArgs e)

        {

            this.textBox1.Text = "";

            input += "2";

            this.textBox1.Text += input;

        }

        private void Three_Click(object sender, EventArgs e)

        {

            this.textBox1.Text = "";

            input += "3";

            this.textBox1.Text += input;

        }

        private void Four_Click(object sender, EventArgs e)

        {

            this.textBox1.Text = "";

            input += "4";

            this.textBox1.Text += input;

        }

        private void Five_Click(object sender, EventArgs e)

        {

            this.textBox1.Text = "";

            input += "5";

            this.textBox1.Text += input;

        }

        private void Six_Click(object sender, EventArgs e)

        {

            this.textBox1.Text = "";

            input += "6";

            this.textBox1.Text += input;

        }

        private void Seven_Click(object sender, EventArgs e)

        {

            this.textBox1.Text = "";

            input += "7";

            this.textBox1.Text += input;

        }

        private void Eight_Click(object sender, EventArgs e)

        {

            this.textBox1.Text = "";

            input += "8";

            this.textBox1.Text += input;

        }

        private void Nine_Click(object sender, EventArgs e)

        {

            this.textBox1.Text = "";

            input += "9";

            this.textBox1.Text += input;

        }

        private void Zero_Click(object sender, EventArgs e)

        {

            this.textBox1.Text = "";

            input += "0";

            this.textBox1.Text += input;

        }

        private void Dot_Click(object sender, EventArgs e)

        {

            this.textBox1.Text = "";

            input += ".";

            this.textBox1.Text += input;

        }

        private void clear_Click(object sender, EventArgs e)

        {

            input += "C";

            this.textBox1.Text = "";

            this.input = string.Empty;

            this.operand1 = string.Empty;

            this.operand2 = string.Empty;

        }

        private void Divide_Click(object sender, EventArgs e)

        {

            operand1 = input;

            operation = char.Parse("/");

            input = string.Empty;

        }

        private void Multiply_Click(object sender, EventArgs e)

        {

            operand1 = input;
            operation = char.Parse("*");

            input = string.Empty;

        }

        private void Minus_Click(object sender, EventArgs e)

        {

            operand1 = input;

            operation = char.Parse("-");

            input = string.Empty;

        }

        private void Plus_Click(object sender, EventArgs e)

        {

            operand1 = input;

            operation = char.Parse("+");

            input = string.Empty;

        }


        

        private void Equals_Click(object sender, EventArgs e)

        {

            operand2 = input;

            if (operation == '+')

            {

                textBox1.Text = AddOperation(operand1, operand2);

            }

            else if (operation == '-')

            {

                textBox1.Text = MinusOperation(operand1, operand2);

            }

            else if (operation == '*')

            {

                textBox1.Text = MultiplyOperation(operand1, operand2);

            }

            else if (operation == '/')

            {
                double.TryParse(operand2, out double number);
                if (number != 0)

                {

                    textBox1.Text = DivideOperation(operand1, operand2);

                }

                else

                {

                    textBox1.Text = "DIV/Zero!";

                }

            }

        }

    }

}

