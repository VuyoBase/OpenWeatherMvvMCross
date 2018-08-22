using System;
using Android.Widget;
using OpenWeather.Core;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using Android.Runtime;
using Android.App;

namespace OpenWeather.Droid
{
    [Application]
    public class Setup:MvxAndroidApplication<MvxAndroidSetup<App>,App>
    {
        public Setup(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}