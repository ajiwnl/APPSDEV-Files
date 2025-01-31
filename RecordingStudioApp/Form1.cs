using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordingStudioApp
{
    public partial class RecordingStudioRentalForm : Form
    {
        public RecordingStudioRentalForm()
        {
            InitializeComponent();
        }

        private void CurrentBand(object sender, EventArgs e)
        {
            CurrentBandLbl.Text = BandNametxtbox.Text;
        }

        const double MINTOHR = 60.0;
        const int RATE = 200;
        byte count = 0;
        int MinutesIN;
        double currentCharge = 0, totalCharge = 0, avg = 0;


        private void CurrentCharge(object sender, EventArgs e)
        {
            try {
               MinutesIN = Convert.ToInt32(RentalMintxtbox.Text);
                currentCharge = (MinutesIN / MINTOHR) * RATE;
                CurrentChargeLbl.Text = String.Format(CultureInfo.GetCultureInfo("en-PH"),
                                 "{0:c}", currentCharge);
            }
            catch(Exception ex) {
                
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            count++;
            totalCharge += currentCharge;
            avg = totalCharge/ count;

            TotalBandLbl.Text = count.ToString();
            TotalChargeLbl.Text = String.Format(CultureInfo.GetCultureInfo("en-PH"),
                                 "{0:c}", totalCharge);
            AvgChargeLbl.Text = String.Format(CultureInfo.GetCultureInfo("en-PH"),
                                 "{0:c}", avg);
        }

    }
}
