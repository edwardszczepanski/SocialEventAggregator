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
	public class ListViewAdapter : BaseAdapter<string>
	{
		private List<string> items;
		private Context context;

		public ListViewAdapter(Context context, List<string> items){
			this.items = items;
			this.context = context;
		}

		public override int Count {
			get {
				return items.Count;
			}
		}
		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View row = convertView;
			if (row == null) {
				row = LayoutInflater.From (context).Inflate (Resource.Layout.listview_row, null, false);
			}
			TextView textView = row.FindViewById<TextView> (Resource.Id.txtName);
			textView.Text = items [position];
			return row;
		}
		public override long GetItemId (int position)
		{
			return position;
		}
		public override string this[int index] {
			get {
				return items [index];
			}
		}
	}
}

