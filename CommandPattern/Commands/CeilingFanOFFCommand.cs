using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CeilingFanOFFCommand : ICommand
    {
        CeilingFan ceilingFan;

        public CeilingFanOFFCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void execute()
        {
            ceilingFan.off();
        }

        public void undo()
        {
            ceilingFan.on();
        }
    }
}
