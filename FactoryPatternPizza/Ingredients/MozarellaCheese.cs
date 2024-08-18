using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza.Ingredients
{
    public class MozarellaCheese : ICheese
    {
        public string getCheese()
        {
            return "Chicago Uses Mozarella Cheese";
        }
    }
}
