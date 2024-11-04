// See https://aka.ms/new-console-template for more information
using IteratorPattern;

Console.WriteLine("Hello, World!");

var pancakeHouseMenu = new PanCakeHouseMenu();

var dinerMenu = new DinerMenu();

Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

waitress.PrintMenu();
