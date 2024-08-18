using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza.Ingredients
{
    public class FrozenCalms : Icalms
    {
        public string getCalms()
        {
            return "Chicago gets frozen Calms";
        }
    }
}
