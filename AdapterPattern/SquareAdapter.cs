using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class SquareAdapter : RoundPeg
    {
        private SquarePeg SquarePeg;

        public SquareAdapter(SquarePeg squarePeg) : base()
        {
            SquarePeg = squarePeg;
        }

        public override double getRadius()
        {
            return Math.Sqrt(Math.Pow((SquarePeg.width / 2), 2) * 2);
        }
    }
}
