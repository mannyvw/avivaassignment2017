using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Aviva.Service;
using MvvmCross.Core.ViewModels;

namespace Aviva.ViewModels
{
    public class HomeScreenViewModel : MvxViewModel
    {
        readonly IAPIClient _apiClient;

        public string City { get; set; }
        string _weather;
		public string Weather
        {
            get
            {
                return _weather;
            }
            set
            {
                _weather = value;
                RaisePropertyChanged();
            }
        }
		string _temperature;
		public string Temperature
		{
			get
			{
				return _temperature;
			}
			set
			{
				_temperature = value;
				RaisePropertyChanged();
			}
		}
        public IMvxCommand ShowWeatherCommand { get; set; }

        public HomeScreenViewModel(IAPIClient apiClient)
        {
            _apiClient = apiClient;
            ShowWeatherCommand = new MvxCommand(async () => await ExecuteFindWeatherCommand());
        }

        public async Task ExecuteFindWeatherCommand()
        {
            try
            {
                var response = await _apiClient.GetWeather(City);

                if (response != null)
                {
                    if (response.Report.Count > 0)
                    {
                        Temperature = response.Main.Temperature.ToString();
                    }
                    Weather = response.Report[0].Description;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error getting weather {ex.Message}");
            }
        }
    }
}
