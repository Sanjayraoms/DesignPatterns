using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class RoadLogistics : Logistics
    {
        public override ITransport getTransport()
        {
            return new Truck();
        }
    }
}
