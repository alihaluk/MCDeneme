using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace MCDeneme
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MCDenemePage();
		}

		protected override void OnStart()
		{
			MobileCenter.Start("android=51011bfb-b74e-4223-913d-38e09ce6501d;" +
				   "ios=3053e951-69bd-4bf0-9d5f-2d74f9496732",
				   typeof(Analytics), typeof(Crashes));
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
