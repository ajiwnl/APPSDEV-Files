using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Constructor
{
    internal class Student
    {
        string name;
        int id;

        public Student()
        {
            id = 0;
            name = "";
        }

        //overloaded constructor
        public Student(int id, string n)
        {
            this.id = (id <= 0) ? 0 : id;
            name = (n == String.Empty) ? "No Name" : n;

        }

        public new string ToString() //use the keyword new or override
        {
            return "ID No: " + id + Environment.NewLine + "Name: " + name;
        }

    }
}
