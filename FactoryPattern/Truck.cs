using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Truck : ITransport
    {
        public void deliver()
        {
            Console.WriteLine("Deliver the package on road in the boxes");
        }
    }
}
