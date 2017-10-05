using NUnit.Framework;
using System;
using Aviva.Service;
using Aviva.ViewModels;
using Moq;
using Aviva.Model;
using System.Collections.Generic;

namespace Avava.Tests
{
    [TestFixture()]
    public class HomeScreenViewModelTests
    {
        const string ScaryWeatherReport = "Lightning lightning very very frightening";
        const double ScaryTemperature = 200;
        const string NiceWeatherReport = "Sunny";
        const double NiceTemperature = 30;
        HomeScreenViewModel viewModel;
        Mock<IAPIClient> mockApi;

        [Test()]
        public void SimpleTestLondon()
        {
            viewModel.City = "London";
            viewModel.ExecuteFindWeatherCommand().RunTaskSynchronously();

            Assert.AreEqual(ScaryWeatherReport, viewModel.Weather);
            Assert.AreEqual(ScaryTemperature.ToString(), viewModel.Temperature);
        }

        [Test()]
        public void SimpleTestParis()
        {
        	viewModel.City = "Paris";
        	viewModel.ExecuteFindWeatherCommand().RunTaskSynchronously();

        	Assert.AreEqual(NiceWeatherReport, viewModel.Weather);
        	Assert.AreEqual(NiceTemperature.ToString(), viewModel.Temperature);
        }

        [Test()]
        public void SimpleTestBerlin()
        {
        	viewModel.City = "Berlin";
        	viewModel.ExecuteFindWeatherCommand().RunTaskSynchronously();

            Assert.AreEqual(null, viewModel.Weather);
        	Assert.AreEqual(null, viewModel.Temperature);
        }

        void CreateMocks()
        {
            mockApi = new Mock<IAPIClient>();
            mockApi.Setup(a => a.GetWeather("London")).ReturnsAsync(
                new WeatherResponse() 
                { 
                    Main = new Main() { Temperature = ScaryTemperature },
                    Report = new List<WeatherReport>() { new WeatherReport() { Description = ScaryWeatherReport } }
                });

            mockApi.Setup(a => a.GetWeather("Paris")).ReturnsAsync(
			    new WeatherResponse()
                {
                    Main = new Main() { Temperature = NiceTemperature },
                    Report = new List<WeatherReport>() { new WeatherReport() { Description = NiceWeatherReport } }
                });
            mockApi.Setup(a => a.GetWeather("Berlin")).ThrowsAsync(new Exception("API ISSUE"));
        }

        void CreateVM()
        {
            viewModel = new HomeScreenViewModel(mockApi.Object);
        }

        [SetUp]
        public void Setup()
        {
            CreateMocks();
            CreateVM();
        }
    }
}
