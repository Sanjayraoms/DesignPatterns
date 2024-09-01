using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class MacroCommand : ICommand
    {
        ICommand[] commands;
        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }
        public void execute()
        {
            foreach (var item in commands)
            {
                item.execute();
            }
        }

        public void undo()
        {
            foreach (var item in commands)
            {
                item.undo();
            }
        }
    }
}
