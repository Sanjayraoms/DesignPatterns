using ObserverPattern.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Publisher
{
    public class WeatherDataObject : ISubject
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private List<IObserver> observers;

        public WeatherDataObject()
        {
            observers = new List<IObserver>();
        }
        public void addSubscribers(IObserver observer)
        {
            observers.Add(observer);
        }

        public void notifySubscribers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public void removeSubscribers(IObserver observer)
        {
            observers?.Remove(observer);
        }

        public void measurementsChanged()
        {
            notifySubscribers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        public float getTemperature()
        {
            return temperature;
        }

        public float getHumidity()
        {
            return humidity;
        }

        public float getPressure()
        {
            return pressure;
        }
    }
}
