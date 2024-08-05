// See https://aka.ms/new-console-template for more information
using StrategyPattern;
using StrategyPattern.FlyBehavior;

Console.WriteLine("Hello, World!");

var duckSim = new MallardDuck();

duckSim.FlyBehavior.Fly();
duckSim.QuackBehavior.Quack();
duckSim.SetFlyBehavior(new FlywithRocketSpeed());
duckSim.FlyBehavior.Fly();