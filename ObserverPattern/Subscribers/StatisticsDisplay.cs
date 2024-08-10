using ObserverPattern.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subscribers
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private WeatherDataObject weatherDataObject;
        private List<float> temperatures = new List<float>();
        public StatisticsDisplay(WeatherDataObject weatherDataObject)
        {
            this.weatherDataObject = weatherDataObject;
            this.weatherDataObject.addSubscribers(this);
        }
        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min Temperatures : {temperatures.Average()}F / {temperatures.Max()}F / {temperatures.Min()}F");
        }

        public void Update()
        {
            temperatures.Add(weatherDataObject.getTemperature());
            Display();
        }
    }
}
