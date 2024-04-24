using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public class Request
    {
        public Priority priority { get; }

        public Request(Priority priority)
        {
            this.priority = priority;
        }

    }

    public enum Priority
    {
        BASIC, INTERMEDIATE, CRITICAL
    }
}
