
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
			mItems.Add ("EmX");
			mItems.Add ("11 - Thurston");
			mItems.Add ("12 - Gateway");
			mItems.Add ("13 - Centennial");
			mItems.Add ("17 - 5th St/Hayden B");
			mItems.Add ("18 - Mohawk");
			mItems.Add ("24 - Donald");
			mItems.Add ("27 - Fairmount");
			mItems.Add ("28 - Hilyard");
			mItems.Add ("32 - W 1st Ave");
			mItems.Add ("33 - Jefferson");
			mItems.Add ("36 - W 18th Ave");
			mItems.Add ("40 - Echo Hollow");
			mItems.Add ("41 - Barger/W 11th");
			mItems.Add ("43 - W 11th / Barger");
			mItems.Add ("51 - Santa Clara");
			mItems.Add ("52 - Irving");
			mItems.Add ("55 - North Park");
			mItems.Add ("66 - VRC/Coburg");
			mItems.Add ("67 - Coburg Rd/VRC");
			mItems.Add ("73 - UO/Willamette");
			mItems.Add ("76 - UO/Warren");
			mItems.Add ("78 - UO/Seneca Sta");
			mItems.Add ("79x - UO/Kinsrow");
			mItems.Add ("81 - LCC/Harris");
			mItems.Add ("82 - LCC/Pearl");
			mItems.Add ("85 - LCC/Springfield");
			mItems.Add ("91 - McKenzie Br");
			mItems.Add ("92 - Lowell/LCC");
			mItems.Add ("93 - Veneta");
			mItems.Add ("95 - Junction City");
			mItems.Add ("96 - Coburg");
			mItems.Add ("98 - Cottage Grove");
			mItems.Add ("Airport Connector");
			mItems.Add ("970x-971x - Butte to Butte Express");
			mItems.Add ("988x-989x - Oregon Country Fair Express");
			mItems.Add ("990x-999x - Autzen Express");
			mItems.Add ("Diamond Express");
			mItems.Add ("Rhody Express");



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

