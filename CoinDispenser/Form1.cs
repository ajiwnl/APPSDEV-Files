using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinDispenser
{
    public partial class CoinDispenserForm : Form
    {
        public CoinDispenserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Variable Declarations
            int PurchasePriceIn, AmtTenderedIn, Change, FivePeso, OnePeso,
                TwentyFiveCent, TenCent, FiveCent, OneCent;
            
            //Parsing to convert String to int
            PurchasePriceIn = Int32.Parse(AmountInTxtbox.Text);
            AmtTenderedIn = Int32.Parse(AmtTenderedTxtbox.Text);

            //Computations
            Change = AmtTenderedIn - PurchasePriceIn;
            FivePeso = Change / 500;
            OnePeso= Change % 500 / 100;
            TwentyFiveCent= Change % 500 % 100 / 25;
            TenCent = Change % 500 % 100 % 25 /10;
            FiveCent = Change % 500 % 100 % 25 % 10 / 5;
            OneCent = Change % 500 % 100 % 25 % 10 % 5 / 1;

            //Output
            PurchasePriceLbl.Text = String.Format(CultureInfo.GetCultureInfo("en-PH"), "{0:c}", PurchasePriceIn / 100.0);
            AmtTenderedLbl.Text = String.Format(CultureInfo.GetCultureInfo("en-PH"), "{0:c}", AmtTenderedIn / 100.0);
            ChangeLbl.Text = String.Format(CultureInfo.GetCultureInfo("en-PH"), "{0:c}", Change/100.0);
            FivePesoLbl.Text = FivePeso.ToString();
            OnePesoLbl.Text = OnePeso.ToString();
            TwentyFiveCentLbl.Text = TwentyFiveCent.ToString(); 
            TenCentLbl.Text = TenCent.ToString();  
            FiveCentLbl.Text = FiveCent.ToString(); 
            OneCentLbl.Text = OneCent.ToString();

        }
    }
}
