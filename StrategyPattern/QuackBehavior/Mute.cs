﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.QuackBehavior
{
    public class Mute : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Cannot Quack");
        }
    }
}
