using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Bevarage
    {
        internal string description = "Unknown Bevarage";

        public abstract string getDescription();

        public abstract double cost();
    }
}
