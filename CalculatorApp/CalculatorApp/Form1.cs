using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userinput = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            calculatorDisplay.Text += ".";

        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userinput += "0";
            calculatorDisplay.Text += userinput;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userinput += "1";
            calculatorDisplay.Text += userinput;

        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userinput += "2";
            calculatorDisplay.Text += userinput;

        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userinput += "3";
            calculatorDisplay.Text += userinput;

        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userinput += "4";
            calculatorDisplay.Text += userinput;

        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userinput += "5";
            calculatorDisplay.Text += userinput;

        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userinput += "6";
            calculatorDisplay.Text += userinput;

        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userinput += "7";
            calculatorDisplay.Text += userinput;

        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userinput += "8";
            calculatorDisplay.Text += userinput;

        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userinput += "9";
            calculatorDisplay.Text += userinput;

        }

        private void ACButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userinput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            second = userinput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            //plus
            if (function == '+')
            {
                result = firstNum + secondNum;
                calculatorDisplay.Text = result.ToString();

            }
            //minus
            else if (function == '-')
            {
                result = firstNum - secondNum;
                calculatorDisplay.Text = result.ToString();

            }
            //divide
            else if (function == '/')
            {
                if (secondNum == '0') { calculatorDisplay.Text = "Math Error"; }
                else
                {
                    result = firstNum / secondNum;
                    calculatorDisplay.Text = result.ToString();

                }
            }
            //multiply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                calculatorDisplay.Text = result.ToString();

            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userinput;
            userinput = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userinput;
            userinput = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userinput;
            userinput = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userinput;
            userinput = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
