using ObserverPattern.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subscribers
{
    public class CurrentConditionDisplay : IDisplayElement, IObserver
    {
        private float temperature;
        private float humidity;
        private WeatherDataObject weatherDataObject;

        public CurrentConditionDisplay(WeatherDataObject weatherDataObject)
        {
            this.weatherDataObject = weatherDataObject;
            this.weatherDataObject.addSubscribers(this);
        }
        public void Display()
        {
            Console.WriteLine($"Current Conditions : {temperature} F Degrees {humidity} % humidity ");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }
    }
}
