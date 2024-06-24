using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Remote
{
    public interface IRemote
    {
        abstract void togglePower();
        abstract void volumeDown();
        abstract void volumeUp();
        abstract void channelDown();
        abstract void channelUp();

    }
}
