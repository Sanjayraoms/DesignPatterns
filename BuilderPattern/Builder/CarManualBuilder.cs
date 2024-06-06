using BuilderPattern.BaseClasses;
using BuilderPattern.BuilderComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public class CarManualBuilder : IBuilder
    {
        private CarType carType;
        private Engine engine;
        private Transmission transmission;
        private GPSNavigator gpsNavigator;

        public void SetCarType(CarType carType)
        {
            this.carType = carType;
        }

        public void SetEngine(Engine engine)
        {
            this.engine = engine;
        }

        public void SetNavigator(GPSNavigator gPSNavigator)
        {
            this.gpsNavigator = gPSNavigator;
        }

        public void SetTransmission(Transmission transmission)
        {
            this.transmission = transmission;
        }

        public CarManual Build()
        {
            CarManual carManual = new CarManual(engine,carType,transmission,gpsNavigator);
            return carManual;
        }
    }
}
