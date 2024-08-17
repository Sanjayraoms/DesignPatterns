using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Cheese":
                    return new ChicagoCheesePizza();
                    break;
                default:
                    return new ChicagoCheesePizza();
                    break;
            }
        }
    }
}
