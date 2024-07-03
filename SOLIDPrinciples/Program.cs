// See https://aka.ms/new-console-template for more information
using SOLIDPrinciples.OpenClosedPrinciple;
using SOLIDPrinciples.SingleResponsibility;
using System.Diagnostics;
using static System.Console;

Console.WriteLine("Hello, World!");

// Single Responsibility
//Journal Journal = new Journal();
//Journal.AddEntry("Today is a good day");
//Journal.AddEntry("Discipline everyday");

//Persistence Persistence = new Persistence();
//string filename = @"C:\Temp\SRP.txt";
//Persistence.SavetoFile(Journal, filename, true);

//var psi = new ProcessStartInfo(filename)
//{
//    UseShellExecute = true
//};

//Process.Start(psi);

// Open Closed Principle

var apple = new Product("Apple", Color.GREEN, Size.SMALL);
var tree = new Product("Tree", Color.GREEN, Size.LARGE);
var house = new Product("House", Color.RED, Size.LARGE);

Product[] products = { apple, tree, house };

var pf = new ProductFilter();
WriteLine("Green products (old):");
foreach (var p in pf.FilterByColor(products, Color.GREEN))
    WriteLine($" - {p.Name} is green");

// ^^ BEFORE

// vv AFTER
var bf = new BetterFilter();
WriteLine("Green products (new):");
foreach (var p in bf.Filter(products,new ColorSpec(Color.GREEN)))
    WriteLine($" - {p.Name} is green");

WriteLine("Large products");
foreach (var p in bf.Filter(products, new SizeSpec(Size.LARGE)))
    WriteLine($" - {p.Name} is large");

WriteLine("Large blue items");
foreach (var p in bf.Filter(products,
  new AndSpecification<Product>(new ColorSpec(Color.RED), new SizeSpec(Size.LARGE)))
)
{
    WriteLine($" - {p.Name} is big and blue");
}

ReadLine();

