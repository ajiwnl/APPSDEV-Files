using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Property
{
    internal class Student
    {
        int id;
        string name;

        public Student() { 
        
        }
        public string Name
        {
            set
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
            get { return name; }

        }
        public int IdNum
        {
            set
            {

                if ((value <= 0))
                {
                    id = 0;
                }
                else
                {
                    id = value;
                }
            }
            get { return id; }

        }
        public new string ToString() //use the keyword new or override
        {
            return "ID No: " + id + Environment.NewLine + "Name: " + name;
        }

    }
}
