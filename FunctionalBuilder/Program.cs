// See https://aka.ms/new-console-template for more information
using FunctionalBuilder;

Console.WriteLine("Hello, World!");

var person = new PersonBuilder()
                 .Called("Sanjay")
                 .WorksAs("Developer")
                 .WorksAt("PowerSchool")
                 .Build();
