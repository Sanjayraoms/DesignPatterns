// See https://aka.ms/new-console-template for more information
using FactoryPattern;

Logistics logistics = new RoadLogistics();
Console.WriteLine("Road Logistics is delivered as below");
Console.WriteLine("----------------------------------------------");
logistics.DoWork();

Console.WriteLine("\n");

logistics = new SeaLogistics();
Console.WriteLine("Sea Logistics is delivered as below");
Console.WriteLine("----------------------------------------------");
logistics.DoWork();

Console.ReadLine();
