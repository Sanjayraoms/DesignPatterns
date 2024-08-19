using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class LightsOnCommand : ICommand
    {
        Light light;

        public LightsOnCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.on()
        }
    }
}
