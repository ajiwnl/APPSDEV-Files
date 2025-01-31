using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCarCenterForm
{
    public partial class VBAutoCarCenterForm : Form
    {
        public VBAutoCarCenterForm()
        {
            InitializeComponent();
        }
        const double
            stereoSys = 425.76,
            leatherInt = 987.41,
            compNav = 1741.23,
            Standard = 0.00,
            Pearlized = 345.72,
            customDetail = 599.99,
            Tax = 0.08;

        double
            carPrice,
            tradeIN,
            accTotal = 0.00,
            finishTotal = 0.00,
            afTotal = 0.00,
            subTotal = 0.00,
            salesTax = 0.00,
            total = 0.00,
            amtDue = 0.00;

        private void CalculateBtn_Click(object sender, EventArgs e)
        {

            try {
                // Check if CarPriceTxtBox and TradeInTxtBox have valid inputs
                if (!double.TryParse(CarPriceTxtBox.Text, out carPrice) && !double.TryParse(TradeInTxtBox.Text, out tradeIN))
                {
                    throw new Exception("Invalid value for Car Price and Trade-in Allowance");
                }

                if (!double.TryParse(CarPriceTxtBox.Text, out carPrice))
                {
                    throw new Exception("Invalid value for Car Price");
                }

                if (!double.TryParse(TradeInTxtBox.Text, out tradeIN))
                {
                    throw new Exception("Invalid value for Trade-In Allowance");
                }
                //Calculate accessory and finish totals
                if (StereoSysChkBox.Checked)
                    {
                        accTotal += stereoSys;
                    }
                    if (LeatherIntChkBox.Checked)
                    {
                        accTotal += leatherInt;
                    }
                    if (CompNavChkBox.Checked)
                    {
                        accTotal += compNav;
                    }
                    if (StandRadBtn.Checked)
                    {
                        finishTotal += Standard;
                    }
                    else if (PearlRadBtn.Checked)
                    {
                        finishTotal += Pearlized;
                    }
                    else if (CustomRadBtn.Checked)
                    {
                        finishTotal += customDetail;
                    }
                    afTotal = accTotal + finishTotal;

                    //Calculate subtotal, sales tax, total, and amount due
                    subTotal = carPrice + afTotal - tradeIN;
                    salesTax = subTotal * Tax;
                    total = subTotal + salesTax;
                    amtDue = total;

                    //Display calculated values in the appropriate labels
                    AccNFinishlbl.Text = String.Format("{0:C}", afTotal);
                    SubTotalLbl.Text = String.Format("{0:C}", subTotal);
                    TaxLbl.Text = String.Format("{0:C}", salesTax);
                    TotalLbl.Text = String.Format("{0:C}", total);
                    AmtDueLbl.Text = String.Format("{0:C}", amtDue);

                }

            catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            //Reset the Radio buttons and Checkboxes into default .checked = false.
            if (StereoSysChkBox.Checked)
            {
                StereoSysChkBox.Checked = false;
            }
            if (LeatherIntChkBox.Checked)
            {
                LeatherIntChkBox.Checked = false;
            }
            if (CompNavChkBox.Checked)
            {
                CompNavChkBox.Checked = false;
            }
            if (StandRadBtn.Checked) { 
                StandRadBtn.Checked = false;
            }
            if (PearlRadBtn.Checked) { 
                PearlRadBtn.Checked = false;
            }
            if (CustomRadBtn.Checked) { 
                CustomRadBtn.Checked = false;
            }
            //Reset the all the labels into " "/empty strings
            CarPriceTxtBox.Text = String.Empty;
            TradeInTxtBox.Text = String.Empty;
            AccNFinishlbl.Text = String.Empty;
            SubTotalLbl.Text = String.Empty;
            TaxLbl.Text = String.Empty;
            TotalLbl.Text = String.Empty;
            AmtDueLbl.Text = String.Empty;

            //Reset all the datas to 0.00;
            accTotal = 0.00;
            finishTotal = 0.00;
            afTotal = 0.00;
            subTotal = 0.00;
            salesTax = 0.00;
            total = 0.00;
            amtDue = 0.00;

        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
