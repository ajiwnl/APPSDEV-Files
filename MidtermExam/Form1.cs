using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            int[] myArray = {1,2,3,4,5};
            DoIt(myArray);
            for (int j = 0;j<myArray.Length;j++)
            str = str +" " + myArray[j]; 
         
            MessageBox.Show(str);
        }
        public void DoIt(int[] z) {
          z = null;
        }
    }
}
