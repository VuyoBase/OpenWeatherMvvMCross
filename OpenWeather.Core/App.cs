using System;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using OpenWeather.Core.Services;
using OpenWeather.Core.ViewModels;

namespace OpenWeather.Core
{
    public class App:MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterType<IWeatherService, WeatherService>();

            RegisterAppStart<MainViewModel>();
        }
    }
}
