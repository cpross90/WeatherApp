using System;
using System.Net.Http;

using weather.Models;

namespace weather.Services{
    class weatherAPI
    {
        private const string API_URL = "https://dark-sky.p.rapidapi.com";
        private const string API_VAR = "WEATHER_API";
        private string apiKey;

        public weatherAPI()
        {
            apiKey = System.Environment.GetEnvironmentVariable(API_VAR);
        }

        async public void getForecast()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://api.weatherstack.com/current?access_key=ff4683cabd8c1f5cf41ebcc802f42ef0&query=Seattle"),
                Headers =
                {
                    { "x-rapidapi-key", apiKey },
                    { "x-rapidapi-host", API_URL },
                }
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Body" + body);
        }
    }
}