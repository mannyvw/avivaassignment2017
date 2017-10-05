using System;
using System.Net.Http;
using System.Threading.Tasks;
using Aviva.Model;
using Newtonsoft.Json;
using Aviva;

namespace Aviva.Service
{
    public class APIClient : IAPIClient
    {
        public async Task<WeatherResponse> GetWeather(string city)
        {
            var client = new HttpClient();

            var response = await client.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={Uri.EscapeDataString(city)}&appid={Configuration.AppID}");

            var weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(await response.Content.ReadAsStringAsync());

            return weatherResponse;
        }
    }
}
