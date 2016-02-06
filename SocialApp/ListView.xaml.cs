using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SocialApp
{
	public partial class ListView : ContentPage
	{
		public ListView ()
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

			/*MainListView.ItemsSource = new List<EmptyClass> 
			{
				new EmptyClass{Name = "Edward", Age = 15},
				new EmptyClass{Name = "John", Age =45},
				new EmptyClass{Name = "Joe", Age =86},
				new EmptyClass{Name = "Albert", Age = 1},
				new EmptyClass{Name = "Alfonso", Age =53},
				new EmptyClass{Name = "Sammy", Age = 24}
			};
			*/
		}
	}
}

