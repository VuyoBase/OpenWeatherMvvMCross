using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Binding;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using OpenWeather.Core.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace OpenWeather.Droid
{
    [Activity(Label = "WeatherDetailsActivity")]
    public class WeatherDetailsActivity : MvxAppCompatActivity<WeatherViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.detailed_weather);

            var listview = FindViewById(Resource.Id.listView);

            var set = this.CreateBindingSet<WeatherDetailsActivity, WeatherViewModel>();

            // Create your application here
            // Fluent Binding
            set.Bind(listview)
                .For("ItemSource")
                .To(vm => vm.WeatherDetails);

            set.Bind(FindViewById(Resource.Id.weather_location))
                .For("Text")
                .To(vm => vm.WeatherLocation);
                //.WithConversion("");

            set.Bind(FindViewById(Resource.Id.tempareture))
                .For("Text")
                .To(vm => vm.WeatherTemprature);

            set.Bind(FindViewById(Resource.Id.forecast))
                .For("Text")
                .To(vm => vm.WeatherForecast);

            set.Bind(FindViewById(Resource.Id.weather_icon))
                .For("ImageSource")
                .To(vm => vm.WeatherIconUrl);

            set.Bind(FindViewById(Resource.Id.cityName))
                .For("EditText")
                .To(vm => vm.City);

            set.Apply();
        }
    }
}