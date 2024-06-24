using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Device
{
    public interface IDevice
    {
        abstract bool isEnabled();
        abstract void enable();

        abstract void disable();

        abstract int getVolume();

        abstract void setVolume(int volume);

        abstract int getChannel();
        abstract void setChannel(int channel);

        abstract void printStatus();
    }
}
