﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public interface IMenu
    {
        public IEnumerator<MenuItem> GetIterator();
    }
}
