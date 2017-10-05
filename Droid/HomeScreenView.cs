
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Aviva.ViewModels;
using MvvmCross.Droid.Views;

namespace Aviva.Droid
{
    [Activity(Label = "HomeScreenView")]
    public class HomeScreenView : MvxActivity
    {
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.HomeScreen);
		}		
    }
}
