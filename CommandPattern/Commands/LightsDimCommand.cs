using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class LightsDimCommand : ICommand
    {
        Light light;

        public LightsDimCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.dim();
        }

        public void undo()
        {
            light.off();
        }
    }
}
