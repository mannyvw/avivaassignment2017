// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Aviva.iOS
{
    [Register ("HomeScreenViewController")]
    partial class HomeScreenViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CityText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ShowWeather { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TemperatureLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel WeatherLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CityText != null) {
                CityText.Dispose ();
                CityText = null;
            }

            if (ShowWeather != null) {
                ShowWeather.Dispose ();
                ShowWeather = null;
            }

            if (TemperatureLabel != null) {
                TemperatureLabel.Dispose ();
                TemperatureLabel = null;
            }

            if (WeatherLabel != null) {
                WeatherLabel.Dispose ();
                WeatherLabel = null;
            }
        }
    }
}