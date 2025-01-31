using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaysCalculator
{
    public partial class DaysCalculatorForm : Form
    {
        public DaysCalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            int DAYSINYEAR = 365;
            byte YrInput;
            int DaysInYr;

            try {

                if (!byte.TryParse(YrInputTxtbox.Text, out YrInput))
                {
                    throw new Exception("Max input is only 255");
                }
                DaysInYr = YrInput * DAYSINYEAR;
                DaysLbl.Text = DaysInYr.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        
  


        }
    }
}
