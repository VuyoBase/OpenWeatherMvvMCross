using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using MvvmCross.Droid.Support.V7.AppCompat;
using OpenWeather.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;
using System;

namespace OpenWeather.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : MvxAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Create A Button Object To Set The Event
            Button button = FindViewById<Button>(Resource.Id.weatherBtn);

            button.Click += Button_Click;
        }

        private async void Button_Click(object sender,  EventArgs e)
        {
            EditText City = FindViewById<EditText>(Resource.Id.city);

            if (!string.IsNullOrEmpty(City.Text))
            {

            }
            //{
            //    FindViewById<TextView>(Resource.Id.windText).Text = weather.Wind;
            //    FindViewById<TextView>(Resource.Id.cloudinessText).Text = weather.Cloudiness;
            //    FindViewById<TextView>(Resource.Id.preassureText).Text = weather.Preassure;
            //    FindViewById<TextView>(Resource.Id.humidityText).Text = weather.Humidity;
            //    FindViewById<TextView>(Resource.Id.sunriseText).Text = weather.Sunrise;
            //    FindViewById<TextView>(Resource.Id.geoCoordsText).Text = weather.Geo coords;

            //}

        }

            //Assign The Event To ButtonS
           /* button.Click += delegate {
                StartActivity(typeof(MainActivity));
                SendCityName();
            };*/

           
        }
    }
    

