using ObserverPattern.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Publisher
{
    public interface ISubject
    {
        public void addSubscribers(IObserver observer);

        public void removeSubscribers(IObserver observer);

        public void notifySubscribers();
    }
}
