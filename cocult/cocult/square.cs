using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    class Square
    {  
        public double Side {  get; set; }

        public Square(double side)
        {
            this.Side = side;
        }

        public double S()
        {
            return Side * Side;
        }

        public double P()
        {
            return Side * 4;
        }
    }
}
