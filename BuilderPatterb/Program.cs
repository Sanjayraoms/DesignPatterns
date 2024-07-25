// See https://aka.ms/new-console-template for more information
using BuilderPattern;

Console.WriteLine("Hello, World!");

var builder = new HTMLBuilder("ul");
builder.AddChild("li", "Hello").AddChild("li", "World!!");

Console.WriteLine(builder.ToString());

Console.Read();