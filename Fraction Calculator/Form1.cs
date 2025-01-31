using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction_Calculator
{
    public partial class FractionCalculatorForm : Form
    {
        public FractionCalculatorForm()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            int num1, num2, denom1, denom2;

            try
            {

                Input(out num1, out num2, out denom1, out denom2);

                string selectedOpt = OptCmbBox.SelectedItem.ToString();

                FractionOpt frac1, frac2, add, sub, multiply, divide;
                FractionOperations(num1, num2, denom1, denom2, out frac1, out frac2);

                switch (selectedOpt)
                {
                    case "+":
                        add = frac1.Add(frac2);
                        MessageBox.Show($"Result: {add.num}/{add.denom}\nSimplified: {add.Simplified()}\nDecimal: {add.DecimalConversion()}");
                        break;
                    case "-":
                        sub = frac1.Subtract(frac2);
                        MessageBox.Show($"Result: {sub.num}/{sub.denom}\nSimplified: {sub.Simplified()}\nDecimal: {sub.DecimalConversion()}");
                        break;
                    case "x":
                        multiply = frac1.Multiply(frac2);
                        MessageBox.Show($"Result: {multiply.num}/{multiply.denom}\nSimplified: {multiply.Simplified()}\nDecimal: {multiply.DecimalConversion()}");
                        break;
                    case "÷":
                        divide = frac1.Divide(frac2);
                        MessageBox.Show($"Result: {divide.num}/{divide.denom}\nSimplified: {divide.Simplified()}\nDecimal: {divide.DecimalConversion()}");
                        break;



                }


            }
      
            catch (ArgumentException ex) {
                MessageBox.Show(ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Num1TxtBox.Clear();
                Num2TxtBox.Clear();
                Denom1TxtBox.Clear();
                Denom2TxtBox.Clear();
            }
            
        }

        private static void FractionOperations(int num1, int num2, int denom1, int denom2, out FractionOpt frac1, out FractionOpt frac2)
        {
            frac1 = new FractionOpt(num1, denom1);
            frac2 = new FractionOpt(num2, denom2);
        }

        private void Input(out int num1, out int num2, out int denom1, out int denom2)
        {
            if (!Int32.TryParse(Num1TxtBox.Text, out num1) || !Int32.TryParse(Num2TxtBox.Text, out num2) || !Int32.TryParse(Denom1TxtBox.Text, out denom1) || !Int32.TryParse(Denom2TxtBox.Text, out denom2)) {
                throw new FormatException("Enter a valid integers in all the fields");
            }
        }
    }
}
