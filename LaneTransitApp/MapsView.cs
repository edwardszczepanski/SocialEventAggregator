
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
using Android.Gms.Maps;

namespace LaneTransitApp
{
	[Activity (Label = "Google Maps")]			
	public class MapsView : Activity, IOnMapReadyCallback
	{
		private GoogleMap mMap;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.MapsLayout);
			SetUpMap ();

		}

		private void SetUpMap(){
			if (mMap == null) {
				FragmentManager.FindFragmentById<MapFragment> (Resource.Id.map).GetMapAsync (this);
			}
		}

		public void OnMapReady (GoogleMap googleMap)
		{
			mMap = googleMap;
		}
	}
}

