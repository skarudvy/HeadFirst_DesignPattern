using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter02_WeatherStation
{
    public interface ISubject
    {
        void registerObserver(IObserver j);
        void removeObserver(IObserver o);
        void notifyObservers();
    }
}
