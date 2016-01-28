using Android.App;
using Android.Widget;
using Android.OS;
using System.Net;

namespace LaneTransitApp
{
	[Activity (Label = "Lane Transit App", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);

			string htmlCode = "Nothing found";
			using (WebClient client = new WebClient ()) {
				htmlCode = client.DownloadString ("https://www.ltd.org/system-map/route_79x/");
			}




			TextView textView = FindViewById<TextView> (Resource.Id.TEXT_STATUS_ID);
			textView.Text = htmlCode;
	

			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				//button.Text = string.Format ("{0} clicks!", count++);
				StartActivity(typeof(Page2));
			};
		}
	}
}


