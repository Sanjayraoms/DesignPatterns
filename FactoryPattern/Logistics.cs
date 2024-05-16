using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class Logistics
    {
        public abstract ITransport getTransport();
        public void DoWork()
        {
            ITransport transport = getTransport();
            transport.deliver();
        }
    }
}
