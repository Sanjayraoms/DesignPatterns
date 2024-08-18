using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class ChicagoPizzaStore : PizzaStore
    {
        IIngredientFactory _ingredientFactory;
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Cheese":
                    _ingredientFactory = new ChicagoIngredientFactory();
                    return new ChicagoCheesePizza(_ingredientFactory);
                    break;
                default:
                    _ingredientFactory = new ChicagoIngredientFactory();
                    return new ChicagoCheesePizza(_ingredientFactory);
                    break;
            }
        }
    }
}
