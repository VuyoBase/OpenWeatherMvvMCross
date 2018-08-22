using MvvmCross.ViewModels;
using OpenWeather.Core.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeather.Core.ViewModels
{
    public class Weather : MvxViewModel<Forecast>
    {

        protected Weather()
        {
        }

        public override void Prepare(Forecast parameter)
        {
            
        }
    }
}
