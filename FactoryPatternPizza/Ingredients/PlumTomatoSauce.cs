using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza.Ingredients
{
    public class PlumTomatoSauce : ISauce
    {
        public string getSauce()
        {
            return "Chicago uses Plum Tomato Sauce";
        }
    }
}
