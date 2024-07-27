// See https://aka.ms/new-console-template for more information
using StepwiseBuilder;

Console.WriteLine("Hello, World!");

var car = CarBuilder.Create()
            .IfType(CarType.Sedan)
            .WithWheels(16)
            .Build();
Console.WriteLine(car.ToString());

Console.ReadLine();
