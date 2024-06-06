using BuilderPattern.BaseClasses;
using BuilderPattern.BuilderComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public class CarBuilder : IBuilder
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

        public Car Build()
        {
            Car car = new Car(engine,carType,transmission,gpsNavigator);
            return car;
        }
    }
}
