using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorHW
{
    enum operation
    {
        Addition,
        Subtraction,
        Multiply,
        Divide,
        Square,
        None
    }

    public partial class Form1 : Form
    {

        private operation myOperator = operation.None;
        private bool isOperationPerformanced = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "0") || (isOperationPerformanced))
            {
                textBox1.Clear();
            }
            textBox1.Text += ((Button)sender).Text;
            //OR
            //Button button = (Button)sender;
            //textBox1.Text = textBox1.Text + button.Text;
            isOperationPerformanced = false;
        }



        private void button17_Click(object sender, EventArgs e)
        {
            if (myOperator == operation.None)
            {
                Calculator.FirstNum = double.Parse(textBox1.Text);
            }

            else
                Calculator.SecondNum = double.Parse(textBox1.Text);
            {
                switch (myOperator)
                {
                    case operation.Addition:
                        Calculator.FirstNum = Calculator.Addition();
                        break;

                    case operation.Subtraction:
                        Calculator.FirstNum = Calculator.Subtraction();
                        break;

                    case operation.Multiply:
                        Calculator.FirstNum = Calculator.Multiply();
                        break;

                    case operation.Divide:
                        Calculator.FirstNum = Calculator.Divided();
                        break;

                    case operation.Square:
                        Calculator.FirstNum = Calculator.Square();
                        break;
                }
            }
            textBox1.Text = Calculator.FirstNum.ToString();
            isOperationPerformanced = true;

        }

        private void Clearbutton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myOperator = operation.Divide;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myOperator = operation.Multiply;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myOperator = operation.Subtraction;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            myOperator = operation.Addition;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myOperator = operation.Square;
        }
    }
}

