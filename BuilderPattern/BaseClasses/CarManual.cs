using BuilderPattern.BuilderComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BaseClasses
{
    public class CarManual
    {
        public Engine engine { get; private set; }

        public CarType carType { get; private set; }

        public Transmission transmission { get; private set; }

        public GPSNavigator gPSNavigator { get; private set; }

        public CarManual(Engine engine, CarType carType, Transmission transmission, GPSNavigator gPSNavigator)
        {
            this.engine = engine;
            this.carType = carType;
            this.transmission = transmission;
            this.gPSNavigator = gPSNavigator;
        }

        public string getCarManual()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Engine Details :\n Volume: " + engine.Volume + "\n Mileage:" + engine.mileage);
            stringBuilder.Append("\n Transmission type:" + transmission);
            stringBuilder.Append("\n GPS Navigator:" + gPSNavigator.Navigation);
            return stringBuilder.ToString();
        }
    }
}
