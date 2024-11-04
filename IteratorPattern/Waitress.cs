using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Waitress
    {
        IMenu pancakemenu;
        IMenu dinerMenu;

        public Waitress(IMenu pancakemenu, IMenu dinerMenu)
        {
            this.pancakemenu = pancakemenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IEnumerator<MenuItem> pancakeMenuIterator = pancakemenu.GetIterator();
            IEnumerator<MenuItem> dinerManuIterator = dinerMenu.GetIterator();

            Console.WriteLine("Breakfast Items");
            PrintMenu(pancakeMenuIterator);

            Console.WriteLine("Dinner Items");
            PrintMenu(dinerManuIterator);
        }

        private void PrintMenu(IEnumerator<MenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = iterator.Current;
                if (menuItem != null)
                {
                    Console.WriteLine($"{menuItem.Name}, {menuItem.Description} -- {menuItem.Amount}"); 
                }
            }
        }
    }
}
