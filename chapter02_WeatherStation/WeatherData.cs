using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter02_WeatherStation
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }
        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            int index = observers.IndexOf(o);

            if (index > 0)
                observers.RemoveAt(index);
        }

        public void notifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.update(this.temperature, this.humidity, this.pressure);
            }
        }

        /// <summary>
        /// 기상 스테이션으로부터 갱신된 측정치를 받으면 옵저버들에게 알립니다.
        /// </summary>
        public void measurementsChanged()
        {
            notifyObservers();
        }

        ///
        public void setMeasurementsChanged(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}
