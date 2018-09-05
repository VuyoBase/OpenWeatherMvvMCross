using System.Threading.Tasks;
using OpenWeather.Core.dto;
using OpenWeather.Core.Services;

namespace OpenWeather.Core
{
    public class DarkSkyWeatherService : IWeatherService
    {
        public Task<Forecast> GetWeather(string cityName)
        {
            // call Dark Sky for weahter
            // return empty forecast for now
            return Task.FromResult(new Forecast());
        }
    }
}