using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
   internal class Box : ParentRectangle
    {
        int height;

        public Box() {

            height = 0;
           
        }

        public Box(int length, int width, int height) { 
        Length= length;
        Width= width;
        this.height = height;

        }

        public int Height {
            get { return height; }
            set { height = value; }
        }

        public int volume() { 
        
        return base.Area()+Length*Height+Width*Height;
        }
 
        public new string ToString() //use the keyword new or override
        {
            return "Length: " +Length+ "\nWidth: " +Width+"\nHeight: "+Height+"\nSurface of the box: " +volume();
        }

    }
}
