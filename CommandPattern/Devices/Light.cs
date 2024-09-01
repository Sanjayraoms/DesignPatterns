using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Devices
{
    public class Light
    {
        public string Place;

        public Light(string place)
        {
            Place = place;
        }

        public void on()
        {
            Console.WriteLine($"Light gets turned ON in {Place}");
        }

        public void off()
        {
            Console.WriteLine($"Light gets turned OFF in {Place}");
        }

        public void dim()
        {
            Console.WriteLine($"Light gets dimmed for party mode in {Place}");
        }
    }
}
