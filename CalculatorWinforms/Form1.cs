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
        private int firstNumber;
        private int secondNumber;
        private int result;
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
                firstNumber = int.Parse(txtFirstOperand.Text);
                secondNumber = int.Parse(txtSecondOperand.Text);
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
    }
}