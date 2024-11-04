using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class PanCakeHouseMenu : IMenu
    {
        private static int MAX_ITEMS = 5;
        private int currIndex = 0;

        MenuItem[] menuItems;

        public PanCakeHouseMenu()
        {
            this.menuItems = new MenuItem[MAX_ITEMS];

            addItem("Masala Dosa", "Made with rice batter and masala", true, 45);
            addItem("Rava Masala Dosa", "Made with rava batter and masala", true, 75);
            addItem("Idli wada", "Made with idli rava and urad dal", true, 45);
            addItem("Pongal", "Made with rice and vegetables", true, 45);
        }

        private void addItem(string name, string description, bool isVeg, int price)
        {
            if (currIndex < MAX_ITEMS)
            {
                MenuItem menuItem = new MenuItem(name, description, isVeg, price);
                menuItems[currIndex] = menuItem;
            }
            else
            {
                Console.WriteLine("Menu is full. Cannot add more items");
            }
            currIndex++;
        }

        public IEnumerator<MenuItem> GetIterator()
        {
            return new PancakeMenuIterator(menuItems);
        }

    }
}
