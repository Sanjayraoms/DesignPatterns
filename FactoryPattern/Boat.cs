using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Boat : ITransport
    {
        public void deliver()
        {
            Console.WriteLine("Package is delivered in Sea route in the container");
        }
    }
}
