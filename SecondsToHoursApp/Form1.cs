using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondsToHoursApp
{
    public partial class SecondsConverter : Form
    {
        public SecondsConverter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int HRSINSECS = 3600;
            const int MINSINSECS = 60;
            long SecondsIn = long.Parse(SecondsIntxtBox.Text);
            int HoursOut, MinutesOut, SecondsOut;

            HoursOut = (int) SecondsIn / HRSINSECS;
            MinutesOut = (int) (SecondsIn % HRSINSECS)/MINSINSECS;
            SecondsOut = (int) SecondsIn % MINSINSECS;

            HrsOuttxtBox.Text = HoursOut.ToString();
            MinsOuttxtBox.Text = MinutesOut.ToString();
            SecsOuttxtBox.Text = SecondsOut.ToString();

        }
    }
}
