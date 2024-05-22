// See https://aka.ms/new-console-template for more information
using AbstractFactory.Classes;

Console.WriteLine("Enter the OS");

string OS = Console.ReadLine();
Client? client;

switch (OS)
{
    case "WINDOWS":
        client = new Client(new WindowsOS());
        break;
    case "MAC":
        client = new Client(new MacOS());
        break;
    default:
        client = new Client(new LinuxOS());
        break;
}
client.Render();
Console.ReadLine();
