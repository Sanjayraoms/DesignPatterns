// See https://aka.ms/new-console-template for more information
using FactoryPatternPizza;

Console.WriteLine("Hello, World!");

PizzaStore nyStore  =  new NewYorkPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

nyStore.OrderPizza("Cheese");
Console.WriteLine("=========================================================");
chicagoStore.OrderPizza("Cheese");


