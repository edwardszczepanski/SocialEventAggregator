
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
	[Activity (Label = "Maps Implementation")]			
	public class MapsView : Activity, IOnMapReadyCallback
	{
		private GoogleMap mMap;

		private Button btnNormal;
		private Button btnHybrid;
		private Button btnSatellite;
		private Button btnTerrain;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.MapsLayout);
			btnNormal = FindViewById<Button> (Resource.Id.btnNormal);
			btnHybrid = FindViewById<Button> (Resource.Id.btnHybrid);
			btnSatellite = FindViewById<Button> (Resource.Id.btnSatellite);
			btnTerrain = FindViewById<Button> (Resource.Id.btnTerrain);

			btnNormal.Click += BtnNormal_Click;
			btnHybrid.Click += BtnHybrid_Click;
			btnSatellite.Click += BtnSatellite_Click;
			btnTerrain.Click += BtnTerrain_Click;

			SetUpMap ();
		}

		void BtnTerrain_Click (object sender, EventArgs e)
		{
			mMap.MapType = GoogleMap.MapTypeTerrain;
		}

		void BtnHybrid_Click (object sender, EventArgs e)
		{
			mMap.MapType = GoogleMap.MapTypeHybrid;
		}

		void BtnSatellite_Click (object sender, EventArgs e)
		{
			mMap.MapType = GoogleMap.MapTypeSatellite;
		}

		void BtnNormal_Click (object sender, EventArgs e)
		{
			mMap.MapType = GoogleMap.MapTypeNormal;
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

