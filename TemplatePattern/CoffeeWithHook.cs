using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class CoffeeWithHook : CaffieneBevaragewithHook
    {
        public override bool customerWantCondiments()
        {
            Console.WriteLine("Do you like to add milk and Sugar");
            string answer = Console.ReadLine().ToString();
            if (answer == null)
            {
                answer = "n";
            }
            return answer == "y" ? true : false;
        }
        public override void addCondiments()
        {
            Console.WriteLine("Added milk and Sugar Condiments");
        }

        public override void brew()
        {
            Console.WriteLine("Brewig the Coffee");
        }
    }
}
