using System;
using Aviva.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace Aviva.iOS
{
    public partial class HomeScreenViewController : MvxViewController<HomeScreenViewModel>
    {
        public HomeScreenViewController() : base("HomeScreenViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.CreateBinding(CityText).To((HomeScreenViewModel vm) => vm.City).Apply();
            this.CreateBinding(ShowWeather).To((HomeScreenViewModel vm) => vm.ShowWeatherCommand).Apply();
            this.CreateBinding(TemperatureLabel).To((HomeScreenViewModel vm) => vm.Temperature).Apply();
            this.CreateBinding(WeatherLabel).To((HomeScreenViewModel vm) => vm.Weather).Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

