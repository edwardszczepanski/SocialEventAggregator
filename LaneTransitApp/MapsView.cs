
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

namespace LaneTransitApp
{
	[Activity (Label = "Google Maps")]			
	public class MapsView : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			var geoUri = Android.Net.Uri.Parse ("geo:42.374260,-71.120824");
			var mapIntent = new Intent (Intent.ActionView, geoUri);
			StartActivity (mapIntent);

			// Create your application here
		}
	}
}

