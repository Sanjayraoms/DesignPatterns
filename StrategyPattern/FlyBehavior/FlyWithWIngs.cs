using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.FlyBehavior
{
    public class FlyWithWIngs : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings");
        }
    }
}
