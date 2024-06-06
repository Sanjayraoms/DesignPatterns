using BuilderPattern.Builder;
using BuilderPattern.BuilderComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        public void ConstructSUV(IBuilder builder)
        {
            builder.SetEngine(new Engine(17.5, 1.2));
            builder.SetCarType(CarType.SUV);
            builder.SetTransmission(Transmission.MANUAL);
            builder.SetNavigator(new GPSNavigator("1809 HSR"));
        }


    }
}
