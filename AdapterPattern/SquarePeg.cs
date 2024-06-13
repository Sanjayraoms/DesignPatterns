using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class SquarePeg
    {
        public double width { get; private set; }

        public SquarePeg(double width)
        {
            this.width = width;
        }

        public double getSquare()
        {
            return Math.Pow(Math.Abs(width), 2);
        }
    }
}
