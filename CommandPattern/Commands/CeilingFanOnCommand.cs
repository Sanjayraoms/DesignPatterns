using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CeilingFanOnCommand : ICommand
    {
        CeilingFan ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void execute()
        {
            ceilingFan.on();
        }

        public void undo()
        {
            ceilingFan.off();
        }
    }
}
