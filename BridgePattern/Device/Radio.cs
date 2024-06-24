﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Device
{
    public class Radio : IDevice
    {
        private bool _ison = false;
        private int _volume = 60;
        private int _channel = 60;
        public void disable()
        {
            _ison = false;
        }

        public void enable()
        {
            _ison = true;
        }

        public int getChannel()
        {
            return _channel;
        }

        public int getVolume()
        {
            return _volume;
        }

        public bool isEnabled()
        {
            return _ison;
        }

        public void setChannel(int channel)
        {
            _channel = channel;
        }

        public void setVolume(int volume)
        {
            if (volume > 100)
                _volume = 100;
            else if (volume < 0)
                _volume = 0;
            else
                _volume = volume;
        }

        public void printStatus()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("This is a Radio device");
            Console.WriteLine("This Radio is " + (_ison ? "Enabled" : "Disabled"));
            Console.WriteLine("Current channel is : " + _channel);
            Console.WriteLine("Current volume is : " + _volume);
        }
    }
}
