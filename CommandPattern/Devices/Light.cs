using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Devices
{
    public class Light
    {
        public void on()
        {
            Console.WriteLine("Light gets turned ON");
        }

        public void off()
        {
            Console.WriteLine("Light gets turned OFF");
        }
    }
}
