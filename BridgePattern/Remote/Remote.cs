using BridgePattern.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Remote
{
    public class Remote : IRemote
    {
        protected IDevice device;

        public Remote(IDevice device)
        {
            this.device = device;
        }

        public void channelDown()
        {
            Console.WriteLine("Remote : Channel Down");
            device.setChannel(device.getChannel() - 10);
        }

        public void channelUp()
        {
            Console.WriteLine("Remote : Channel Up");
            device.setChannel(device.getChannel() + 10);
        }

        public void togglePower()
        {
            Console.WriteLine("Remote : Toggle Power");
            if (device.isEnabled())
                device.disable();
            else
                device.enable();
        }

        public void volumeDown()
        {
            Console.WriteLine("Remote : Volume Down");
            device.setVolume(device.getVolume() - 10);
        }

        public void volumeUp()
        {
            Console.WriteLine("Remote : Volume Up");
            device.setVolume(device.getVolume() + 10);
        }
    }
}
