// See https://aka.ms/new-console-template for more information
using TemplatePattern;

Console.WriteLine("Hello, World!");

CoffeeWithHook coffee = new CoffeeWithHook();
coffee.prepareRecipe();

TeaWithHook tea = new TeaWithHook();
tea.prepareRecipe();
