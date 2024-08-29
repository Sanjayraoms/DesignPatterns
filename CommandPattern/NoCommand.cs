using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class NoCommand : ICommand
    {
        public void execute()
        {
            Console.WriteLine("Empty Command");
        }

        public void undo()
        {
            Console.WriteLine("Empty undo Command");
        }
    }
}
