using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_Calculator
{
    public partial class DepreciationCalculator : Form
    {
        public DepreciationCalculator()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            double initialCost, salvageValue;
            int life;
            Input(out initialCost, out salvageValue, out life);

            if (SLNRadBtn.Checked == true)
            {
                OutputListView.Items.Clear();
                SLN(initialCost, salvageValue, life);
            }

            if (SYDRadBtn.Checked == true)
            {
                OutputListView.Items.Clear();
                SYD(initialCost, salvageValue, life);
            }

            if (DBRadBtn.Checked == true)
            {
                OutputListView.Items.Clear();
                DB(initialCost, salvageValue, life);
            }

            if (DDBRadBtn.Checked == true)
            {
                OutputListView.Items.Clear();
                DBB(initialCost, salvageValue, life);
            }
        }

        private void Input(out double initialCost, out double salvageValue, out int life)
        {
            try
            {
                initialCost = double.Parse(InitialCostTxtBox.Text);
                salvageValue = double.Parse(SalvageValueTxtBox.Text);
                life = Int32.Parse(LifeTxtBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                initialCost = 0;
                salvageValue = 0;
                life = 0;
                InitialCostTxtBox.Clear();
                SalvageValueTxtBox.Clear();
                LifeTxtBox.Clear();
            }
        }
        private void SLN(double initialCost, double salvageValue, int life)
        {
            double depExpense;
            int remainingLife;

            for (int i = 1; i <= life; i++)
            {
                remainingLife = life - i + 1;
                depExpense = (initialCost - salvageValue) / remainingLife;
                initialCost = initialCost - depExpense;

                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(depExpense.ToString("C"));
                item.SubItems.Add(initialCost.ToString("C"));
                OutputListView.Items.Add(item);
            }
        }
        private void SYD(double initialCost, double salvageValue, int life)
        {
            double totalDepCost = initialCost - salvageValue;
            int remainingLife;
            int sumofYears = (life * (life + 1)) / 2;
            double depreciationRate;
            double depExpense;

            for (int i = 1; i <= life; i++)
            {
                remainingLife = life - i + 1;
                depreciationRate = (double)remainingLife / sumofYears;
                depExpense = depreciationRate * totalDepCost;
                initialCost -= depExpense;

                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(depExpense.ToString("C"));
                item.SubItems.Add(initialCost.ToString("C"));
                OutputListView.Items.Add(item);
            }
        }

        private void DB(double initialCost, double salvageValue, int life)
        {
            const double declineRate = 1.5;

            double depRate = 1.0 / life * declineRate;
            double depExpense;
            int remainingLife;

            for (int i = 1; i <= life; i++)
            {
                remainingLife = life - i + 1;
                depExpense = initialCost * depRate;
                if (initialCost - depExpense < salvageValue)
                {
                    depExpense = initialCost - salvageValue;
                    initialCost = salvageValue;
                }
                else
                {
                    initialCost -= depExpense;
                }

                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(depExpense.ToString("C"));
                item.SubItems.Add(initialCost.ToString("C"));
                OutputListView.Items.Add(item);
            }
        }
        private void DBB(double initialCost, double salvageValue, int life)
        {
            OutputListView.Items.Clear();

            const double declineRate = 2.0;

            double depRate = 1.0 / life * declineRate;
            double depExpense;
            int remainingLife;

            for (int i = 1; i <= life; i++)
            {
                remainingLife = life - i + 1;
                depExpense = initialCost * depRate;
                if (initialCost - depExpense < salvageValue)
                {
                    depExpense = initialCost - salvageValue;
                    initialCost = salvageValue;
                }
                else
                {
                    initialCost -= depExpense;
                }

                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(depExpense.ToString("C"));
                item.SubItems.Add(initialCost.ToString("C"));
                OutputListView.Items.Add(item);
            }
        }
    }
}
