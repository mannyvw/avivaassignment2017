using System;
using Aviva.Service;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace Aviva
{
    public class App : MvxApplication
	{

		/// <summary>
		/// Setup IoC registrations.
		/// </summary>
		public App()
		{
			// Whenever Mvx.Resolve is used, a new instance of Calculation is provided.
			Mvx.RegisterType<IAPIClient, APIClient>();

			// Tells the MvvmCross framework that whenever any code requests an IMvxAppStart reference,
			// the framework should return that same appStart instance.
			var appStart = new CustomAppStart();
			Mvx.RegisterSingleton<IMvxAppStart>(appStart);

			// Another option is to utilize a default App Start object with 
			// var appStart = new MvxAppStart<TipViewModel>();
		}
	}
}
