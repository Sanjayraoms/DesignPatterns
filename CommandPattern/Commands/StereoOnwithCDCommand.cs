using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class StereoOnwithCDCommand : ICommand
    {
        Stereo stereo;

        public StereoOnwithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(12);
        }

        public void undo()
        {
            stereo.off()
        }
    }
}
