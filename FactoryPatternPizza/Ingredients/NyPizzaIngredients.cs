using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza.Ingredients
{
    public class NyPizzaIngredients : IIngredientFactory
    {
        public ICheese createCheese()
        {
            return new RegginoCheese();
        }

        public Icalms createClams()
        {
            return new FreshCalms();
        }

        public IDough createDough()
        {
            return new ThinCrustDough();
        }

        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }
    }
}
