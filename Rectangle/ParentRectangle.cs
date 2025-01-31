using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rectangle
{
    internal class ParentRectangle
    {
        int length, width, area;

        public ParentRectangle(){
            length = 0;
            width = 0;
        }
        
        public ParentRectangle(int width, int length) { 
        this.width = width;
        this.length = length;   
        }

        public int Length {
            get { return length; }
            set { length = value; }
        }

        public int Width {
            get { return width; }
            set { width = value; }
        }

        public int Area() {

            area = length * width;

            return area;
        }

        public new string ToString() //use the keyword new or override
        {
            return "Length: " + Length + "\nWidth: " + Width+"\nArea of Rectangle: "+Area();
        }
    }
}
