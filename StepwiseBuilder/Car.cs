using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepwiseBuilder
{
    public enum CarType
    {
        Sedan,
        CrossOver
    }
    public class Car
    {
        public CarType CarType;
        public int WheelSize;

        public override string ToString()
        {
            return $"Brand new {CarType} car with wheel size {WheelSize}";
        }
    }

    public interface ISpecifyCarType
    {
        ISpecifyWheelSize IfType(CarType type);
    }

    public interface ISpecifyWheelSize
    {
        IBuildCar WithWheels(int size);
    }

    public interface IBuildCar
    {
        Car Build();
    }

    public class CarBuilder
    {
        private class Impl : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
        {
            private Car Car = new Car();
            public Car Build()
            {
                return Car;
            }

            public ISpecifyWheelSize IfType(CarType type)
            {
                Car.CarType = type;
                return this;
            }

            public IBuildCar WithWheels(int size)
            {
                switch (Car.CarType)
                {
                    case CarType.Sedan when size < 15 || size > 17:
                    case CarType.CrossOver when size < 17 || size > 20:
                        throw new ArgumentException($"Wrong size of wheel for {Car.CarType} Type");
                }
                Car.WheelSize = size;
                return this;
            }
        }

        public static ISpecifyCarType Create()
        {
            var builder = new Impl();
            return builder;
        }
    }

}
