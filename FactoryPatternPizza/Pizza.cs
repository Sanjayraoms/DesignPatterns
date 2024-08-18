using FactoryPatternPizza.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public abstract class Pizza
    {
        protected string Name;
        protected IDough Dough;
        protected List<string> Toppings;
        protected ISauce Sauce;
        protected ICheese Cheese;

        public abstract void prepareIngredients();

        public void Bake()
        {
            Console.WriteLine("Pizza is getting baked for 25mins with 150 temp");
        }

        public void Cut()
        {
            Console.WriteLine("Pizza is cut into round shapes");
        }

        public void Box()
        {
            Console.WriteLine("Pizza is delivered in square carton box");
        }
    }
}
