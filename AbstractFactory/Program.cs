// See https://aka.ms/new-console-template for more information
using AbstractFactory.Classes;

Console.WriteLine("Enter the OS");

string OS = Console.ReadLine();
Client? client;
if (OS == "WINDOWS")
{
    client = new Client(new WindowsOS());
}else
{
    client = new Client(new MacOS());
}
client.Render();
Console.ReadLine();
