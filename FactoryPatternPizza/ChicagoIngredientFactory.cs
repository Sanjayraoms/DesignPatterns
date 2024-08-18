using FactoryPatternPizza.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class ChicagoIngredientFactory : IIngredientFactory
    {

        public ICheese createCheese()
        {
            return new MozarellaCheese();
        }

        public Icalms createClams()
        {
            return new FrozenCalms();
        }

        public IDough createDough()
        {
            return new ThickCrustDough();
        }

        public ISauce createSauce()
        {
            return new PlumTomatoSauce();
        }
    }
}
