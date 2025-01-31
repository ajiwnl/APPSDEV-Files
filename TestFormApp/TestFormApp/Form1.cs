using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFormApp
{
    public partial class TestFormApp : Form
    {
        public TestFormApp()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to C# Mr./Ms. \n"+TextBox.Text, "Prompt Test Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
