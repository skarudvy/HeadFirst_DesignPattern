﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter02_WeatherStation
{
    public interface IObserver
    {
        void update(float temp, float humidity, float pressure);
    }
}
