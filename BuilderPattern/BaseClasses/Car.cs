using BuilderPattern.BuilderComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BaseClasses
{
    public class Car
    {
        public Engine engine { get; private set; }

        public CarType carType { get; private set; }

        public Transmission transmission { get; private set; }

        public GPSNavigator gPSNavigator { get; private set; }

        public Car(Engine engine, CarType carType, Transmission transmission, GPSNavigator gPSNavigator)
        {
            this.engine = engine;
            this.carType = carType;
            this.transmission = transmission;
            this.gPSNavigator = gPSNavigator;
        }

        public CarType GetCar()
        {
            return this.carType;
        }
    }
}
