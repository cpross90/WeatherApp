using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Environment;

namespace weather.Services
{
    class weatherAPI
    {
        const String API_URL = "dark-sky.p.rapidapi.com";
        const String API_KEY = "WEATHER_API";
        private String apiKey;

        weatherAPI()
        {
            apiKey = System.Environment.GetEnvironmentVariable(API_VARIABLE);
        }

        async public void getForecast(Models.forecast obj)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://dark-sky.p.rapidapi.com/47.6727,-122.1873,2019-02-20T12:30:15"),
                Headers =
            {
                { "x-rapidapi-key", API_KEY },
                { "x-rapidapi-host", API_URL },
            },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }
    }
}
