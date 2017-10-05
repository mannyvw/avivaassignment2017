using System;
using Aviva.ViewModels;
using MvvmCross.Core.ViewModels;

namespace Aviva
{
	class CustomAppStart : MvxNavigatingObject, IMvxAppStart
	{
		/// <summary>
		/// Hint can take command-line startup parameters, and then pass them to the called view models.
		/// </summary>
		public void Start(object hint = null)
		{
			ShowViewModel<HomeScreenViewModel>();
		}
	}
}
