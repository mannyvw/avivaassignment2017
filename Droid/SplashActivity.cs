using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;

namespace Aviva.Droid
{
	[Activity(Label = "SplashActivity", 
              MainLauncher = true,
			  NoHistory = true, 
              Theme = "@style/MyTheme.Splash",
			  ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : AppCompatActivity
    {
        static readonly string TAG = "X:" + typeof(SplashActivity).Name;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
		}

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        // Simulates background work that happens behind the splash screen
        async void SimulateStartup()
        {
        	Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
        	await Task.Delay(1000); // Simulate a bit of startup work.
        	Log.Debug(TAG, "Startup work is finished - starting MainActivity.");
            StartActivity(new Intent(Application.Context, typeof(HomeScreenView)));
        }
    }
}
