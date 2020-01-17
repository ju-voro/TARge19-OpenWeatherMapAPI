using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMapAPI
{
    class WeatherDetails
    {
        public class Weather
        {
            public string Main { get; set; }
            public string Description { get; set; }
        }

        public class Main
        {
            public double Temp { get; set; }
        }

        public class Sys
        {
            public string Country { get; set; }
        }
        public class root
        {
            public Sys Sys { get; set; }
            public List<Weather> Weather { get; set; }
            public string Name { get; set; }
            public Main Main { get; set; }

        }
    }
}
