// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Console.WriteLine("Hello, World!");

RoundHole roundHole = new RoundHole(5);
RoundPeg roundPeg = new RoundPeg(3);

if (roundHole.fits(roundPeg))
{
    Console.WriteLine("Round Peg r2 fits in round hole r5");
}

SquarePeg squarePeg = new SquarePeg(2);
SquarePeg squarePeg2 = new SquarePeg(20);

SquareAdapter squareAdapter = new SquareAdapter(squarePeg);
SquareAdapter squareAdapter1 = new SquareAdapter(squarePeg2);

if (roundHole.fits(squareAdapter))
{
    Console.WriteLine("Square peg w2 fits in round hole r5");
}

if (!roundHole.fits(squareAdapter1))
{
    Console.WriteLine("Square peg w20 do not fits in round hole r5");
}

Console.ReadLine();
