using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class GarageDoorDownCommand : ICommand
    {
        Garage garage;

        public GarageDoorDownCommand(Garage garage)
        {
            this.garage = garage;
        }

        public void execute()
        {
            garage.doorDown();
        }

        public void undo()
        {
            garage.doorUp();
        }
    }
}
