using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class RoundHole
    {
        public double radius { get; private set; }

        public RoundHole(double radius)
        {
            this.radius = radius;   
        }

        public bool fits(RoundPeg roundPeg)
        {
            return this.radius >= roundPeg.getRadius();
        }
    }
}
