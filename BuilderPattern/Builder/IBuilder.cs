using BuilderPattern.BuilderComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public interface IBuilder
    {
        abstract void SetEngine(Engine engine);
        abstract void SetCarType(CarType carType);
        abstract void SetTransmission(Transmission transmission);
        abstract void SetNavigator(GPSNavigator gPSNavigator);

    }
}
