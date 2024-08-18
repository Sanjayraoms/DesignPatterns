using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class NYCheesePizza : Pizza
    {
        IIngredientFactory nyingredientFactory;
        public NYCheesePizza(IIngredientFactory ingredientFactory)
        {
            Name = "New York Cheese burst thin crest Pizza";
            Toppings = new List<string>();
            Toppings.Add("Cheese");
            Toppings.Add("Corn");
            Toppings.Add("Capsicum");
            this.nyingredientFactory = ingredientFactory;
        }

        public override void prepareIngredients()
        {
            Dough = nyingredientFactory.createDough();
            Sauce = nyingredientFactory.createSauce();
            Cheese = nyingredientFactory.createCheese();

            Console.WriteLine($"Mix the Dough : {Dough.GetDough()}");
            Console.WriteLine($"Toss the dough : {Dough.GetDough()}");
            Console.WriteLine($"Add sauce : {Sauce.getSauce()}");
            Console.WriteLine($"Add cheese : {Cheese.getCheese()}");
            Console.WriteLine("Adding the Toppings : ");
            foreach (var item in Toppings)
            {
                Console.WriteLine($"{item}, ");
            }
        }
    }
}
