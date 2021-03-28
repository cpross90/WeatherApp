using System;
using System.Net.Http;

namespace Weather.Services
{
    class WeatherApi
    {
        private const string API_URL = "https://dark-sky.p.rapidapi.com";
        private string? _apiKey;

        public WeatherApi(string? apiKey)
        {
            if (String.IsNullOrEmpty(apiKey))
            {
                throw new NullReferenceException("Error: Missing enviroment variable 'API_KEY'");
            }

            _apiKey = apiKey;
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