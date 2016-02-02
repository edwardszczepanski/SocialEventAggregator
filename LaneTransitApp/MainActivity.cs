using Android.App;
using Android.Widget;
using Android.OS;
using System.Net;
using System.Text.RegularExpressions;
using System;

namespace LaneTransitApp
{
	[Activity (Label = "Social Event Aggregator", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);


			TextView textView = FindViewById<TextView> (Resource.Id.TEXT_STATUS_ID);

			textView.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam erat eros, gravida vitae convallis non, consequat eu justo. Vivamus non enim id felis malesuada convallis. Aenean fermentum egestas purus, in venenatis mauris hendrerit et. Curabitur vel volutpat urna. Morbi id porttitor massa. Ut vehicula erat suscipit dictum suscipit. Pellentesque non magna et ex elementum auctor. Curabitur nec justo et dui pellentesque vulputate. Fusce hendrerit neque non urna elementum suscipit. Vivamus ut auctor nisl, vel posuere lectus. Nullam mollis ac sem sit amet tempor. Vestibulum aliquam sed mauris non dignissim. Vestibulum tempor malesuada lacus ac viverra. Praesent porttitor magna vitae nulla ullamcorper accumsan. Mauris commodo molestie orci, quis luctus leo pellentesque et. In sed vestibulum leo, at dictum ante.\n\nVivamus porta sem augue, ac tristique tellus fringilla at. Morbi eleifend ornare finibus. In hac habitasse platea dictumst. Sed posuere neque eu urna mattis euismod. Curabitur varius metus sed nibh sollicitudin, a viverra magna vulputate. Aenean iaculis sapien quis imperdiet facilisis. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nullam sit amet commodo est. Etiam finibus, nunc a maximus posuere, sem est vestibulum ipsum, in pharetra massa elit vel libero. Pellentesque pretium, risus et venenatis faucibus, risus est facilisis urna, nec sodales nulla ante sed turpis. Aliquam erat volutpat. Sed porta sem enim, id dictum mauris dapibus id. Fusce eu euismod elit. Sed sit amet elit quis risus hendrerit fringilla id volutpat nunc.\n\nEtiam lacinia lorem lacus, eget lobortis leo semper vitae. Maecenas faucibus et tellus a condimentum. Phasellus volutpat hendrerit congue. Donec vulputate quis mauris non porttitor. Donec non leo vehicula lacus malesuada ornare at ac mauris. Cras finibus eu metus at consequat. Duis in sapien ex. Nunc eu tortor nec nulla mollis eleifend. Nullam ornare scelerisque varius.\n\nCurabitur condimentum facilisis libero, sed ornare velit interdum et. Proin vitae pulvinar dolor. Phasellus interdum sodales nisl, ullamcorper consectetur magna venenatis vitae. Morbi semper, urna id sagittis lacinia, justo erat convallis leo, in vulputate urna metus id mi. Curabitur gravida nisi vel mauris dictum placerat. Nulla justo odio, aliquet eu ligula a, sollicitudin dictum risus. Donec sed dolor nec mauris ullamcorper ultricies quis ac metus. Ut sagittis iaculis ligula in egestas. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec aliquam dapibus pharetra. Sed in blandit tortor. Nullam ac diam eu justo varius hendrerit eget faucibus ligula. Morbi lectus metus, semper a efficitur sed, pretium sit amet nulla. In eu convallis ex. Suspendisse a ultrices elit.\n\nAenean aliquet consequat metus quis lobortis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla tempor eleifend arcu, sit amet eleifend velit porttitor eu. Pellentesque hendrerit lacus molestie felis molestie efficitur. Praesent vel tellus ultrices, congue dolor at, interdum tortor. Nullam sed dui nec turpis lacinia rhoncus nec eu magna. Phasellus vestibulum laoreet sem, in molestie massa mattis ut. Aliquam vel eros dolor. Integer a erat vehicula metus mattis consectetur vitae eget nisl.";

	
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				StartActivity(typeof(MapsView));
			};

			Button button2 = FindViewById<Button> (Resource.Id.myButton2);

			button2.Click += delegate {
				StartActivity(typeof(Page2));
			};
		}
	}
}


