using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {

        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || (isOperationPerformed))
            {
                textBox1_Result.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (textBox1_Result.Text.Contains("."))
                {
                    textBox1_Result.Text = textBox1_Result.Text + button.Text;
                }
            }
            else
            {
                textBox1_Result.Text = textBox1_Result.Text + button.Text;
            }
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button19.PerformClick();
                operationPerformed = button.Text;
                currentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox1_Result.Text);
                currentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "0";
            resultValue = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1_Result.Text = (resultValue + Double.Parse(textBox1_Result.Text)).ToString();
                    break;

                case "-":
                    textBox1_Result.Text = (resultValue - Double.Parse(textBox1_Result.Text)).ToString();
                    break;

                case "*":
                    textBox1_Result.Text = (resultValue * Double.Parse(textBox1_Result.Text)).ToString();
                    break;

                case "/":
                    textBox1_Result.Text = (resultValue / Double.Parse(textBox1_Result.Text)).ToString();
                    break;

                default:
                    break;

            }
            resultValue = Double.Parse(textBox1_Result.Text);
            currentOperation.Text = "";

        }
    }
}
