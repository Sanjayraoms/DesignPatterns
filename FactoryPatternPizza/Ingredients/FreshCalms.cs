using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza.Ingredients
{
    public class FreshCalms : Icalms
    {
        public string getCalms()
        {
            return "New York gets Fresh Calms";
        }
    }
}
