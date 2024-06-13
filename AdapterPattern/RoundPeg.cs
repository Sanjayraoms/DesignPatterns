using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class RoundPeg
    {
        private double Radius;

        public RoundPeg()
        {

        }
        public RoundPeg(double radius)
        {
            Radius = radius;
        }

        public virtual double getRadius()
        {
            return Radius;
        }
    }
}
