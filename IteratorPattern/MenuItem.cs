using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class MenuItem
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool isVegetarian { get; set; }

        public double Amount { get; set; }

        public MenuItem(string name, string description, bool isVegetarian, double amount)
        {
            Name = name;
            Description = description;
            this.isVegetarian = isVegetarian;
            Amount = amount;
        }
    }
}
