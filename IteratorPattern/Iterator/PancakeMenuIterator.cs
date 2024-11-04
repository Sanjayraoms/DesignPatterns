using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    public class PancakeMenuIterator : IEnumerator<MenuItem>
    {
        MenuItem[] menuItems;
        int currIndex = 0;

        public PancakeMenuIterator(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;
        }

        public MenuItem Current => menuItems[currIndex++];

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            return currIndex < menuItems.Length;
        }

        public MenuItem next()
        {
            var currItem = menuItems[currIndex];
            currIndex++;
            return currItem;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
