using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class TeaWithHook : CaffieneBevaragewithHook
    {
        public override bool customerWantCondiments()
        {
            Console.WriteLine("Do you like to add Lemon");
            string answer = Console.ReadLine().ToString();
            if (answer == null)
            {
                answer = "n";
            }
            return answer == "y" ? true : false;
        }
        public override void addCondiments()
        {
            Console.WriteLine("Added lemon to Tea");
        }

        public override void brew()
        {
            Console.WriteLine("Steeping the Tea bag");
        }
    }
}
