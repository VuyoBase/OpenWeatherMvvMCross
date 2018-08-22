using OpenWeather.Core.dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Core.Services
{
    public interface IWeatherService
    {
        Task <Forecast> GetWeather(String cityName);
    }
}
