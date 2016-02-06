using System;

using Xamarin.Forms;

namespace SocialApp
{
	public class Test : ContentPage
	{
		public Test ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


