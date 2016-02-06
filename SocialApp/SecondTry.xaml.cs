using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SocialApp
{
	public partial class SecondTry : ContentPage
	{
		public SecondTry ()
		{
			InitializeComponent ();
			var listView = new Xamarin.Forms.ListView();
			listView.ItemsSource = new string[]{
				"mono",
				"monodroid",
				"monotouch",
				"monorail",
				"monodevelop",
				"monotone",
				"monopoly",
				"monomodal",
				"mononucleosis"
			};
		}
	}
}

