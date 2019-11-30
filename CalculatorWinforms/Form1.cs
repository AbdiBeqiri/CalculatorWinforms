using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinforms
{
    public partial class Form1 : Form
    {
        private bool operatorClicked = false;
        private decimal firstNumber;
        private decimal secondNumber;
        private decimal result;
        string _operator = string.Empty;
        string _valueOfButtonClicked = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button btnClicked = (sender as Button);
            _valueOfButtonClicked = btnClicked.Text;
            _operator = txtOperator.Text;


            switch (_valueOfButtonClicked)
            {
                case "+":
                    txtOperator.Text = "+";
                    operatorClicked = true;
                    break;

                case "-":
                    txtOperator.Text = "-";
                    operatorClicked = true;
                    break;

                case "*":
                    txtOperator.Text = "*";
                    operatorClicked = true;
                    break;

                case "/":
                    txtOperator.Text = "/";
                    operatorClicked = true;
                    break;

                case "C":
                    txtFirstOperand.Text = "";
                    txtSecondOperand.Text = "";
                    txtResult.Text = "";
                    txtOperator.Text = "";
                    firstNumber = -1;
                    secondNumber = -1;
                    result = -1;
                    operatorClicked = false;
                    break;

                case "CE":
                    if (!operatorClicked)
                    {
                        txtFirstOperand.Text = "";
                        firstNumber = -1;
                    }
                    else
                    {
                        txtSecondOperand.Text = "";
                        secondNumber = -1;
                        txtResult.Text = "";
                        result = -1;
                        txtOperator.Text = "";
                        _operator = "";
                        operatorClicked = false;
                    }
                    break;

                case "=":
                    if (txtFirstOperand.Text == "" || txtSecondOperand.Text == "")
                return;
            else
            {
                firstNumber = decimal.Parse(txtFirstOperand.Text);
                secondNumber = decimal.Parse(txtSecondOperand.Text);
            }
            _operator = txtOperator.Text;

            switch (_operator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    txtResult.Text = result.ToString();
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    txtResult.Text = result.ToString();
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    txtResult.Text = result.ToString();
                    break;
                case "/":
                    if (secondNumber == 0)
                        txtResult.Text = " Cannot divide by zero";
                    else
                    {
                        result = firstNumber / secondNumber;
                        txtResult.Text = result.ToString();
                    }
                    break;
                
                default:
                    txtResult.Text = "Operator empty!";
                    break;
            }
                    break;

                default:
                    if (!operatorClicked)
                        txtFirstOperand.Text += btnClicked.Text;
                    else
                        txtSecondOperand.Text += btnClicked.Text;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.NumPad0)
            {
                btn0.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                btn1.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                btn2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                btn3.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                btn4.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                btn5.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                btn6.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                btn7.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                btn8.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                btn9.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                btnMultiply.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                btnDivide.PerformClick();
            }
            if (e.KeyCode == Keys.Add)
            {
                btnPlus.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                btnMinus.PerformClick();
            }
            if (e.KeyCode == Keys.Return)
            {
                btnEquals.PerformClick();
            }

        }
    }
}