using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            //input
            int len, wid, height;
            Input(out len, out wid, out height);

            //instantiation
            ParentRectangle r1 = new ParentRectangle();
            Box boxcon = BoxMethod (len, wid, height);


            if (RectangleRadBtn.Checked == true) {
                Rectangle(r1, len, wid); //process
                DisplayRectangle(r1); //output

            }

            if (BoxRadBtn.Checked == true) {
                BoxMethod(len, wid, height);
                DisplayBox(boxcon);

            }
        }

        private static void DisplayBox(Box boxcon)
        {
            MessageBox.Show(boxcon.ToString());
        }

        private static void DisplayRectangle(ParentRectangle r1)
        {
            MessageBox.Show(r1.ToString());
        }

        private Box BoxMethod(int len, int wid, int height)
        {
            Box boxcon = new Box(len, wid, height);
            return boxcon;
        }

        private static void Rectangle(ParentRectangle r1, int len, int wid)
        {
            r1.Width = wid;
            r1.Length = len;
        }

        private void Input(out int len, out int wid, out int height)
        {
            len = Int32.Parse(LengthIn.Text);
            wid = Int32.Parse(WidthIn.Text);
            height = Int32.Parse(HeightIn.Text);
        }
    }
}
