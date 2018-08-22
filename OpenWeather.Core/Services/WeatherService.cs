using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using OpenWeather.Core.dto;
using Newtonsoft.Json;

namespace OpenWeather.Core.Services
{
    public class WeatherService : IWeatherService
    {
        public static class Constatnts
        {
            public const String baseUrl = "http://api.openweathermap.org/data/2.5/weather?q=";
            public const String appKey = "&units=metric&type=accurate&appid=3809e9470beedea5655a60e4cd69e351";
        }

        public async Task<Forecast> GetWeather(string cityName)
        {
            //Building uri to make api request 
            Uri uri = new Uri(Constatnts.baseUrl + cityName + Constatnts.appKey);

            //Intitialize Http clien
            using (var http = new HttpClient())
            {
                //Get Response using the URi we  built
                var response = await http.GetAsync(uri);

                //Initialize Weather Forecast Object  
                Forecast Weather = new Forecast();

                //Check if the request was a success
                dynamic data = null;
                if (response.IsSuccessStatusCode)
                {
                    //If so get the the json data from the response
                    var jsonresponse = await response.Content.ReadAsStringAsync();

                    //Convert Json Response to Forecast Weather Object
                    string json = response.Content.ReadAsStringAsync().Result;
                    Weather = JsonConvert.DeserializeObject<Forecast>(jsonresponse);
                }
                //Return weather result
                return Weather;
            }
        }
        
        Task<Forecast> IWeatherService.GetWeather(string cityName)
        {
            throw new NotImplementedException();
        }
    }
}
