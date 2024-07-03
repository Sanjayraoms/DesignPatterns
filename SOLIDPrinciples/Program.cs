// See https://aka.ms/new-console-template for more information
using SOLIDPrinciples.SingleResponsibility;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

Journal Journal = new Journal();
Journal.AddEntry("Today is a good day");
Journal.AddEntry("Discipline everyday");

Persistence Persistence = new Persistence();
string filename = @"C:\Temp\SRP.txt";
Persistence.SavetoFile(Journal, filename, true);

var psi = new ProcessStartInfo(filename)
{
    UseShellExecute = true
};

Process.Start(psi);
