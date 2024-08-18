using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternPizza.Ingredients;

namespace FactoryPatternPizza
{
    public interface IIngredientFactory
    {
        public ICheese createCheese();

        public IDough createDough();

        public ISauce createSauce();

        public Icalms createClams();

    }
}
