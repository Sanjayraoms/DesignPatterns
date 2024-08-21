using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Devices
{
    public class Garage
    {
        public void doorUp()
        {
            Console.WriteLine("Garage door rise up");
        }

        public void doorDown()
        {
            Console.WriteLine("Garage door down");
        }
    }
}
