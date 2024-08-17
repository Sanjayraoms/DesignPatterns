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
        protected string Doug;
        protected List<string> Toppings;
        protected string Sauce;

        public void Prepare()
        {
            Console.WriteLine("Mix the Dough");
            Console.WriteLine("Toss the dough");
            Console.WriteLine($"Add sauce {Sauce}");
            Console.WriteLine("Adding the Toppings : ");
            foreach (var item in Toppings)
            {
                Console.WriteLine($"{item}, ");
            }
        }

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
