using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(Bevarage bevarage)
        {
            this.bevarage = bevarage;
        }
        public override double cost()
        {
            return bevarage.cost() + 0.20;
        }

        public override string getDescription()
        {
            return bevarage.getDescription() + ", whip";
        }
    }
}
