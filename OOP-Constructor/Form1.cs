using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            int id;
            string name;

            try {
                Input(out id, out name);
                Student std = Process(id, name);
                Display(std);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private static void Display(Student std)
        {
            MessageBox.Show(std.ToString());
        }

        private Student Process(int id, string name)
        {
            return new Student(id, name);
        }

        private void Input(out int id, out string name)
        {
            name = Convert.ToString(NameTxtBox.Text);

            if (!Int32.TryParse(IdTxtBox.Text, out id)) {
                throw new Exception("Invalid Input");
            }
        }
    }
}
