using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CeilingFanHighCommand : ICommand
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.high();
        }

        public void undo()
        {
            if (prevSpeed == ceilingFan.HIGH)
                ceilingFan.high();
            else if (prevSpeed == ceilingFan.MEDIUM)
                ceilingFan.medium();
            else if(prevSpeed == ceilingFan.LOW)
                ceilingFan.low();
            else if(prevSpeed == ceilingFan.OFF)
                ceilingFan.off();
        }
    }
}
