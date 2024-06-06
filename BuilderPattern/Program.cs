// See https://aka.ms/new-console-template for more information
using BuilderPattern;
using BuilderPattern.BaseClasses;
using BuilderPattern.Builder;

Console.WriteLine("Hello, World!");

Director Director = new Director();

CarBuilder CarBuilder = new CarBuilder();

Director.ConstructSUV(CarBuilder);

Car car = CarBuilder.Build();
Console.WriteLine("Car Built : \n" + car.GetCar().ToString());
Console.WriteLine("--------------------------------------------");

CarManualBuilder CarManualBuilder = new CarManualBuilder();
Director.ConstructSUV(CarManualBuilder);

CarManual carManual = CarManualBuilder.Build();

Console.WriteLine(carManual.getCarManual());

Console.ReadLine();

