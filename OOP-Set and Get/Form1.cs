using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Set_and_Get
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

                Student std = StdSet(id, name);

                Display(std);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Display(Student std)
        {
            MessageBox.Show("ID No: " + std.GetIdNum() + "\n" + "Name: " + std.GetName());
        }

        private Student StdSet(int id, string name)
        {
            Student std = new Student();

            std.SetIdNum(id);
            std.SetName(name);
            return std;
        }

        private void Input(out int id, out string name)
        {
            if (!Int32.TryParse(IdNoTxtBox.Text, out id)) {
                throw new Exception("Invalid Input");
            }
            name = Convert.ToString(NameTxtBox.Text);
        }
    }
}
