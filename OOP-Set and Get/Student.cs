using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Set_and_Get
{
    internal class Student
    {
        string name;
        int id;

        public void SetIdNum(int id) { this.id = id; }

        public int GetIdNum() { return id; }

        public void SetName(string value)
        {
            if ((value == string.Empty))
            {
                name = "No Name";
            }
            else
            {
                name = value;
            }
        }

        public String GetName() { return name; }

        public new string ToString() //use the keyword new or override
        {
            return "ID No: " + id + Environment.NewLine + "Name: " + name;
        }



    }
}
