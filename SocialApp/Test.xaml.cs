using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SocialApp
{
	public partial class Test : ContentPage
	{
		public Test ()
		{
			InitializeComponent ();
		}
		readonly string[] options = { " It is certain", 
			" It is decidely so",
			" It is certain", 
			" Without a doubt",
			" Yes, definitely",
			" Most likely",
			" Outlook good", 
			" Yes",
			" Signs point to yes",
			" Reply hazy try again", 
			" Ask again later",
			" Better not tell you now",
			" Cannot predict now", 
			" Concentrate and ask again",
			" Don't count on it",
			" My reply is no", 
			" My sources say no",
			" Outlook not so good", 
			" Very doubtful"};


		void ShakeClicked (object s, EventArgs e){
			var random = new System.Random ();
			output.Text = options [random.Next (0, options.Length - 1)];
		}
	}
}

