using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Bevarages
{
    public class HouseBlend : Bevarage
    {
        public HouseBlend()
        {
            description = "House Blend";
        }
        public override double cost()
        {
            return 0.89;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
