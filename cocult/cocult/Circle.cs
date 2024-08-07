using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    class Circle
    {
        public double Radius { get; set; } 

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double S()
        {
            return Math.Pow(Math.PI * Radius,2);
        }

        public double P()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
