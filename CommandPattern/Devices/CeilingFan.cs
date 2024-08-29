using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Devices
{
    public class CeilingFan
    {
        public readonly int OFF = 0;
        public readonly int LOW = 1;
        public readonly int MEDIUM = 2;
        public readonly int HIGH = 3;

        public int speed;
        public string Place;

        public CeilingFan(string place)
        {
            Place = place;
            speed = OFF;
        }

        public void low()
        {
            speed = LOW;
            Console.WriteLine($"Ceiling Fan speed at {Place} is changed to {speed}");
        }

        public void medium()
        {
            speed = MEDIUM;
            Console.WriteLine($"Ceiling Fan speed at {Place} is changed to {speed}");
        }

        public void high()
        {
            speed = HIGH;
            Console.WriteLine($"Ceiling Fan speed at {Place} is changed to {speed}");
        }
        public void on()
        {
            Console.WriteLine($"Ceiling Fan turned ON at {Place}");
        }

        public void off()
        {
            speed = OFF;
            Console.WriteLine($"Ceiling Fan turned OFF at {Place}");
        }

        public int getSpeed()
        {
            return speed;
        }
    }
}
