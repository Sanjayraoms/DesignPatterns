using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class GarageDoorUpCommand : ICommand
    {
        Garage garage;

        public GarageDoorUpCommand(Garage garage)
        {
            this.garage = garage;
        }

        public void execute()
        {
            garage.doorUp();
        }

        public void undo()
        {
            garage.doorDown();
        }
    }
}
