
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
	[Activity (Label = "Real Time Map")]
	public class SystemMap : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Webview);

			WebView webView = FindViewById<WebView>(Resource.Id.LocalWebView);
			webView.SetWebViewClient(new WebViewClient ());

			webView.Settings.JavaScriptEnabled = true;
			webView.LoadUrl("https://www.ltd.org/system-map/");
			webView.Settings.SetSupportZoom(true);
			webView.Settings.BuiltInZoomControls = true;
			webView.SetInitialScale (100);
		}
	}
}

