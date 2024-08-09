// See https://aka.ms/new-console-template for more information
using ObserverPattern.Publisher;
using ObserverPattern.Subscribers;

Console.WriteLine("Hello, World!");

WeatherDataObject WeatherDataObject = new WeatherDataObject();

CurrentConditionDisplay currentCondition = new CurrentConditionDisplay(WeatherDataObject);

WeatherDataObject.setMeasurements(81.5f, 65, 30.4f);

