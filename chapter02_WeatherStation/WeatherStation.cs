using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter02_WeatherStation
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.setMeasurementsChanged(80, 65, 30.4f);
            weatherData.setMeasurementsChanged(82, 70, 29.2f);
            weatherData.setMeasurementsChanged(78, 90, 30.4f);
        }
    }
}
