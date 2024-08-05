using StrategyPattern.FlyBehavior;
using StrategyPattern.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWIngs();
            QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I look like Mallard Duck");
        }
    }
}
