using System;
using System.Net.Http;

namespace weather.Services
{
    class WeatherAPI
    {
        private const string API_URL = "https://dark-sky.p.rapidapi.com";
        private const string API_VAR = "API_KEY";
        private string? _apiKey;

        public WeatherAPI()
        {
            _apiKey = Environment.GetEnvironmentVariable(API_VAR);

            if (String.IsNullOrEmpty(_apiKey))
            {
                throw new NullReferenceException("Error: Missing enviroment variable 'API_KEY'");
            }
        }

        async public void GetForecast()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"http://api.weatherstack.com/current?access_key={_apiKey}&query=Seattle"),
                Headers =
                {
                    { "x-rapidapi-key", _apiKey },
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