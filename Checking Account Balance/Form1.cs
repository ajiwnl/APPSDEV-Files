using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checking_Account_Balance
{
    public partial class CheckAcctBalanceForm : Form
    {
        public CheckAcctBalanceForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        const int deduct = 50;
        double deposit = 0.00,
               check = 0.00,
               serviceCharge = 0.00,
               newBalance = 0.00,
               inputAmt;
        int numDep = 0,
            numCheck = 0;

        private void SummaryBtn_Click(object sender, EventArgs e)
        {
  
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            NoCheckLbl.Visible = true;
            NoDepLbl.Visible = true;
            DepositLbl.Visible = true;
            CheckLbl.Visible = true;

            NoDepLbl.Text = numDep.ToString();
            NoCheckLbl.Text = numCheck.ToString();
            DepositLbl.Text = String.Format(CultureInfo.GetCultureInfo("en-PH"), "{0:c}", deposit);
            CheckLbl.Text = String.Format(CultureInfo.GetCultureInfo("en-PH"), "{0:c}", check);
                    
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DepRadBtn.Checked = false;
            ServiceChargeRadBtn.Checked = false;
            CheckRadBtn.Checked = false;

            NewBalanceLbl.Text = String.Empty;
            NoCheckLbl.Text = String.Empty;
            NoDepLbl.Text = String.Empty;
            CheckLbl.Text = String.Empty;
            DepositLbl.Text = String.Empty; 
            InputAmtTxtBox.Text = String.Empty;

            deposit = 0.00;
            check = 0.00;
            serviceCharge = 0.00;
            newBalance = 0.00;

            numCheck= 0;
            numDep = 0;
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {

            try{

                if (!double.TryParse(InputAmtTxtBox.Text, out inputAmt)) {
                    throw new Exception("Input an amount, transaction cannot proceed");
                }

                if (DepRadBtn.Checked)
                {
                    deposit += inputAmt;
                    newBalance = deposit;

                    numDep++;
                }
                if (CheckRadBtn.Checked)
                {
                    if (inputAmt > newBalance)
                    {
                        newBalance -= deduct;
                        MessageBox.Show("Insufficient Balance the transaction cannot proceed", "Low on Balance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        check += inputAmt;
                        newBalance = check - deduct;
                        numCheck++;
                    }

                }
                if (ServiceChargeRadBtn.Checked)
                {
                    serviceCharge += inputAmt;
                    newBalance -= serviceCharge;


                }


                if (newBalance < 0)
                {
                    MessageBox.Show("Low on Balance the transaction cannot proceed", "No Balance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                NewBalanceLbl.Text = String.Format(CultureInfo.GetCultureInfo("en-PH"), "{0:c}", newBalance);

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           

        }
    }
}
