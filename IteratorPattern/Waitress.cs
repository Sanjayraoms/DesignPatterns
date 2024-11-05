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
        IMenu cafeMenu;

        public Waitress(IMenu pancakemenu, IMenu dinerMenu, IMenu cafeMenu)
        {
            this.pancakemenu = pancakemenu;
            this.dinerMenu = dinerMenu;
            this.cafeMenu = cafeMenu;
        }

        public void PrintMenu()
        {
            IEnumerator<MenuItem> pancakeMenuIterator = pancakemenu.GetIterator();
            IEnumerator<MenuItem> dinerManuIterator = dinerMenu.GetIterator();
            IEnumerator<MenuItem> cafeMenuIterator = cafeMenu.GetIterator();

            Console.WriteLine("Breakfast Items");
            PrintMenu(pancakeMenuIterator);
            Console.WriteLine("============================================================== \n");

            Console.WriteLine("Dinner Items");
            PrintMenu(dinerManuIterator);
            Console.WriteLine("============================================================== \n");

            Console.WriteLine("Cafe Items");
            PrintMenu(cafeMenuIterator);

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
