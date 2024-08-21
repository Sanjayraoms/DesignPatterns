using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Devices
{
    public class CeilingFan
    {
        public string Place;

        public CeilingFan(string place)
        {
            Place = place;
        }

        public void on()
        {
            Console.WriteLine($"Ceiling Fan turned ON at {Place}");
        }

        public void off()
        {
            Console.WriteLine($"Ceiling Fan turned OFF at {Place}");
        }
    }
}
