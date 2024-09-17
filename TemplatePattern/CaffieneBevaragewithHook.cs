using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class CaffieneBevaragewithHook
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantCondiments())
            {
                addCondiments();
            }
        }

        public virtual bool customerWantCondiments()
        {
            return true;
        }

        public void pourInCup()
        {
            Console.WriteLine("Pour Bevarage into Cup");
        }

        public void boilWater()
        {
            Console.WriteLine("Boil Water");
        }

        public abstract void brew();
        public abstract void addCondiments();


    }
}
