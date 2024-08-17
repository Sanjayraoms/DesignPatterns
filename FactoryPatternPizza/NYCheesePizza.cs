using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            Name = "New York Cheese burst thin crest Pizza";
            Sauce = "Red chilli Sauce";
            Doug = "Whole wheat thin crest";
            Toppings = new List<string>();
            Toppings.Add("Cheese");
            Toppings.Add("Corn");
            Toppings.Add("Capsicum");
        }
    }
}
