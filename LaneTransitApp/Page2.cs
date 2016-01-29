
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
	[Activity (Label = "Page2")]			
	public class Page2 : Activity
	{
		private List<string> mItems;
		private ListView listView;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.listView);

			listView = FindViewById <ListView> (Resource.Id.listView);

			mItems = new List<string>();
			mItems.Add ("Edward");
			mItems.Add ("Sho");
			mItems.Add ("Szczepanski");
			mItems.Add ("Edward");
			mItems.Add ("Sho");
			mItems.Add ("Szczepanski");
			mItems.Add ("Edward");
			mItems.Add ("Sho");
			mItems.Add ("Szczepanski");
			mItems.Add ("Edward");
			mItems.Add ("Sho");
			mItems.Add ("Szczepanski");
			mItems.Add ("Edward");
			mItems.Add ("Sho");
			mItems.Add ("Szczepanski");
			mItems.Add ("Edward");
			mItems.Add ("Sho");
			mItems.Add ("Szczepanski");

			ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
			listView.Adapter = adapter;

			listView.ItemClick += listView_ItemClick;



		}

		void listView_ItemClick (object sender, AdapterView.ItemClickEventArgs e)
		{
			Console.WriteLine (mItems [e.Position]);
			StartActivity(typeof(LaneWebsite));
		}
	}

}

