using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class CafeMenu : IMenu
    {
        Dictionary<string,MenuItem> menuItems = new Dictionary<string,MenuItem>();

        public CafeMenu()
        {
            addItem("Irani Chai", "Chai done in Irani Style", true, 10);
            addItem("Bru Coffe", "Coffe done using Instant COffee powder", true, 12);
            addItem("Ginger Chai", "Chai done with grated ginger", true, 12.5);
            addItem("Khara bun", "Bun done with spices and butter", true, 10);
        }

        private void addItem(string name, string description, bool isVeg, double price)
        {
            MenuItem menuItem = new MenuItem(name,description,isVeg,price);
            menuItems.Add(name, menuItem);
        }

        public IEnumerator<MenuItem> GetIterator()
        {
            return menuItems.Values.GetEnumerator();
        }
    }
}
