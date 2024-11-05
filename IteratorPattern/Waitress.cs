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
        List<IMenu> menus;

        public Waitress(List<IMenu> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            foreach (var menu in menus)
            {
                IEnumerator<MenuItem> menuIterator = menu.GetIterator();
                PrintMenu(menuIterator);
                Console.WriteLine("============================================================== \n");
            }
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
