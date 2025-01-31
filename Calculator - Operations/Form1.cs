using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator___Operations
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        double result = 0;
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            char operators = ' ';
            double number = 0;
            char[] operatorsComboBox = { '+', '-', '*', '^', '/', 'Q' };
            try
            {
                Input(ref operators, ref number, ref operatorsComboBox);
                Operation(ref operators, ref number);
                Display(ref operators, ref number);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero", "Arithmetic Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        public void Input(ref char operators, ref double number, ref char[] operatorsComboBox)
        {
            operators = operatorsComboBox[OperatorComboBox.SelectedIndex];
            if (!double.TryParse(InputTxtBox.Text, out number))
            {

                throw new Exception("Enter a valid Number");
            }
            //operators = operatorsComboBox[OperatorComboBox.SelectedIndex];
            //number = Convert.ToDouble(InputTxtBox.Text);
        }

        public void Operation(ref char operators, ref double number)
        {
            switch (operators)
            {
                case '+':
                    result = result + number;
                    break;
                case '-':
                    result = result - number;
                    break;
                case '*':
                    result = result * number;
                    break;
                case '^':
                    result = Math.Pow(result, number);
                    break;
                case '/':
                    if (number == 0)
                    {
                        throw new Exception("Cannot be divide by zero (0)");
                    }
                    else
                    {
                        result = result / number;
                    }
                    break;
                case 'Q':
                    result = result + 0;
                    break;
            }
        }

        public void Display(ref char operators, ref double number)
        {
            switch (operators)
            {
                case '+':
                    ResultListBox.Items.Add("+ " + number);
                    ResultListBox.Items.Add("Result: " + result);
                    break;
                case '-':
                    ResultListBox.Items.Add("- " + number);
                    ResultListBox.Items.Add("Result: " + result);
                    break;
                case '*':
                    ResultListBox.Items.Add("* " + number);
                    ResultListBox.Items.Add("Result: " + result);
                    break;
                case '/':
                    ResultListBox.Items.Add("/ " + number);
                    ResultListBox.Items.Add("Result: " + result);
                    break;
                case '^':
                    ResultListBox.Items.Add("^ " + number);
                    ResultListBox.Items.Add("Result: " + result);
                    break;
                case 'Q':
                    ResultListBox.Items.Add("Q " + number);
                    ResultListBox.Items.Add("Result: " + result);
                    break;
            }
        }
    }
}
