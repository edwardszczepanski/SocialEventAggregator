using Android.App;
using Android.Widget;
using Android.OS;
using System.Net;
using System.Text.RegularExpressions;
using System;

namespace LaneTransitApp
{
	[Activity (Label = "Social Event Aggregator", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);


			TextView textView = FindViewById<TextView> (Resource.Id.TEXT_STATUS_ID);

			textView.Text = "Herro dere";

	
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				//button.Text = string.Format ("{0} clicks!", count++);
				StartActivity(typeof(MapsView));
			};
		}
	}
}


