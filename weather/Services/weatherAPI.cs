using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace weather.Services
{
    enum apiOptions
    {
        LAT = 0,
        LONG,
        TIME
    }

    class weatherAPI
    {
        private const String API_URL = "https://dark-sky.p.rapidapi.com";
        private const String API_VAR = "WEATHER_API";
        private String apiKey;

        weatherAPI()
        {
            apiKey = System.Environment.GetEnvironmentVariable(API_VAR);
        }

        async public void getForecast(Models.forecast obj, String[] options)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(API_URL + options[apiOptions.LAT] + ',' + options[apiOptions.LONG] + ',' + options[apiOptions.TIME]),
                Headers =
            {
                { "x-rapidapi-key", apiKey },
                { "x-rapidapi-host", API_URL },
            },
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }
    }
}
