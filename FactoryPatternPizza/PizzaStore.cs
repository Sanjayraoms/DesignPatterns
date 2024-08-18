using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public abstract class PizzaStore
    {
        private Pizza pizza;
        public Pizza OrderPizza(string type)
        {
            pizza = CreatePizza(type);
            pizza.prepareIngredients();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

//Factory method pattern encapsulates object creations by letting subclasses to decide which objects to create
        public abstract Pizza CreatePizza(string type);
    }
}
