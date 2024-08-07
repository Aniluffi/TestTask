using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    class Rectangle
    {     
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public double S()
        {
            return Side1 * Side2;
        }

        public double P()
        {
            return Side1 + Side2 * 2;
        }
    }
}
