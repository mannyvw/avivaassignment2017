using System;
using System.Threading.Tasks;
using Aviva.Model;

namespace Aviva.Service
{
    public interface IAPIClient
    {
        Task<WeatherResponse> GetWeather(string city);
    }
}
