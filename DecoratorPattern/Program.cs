// See https://aka.ms/new-console-template for more information
using DecoratorPattern;
using DecoratorPattern.Bevarages;
using DecoratorPattern.Condiments;

Console.WriteLine("Hello, World!");

Bevarage b = new Espresso();

Console.WriteLine("Espresso");
Console.WriteLine($"Bevarage : {b.getDescription()}, Cost : {b.cost()}");
Console.WriteLine("================================================================");

Bevarage b1 = new HouseBlend();
b1 = new Mocha(b1);
b1 = new Mocha(b1);
b1 = new Soy(b1);

Console.WriteLine("House Blend");
Console.WriteLine($"Bevarage : {b1.getDescription()}, Cost : {b1.cost()}");
Console.WriteLine("================================================================");