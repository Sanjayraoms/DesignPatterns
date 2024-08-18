using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza.Ingredients
{
    public class MarinaraSauce : ISauce
    {
        public string getSauce()
        {
            return "NY uses Marinara Sauce";
        }
    }
}
