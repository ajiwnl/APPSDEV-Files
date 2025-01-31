using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bagel_Menu.Bagel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bagel_Menu
{
    public partial class BakeryBagelForm : Form
    {
        public BakeryBagelForm()
        {
            InitializeComponent();
            SpinRadBtn.Checked = false;
            ChefRadBtn.Checked = false;
            ColaRadBtn.Checked = false;
            CSRadBtn.Checked = false;
        }

        private double defBagelPrice = 2.25;
        private double loxPrice = 1.20;
        private double ccPrice = 1.00;
        private double spinachPrice = 2.75;
        private double chefPrice = 3.25;
        private double colaPrice = 1.25;
        private double creamSodaPrice = 1.25;
        private double totalBagel = 0.00;
        private double total = 0.00;

        private void TotalBtn_Click(object sender, EventArgs e)
        {
            double bagelTotal = Convert.ToDouble(bagelPrice.Text);
            double saladTotal = Convert.ToDouble(saladPrice.Text);
            double sodaTotal = Convert.ToDouble(sodaPrice.Text);

            total = bagelTotal + saladTotal + sodaTotal;
            totalPrice.Text = total.ToString("0.##");

            ClearSelection();
        }


        private void BagCbox_CheckedChanged(object sender, EventArgs e)
        {
            if (BagCbox.Checked)
            {
                BagelGBox.Visible = true;
                totalBagel += defBagelPrice;
                bagelPrice.Text = totalBagel.ToString("0.##");
            }
            else
            {
                BagelGBox.Visible = false;
                totalBagel -= defBagelPrice;
                bagelPrice.Text = totalBagel.ToString("0.##");
            }
        }

        private void SalCbox_CheckedChanged(object sender, EventArgs e)
        {
            if (SalCbox.Checked)
            {
                SaladGBox.Visible = true;
            }
            else
            {
                SaladGBox.Visible = false;
                saladPrice.Text = "0";
                SpinRadBtn.Checked = false;
                ChefRadBtn.Checked = false;
            }
        }
        private void SodaCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SodaCBox.Checked)
            {
                SodaGBox.Visible = true;
            }
            else
            {
                SodaGBox.Visible = false;
                sodaPrice.Text = "0";
                ColaRadBtn.Checked = false;
                CSRadBtn.Checked = false;

            }
        }
        private void LoxCbox_CheckedChanged(object sender, EventArgs e)
        {
            if (LoxCbox.Checked)
            {
                totalBagel += loxPrice;
                bagelPrice.Text = totalBagel.ToString("0.##");
            }
            else
            {
                totalBagel -= loxPrice;
                bagelPrice.Text = totalBagel.ToString("0.##");

            }

        }
        private void CCCbox_CheckedChanged(object sender, EventArgs e)
        {
            if (CCCbox.Checked)
            {
                totalBagel += ccPrice;
                bagelPrice.Text = totalBagel.ToString("0.##");
            }
            else
            {
                totalBagel -= ccPrice;
                bagelPrice.Text = totalBagel.ToString("0.##");

            }
        }

        private void SpinRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SpinRadBtn.Checked)
                saladPrice.Text = spinachPrice.ToString("0.##");
        }

        private void ChefRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ChefRadBtn.Checked)
                saladPrice.Text = chefPrice.ToString("0.##");
        }

        private void ColaRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaRadBtn.Checked)
                sodaPrice.Text = colaPrice.ToString("0.##");
        }

        private void CSRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CSRadBtn.Checked)
                sodaPrice.Text = creamSodaPrice.ToString("0.##");
        }

        private void ClearSelection()
        {
            BagCbox.Checked = false;
            SalCbox.Checked = false;
            SodaCBox.Checked = false;
            SpinRadBtn.Checked = false;
            ChefRadBtn.Checked = false;
            ColaRadBtn.Checked = false;
            CSRadBtn.Checked = false;
            bagelPrice.Text = "0";
            saladPrice.Text = "0";
            sodaPrice.Text = "0";

        }

    }
}
