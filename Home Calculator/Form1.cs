using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_Calculator
{
    public partial class FinancialCalculatorForm : Form
    {
        public FinancialCalculatorForm()
        {
            InitializeComponent();
        }
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double homePrice = 0,
                   interestRate = 0,
                   yrsToPay = 0,
                   percent = 0,
                   downPayment,
                   financedAmount,
                   monthlyPayment,
                   monthlyRate,
                   totalAmount,
                   totalInterest;

            InputValues(ref homePrice, ref interestRate, ref yrsToPay, ref percent);
            DownPayment(homePrice, percent, out downPayment);
            FinancedAmount(homePrice, percent, downPayment, out financedAmount);
            MonthlyPayment(financedAmount, interestRate, out monthlyRate, out monthlyPayment, out totalAmount, yrsToPay);
            TotalInterest(financedAmount, downPayment, totalAmount, out totalInterest);
            DisplayResults(downPayment, financedAmount, monthlyPayment, totalInterest);
        }

        private void InputValues(ref double homePrice, ref double interestRate, ref double yrsToPay, ref double percent)
        {
            homePrice = double.Parse(HomePriceTxtBox.Text);
            interestRate = double.Parse(InterestRateTxtBox.Text);
            yrsToPay = double.Parse(YrsToPayTxtBox.Text);
            percent = double.Parse(PercentDPTxtBox.Text);
        }
        private double DownPayment(double homePrice, double percent, out double downPayment)
        {
            downPayment = (homePrice * percent) / 100;
            return downPayment;
        }

        private double FinancedAmount(double homePrice, double percent, double downPayment, out double financedAmount)
        {
            financedAmount = homePrice - downPayment;
            return financedAmount;
        }

        private void MonthlyPayment(double financedAmount, double interestRate, out double monthlyRate, out double monthlyPayment, out double totalAmount, double yrsToPay)
        {
            interestRate = interestRate / 100;
            monthlyRate = interestRate / 12.0;
            monthlyPayment = (financedAmount * monthlyRate) / (1 - Math.Pow(1 + monthlyRate, -360));
            totalAmount = (monthlyPayment * 12) * yrsToPay;
        }

        private double TotalInterest(double financedAmount, double downPayment, double totalAmount, out double totalInterest)
        {
            totalInterest = (totalAmount - financedAmount) - downPayment;
            return totalInterest;
        }

        private void DisplayResults(double downPayment, double financedAmount, double monthlyPayment, double totalInterest)
        {
            ListViewItem item = new ListViewItem(downPayment.ToString("C"));
            item.SubItems.Add(financedAmount.ToString("C"));
            item.SubItems.Add(monthlyPayment.ToString("C"));
            item.SubItems.Add(totalInterest.ToString("C"));
            OutputListView.Items.Add(item);
            HomePriceTxtBox.Clear();
            InterestRateTxtBox.Clear();
            YrsToPayTxtBox.Clear();
            PercentDPTxtBox.Clear();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            OutputListView.Items.Clear();
        }

    }
}
