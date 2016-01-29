using Android.App;
using Android.Widget;
using Android.OS;
using System.Net;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System;

namespace LaneTransitApp
{
	[Activity (Label = "Lane Transit App", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);



			TextView textView = FindViewById<TextView> (Resource.Id.TEXT_STATUS_ID);

			HtmlWeb web = new HtmlWeb();
			HtmlDocument doc = web.Load("https://www.ltd.org/system-map/route_79x/");
			HtmlNodeCollection tags = doc.DocumentNode.SelectNodes("//td");
			foreach (HtmlNode item in tags)  
			{  
				textView.Text = textView.Text + item.InnerHtml;
			}  
			textView.Text = Regex.Replace(textView.Text, @"<[^>]*>", String.Empty);


			/*

			string pattern = "<div.*?>(.*?)<\\/div>";

			MatchCollection matches = Regex.Matches(htmlCode, pattern);
			Console.WriteLine("Matches found: {0}", matches.Count);

			if (matches.Count > 0) {
				foreach (Match m in matches) {
					Console.WriteLine("Inner DIV: {0}", m.Groups[1]);
				}
			}
			*/

	

			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				//button.Text = string.Format ("{0} clicks!", count++);
				StartActivity(typeof(Page2));
			};
		}
	}
}


