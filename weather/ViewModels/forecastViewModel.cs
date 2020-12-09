using System;
using System.Collections.Generic;
using System.Text;

namespace weather.ViewModels
{
    class forecastViewModel
    {
        private const uint NUM_DAYS_IN_WEEK = 7;

        private Services.weatherAPI API;
        private Models.forecast[] sevenDay = new Models.forecast[NUM_DAYS_IN_WEEK];
    }
}