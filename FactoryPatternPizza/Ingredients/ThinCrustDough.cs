using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza.Ingredients
{
    public class ThinCrustDough : IDough
    {
        public string GetDough()
        {
            return "NY Thin Crust Dough";
        }


    }
}
