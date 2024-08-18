using FactoryPatternPizza.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class NewYorkPizzaStore : PizzaStore
    {
        IIngredientFactory _ingredientFactory;
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Cheese":
                    _ingredientFactory = new NyPizzaIngredients();
                    return new NYCheesePizza(_ingredientFactory);
                    break;
                default:
                    _ingredientFactory = new NyPizzaIngredients();
                    return new NYCheesePizza(_ingredientFactory);
                    break;
            }
        }
    }
}
