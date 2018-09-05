using MvvmCross.ViewModels;
using OpenWeather.Core.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeather.Core.ViewModels
{
    public class WeatherViewModel : MvxViewModel<Forecast>
    {

        protected WeatherViewModel()
        {

        }

        public object WeatherDetails
        {
            get;

            set;
        }

        public object WeatherLocation
        {
            get;

            set;
        }
        public object WeatherTemprature
        {
            get;

            set;
        }
        public object WeatherForecast
        {
            get;

            set;
        }
        public object WeatherIconUrl
        {
            get;

            set;
        }
        public object City
        {
            get;

            set;
        }

        public override void Prepare(Forecast forecast)
        {
            WeatherLocation = forecast.CityName;
        }
    }
}
