using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class StereoOffwithCDCommand : ICommand
    {
        Stereo stereo;

        public StereoOffwithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.off();
        }

        public void undo()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(12);
        }
    }
}
