using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Devices
{
    public class Stereo
    {
        public string CurrentMode;

        public int Volume;

        public void on()
        {
            Console.WriteLine($"Turning ON Stereo");
        }

        public void off()
        {
            Console.WriteLine($"Turning OFF Stereo");
        }

        public void setCD()
        {
            CurrentMode = "CD";
        }

        public void setDVD()
        {
            CurrentMode = "DVD";
        }

        public void setRadio()
        {
            CurrentMode = "RADIO";
        }

        public void setVolume(int volume)
        {
            Volume = volume;
        }
    }
}
