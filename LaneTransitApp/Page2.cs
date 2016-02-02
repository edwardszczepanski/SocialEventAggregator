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
using Android.Webkit;

namespace LaneTransitApp
{
	[Activity (Label = "Select your Route")]			
	public class Page2 : Activity
	{
		private List<Route> RouteList;
		private ListView listView;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.listView);

			listView = FindViewById <ListView> (Resource.Id.listView);

			RouteList = new List<Route>();
			RouteList.Add (new Route("Emx", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("11 - Thurston", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("13 - Centennial", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("17 - 5th St/Hayden B", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("18 - Mohawk", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("24 - Donald", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("27 - Fairmount", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("28 - Hilyard", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("32 - W 1st Ave", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("Emx", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("11 - Thurston", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("13 - Centennial", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("17 - 5th St/Hayden B", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("18 - Mohawk", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("24 - Donald", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("27 - Fairmount", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("28 - Hilyard", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("32 - W 1st Ave", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("Emx", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("11 - Thurston", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("13 - Centennial", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("17 - 5th St/Hayden B", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("18 - Mohawk", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("24 - Donald", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("27 - Fairmount", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("28 - Hilyard", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("32 - W 1st Ave", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("Emx", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("11 - Thurston", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("13 - Centennial", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("17 - 5th St/Hayden B", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("18 - Mohawk", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("24 - Donald", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("27 - Fairmount", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("28 - Hilyard", "https://www.ltd.org/system-map/route_101/"));
			RouteList.Add (new Route("32 - W 1st Ave", "https://www.ltd.org/system-map/route_101/"));


			ListViewAdapter adapter = new ListViewAdapter (this, RouteList);

			listView.Adapter = adapter;

			listView.ItemClick += listView_ItemClick;
		}

		void listView_ItemClick (object sender, AdapterView.ItemClickEventArgs e)
		{
			StartActivity(typeof(SystemMap));
		}
	}

}

