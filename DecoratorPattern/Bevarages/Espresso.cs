using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Bevarages
{
    public class Espresso : Bevarage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override double cost()
        {
            return 1.99;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
