using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.FlyBehavior
{
    public class FlywithRocketSpeed : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying with rocket speed");
        }
    }
}
