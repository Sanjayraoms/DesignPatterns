using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class ChicagoCheesePizza : Pizza
    {
        public ChicagoCheesePizza()
        {
            Name = "Chicago Cheese burst thick crest Pizza";
            Sauce = "Red chilli Sauce";
            Doug = "Whole wheat thick crest";
            Toppings = new List<string>();
            Toppings.Add("Cheese");
            Toppings.Add("Corn");
            Toppings.Add("Mozarella Cheese");
        }
    }
}
