using FactoryPatternPizza.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class ChicagoCheesePizza : Pizza
    {
        IIngredientFactory chicagoIngredientFactory;
        public ChicagoCheesePizza(IIngredientFactory ingredientFactory)
        {
            chicagoIngredientFactory = ingredientFactory;
            Name = "Chicago Cheese burst thick crest Pizza";
            Toppings = new List<string>();
            Toppings.Add("Cheese");
            Toppings.Add("Corn");
            Toppings.Add("Mozarella Cheese");
        }

        public override void prepareIngredients()
        {
            Dough = chicagoIngredientFactory.createDough();
            Sauce = chicagoIngredientFactory.createSauce();
            Cheese = chicagoIngredientFactory.createCheese();

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
