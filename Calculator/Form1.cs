using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double result;
        char operatorChoice;
        double number;

        private void button1_Click(object sender, EventArgs e)
        {
            ScanData();
            DoNextOperation(ref operatorChoice, ref number);
            Display(ref operatorChoice, ref number);
        }

        public void ScanData()
        {
            operatorChoice = Convert.ToChar(operatorTextBox.Text);
            number = Convert.ToInt32(NumberTextBox.Text);

        }

        public void DoNextOperation(ref char operatorChoice, ref double number)
        {
            switch (operatorChoice)
            {
                case'+':
                result = result + number;
            break;
                case '-':
                    result = result - number;
                    break;
                case '*':
                    result = result * number;
                    break;

                    case '/':
                    result = result / number;
                    break;

                case '^':
                    result = Math.Pow(result, number);
                    break;

                case 'q':
                    result = result + 0;
                    break;
            }
            
            
            
        }
        public void Display(ref char operatorChoice, ref double number)
        {
            switch(operatorChoice)
            {
                case '+':
                    ResultListBox.Items.Add("+ " + number);
                    ResultListBox.Items.Add("Result so fair is " + result);
                    break;

                case '-':
                    ResultListBox.Items.Add("- " + number);
                    ResultListBox.Items.Add("Result so fair is " + result);
                    break;

                case '*':
                    ResultListBox.Items.Add("* " + number);
                    ResultListBox.Items.Add("Result so fair is " + result);
                    break;

                case '/':
                    ResultListBox.Items.Add("/ " + number);
                    ResultListBox.Items.Add("Result so fair is " + result);
                    break;

                case '^':
                    ResultListBox.Items.Add("^ " + number);
                    ResultListBox.Items.Add("Result so fair is " + result);
                    break;

                case 'q':
                    ResultListBox.Items.Add("q " + number);
                    ResultListBox.Items.Add("Result so fair is " + result);
                    break;

            }
        }
    }
}
