using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class NewYorkPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Cheese": 
                    return new NYCheesePizza();
                    break;
                default:
                    return new NYCheesePizza();
                    break;
            }
        }
    }
}
