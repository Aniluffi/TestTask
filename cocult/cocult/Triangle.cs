using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    class Triangle
    {
        

        public double Side { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        
        public Triangle(double side, double side1, double side2)
        {
            Side = side;
            Side1 = side1;
            Side2 = side2;
        }

        public double S()
        {
            double p = P() / 2;

            return Math.Sqrt(p * (p - Side) * (p - Side1) * (p - Side2));
        }

        public double P()
        {
           
            return Side + Side1 + Side2;
        }
    }
}
