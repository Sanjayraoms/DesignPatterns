using BridgePattern.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Remote
{
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice device) : base(device)
        {

        }

        public void Mute()
        {
            device.setVolume(0);
        }
    }
}
