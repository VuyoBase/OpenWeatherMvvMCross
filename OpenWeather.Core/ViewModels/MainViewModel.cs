using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using OpenWeather.Core.Services;
using OpenWeather.Core.dto;

namespace OpenWeather.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {

        private IWeatherService _weatherService;
        private IMvxNavigationService _navigationService;

        public MainViewModel(IWeatherService weatherService, IMvxNavigationService navigationService)
        {
            _weatherService = weatherService;
            _navigationService = navigationService;
        }

        private readonly string _CityName = string.Empty;
        public string CityName
        {
            get => _CityName;
            set => SetProperty(ref value, _CityName);
        }

        public MvxAsyncCommand getWeatherCommand;

        public IMvxAsyncCommand GetWeatherCommand
        {
            get
            {
                return getWeatherCommand ?? (getWeatherCommand = new MvxAsyncCommand(async () => await FetchWeather()));
            }
        }

        public async Task FetchWeather()
        {
            var forcast = new Forecast();

            try
            {
            var WeatherService = new WeatherService();
            var WeatherDetails = await WeatherService.GetWeather(CityName);
                Console.WriteLine(WeatherDetails.CityName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}


