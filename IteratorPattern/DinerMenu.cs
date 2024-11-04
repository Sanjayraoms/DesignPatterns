using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class DinerMenu : IMenu
    {
        List<MenuItem> menuItems;

        public DinerMenu()
        {
            this.menuItems = new List<MenuItem>();

            addItem("Kulcha", "Indian bread made of wheat and maida", true, 35.5);

            addItem("Butter Chicken", "Grilled chicken with butter gravy", false, 140);

            addItem("Mudde", "Most nutritious Indian food made of ragi", true, 15.5);

            addItem("Naati koli curry", "Indian desi chicken curry", true, 35.5);
        }

        private void addItem(string v1, string v2, bool v3, double v4)
        {
            var menuItem = new MenuItem(v1, v2, v3, v4);
            menuItems.Add(menuItem);
        }

        public IEnumerator<MenuItem> GetIterator()
        {
            return menuItems.GetEnumerator();
        }
    }
}
