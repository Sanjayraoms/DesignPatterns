using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Bevarages
{
    public class DarkRoast : Bevarage
    {
        public DarkRoast()
        {
            description = "Dark Roast coffee";
        }
        public override double cost()
        {
            return 1.5;
        }
        public override string getDescription()
        {
            return description;
        }
    }
}
