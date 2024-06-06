using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BuilderComponents
{
    public class Engine
    {
        public double mileage { get; private set; }
        public double Volume { get; private set; }

        public Engine(double mileage, double Volume)
        {
            this.mileage = mileage;
            this.Volume = Volume;
        }
        
    }

    public enum CarType
    {
        SUV,SPORT_CAR,MANUAL
    }

    public enum Transmission
    {
        AUTO,MANUAL,DCT
    }
}
