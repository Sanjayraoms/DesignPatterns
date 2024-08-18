using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza.Ingredients
{
    public class ThickCrustDough : IDough
    {
        public string GetDough()
        {
            return "Chicago Style Thick Crust dough";
        }
    }
}
