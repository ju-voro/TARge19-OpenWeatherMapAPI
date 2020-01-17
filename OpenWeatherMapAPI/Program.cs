using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace OpenWeatherMapAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://openweathermap.org/data/2.5/weather?id=588409&appid=b6907d289e10d714a6e88b30761fae22";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                WeatherDetails.root weather = JsonConvert.DeserializeObject<WeatherDetails.root>(response);
                Console.WriteLine(weather.Name);
                Console.WriteLine(weather.Sys.Country);
                Console.WriteLine(weather.Weather[0].Main);
                Console.WriteLine(weather.Weather[0].Description);
                Console.WriteLine(weather.Main.Temp);                

            }

        }
    }
}
