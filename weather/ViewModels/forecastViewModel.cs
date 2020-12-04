using System;
using System.Collections.Generic;
using System.Text;

namespace weather.ViewModels
{
    class forecastViewModel
    {
        public Models.forecast forecast;

        public forecastViewModel()
        {
            forecast = new Models.forecast();
        }
    }
}